using NewBank.Dominio.ModuloContaSalario;

namespace NewBank.WinApp.ModuloContaSalario
{
    public partial class TelaContaSalarioForm : Form
    {
        private List<string> erros;
        private ContaSalario contaSalario;

        public ContaSalario ContaSalario
        {
            set
            {

            }
            get
            {
                return this.contaSalario;
            }
        }
        public TelaContaSalarioForm()
        {
            InitializeComponent();
        }
    }
}
