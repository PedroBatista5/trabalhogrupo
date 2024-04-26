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
    public partial class Animal_Atualizar : Form
    {
        private int _receberID;

        sql_animal sql = new sql_animal();
        c_animal c = new c_animal();
        public Animal_Atualizar(int receberID)
        {
            InitializeComponent();
            _receberID = receberID;
        }
        private void PreencherCamposAnimal(int id)
        {
            // Obter os dados do animal com base no ID recebido
            c_animal animal = sql.ObterAnimalPorID(id);

            // Preencher os campos do formulário com os dados obtidos
            txtNome.Text = animal.nome_dono;
            txtContacto.Text = animal.contacto_dono;
            dtpNascimento.Value = animal.data_nascimento;
            dtpConsulta.Value = animal.data_ultima_consulta;
            cbTipo.Text = animal.tipo_animal;
            txtRaca.Text = animal.raça;
            cbSexo.Text = animal.sexo;
            txtPeso.Text = animal.peso.ToString();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            string novoNomeDono = txtNome.Text;
            string novoContactoDono = txtContacto.Text;
            DateTime novaDataNascimento = dtpNascimento.Value;
            DateTime novaDataUltimaConsulta = dtpConsulta.Value;
            string novoTipoAnimal = cbTipo.Text;
            string novaRaca = txtRaca.Text;
            string novoSexo = cbSexo.Text;
            double novoPeso = double.Parse(txtPeso.Text); // Certifique-se de lidar com exceções de conversão aqui

            // Preencher o objeto c_animal com os dados do formulário
            c.nome_dono = novoNomeDono;
            c.contacto_dono = novoContactoDono;
            c.data_nascimento = novaDataNascimento;
            c.data_ultima_consulta = novaDataUltimaConsulta;
            c.tipo_animal = novoTipoAnimal;
            c.raça = novaRaca;
            c.sexo = novoSexo;
            c.peso = novoPeso;

            // Chamar o método para editar os campos da tabela
            sql.EditarAnimal(int.Parse(lblID.Text), c);

            // Exibir mensagem de sucesso ou fazer outra ação desejada
            MessageBox.Show("Campos editados com sucesso!");
        }


        private void btVoltar_Click(object sender, EventArgs e)
        {
            Animal k = new Animal();
            k.Show();
            this.Hide();
        }

        private void Animal_Atualizar_Load(object sender, EventArgs e)
        {
            lblID.Text = _receberID.ToString();
            PreencherCamposAnimal(_receberID);
        }
    }
}
