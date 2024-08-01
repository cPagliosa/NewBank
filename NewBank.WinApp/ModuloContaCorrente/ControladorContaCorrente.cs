using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.ModuloContaCorrente;
using NewBank.Dominio.ModuloHistorioco;
using NewBank.Dominio.ModuloOperacao;
using NewBank.Dominio.Resources;
using NewBank.WinApp.Compartilhado;
using NewBank.WinApp.ModuloHistorioco;
using NewBank.WinApp.ModuloOperacao;

namespace NewBank.WinApp.ModuloContaCorrente
{
    public class ControladorContaCorrente : ControladorBase
    {
        private IRepositorioContaCorrente repositorioContaCorrente;
        private IRepositorioHistorioco repositorioHistorioco;
        private TabelaContaCorrente tabelaContaCorrente;

        public override string TipoCadastro { get { return Lingua.ContaCorrente; } }
        public override string ToolTipAdicionar { get { return Lingua.CadConta; } }
        public override string ToolTipEditar { get { return Lingua.EdtConta; } }
        public override string ToolTipExcluir { get { return Lingua.ExcConta; } }



        public ControladorContaCorrente(IRepositorioContaCorrente repositorioContaCorrente,IRepositorioHistorioco repositorioHistorioco,IRepositorioOperacao repositorioOperacao)
        {
            this.repositorioContaCorrente = repositorioContaCorrente;
            this.repositorioHistorioco = repositorioHistorioco;
        }
        public override UserControl ObterListagem()
        {
            if (tabelaContaCorrente == null)
                tabelaContaCorrente = new TabelaContaCorrente();

            CarregarDadosTabela();

            return tabelaContaCorrente;
        }

        public override void Adicionar()
        {
            TelaContaCorrenteForm telaContaCorrente = new TelaContaCorrenteForm();

            DialogResult resultado = telaContaCorrente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            ContaCorrente novaConta = telaContaCorrente.ContaCorrente;

            this.repositorioContaCorrente.Cadastrar(novaConta);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{Lingua.Resp1} \"{novaConta.Numero}\" {Lingua.AddRespP2}");
        }

        public override void Editar()
        {
            TelaContaCorrenteForm telaContaCorrente = new TelaContaCorrenteForm();

            int idSelecionado = tabelaContaCorrente.ObterRegistroSelecionado();

            ContaCorrente contaSelecionada = repositorioContaCorrente.SelecionarPorId(idSelecionado);

            if (contaSelecionada == null)
            {
                MessageBox.Show(
                    Lingua.SelecionarAviso,
                    Lingua.Aviso,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaContaCorrente.ContaCorrente = contaSelecionada;

            DialogResult resultado = telaContaCorrente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            ContaCorrente contaEditada = telaContaCorrente.ContaCorrente;

            repositorioContaCorrente.Editar(contaSelecionada.Id, contaEditada);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{Lingua.Resp1} \"{contaSelecionada.Numero}\" {Lingua.EditRespP2}");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaContaCorrente.ObterRegistroSelecionado();

            ContaCorrente contaSelecionada = repositorioContaCorrente.SelecionarPorId(idSelecionado);

            if (contaSelecionada == null)
            {
                MessageBox.Show(
                    Lingua.SelecionarAviso,
                    Lingua.Aviso,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"{Lingua.PerguntaExcluir} \"{contaSelecionada.Numero}\"?",
                Lingua.ConfirmarExclusao,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioContaCorrente.Excluir(contaSelecionada.Id);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{Lingua.Resp1} \"{contaSelecionada.Numero}\" {Lingua.ExRespP2}");
        }

        public override void Historioco()
        {
            TelaHistoricoForm telaHistorico = new TelaHistoricoForm();

            int idSelecionado = tabelaContaCorrente.ObterRegistroSelecionado();

            ContaCorrente contaSelecionada = repositorioContaCorrente.SelecionarPorId(idSelecionado);

            List<Historioco> his = repositorioHistorioco.SelecionarTodos();

            foreach (Historioco h in his)
            {
                if (contaSelecionada.Titular.Nome.Equals(h.Titular.Nome))
                {
                    telaHistorico.Operacoes = h.Operacoes;
                    telaHistorico.AtualizarRegistros(h.Operacoes);
                    break;
                }
            }
            
            DialogResult resultado = telaHistorico.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            CarregarDadosTabela();

        }

        public override void Operacao()
        {
            int idSelecionado = tabelaContaCorrente.ObterRegistroSelecionado();

            ContaCorrente contaSelecionada = repositorioContaCorrente.SelecionarPorId(idSelecionado);

            TelaOperacaoForm telaOperacao = new TelaOperacaoForm(contaSelecionada,null,null,1);

            DialogResult resultado = telaOperacao.ShowDialog();

            if (resultado != DialogResult.OK)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(Lingua.NPssOpera);
                return;
            }

            Dominio.ModuloOperacao.Operacao operacaoFeita = telaOperacao.Operacao;

            ContaCorrente contaEditada = telaOperacao.Corrente;

            this.GerarHistorioco(operacaoFeita,contaEditada);

            repositorioContaCorrente.Editar(contaSelecionada.Id, contaEditada);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape(Lingua.OperacaoSucesso);

        }

        private void CarregarDadosTabela()
        {

            List<ContaCorrente> disciplina = this.repositorioContaCorrente.SelecionarTodos();

            tabelaContaCorrente.AtualizarRegistros(disciplina);
        }

        private void GerarHistorioco(Operacao opera,ContaCorrente conta)
        {
            List<Historioco> historiocos = repositorioHistorioco.SelecionarTodos();

            bool achado = false;
            foreach (Historioco h in historiocos)
            {
                if (conta.Titular.Nome.Equals(h.Titular.Nome))
                {
                    h.Operacoes.Add(opera);
                    repositorioHistorioco.Editar(h.Id, h);
                    achado = true;
                    break;
                }
            }

            if (!achado)
            {
                List<Dominio.ModuloOperacao.Operacao> operacaos = new List<Operacao>();
                operacaos.Add(opera);
                Historioco novo = new Historioco(conta.Titular,operacaos);
                repositorioHistorioco.Cadastrar(novo);
            }

        }
    }
}
