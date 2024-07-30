

namespace Gerador_de_Testes.ModoloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        private Disciplina disciplina;
        private IRepositorioDisciplina repositorio;
        private List<string> erros;

        public Disciplina Disciplina
        {
            set
            {
                this.txtId.Text = value.Id.ToString();
                this.txtNome.Text = value.Nome;
            }
            get
            {
                return this.disciplina;
            }
        }

        public TelaDisciplinaForm(string tipo,IRepositorioDisciplina repositorio)
        {
            InitializeComponent();
            this.Text = tipo;
            this.repositorio = repositorio;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.EntradaDados();

            if (erros.Count > 0) 
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                this.txtNome.Text = null;
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void EntradaDados()
        {
            disciplina = new(this.txtNome.Text);
            erros = disciplina.Validar();

            List<Disciplina> disciplinas = repositorio.SelecionarTodos();
            foreach (Disciplina d in disciplinas)
            {
                if (disciplina.Nome.Equals(d.Nome))
                {
                    erros.Add("Disciplina com mesmo nome ja cadastrada");
                    return;
                }                   
            }
        }
    }
}
