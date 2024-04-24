namespace trabalhogrupo.Forms
{
    partial class Animal
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
            dgvAnimais = new DataGridView();
            label1 = new Label();
            btAdicionar = new Button();
            btRemover = new Button();
            btAlterar = new Button();
            btVoltar = new Button();
            btVoltarRemover = new Button();
            btConfirmar = new Button();
            btLabel2 = new Button();
            txtID = new TextBox();
            btConfirmarAtualizar = new Button();
            lblInformacao = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAnimais).BeginInit();
            SuspendLayout();
            // 
            // dgvAnimais
            // 
            dgvAnimais.AllowUserToAddRows = false;
            dgvAnimais.AllowUserToDeleteRows = false;
            dgvAnimais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimais.Location = new Point(12, 41);
            dgvAnimais.Name = "dgvAnimais";
            dgvAnimais.ReadOnly = true;
            dgvAnimais.RowTemplate.Height = 25;
            dgvAnimais.Size = new Size(638, 322);
            dgvAnimais.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 1;
            label1.Text = "Animais Atuais:";
            // 
            // btAdicionar
            // 
            btAdicionar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btAdicionar.Location = new Point(656, 41);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(118, 65);
            btAdicionar.TabIndex = 2;
            btAdicionar.Text = "Adicionar Animal";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // btRemover
            // 
            btRemover.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btRemover.Location = new Point(656, 131);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(118, 65);
            btRemover.TabIndex = 3;
            btRemover.Text = "Remover Animal";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btAlterar
            // 
            btAlterar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterar.Location = new Point(656, 215);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(118, 65);
            btAlterar.TabIndex = 4;
            btAlterar.Text = "Alterar Registo";
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click;
            // 
            // btVoltar
            // 
            btVoltar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltar.Location = new Point(656, 298);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(118, 65);
            btVoltar.TabIndex = 5;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // btVoltarRemover
            // 
            btVoltarRemover.Enabled = false;
            btVoltarRemover.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltarRemover.Location = new Point(655, 298);
            btVoltarRemover.Name = "btVoltarRemover";
            btVoltarRemover.Size = new Size(118, 65);
            btVoltarRemover.TabIndex = 9;
            btVoltarRemover.Text = "Voltar";
            btVoltarRemover.UseVisualStyleBackColor = true;
            btVoltarRemover.Visible = false;
            btVoltarRemover.Click += btVoltarRemover_Click;
            // 
            // btConfirmar
            // 
            btConfirmar.Enabled = false;
            btConfirmar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmar.Location = new Point(655, 215);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(118, 65);
            btConfirmar.TabIndex = 8;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = true;
            btConfirmar.Visible = false;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // btLabel2
            // 
            btLabel2.Enabled = false;
            btLabel2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btLabel2.Location = new Point(655, 131);
            btLabel2.Name = "btLabel2";
            btLabel2.Size = new Size(118, 34);
            btLabel2.TabIndex = 7;
            btLabel2.Text = "ID\r\n                  ";
            btLabel2.UseVisualStyleBackColor = true;
            btLabel2.Visible = false;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(656, 163);
            txtID.Name = "txtID";
            txtID.Size = new Size(117, 23);
            txtID.TabIndex = 10;
            txtID.Visible = false;
            // 
            // btConfirmarAtualizar
            // 
            btConfirmarAtualizar.Enabled = false;
            btConfirmarAtualizar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarAtualizar.Location = new Point(656, 215);
            btConfirmarAtualizar.Name = "btConfirmarAtualizar";
            btConfirmarAtualizar.Size = new Size(118, 65);
            btConfirmarAtualizar.TabIndex = 11;
            btConfirmarAtualizar.Text = "Confirmar";
            btConfirmarAtualizar.UseVisualStyleBackColor = true;
            btConfirmarAtualizar.Visible = false;
            btConfirmarAtualizar.Click += btConfirmarAtualizar_Click;
            // 
            // lblInformacao
            // 
            lblInformacao.BackColor = Color.White;
            lblInformacao.Enabled = false;
            lblInformacao.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformacao.Location = new Point(655, 41);
            lblInformacao.Name = "lblInformacao";
            lblInformacao.Size = new Size(118, 65);
            lblInformacao.TabIndex = 12;
            lblInformacao.Text = "Remover Animal";
            lblInformacao.TextAlign = ContentAlignment.MiddleCenter;
            lblInformacao.Visible = false;
            // 
            // Animal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInformacao);
            Controls.Add(btConfirmarAtualizar);
            Controls.Add(txtID);
            Controls.Add(btVoltarRemover);
            Controls.Add(btConfirmar);
            Controls.Add(btLabel2);
            Controls.Add(btVoltar);
            Controls.Add(btAlterar);
            Controls.Add(btRemover);
            Controls.Add(btAdicionar);
            Controls.Add(label1);
            Controls.Add(dgvAnimais);
            Name = "Animal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animal";
            ((System.ComponentModel.ISupportInitialize)dgvAnimais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAnimais;
        private Label label1;
        private Button btAdicionar;
        private Button btRemover;
        private Button btAlterar;
        private Button btVoltar;
        private Button btVoltarRemover;
        private Button btConfirmar;
        private Button btLabel2;
        private TextBox txtID;
        private Button btConfirmarAtualizar;
        private Label lblInformacao;
    }
}