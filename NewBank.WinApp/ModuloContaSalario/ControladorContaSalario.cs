using NewBank.Dominio.ModuloContaSalario;
using NewBank.Dominio.ModuloHistorioco;
using NewBank.Dominio.ModuloOperacao;
using NewBank.Dominio.Resources;
using NewBank.WinApp.Compartilhado;
using NewBank.WinApp.ModuloHistorioco;
using NewBank.WinApp.ModuloOperacao;


namespace NewBank.WinApp.ModuloContaSalario
{
    public class ControladorContaSalario : ControladorBase
    {
        private IRepositorioContaSalario repositorioContaSalario;
        private IRepositorioHistorioco repositorioHistorioco;
        private TabelaContaSalario tabelaContaSalario;

        public override string TipoCadastro { get { return Lingua.ContaSalario; } }
        public override string ToolTipAdicionar { get { return Lingua.CadConta; } }
        public override string ToolTipEditar { get { return Lingua.EdtConta; } }
        public override string ToolTipExcluir { get { return Lingua.ExcConta; } }

        public ControladorContaSalario(IRepositorioContaSalario repositorioContaSalario, IRepositorioHistorioco repositorioHistorioco, IRepositorioOperacao repositorioOperacao)
        {
            this.repositorioContaSalario = repositorioContaSalario;
            this.repositorioHistorioco = repositorioHistorioco;
        }
        public override UserControl ObterListagem()
        {
            if (tabelaContaSalario == null)
                tabelaContaSalario = new TabelaContaSalario();

            CarregarDadosTabela();

            return tabelaContaSalario;
        }

        public override void Adicionar()
        {
            TelaContaSalarioForm telaContaSalario = new TelaContaSalarioForm();

            DialogResult resultado = telaContaSalario.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            ContaSalario novaConta = telaContaSalario.ContaSalario;

            this.repositorioContaSalario.Cadastrar(novaConta);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{Lingua.Resp1} \"{novaConta.Numero}\" {Lingua.AddRespP2}");
        }

        public override void Editar()
        {
            TelaContaSalarioForm telaContaSalario = new TelaContaSalarioForm();

            int idSelecionado = tabelaContaSalario.ObterRegistroSelecionado();

            ContaSalario contaSelecionada = repositorioContaSalario.SelecionarPorId(idSelecionado);

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

            telaContaSalario.ContaSalario = contaSelecionada;

            DialogResult resultado = telaContaSalario.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            ContaSalario contaEditada = telaContaSalario.ContaSalario;

            repositorioContaSalario.Editar(contaSelecionada.Id, contaEditada);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{Lingua.Resp1} \"{contaSelecionada.Numero}\" {Lingua.EditRespP2}");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaContaSalario.ObterRegistroSelecionado();

            ContaSalario contaSelecionada = repositorioContaSalario.SelecionarPorId(idSelecionado);

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

            repositorioContaSalario.Excluir(contaSelecionada.Id);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{Lingua.Resp1} \"{contaSelecionada.Titular.Nome}\" {Lingua.ExRespP2}");
        }

        public override void Historioco()
        {
            TelaHistoricoForm telaHistorico = new TelaHistoricoForm();

            int idSelecionado = tabelaContaSalario.ObterRegistroSelecionado();

            ContaSalario contaSelecionada = repositorioContaSalario.SelecionarPorId(idSelecionado);

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
            int idSelecionado = tabelaContaSalario.ObterRegistroSelecionado();

            ContaSalario contaSelecionada = repositorioContaSalario.SelecionarPorId(idSelecionado);

            TelaOperacaoForm telaOperacao = new TelaOperacaoForm(null, contaSelecionada, null, 2);

            DialogResult resultado = telaOperacao.ShowDialog();

            if (resultado != DialogResult.OK)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(Lingua.NPssOpera);
                return;
            }

            Dominio.ModuloOperacao.Operacao operacaoFeita = telaOperacao.Operacao;

            ContaSalario contaEditada = telaOperacao.Salario;

            this.GerarHistorioco(operacaoFeita, contaEditada);

            repositorioContaSalario.Editar(contaSelecionada.Id, contaEditada);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape(Lingua.OperacaoSucesso);
        }
        private void CarregarDadosTabela()
        {
            List<ContaSalario> disciplina = this.repositorioContaSalario.SelecionarTodos();

            tabelaContaSalario.AtualizarRegistros(disciplina);
        }

        private void GerarHistorioco(Operacao opera, ContaSalario conta)
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
