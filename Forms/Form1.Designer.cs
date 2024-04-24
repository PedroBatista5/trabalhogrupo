namespace trabalhogrupo
{
    partial class MenuInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_animal = new Button();
            bt_consulta = new Button();
            SuspendLayout();
            // 
            // bt_animal
            // 
            bt_animal.FlatAppearance.BorderColor = SystemColors.Highlight;
            bt_animal.FlatAppearance.BorderSize = 3;
            bt_animal.FlatStyle = FlatStyle.Flat;
            bt_animal.Location = new Point(336, 90);
            bt_animal.Name = "bt_animal";
            bt_animal.Size = new Size(80, 40);
            bt_animal.TabIndex = 0;
            bt_animal.Text = "Animal";
            bt_animal.UseVisualStyleBackColor = true;
            bt_animal.Click += bt_animal_Click;
            // 
            // bt_consulta
            // 
            bt_consulta.FlatAppearance.BorderColor = SystemColors.Highlight;
            bt_consulta.FlatAppearance.BorderSize = 3;
            bt_consulta.FlatStyle = FlatStyle.Flat;
            bt_consulta.Location = new Point(336, 273);
            bt_consulta.Name = "bt_consulta";
            bt_consulta.Size = new Size(80, 40);
            bt_consulta.TabIndex = 1;
            bt_consulta.Text = "Consulta";
            bt_consulta.UseVisualStyleBackColor = true;
            bt_consulta.Click += bt_consulta_Click;
            // 
            // MenuInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_consulta);
            Controls.Add(bt_animal);
            Name = "MenuInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Inicial";
            ResumeLayout(false);
        }

        #endregion

        private Button bt_animal;
        private Button bt_consulta;
    }
}