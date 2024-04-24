using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhogrupo.Forms
{
    public partial class Animal_Adicionar : Form
    {
        public string nome_dono { get; set; }
        public string contacto_dono { get; set; }
        public DateTime data_nascimento { get; set; }
        public DateTime data_ultima_consulta { get; set; }
        public string tipo_animal { get; set; }
        public string raça { get; set; }
        public string sexo { get; set; }
        public double peso { get; set; }


        public Animal_Adicionar()
        {
            InitializeComponent();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            nome_dono = txtNome.Text;
            contacto_dono = txtContacto.Text;
            data_nascimento = dtpNascimento.Value;
            data_ultima_consulta = dtpConsulta.Value;
            tipo_animal = cbTipo.Text;
            raça = txtRaca.Text;
            sexo = cbSexo.Text;
            peso = double.Parse(txtPeso.Text);

            btAdicionar.Enabled = true;
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Animal_Adicionar k = new Animal_Adicionar();
            k.Show();
            this.Hide();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            Animal_Atualizar k = new Animal_Atualizar();
            k.Show();
            this.Hide();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Animal k = new Animal();
            k.Show();
            this.Hide();
        }
    }
}
