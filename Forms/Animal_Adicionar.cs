using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalhogrupo.Construtor;
using trabalhogrupo.SQL;

namespace trabalhogrupo.Forms
{
    public partial class Animal_Adicionar : Form
    {

        sql_animal sql = new sql_animal();
        c_animal obj = new c_animal();

        public Animal_Adicionar()
        {
            InitializeComponent();
        }

        public void AdicionarValores()
        {
            obj.nome_dono = txtNome.Text;
            obj.contacto_dono = txtContacto.Text;
            obj.data_nascimento = dtpNascimento.Value;
            obj.data_ultima_consulta = dtpConsulta.Value;
            obj.tipo_animal = cbTipo.Text;
            obj.raça = txtRaca.Text;
            obj.sexo = cbSexo.Text;
            obj.peso = double.Parse(txtPeso.Text);

            sql.CadastrarAnimal(obj);

            MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            AdicionarValores();

            btAdicionar.Enabled = true;
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarValores();

            Animal_Adicionar k = new Animal_Adicionar();
            k.Show();
            this.Hide();
        }


        private void btVoltar_Click(object sender, EventArgs e)
        {
            Animal k = new Animal();
            k.Show();
            this.Hide();
        }

        private void Animal_Adicionar_Load(object sender, EventArgs e)
        {

        }
    }
}
