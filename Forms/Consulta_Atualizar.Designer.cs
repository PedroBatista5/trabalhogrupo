namespace trabalhogrupo.Forms
{
    partial class Consulta_Atualizar
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
            txtPesos = new TextBox();
            txtObservacao = new TextBox();
            txtPrecricao = new TextBox();
            label5 = new Label();
            txtAto = new TextBox();
            label4 = new Label();
            label10 = new Label();
            txtDiagnostico = new TextBox();
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
            label1 = new Label();
            lblID = new Label();
            btVoltar = new Button();
            btLabel = new Button();
            btConfirmar = new Button();
            SuspendLayout();
            // 
            // txtPesos
            // 
            txtPesos.Location = new Point(13, 340);
            txtPesos.Name = "txtPesos";
            txtPesos.Size = new Size(254, 23);
            txtPesos.TabIndex = 90;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(291, 340);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(254, 23);
            txtObservacao.TabIndex = 89;
            // 
            // txtPrecricao
            // 
            txtPrecricao.Location = new Point(12, 415);
            txtPrecricao.Name = "txtPrecricao";
            txtPrecricao.Size = new Size(532, 23);
            txtPrecricao.TabIndex = 88;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 386);
            label5.Name = "label5";
            label5.Size = new Size(73, 19);
            label5.TabIndex = 87;
            label5.Text = "Prescricao";
            // 
            // txtAto
            // 
            txtAto.Location = new Point(12, 263);
            txtAto.Name = "txtAto";
            txtAto.Size = new Size(254, 23);
            txtAto.TabIndex = 86;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 311);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 85;
            label4.Text = "Peso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 230);
            label10.Name = "label10";
            label10.Size = new Size(82, 19);
            label10.TabIndex = 84;
            label10.Text = "Ato Medico";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(290, 263);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(254, 23);
            txtDiagnostico.TabIndex = 83;
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(290, 98);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(254, 23);
            txtConsulta.TabIndex = 82;
            // 
            // dtpVisita
            // 
            dtpVisita.Location = new Point(290, 179);
            dtpVisita.Name = "dtpVisita";
            dtpVisita.Size = new Size(254, 23);
            dtpVisita.TabIndex = 81;
            // 
            // dtpConsulta
            // 
            dtpConsulta.Location = new Point(12, 179);
            dtpConsulta.Name = "dtpConsulta";
            dtpConsulta.Size = new Size(255, 23);
            dtpConsulta.TabIndex = 80;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(296, 311);
            label6.Name = "label6";
            label6.Size = new Size(86, 19);
            label6.TabIndex = 79;
            label6.Text = "Observações";
            // 
            // Diagnostico
            // 
            Diagnostico.AutoSize = true;
            Diagnostico.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Diagnostico.Location = new Point(295, 230);
            Diagnostico.Name = "Diagnostico";
            Diagnostico.Size = new Size(80, 19);
            Diagnostico.TabIndex = 78;
            Diagnostico.Text = "Diagnostico";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(294, 145);
            label8.Name = "label8";
            label8.Size = new Size(156, 19);
            label8.TabIndex = 77;
            label8.Text = "Data da Proxima Visita";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(293, 64);
            label9.Name = "label9";
            label9.Size = new Size(115, 19);
            label9.TabIndex = 76;
            label9.Text = "Tipo de Consulta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 145);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 75;
            label3.Text = "Data da Consulta";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(13, 98);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 23);
            txtNome.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(115, 19);
            label2.TabIndex = 73;
            label2.Text = "Nome do Medico";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 68;
            label1.Text = "Registo de Animais";
            // 
            // lblID
            // 
            lblID.BackColor = Color.White;
            lblID.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(650, 226);
            lblID.Name = "lblID";
            lblID.Size = new Size(98, 23);
            lblID.TabIndex = 94;
            lblID.Text = "Num";
            lblID.TextAlign = ContentAlignment.TopCenter;
            // 
            // btVoltar
            // 
            btVoltar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltar.Location = new Point(640, 313);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(118, 65);
            btVoltar.TabIndex = 93;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // btLabel
            // 
            btLabel.Enabled = false;
            btLabel.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btLabel.Location = new Point(640, 194);
            btLabel.Name = "btLabel";
            btLabel.Size = new Size(118, 65);
            btLabel.TabIndex = 92;
            btLabel.Text = "ID\r\nID\r\n";
            btLabel.UseVisualStyleBackColor = true;
            // 
            // btConfirmar
            // 
            btConfirmar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmar.Location = new Point(640, 56);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(118, 65);
            btConfirmar.TabIndex = 91;
            btConfirmar.Text = "Confirmar Alteração";
            btConfirmar.UseVisualStyleBackColor = true;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // Consulta_Atualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblID);
            Controls.Add(btVoltar);
            Controls.Add(btLabel);
            Controls.Add(btConfirmar);
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
            Controls.Add(label1);
            Name = "Consulta_Atualizar";
            Text = "Consulta_Atualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesos;
        private TextBox txtObservacao;
        private TextBox txtPrecricao;
        private Label label5;
        private TextBox txtAto;
        private Label label4;
        private Label label10;
        private TextBox txtDiagnostico;
        private TextBox txtConsulta;
        private DateTimePicker dtpVisita;
        private DateTimePicker dtpConsulta;
        private Label label6;
        private Label Diagnostico;
        private Label label8;
        private Label label9;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        public Label lblID;
        private Button btVoltar;
        private Button btLabel;
        private Button btConfirmar;
    }
}