namespace trabalhogrupo.Forms
{
    partial class Animal_Atualizar
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
            txtContacto = new TextBox();
            cbSexo = new ComboBox();
            cbTipo = new ComboBox();
            dtpConsulta = new DateTimePicker();
            dtpNascimento = new DateTimePicker();
            txtPeso = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtRaca = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            btVoltar = new Button();
            btConfirmar = new Button();
            label1 = new Label();
            btLabel = new Button();
            lblID = new Label();
            SuspendLayout();
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(290, 98);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(254, 23);
            txtContacto.TabIndex = 55;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Macho", "Fêmia" });
            cbSexo.Location = new Point(294, 264);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(251, 23);
            cbSexo.TabIndex = 54;
            cbSexo.Text = "Macho";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Cão", "Gato" });
            cbTipo.Location = new Point(16, 264);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(251, 23);
            cbTipo.TabIndex = 53;
            cbTipo.Text = "Cão";
            // 
            // dtpConsulta
            // 
            dtpConsulta.Location = new Point(293, 179);
            dtpConsulta.Name = "dtpConsulta";
            dtpConsulta.Size = new Size(251, 23);
            dtpConsulta.TabIndex = 52;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(16, 179);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(251, 23);
            dtpNascimento.TabIndex = 51;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(297, 345);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(254, 23);
            txtPeso.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(296, 311);
            label6.Name = "label6";
            label6.Size = new Size(36, 19);
            label6.TabIndex = 49;
            label6.Text = "Peso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(295, 230);
            label7.Name = "label7";
            label7.Size = new Size(40, 19);
            label7.TabIndex = 48;
            label7.Text = "Sexo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(294, 145);
            label8.Name = "label8";
            label8.Size = new Size(158, 19);
            label8.TabIndex = 47;
            label8.Text = "Data da Ultima Consula";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(293, 64);
            label9.Name = "label9";
            label9.Size = new Size(64, 19);
            label9.TabIndex = 46;
            label9.Text = "Contacto";
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(16, 345);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(254, 23);
            txtRaca.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 311);
            label4.Name = "label4";
            label4.Size = new Size(38, 19);
            label4.TabIndex = 44;
            label4.Text = "Raça";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 230);
            label5.Name = "label5";
            label5.Size = new Size(105, 19);
            label5.TabIndex = 43;
            label5.Text = "Tipo de Animal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 145);
            label3.Name = "label3";
            label3.Size = new Size(206, 19);
            label3.TabIndex = 42;
            label3.Text = "Data de Nascimento do Animal";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(13, 98);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 23);
            txtNome.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 40;
            label2.Text = "Nome do Dono";
            // 
            // btVoltar
            // 
            btVoltar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltar.Location = new Point(656, 298);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(118, 65);
            btVoltar.TabIndex = 39;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // btConfirmar
            // 
            btConfirmar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmar.Location = new Point(656, 41);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(118, 65);
            btConfirmar.TabIndex = 36;
            btConfirmar.Text = "Confirmar Alteração";
            btConfirmar.UseVisualStyleBackColor = true;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 35;
            label1.Text = "Atualizar Animal";
            // 
            // btLabel
            // 
            btLabel.Enabled = false;
            btLabel.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btLabel.Location = new Point(656, 179);
            btLabel.Name = "btLabel";
            btLabel.Size = new Size(118, 65);
            btLabel.TabIndex = 38;
            btLabel.Text = "ID\r\nID\r\n";
            btLabel.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            lblID.BackColor = Color.White;
            lblID.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(666, 211);
            lblID.Name = "lblID";
            lblID.Size = new Size(98, 23);
            lblID.TabIndex = 56;
            lblID.Text = "Num";
            lblID.TextAlign = ContentAlignment.TopCenter;
            // 
            // Animal_Atualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblID);
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
            Controls.Add(btLabel);
            Controls.Add(btConfirmar);
            Controls.Add(label1);
            Name = "Animal_Atualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animal_Atualizar";
            Load += Animal_Atualizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContacto;
        private ComboBox cbSexo;
        private ComboBox cbTipo;
        private DateTimePicker dtpConsulta;
        private DateTimePicker dtpNascimento;
        private TextBox txtPeso;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtRaca;
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private Button btVoltar;
        private Button btConfirmar;
        private Label label1;
        private Button btLabel;
        public Label lblID;
    }
}