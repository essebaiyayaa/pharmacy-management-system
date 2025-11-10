namespace GestionPharmacie
{
    partial class Form1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            alertes = new Guna.UI2.WinForms.Guna2Button();
            medicament = new Guna.UI2.WinForms.Guna2Button();
            Pharmacie = new Label();
            button2 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(alertes);
            panel1.Controls.Add(medicament);
            panel1.Controls.Add(Pharmacie);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 593);
            panel1.TabIndex = 0;
            // 
            // alertes
            // 
            alertes.BorderRadius = 7;
            alertes.CustomizableEdges = customizableEdges9;
            alertes.DisabledState.BorderColor = Color.DarkGray;
            alertes.DisabledState.CustomBorderColor = Color.DarkGray;
            alertes.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            alertes.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            alertes.FillColor = SystemColors.ActiveCaption;
            alertes.Font = new Font("Segoe UI", 9F);
            alertes.ForeColor = Color.White;
            alertes.Location = new Point(12, 201);
            alertes.Name = "alertes";
            alertes.ShadowDecoration.CustomizableEdges = customizableEdges10;
            alertes.Size = new Size(133, 45);
            alertes.TabIndex = 10;
            alertes.Text = "Alertes";
            alertes.Click += alertes_Click;
            // 
            // medicament
            // 
            medicament.BorderRadius = 7;
            medicament.CustomizableEdges = customizableEdges11;
            medicament.DisabledState.BorderColor = Color.DarkGray;
            medicament.DisabledState.CustomBorderColor = Color.DarkGray;
            medicament.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            medicament.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            medicament.FillColor = SystemColors.ActiveCaption;
            medicament.Font = new Font("Segoe UI", 9F);
            medicament.ForeColor = Color.White;
            medicament.Location = new Point(12, 126);
            medicament.Name = "medicament";
            medicament.ShadowDecoration.CustomizableEdges = customizableEdges12;
            medicament.Size = new Size(133, 45);
            medicament.TabIndex = 9;
            medicament.Text = "Médicaments";
            medicament.Click += medicament_Click;
            // 
            // Pharmacie
            // 
            Pharmacie.AutoSize = true;
            Pharmacie.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Pharmacie.ForeColor = Color.White;
            Pharmacie.Location = new Point(12, 21);
            Pharmacie.Name = "Pharmacie";
            Pharmacie.Size = new Size(133, 32);
            Pharmacie.TabIndex = 4;
            Pharmacie.Text = "Pharmacie";
            // 
            // button2
            // 
            button2.Location = new Point(12, 192);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(347, 130);
            label1.Name = "label1";
            label1.Size = new Size(754, 41);
            label1.TabIndex = 1;
            label1.Text = "Bienvenue dans le système de gestion de pharmacie.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(462, 234);
            label3.Name = "label3";
            label3.Size = new Size(486, 30);
            label3.TabIndex = 3;
            label3.Text = "vos médicaments, surveiller les stocks et recevoir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(418, 192);
            label2.Name = "label2";
            label2.Size = new Size(590, 30);
            label2.TabIndex = 2;
            label2.Text = "Depuis ce tableau de bord, vous pouvez gérer efficacement";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(549, 273);
            label4.Name = "label4";
            label4.Size = new Size(300, 30);
            label4.TabIndex = 4;
            label4.Text = "des alertes avant péremption.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 593);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label Pharmacie;
        private Guna.UI2.WinForms.Guna2Button medicament;
        private Guna.UI2.WinForms.Guna2Button alertes;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}
