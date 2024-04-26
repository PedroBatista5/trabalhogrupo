namespace trabalhogrupo.Forms
{
    partial class Animal_Adicionar
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
            btVoltar = new Button();
            btAlterar = new Button();
            btAdicionar = new Button();
            btConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtRaca = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtPeso = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dtpNascimento = new DateTimePicker();
            dtpConsulta = new DateTimePicker();
            cbTipo = new ComboBox();
            cbSexo = new ComboBox();
            txtContacto = new TextBox();
            SuspendLayout();
            // 
            // btVoltar
            // 
            btVoltar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltar.Location = new Point(656, 230);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(118, 65);
            btVoltar.TabIndex = 11;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // btAlterar
            // 
            btAlterar.Location = new Point(0, 0);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(75, 23);
            btAlterar.TabIndex = 35;
            // 
            // btAdicionar
            // 
            btAdicionar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btAdicionar.Location = new Point(656, 131);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(118, 65);
            btAdicionar.TabIndex = 9;
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
            btConfirmar.TabIndex = 8;
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
            label1.TabIndex = 7;
            label1.Text = "Registo de Animais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 13;
            label2.Text = "Nome do Dono";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(13, 98);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 23);
            txtNome.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 145);
            label3.Name = "label3";
            label3.Size = new Size(206, 19);
            label3.TabIndex = 16;
            label3.Text = "Data de Nascimento do Animal";
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(16, 345);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(254, 23);
            txtRaca.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 311);
            label4.Name = "label4";
            label4.Size = new Size(38, 19);
            label4.TabIndex = 20;
            label4.Text = "Raça";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 230);
            label5.Name = "label5";
            label5.Size = new Size(105, 19);
            label5.TabIndex = 18;
            label5.Text = "Tipo de Animal";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(297, 345);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(254, 23);
            txtPeso.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(296, 311);
            label6.Name = "label6";
            label6.Size = new Size(36, 19);
            label6.TabIndex = 28;
            label6.Text = "Peso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(295, 230);
            label7.Name = "label7";
            label7.Size = new Size(40, 19);
            label7.TabIndex = 26;
            label7.Text = "Sexo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(294, 145);
            label8.Name = "label8";
            label8.Size = new Size(158, 19);
            label8.TabIndex = 24;
            label8.Text = "Data da Ultima Consula";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(293, 64);
            label9.Name = "label9";
            label9.Size = new Size(64, 19);
            label9.TabIndex = 22;
            label9.Text = "Contacto";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(16, 179);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(251, 23);
            dtpNascimento.TabIndex = 30;
            // 
            // dtpConsulta
            // 
            dtpConsulta.Location = new Point(293, 179);
            dtpConsulta.Name = "dtpConsulta";
            dtpConsulta.Size = new Size(251, 23);
            dtpConsulta.TabIndex = 31;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Cão", "Gato" });
            cbTipo.Location = new Point(16, 264);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(251, 23);
            cbTipo.TabIndex = 32;
            cbTipo.Text = "Cão";
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Macho", "Fêmea" });
            cbSexo.Location = new Point(294, 264);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(251, 23);
            cbSexo.TabIndex = 33;
            cbSexo.Text = "Macho";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(290, 98);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(254, 23);
            txtContacto.TabIndex = 34;
            // 
            // Animal_Adicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContacto);
            Controls.Add(cbSexo);
            Controls.Add(cbTipo);
            Controls.Add(dtpConsulta);
            Controls.Add(dtpNascimento);
            Controls.Add(txtPeso);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtRaca);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(btVoltar);
            Controls.Add(btAlterar);
            Controls.Add(btAdicionar);
            Controls.Add(btConfirmar);
            Controls.Add(label1);
            Name = "Animal_Adicionar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animal_Adicionar";
            Load += Animal_Adicionar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVoltar;
        private Button btAlterar;
        private Button btAdicionar;
        private Button btConfirmar;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtRaca;
        private Label label4;
        private Label label5;
        private TextBox txtPeso;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dtpNascimento;
        private DateTimePicker dtpConsulta;
        private ComboBox cbTipo;
        private ComboBox cbSexo;
        private TextBox txtContacto;
    }
}