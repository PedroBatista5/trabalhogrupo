using trabalhogrupo.Forms;

namespace trabalhogrupo
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void bt_animal_Click(object sender, EventArgs e)
        {
            Animal k = new Animal();
            k.Show();
            this.Hide();
        }

        private void bt_consulta_Click(object sender, EventArgs e)
        {
            Consulta k = new Consulta();
            k.Show();
            this.Hide();
        }
    }
}