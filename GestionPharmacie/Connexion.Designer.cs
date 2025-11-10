namespace GestionPharmacie
{
    partial class Connexion
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            connecter = new Button();
            messageErreur = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label1.Location = new Point(395, 50);
            label1.Name = "label1";
            label1.Size = new Size(328, 47);
            label1.TabIndex = 0;
            label1.Text = "Gestion Pharmacie";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(425, 109);
            label2.Name = "label2";
            label2.Size = new Size(254, 23);
            label2.TabIndex = 1;
            label2.Text = "Connectez-vous à votre compte";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(395, 172);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(395, 238);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 3;
            label4.Text = "Mot de passe";
            label4.Click += label4_Click;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 10F);
            txtemail.Location = new Point(542, 165);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(181, 30);
            txtemail.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(542, 237);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(181, 27);
            txtpassword.TabIndex = 5;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // connecter
            // 
            connecter.BackColor = SystemColors.GradientActiveCaption;
            connecter.Location = new Point(468, 303);
            connecter.Name = "connecter";
            connecter.Size = new Size(171, 49);
            connecter.TabIndex = 6;
            connecter.Text = "Se connecter";
            connecter.UseVisualStyleBackColor = false;
            connecter.Click += connecter_Click;
            // 
            // messageErreur
            // 
            messageErreur.AutoSize = true;
            messageErreur.ForeColor = Color.Red;
            messageErreur.Location = new Point(357, 354);
            messageErreur.Name = "messageErreur";
            messageErreur.Size = new Size(0, 20);
            messageErreur.TabIndex = 7;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 506);
            Controls.Add(messageErreur);
            Controls.Add(connecter);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Connexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtemail;
        private TextBox txtpassword;
        private Button connecter;
        private Label messageErreur;
    }
}