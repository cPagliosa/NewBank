using NewBank.Dominio.ModuloContaPoupanca;
using NewBank.Dominio.ModuloHistorioco;
using NewBank.Dominio.ModuloOperacao;
using NewBank.Dominio.Resources;
using NewBank.WinApp.Compartilhado;
using NewBank.WinApp.ModuloHistorioco;
using NewBank.WinApp.ModuloOperacao;

namespace NewBank.WinApp.ModuloContaPoupanca
{
    public class ControladorContaPoupanca : ControladorBase
    {
        private IRepositorioContaPoupanca repositorioContaPoupanca;
        private IRepositorioHistorioco repositorioHistorioco;
        private TabelaContaPoupanca tabelaContaPoupanca;

        public override string TipoCadastro { get { return Lingua.ContaPoupanca; } }
        public override string ToolTipAdicionar { get { return Lingua.CadConta; } }
        public override string ToolTipEditar { get { return Lingua.EdtConta; } }
        public override string ToolTipExcluir { get { return Lingua.ExcConta; } }

        public ControladorContaPoupanca(IRepositorioContaPoupanca repositorioContaPoupanca, IRepositorioHistorioco repositorioHistorioco, IRepositorioOperacao repositorioOperacao)
        {
            this.repositorioContaPoupanca = repositorioContaPoupanca;
            this.repositorioHistorioco = repositorioHistorioco;
        }
        public override UserControl ObterListagem()
        {
            if (tabelaContaPoupanca == null)
                tabelaContaPoupanca = new TabelaContaPoupanca();
            CarregarDadosTabela();

            return tabelaContaPoupanca;
        }

        public override void Adicionar()
        {
            TelaContaPoupancaForm telaContaPoupanca = new TelaContaPoupancaForm();

            DialogResult resultado = telaContaPoupanca.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            ContaPoupanca novaConta = telaContaPoupanca.ContaPoupanca;

            this.repositorioContaPoupanca.Cadastrar(novaConta);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{Lingua.Resp1} \"{novaConta.Numero}\" {Lingua.AddRespP2}");
        }

        public override void Editar()
        {
            TelaContaPoupancaForm telaContaPoupanca = new TelaContaPoupancaForm();

            int idSelecionado = tabelaContaPoupanca.ObterRegistroSelecionado();

            ContaPoupanca contaSelecionada = repositorioContaPoupanca.SelecionarPorId(idSelecionado);

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

            telaContaPoupanca.ContaPoupanca = contaSelecionada;

            DialogResult resultado = telaContaPoupanca.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            ContaPoupanca contaEditada = telaContaPoupanca.ContaPoupanca;

            repositorioContaPoupanca.Editar(contaSelecionada.Id, contaEditada);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{Lingua.Resp1} \"{contaSelecionada.Numero}\" {Lingua.EditRespP2}");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaContaPoupanca.ObterRegistroSelecionado();

            ContaPoupanca contaSelecionada = repositorioContaPoupanca.SelecionarPorId(idSelecionado);

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

            repositorioContaPoupanca.Excluir(contaSelecionada.Id);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{Lingua.Resp1} \"{contaSelecionada.Numero}\" {Lingua.ExRespP2}");
        }

        public override void Historioco()
        {
            TelaHistoricoForm telaHistorico = new TelaHistoricoForm();

            int idSelecionado = tabelaContaPoupanca.ObterRegistroSelecionado();

            ContaPoupanca contaSelecionada = repositorioContaPoupanca.SelecionarPorId(idSelecionado);

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
            int idSelecionado = tabelaContaPoupanca.ObterRegistroSelecionado();

            ContaPoupanca contaSelecionada = repositorioContaPoupanca.SelecionarPorId(idSelecionado);

            TelaOperacaoForm telaOperacao = new TelaOperacaoForm(null, null, contaSelecionada, 3);

            DialogResult resultado = telaOperacao.ShowDialog();

            if (resultado != DialogResult.OK)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(Lingua.NPssOpera);
                return;
            }

            Dominio.ModuloOperacao.Operacao operacaoFeita = telaOperacao.Operacao;

            ContaPoupanca contaEditada = telaOperacao.Poupanca;

            this.GerarHistorioco(operacaoFeita, contaEditada);

            repositorioContaPoupanca.Editar(contaSelecionada.Id, contaEditada);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape(Lingua.OperacaoSucesso);
        }

        private void CarregarDadosTabela()
        {
            List<ContaPoupanca> disciplina = this.repositorioContaPoupanca.SelecionarTodos();

            tabelaContaPoupanca.AtualizarRegistros(disciplina);
        }

        private void GerarHistorioco(Operacao opera, ContaPoupanca conta)
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
                Historioco novo = new Historioco(conta.Titular, operacaos);
                repositorioHistorioco.Cadastrar(novo);
            }

        }
    }
}
