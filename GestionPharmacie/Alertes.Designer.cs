namespace GestionPharmacie
{
    partial class Alertes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            medicament = new Guna.UI2.WinForms.Guna2Button();
            Pharmacie = new Label();
            button2 = new Button();
            gridview = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(medicament);
            panel1.Controls.Add(Pharmacie);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 598);
            panel1.TabIndex = 1;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 7;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.ActiveCaption;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(12, 201);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(133, 45);
            guna2Button1.TabIndex = 10;
            guna2Button1.Text = "Alertes";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // medicament
            // 
            medicament.BorderRadius = 7;
            medicament.CustomizableEdges = customizableEdges7;
            medicament.DisabledState.BorderColor = Color.DarkGray;
            medicament.DisabledState.CustomBorderColor = Color.DarkGray;
            medicament.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            medicament.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            medicament.FillColor = SystemColors.ActiveCaption;
            medicament.Font = new Font("Segoe UI", 9F);
            medicament.ForeColor = Color.White;
            medicament.Location = new Point(12, 126);
            medicament.Name = "medicament";
            medicament.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
            // gridview
            // 
            gridview.BackgroundColor = Color.White;
            gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridview.Location = new Point(173, 10);
            gridview.Name = "gridview";
            gridview.RowHeadersWidth = 51;
            gridview.Size = new Size(949, 576);
            gridview.TabIndex = 2;
            gridview.CellContentClick += gridview_CellContentClick;
            // 
            // Alertes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 598);
            Controls.Add(gridview);
            Controls.Add(panel1);
            Name = "Alertes";
            Text = "Alertes";
            Load += Alertes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button medicament;
        private Label Pharmacie;
        private Button button2;
        private DataGridView gridview;
    }
}