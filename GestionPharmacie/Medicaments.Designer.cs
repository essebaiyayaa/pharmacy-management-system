namespace GestionPharmacie
{
    partial class Medicaments
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            alertes = new Guna.UI2.WinForms.Guna2Button();
            medicament = new Guna.UI2.WinForms.Guna2Button();
            Pharmacie = new Label();
            button2 = new Button();
            txtrechercher = new Guna.UI2.WinForms.Guna2TextBox();
            Rechercher = new Guna.UI2.WinForms.Guna2Button();
            ajouterMedicament = new Guna.UI2.WinForms.Guna2Button();
            gridview = new DataGridView();
            Modifier = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridview).BeginInit();
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
            panel1.Size = new Size(165, 714);
            panel1.TabIndex = 1;
            // 
            // alertes
            // 
            alertes.BorderRadius = 7;
            alertes.CustomizableEdges = customizableEdges1;
            alertes.DisabledState.BorderColor = Color.DarkGray;
            alertes.DisabledState.CustomBorderColor = Color.DarkGray;
            alertes.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            alertes.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            alertes.FillColor = SystemColors.ActiveCaption;
            alertes.Font = new Font("Segoe UI", 9F);
            alertes.ForeColor = Color.White;
            alertes.Location = new Point(12, 192);
            alertes.Name = "alertes";
            alertes.ShadowDecoration.CustomizableEdges = customizableEdges2;
            alertes.Size = new Size(133, 45);
            alertes.TabIndex = 9;
            alertes.Text = "Alertes";
            alertes.Click += alertes_Click;
            // 
            // medicament
            // 
            medicament.BorderRadius = 7;
            medicament.CustomizableEdges = customizableEdges3;
            medicament.DisabledState.BorderColor = Color.DarkGray;
            medicament.DisabledState.CustomBorderColor = Color.DarkGray;
            medicament.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            medicament.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            medicament.FillColor = SystemColors.ActiveCaption;
            medicament.Font = new Font("Segoe UI", 9F);
            medicament.ForeColor = Color.White;
            medicament.Location = new Point(12, 114);
            medicament.Name = "medicament";
            medicament.ShadowDecoration.CustomizableEdges = customizableEdges4;
            medicament.Size = new Size(133, 45);
            medicament.TabIndex = 8;
            medicament.Text = "Médicaments";
            medicament.Click += medicament_Click;
            // 
            // Pharmacie
            // 
            Pharmacie.AutoSize = true;
            Pharmacie.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Pharmacie.ForeColor = Color.White;
            Pharmacie.Location = new Point(18, 17);
            Pharmacie.Name = "Pharmacie";
            Pharmacie.Size = new Size(133, 32);
            Pharmacie.TabIndex = 3;
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
            // txtrechercher
            // 
            txtrechercher.BorderRadius = 7;
            txtrechercher.CustomizableEdges = customizableEdges5;
            txtrechercher.DefaultText = "";
            txtrechercher.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtrechercher.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtrechercher.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtrechercher.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtrechercher.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtrechercher.Font = new Font("Segoe UI", 9F);
            txtrechercher.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtrechercher.Location = new Point(203, 20);
            txtrechercher.Margin = new Padding(3, 4, 3, 4);
            txtrechercher.Name = "txtrechercher";
            txtrechercher.PlaceholderText = "Rechercher par référence, nom...";
            txtrechercher.SelectedText = "";
            txtrechercher.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtrechercher.Size = new Size(506, 40);
            txtrechercher.TabIndex = 6;
            txtrechercher.TextChanged += txtrechercher_TextChanged;
            // 
            // Rechercher
            // 
            Rechercher.BorderRadius = 7;
            Rechercher.CustomizableEdges = customizableEdges7;
            Rechercher.DisabledState.BorderColor = Color.DarkGray;
            Rechercher.DisabledState.CustomBorderColor = Color.DarkGray;
            Rechercher.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Rechercher.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Rechercher.FillColor = SystemColors.ActiveCaption;
            Rechercher.Font = new Font("Segoe UI", 9F);
            Rechercher.ForeColor = Color.White;
            Rechercher.Location = new Point(774, 20);
            Rechercher.Name = "Rechercher";
            Rechercher.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Rechercher.Size = new Size(162, 40);
            Rechercher.TabIndex = 7;
            Rechercher.Text = "Rechercher";
            Rechercher.Click += Rechercher_Click;
            // 
            // ajouterMedicament
            // 
            ajouterMedicament.BorderRadius = 7;
            ajouterMedicament.CustomizableEdges = customizableEdges9;
            ajouterMedicament.DisabledState.BorderColor = Color.DarkGray;
            ajouterMedicament.DisabledState.CustomBorderColor = Color.DarkGray;
            ajouterMedicament.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ajouterMedicament.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ajouterMedicament.FillColor = SystemColors.ActiveCaption;
            ajouterMedicament.Font = new Font("Segoe UI", 9F);
            ajouterMedicament.ForeColor = Color.White;
            ajouterMedicament.Location = new Point(998, 20);
            ajouterMedicament.Name = "ajouterMedicament";
            ajouterMedicament.ShadowDecoration.CustomizableEdges = customizableEdges10;
            ajouterMedicament.Size = new Size(266, 40);
            ajouterMedicament.TabIndex = 8;
            ajouterMedicament.Text = "+ Ajouter un médicament";
            ajouterMedicament.Click += ajouterMedicament_Click;
            // 
            // gridview
            // 
            gridview.BackgroundColor = Color.White;
            gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridview.Columns.AddRange(new DataGridViewColumn[] { Modifier });
            gridview.Location = new Point(203, 83);
            gridview.Name = "gridview";
            gridview.RowHeadersWidth = 51;
            gridview.Size = new Size(1061, 604);
            gridview.TabIndex = 9;
            gridview.CellContentClick += gridview_CellContentClick;
            // 
            // Modifier
            // 
            Modifier.HeaderText = "Modifier";
            Modifier.MinimumWidth = 6;
            Modifier.Name = "Modifier";
            Modifier.Resizable = DataGridViewTriState.True;
            Modifier.SortMode = DataGridViewColumnSortMode.Automatic;
            Modifier.UseColumnTextForButtonValue = true;
            Modifier.Width = 125;
            // 
            // Medicaments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 714);
            Controls.Add(gridview);
            Controls.Add(ajouterMedicament);
            Controls.Add(Rechercher);
            Controls.Add(txtrechercher);
            Controls.Add(panel1);
            Name = "Medicaments";
            Text = "Medicaments";
            Load += Medicaments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Pharmacie;
        private Button Alertes;
        private Button button2;
        private Button Médicaments;
        private Guna.UI2.WinForms.Guna2TextBox txtrechercher;
        private Guna.UI2.WinForms.Guna2Button Rechercher;
        private Guna.UI2.WinForms.Guna2Button ajouterMedicament;
        private Guna.UI2.WinForms.Guna2Button alertes;
        private Guna.UI2.WinForms.Guna2Button medicament;
        private DataGridView gridview;
        private DataGridViewButtonColumn Modifier;
    }
}