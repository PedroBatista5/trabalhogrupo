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
    public partial class Consulta_Adicionar : Form
    {
        sql_consulta sql = new sql_consulta();
        c_consulta obj = new c_consulta();


        public Consulta_Adicionar()
        {
            InitializeComponent();
        }

        public void AdicionarValores()
        {
            obj.id_animal = int.Parse(txtID.Text);
            obj.nome_medico = txtNome.Text;
            obj.tipo_consulta = txtConsulta.Text;
            obj.data_consulta = dtpConsulta.Value;
            obj.prox_visita = dtpVisita.Value;
            obj.diagnostico = txtDiagnostico.Text;
            obj.ato_medico = txtAto.Text;
            obj.observacoes = txtObservacao.Text;
            obj.peso = double.Parse(txtPesos.Text);
            obj.prescricao_medica = txtPrecricao.Text;

            sql.AdicionarConsulta(obj);

            MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            AdicionarValores();

            btAdicionar.Enabled = true;
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Consulta_Adicionar k = new Consulta_Adicionar();
            k.Show();
            this.Hide();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Consulta k = new Consulta();
            k.Show();
            this.Hide();
        }
    }
}
