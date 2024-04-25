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
    public partial class Consulta_Adicionar : Form
    {
        public string nome_medico { get; set; }
        public string tipo_consulta { get; set; }
        public DateTime data_consulta { get; set; }
        public DateTime prox_visita { get; set; }
        public string diagnostico { get; set; }
        public string ato_medico { get; set; }
        public string observacoes { get; set; }
        public double peso { get; set; }
        public string prescricao_medica { get; set; }

        public Consulta_Adicionar()
        {
            InitializeComponent();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            nome_medico = txtNome.Text;
            tipo_consulta = txtConsulta.Text;
            data_consulta = dtpConsulta.Value;
            prox_visita = dtpVisita.Value;
            diagnostico = txtDiagnostico.Text;
            ato_medico = txtAto.Text;
            observacoes = txtObservacao.Text;
            peso = double.Parse(txtPesos.Text);
            prescricao_medica = txtPrecricao.Text;

            btAdicionar.Enabled = true;
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Consulta_Adicionar k = new Consulta_Adicionar();
            k.Show();
            this.Hide();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            Consulta_Atualizar k = new Consulta_Atualizar();
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
