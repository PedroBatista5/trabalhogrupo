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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Animal_Adicionar k = new Animal_Adicionar();
            k.Show();
            this.Hide();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            //Esconder os botões anteriores
            btAdicionar.Enabled = false;
            btRemover.Enabled = false;
            btAlterar.Enabled = false;
            btVoltar.Enabled = false;

            btAdicionar.Visible = false;
            btRemover.Visible = false;
            btAlterar.Visible = false;
            btVoltar.Visible = false;

            //btRemover
            lblInformacao.Text = "Remover Consulta";
            txtID.Enabled = true;
            btConfirmar.Enabled = true;
            btVoltarRemover.Enabled = true;

            lblInformacao.Visible = true;
            btLabel2.Visible = true;
            txtID.Visible = true;
            btConfirmar.Visible = true;
            btVoltarRemover.Visible = true;

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Esconder os botões anteriores
            btAdicionar.Enabled = false;
            btRemover.Enabled = false;
            btAlterar.Enabled = false;
            btVoltar.Enabled = false;

            btAdicionar.Visible = false;
            btRemover.Visible = false;
            btAlterar.Visible = false;
            btVoltar.Visible = false;

            //btRemover
            lblInformacao.Text = "Atualizar Consulta";
            txtID.Enabled = true;
            btConfirmarAtualizar.Enabled = true;
            btVoltarRemover.Enabled = true;

            lblInformacao.Visible = true;
            btLabel2.Visible = true;
            txtID.Visible = true;
            btConfirmarAtualizar.Visible = true;
            btVoltarRemover.Visible = true;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            MenuInicial k = new MenuInicial();
            k.Show();
            this.Hide();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            //Remover o ID da BD

            //Txt ficar limpo
            txtID.Clear();
        }

        private void btVoltarRemover_Click(object sender, EventArgs e)
        {
            //Mostrar bt do menu
            btAdicionar.Enabled = true;
            btRemover.Enabled = true;
            btAlterar.Enabled = true;
            btVoltar.Enabled = true;

            btAdicionar.Visible = true;
            btRemover.Visible = true;
            btAlterar.Visible = true;
            btVoltar.Visible = true;

            //Esconder o btRemover
            txtID.Enabled = false;
            btConfirmar.Enabled = false;
            btVoltarRemover.Enabled = false;

            lblInformacao.Visible = false;
            btLabel2.Visible = false;
            txtID.Visible = false;
            btConfirmar.Visible = false;
            btVoltarRemover.Visible = false;
        }

        private void btConfirmarAtualizar_Click(object sender, EventArgs e)
        {
            //Mostrar bt do menu
            btAdicionar.Enabled = true;
            btRemover.Enabled = true;
            btAlterar.Enabled = true;
            btVoltar.Enabled = true;

            btAdicionar.Visible = true;
            btRemover.Visible = true;
            btAlterar.Visible = true;
            btVoltar.Visible = true;

            //Esconder o btAtualizar
            txtID.Enabled = false;
            btConfirmarAtualizar.Enabled = false;
            btVoltarRemover.Enabled = false;

            lblInformacao.Visible = false;
            btLabel2.Visible = false;
            txtID.Visible = false;
            btConfirmarAtualizar.Visible = false;
            btVoltarRemover.Visible = false;

            //Ir para a pagina atualizar
            Consulta_Atualizar k = new Consulta_Atualizar();
            k.Show();
            this.Hide();
        }
    }
}
