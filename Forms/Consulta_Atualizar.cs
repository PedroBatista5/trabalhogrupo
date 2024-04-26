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
    public partial class Consulta_Atualizar : Form
    {
        private int _receberID;
        sql_consulta sql = new sql_consulta();
        c_consulta c = new c_consulta();

        public Consulta_Atualizar(int receberID)
        {
            InitializeComponent();
            _receberID = receberID;
        }

        public void PreencherCamposConsulta(int id)
        {
            c_consulta consulta = sql.ObterConsultaPorID(id);

            // Preencher os campos do formulário com os dados obtidos
            txtID.Text = consulta.id_animal.ToString();
            txtNome.Text = consulta.nome_medico;
            txtConsulta.Text = consulta.tipo_consulta;
            dtpConsulta.Value = consulta.data_consulta;
            dtpVisita.Value = consulta.prox_visita;
            txtAto.Text = consulta.ato_medico;
            txtDiagnostico.Text = consulta.diagnostico;
            txtPesos.Text = consulta.peso.ToString();
            txtObservacao.Text = consulta.observacoes;
            txtPrecricao.Text = consulta.prescricao_medica;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            int novoID = int.Parse(txtID.Text);
            string novoNomeMedico = txtNome.Text;
            string novoConsultaTipo = txtConsulta.Text;
            DateTime novaDataConsulta = dtpConsulta.Value;
            DateTime novaDataVisita = dtpVisita.Value;
            string novoAto = txtAto.Text;
            string novoDiagnostico = txtDiagnostico.Text;
            double Pesos = double.Parse(txtPesos.Text);
            string novoObservacao = txtObservacao.Text;
            string novoPrecricao = txtPrecricao.Text;

            // Preencher o objeto c_animal com os dados do formulário
            c.id_animal = novoID;
            c.nome_medico = novoNomeMedico;
            c.tipo_consulta = novoConsultaTipo;
            c.data_consulta = novaDataConsulta;
            c.prox_visita = novaDataVisita;
            c.ato_medico = novoAto;
            c.diagnostico = novoDiagnostico;
            c.peso = Pesos;
            c.observacoes = novoObservacao;
            c.prescricao_medica = novoPrecricao;

            // Chamar o método para editar os campos da tabela
            sql.EditarConsulta(int.Parse(lblID.Text), c);

            // Exibir mensagem de sucesso ou fazer outra ação desejada
            MessageBox.Show("Campos editados com sucesso!");
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Consulta k = new Consulta();
            k.Show();
            this.Hide();
        }

        private void Consulta_Atualizar_Load(object sender, EventArgs e)
        {
            lblID.Text = _receberID.ToString();
            PreencherCamposConsulta(_receberID);
        }
    }
}
