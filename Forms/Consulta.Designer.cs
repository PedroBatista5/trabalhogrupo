namespace trabalhogrupo.Forms
{
    partial class Consulta
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
            dataGridView1 = new DataGridView();
            bt_adicionar = new Button();
            bt_editar = new Button();
            bt_remover = new Button();
            bt_voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(646, 263);
            dataGridView1.TabIndex = 0;
            // 
            // bt_adicionar
            // 
            bt_adicionar.FlatAppearance.BorderColor = SystemColors.Highlight;
            bt_adicionar.FlatAppearance.BorderSize = 3;
            bt_adicionar.FlatStyle = FlatStyle.Flat;
            bt_adicionar.Location = new Point(690, 46);
            bt_adicionar.Name = "bt_adicionar";
            bt_adicionar.Size = new Size(80, 40);
            bt_adicionar.TabIndex = 1;
            bt_adicionar.Text = "Adicionar";
            bt_adicionar.UseVisualStyleBackColor = true;
            bt_adicionar.Click += bt_adicionar_Click;
            // 
            // bt_editar
            // 
            bt_editar.FlatAppearance.BorderColor = SystemColors.Highlight;
            bt_editar.FlatAppearance.BorderSize = 3;
            bt_editar.FlatStyle = FlatStyle.Flat;
            bt_editar.Location = new Point(690, 169);
            bt_editar.Name = "bt_editar";
            bt_editar.Size = new Size(80, 40);
            bt_editar.TabIndex = 2;
            bt_editar.Text = "Editar";
            bt_editar.UseVisualStyleBackColor = true;
            bt_editar.Click += bt_editar_Click;
            // 
            // bt_remover
            // 
            bt_remover.FlatAppearance.BorderColor = SystemColors.Highlight;
            bt_remover.FlatAppearance.BorderSize = 3;
            bt_remover.FlatStyle = FlatStyle.Flat;
            bt_remover.Location = new Point(690, 106);
            bt_remover.Name = "bt_remover";
            bt_remover.Size = new Size(80, 40);
            bt_remover.TabIndex = 3;
            bt_remover.Text = "Remover";
            bt_remover.UseVisualStyleBackColor = true;
            bt_remover.Click += bt_remover_Click;
            // 
            // bt_voltar
            // 
            bt_voltar.FlatAppearance.BorderColor = SystemColors.Highlight;
            bt_voltar.FlatAppearance.BorderSize = 3;
            bt_voltar.FlatStyle = FlatStyle.Flat;
            bt_voltar.Location = new Point(690, 237);
            bt_voltar.Name = "bt_voltar";
            bt_voltar.Size = new Size(80, 40);
            bt_voltar.TabIndex = 4;
            bt_voltar.Text = "Voltar";
            bt_voltar.UseVisualStyleBackColor = true;
            bt_voltar.Click += bt_voltar_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_voltar);
            Controls.Add(bt_remover);
            Controls.Add(bt_editar);
            Controls.Add(bt_adicionar);
            Controls.Add(dataGridView1);
            Name = "Consulta";
            Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button bt_adicionar;
        private Button bt_editar;
        private Button bt_remover;
        private Button bt_voltar;
    }
}