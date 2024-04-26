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
    public partial class Consulta : Form
    {
        DataTable dt = new DataTable();
        c_consulta c = new c_consulta();
        sql_consulta sql = new sql_consulta();

        public Consulta()
        {
            InitializeComponent();
            PreencherDataGrid();
            dgvAnimais.ReadOnly = true;
        }

        public void PreencherDataGrid()
        {
            dt = sql_consulta.GetConsulta();
            dgvAnimais.DataSource = dt;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Consulta_Adicionar k = new Consulta_Adicionar();
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
            try
            {
                int id_consulta = Convert.ToInt32(txtID.Text);
                sql.DelConsulta(id_consulta);
                PreencherDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            int valorID = int.Parse(txtID.Text);
            Consulta_Atualizar atualizar = new Consulta_Atualizar(valorID);
            atualizar.Show();
            this.Hide();
        }
    }
}
