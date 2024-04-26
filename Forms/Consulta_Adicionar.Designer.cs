namespace trabalhogrupo.Forms
{
    partial class Consulta_Adicionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtConsulta = new TextBox();
            dtpVisita = new DateTimePicker();
            dtpConsulta = new DateTimePicker();
            label6 = new Label();
            Diagnostico = new Label();
            label8 = new Label();
            label9 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            btVoltar = new Button();
            btAlterar = new Button();
            btAdicionar = new Button();
            btConfirmar = new Button();
            label1 = new Label();
            txtDiagnostico = new TextBox();
            txtAto = new TextBox();
            label4 = new Label();
            label10 = new Label();
            txtPrecricao = new TextBox();
            label5 = new Label();
            txtPesos = new TextBox();
            txtObservacao = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(290, 155);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(254, 23);
            txtConsulta.TabIndex = 54;
            // 
            // dtpVisita
            // 
            dtpVisita.Location = new Point(290, 236);
            dtpVisita.Name = "dtpVisita";
            dtpVisita.Size = new Size(254, 23);
            dtpVisita.TabIndex = 51;
            // 
            // dtpConsulta
            // 
            dtpConsulta.Location = new Point(12, 236);
            dtpConsulta.Name = "dtpConsulta";
            dtpConsulta.Size = new Size(255, 23);
            dtpConsulta.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(296, 368);
            label6.Name = "label6";
            label6.Size = new Size(86, 19);
            label6.TabIndex = 48;
            label6.Text = "Observações";
            // 
            // Diagnostico
            // 
            Diagnostico.AutoSize = true;
            Diagnostico.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Diagnostico.Location = new Point(295, 287);
            Diagnostico.Name = "Diagnostico";
            Diagnostico.Size = new Size(80, 19);
            Diagnostico.TabIndex = 47;
            Diagnostico.Text = "Diagnostico";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(294, 202);
            label8.Name = "label8";
            label8.Size = new Size(156, 19);
            label8.TabIndex = 46;
            label8.Text = "Data da Proxima Visita";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(293, 121);
            label9.Name = "label9";
            label9.Size = new Size(115, 19);
            label9.TabIndex = 45;
            label9.Text = "Tipo de Consulta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 202);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 42;
            label3.Text = "Data da Consulta";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(13, 155);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 23);
            txtNome.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(115, 19);
            label2.TabIndex = 40;
            label2.Text = "Nome do Medico";
            // 
            // btVoltar
            // 
            btVoltar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltar.Location = new Point(656, 216);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(118, 65);
            btVoltar.TabIndex = 39;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // btAlterar
            // 
            btAlterar.Location = new Point(0, 0);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(75, 23);
            btAlterar.TabIndex = 70;
            // 
            // btAdicionar
            // 
            btAdicionar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btAdicionar.Location = new Point(656, 131);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(118, 65);
            btAdicionar.TabIndex = 37;
            btAdicionar.Text = "Continuar a Adicionar";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // btConfirmar
            // 
            btConfirmar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmar.Location = new Point(656, 41);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(118, 65);
            btConfirmar.TabIndex = 36;
            btConfirmar.Text = "Confirmar Registo";
            btConfirmar.UseVisualStyleBackColor = true;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 35;
            label1.Text = "Registo de Animais";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(290, 320);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(254, 23);
            txtDiagnostico.TabIndex = 55;
            // 
            // txtAto
            // 
            txtAto.Location = new Point(12, 320);
            txtAto.Name = "txtAto";
            txtAto.Size = new Size(254, 23);
            txtAto.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 368);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 61;
            label4.Text = "Peso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 287);
            label10.Name = "label10";
            label10.Size = new Size(82, 19);
            label10.TabIndex = 60;
            label10.Text = "Ato Medico";
            // 
            // txtPrecricao
            // 
            txtPrecricao.Location = new Point(12, 465);
            txtPrecricao.Name = "txtPrecricao";
            txtPrecricao.Size = new Size(532, 23);
            txtPrecricao.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 436);
            label5.Name = "label5";
            label5.Size = new Size(73, 19);
            label5.TabIndex = 64;
            label5.Text = "Prescricao";
            // 
            // txtPesos
            // 
            txtPesos.Location = new Point(13, 397);
            txtPesos.Name = "txtPesos";
            txtPesos.Size = new Size(254, 23);
            txtPesos.TabIndex = 67;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(291, 397);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(254, 23);
            txtObservacao.TabIndex = 66;
            // 
            // txtID
            // 
            txtID.Location = new Point(13, 86);
            txtID.Name = "txtID";
            txtID.Size = new Size(254, 23);
            txtID.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 52);
            label7.Name = "label7";
            label7.Size = new Size(70, 19);
            label7.TabIndex = 68;
            label7.Text = "ID animal";
            // 
            // Consulta_Adicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(txtPesos);
            Controls.Add(txtObservacao);
            Controls.Add(txtPrecricao);
            Controls.Add(label5);
            Controls.Add(txtAto);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(txtDiagnostico);
            Controls.Add(txtConsulta);
            Controls.Add(dtpVisita);
            Controls.Add(dtpConsulta);
            Controls.Add(label6);
            Controls.Add(Diagnostico);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(btVoltar);
            Controls.Add(btAlterar);
            Controls.Add(btAdicionar);
            Controls.Add(btConfirmar);
            Controls.Add(label1);
            Name = "Consulta_Adicionar";
            Text = "Consulta_Adicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtConsulta;
        private ComboBox cbSexo;
        private ComboBox cbTipo;
        private DateTimePicker dtpVisita;
        private DateTimePicker dtpConsulta;
        private TextBox txtPeso;
        private Label label6;
        private Label Diagnostico;
        private Label label8;
        private Label label9;
        private TextBox txtRaca;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private Button btVoltar;
        private Button btAlterar;
        private Button btAdicionar;
        private Button btConfirmar;
        private Label label1;
        private TextBox txtDiagnostico;
        private TextBox txtAto;
        private Label label4;
        private Label label10;
        private TextBox txtPrecricao;
        private Label label5;
        private TextBox txtPesos;
        private TextBox txtObservacao;
        private TextBox txtID;
        private Label label7;
    }
}