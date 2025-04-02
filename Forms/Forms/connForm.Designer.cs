using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace Forms
{
    partial class connForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.erreurs = new System.Windows.Forms.Label();
            this.panelConn = new System.Windows.Forms.Panel();
            this.cBoxMDP = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMenuInscr = new System.Windows.Forms.Button();
            this.btnMenuConn = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelInscr = new System.Windows.Forms.Panel();
            this.comboDroit = new System.Windows.Forms.ComboBox();
            this.labDroit = new System.Windows.Forms.Label();
            this.labConf = new System.Windows.Forms.Label();
            this.txtConf = new System.Windows.Forms.TextBox();
            this.btnInscr1 = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.labIdd = new System.Windows.Forms.Label();
            this.labPwd = new System.Windows.Forms.Label();
            this.txtIdd = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.panelConn.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelInscr.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(42, 96);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(175, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(42, 215);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(175, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // btnConn
            // 
            this.btnConn.BackColor = System.Drawing.Color.Transparent;
            this.btnConn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConn.FlatAppearance.BorderSize = 3;
            this.btnConn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConn.ForeColor = System.Drawing.Color.White;
            this.btnConn.Location = new System.Drawing.Point(65, 270);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(135, 41);
            this.btnConn.TabIndex = 4;
            this.btnConn.Text = "connexion";
            this.btnConn.UseVisualStyleBackColor = false;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Brown;
            this.btnExit.Location = new System.Drawing.Point(694, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // erreurs
            // 
            this.erreurs.AutoSize = true;
            this.erreurs.BackColor = System.Drawing.Color.Transparent;
            this.erreurs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreurs.ForeColor = System.Drawing.Color.Yellow;
            this.erreurs.Location = new System.Drawing.Point(252, 455);
            this.erreurs.Name = "erreurs";
            this.erreurs.Size = new System.Drawing.Size(402, 19);
            this.erreurs.TabIndex = 6;
            this.erreurs.Text = "Erreur : Login ou Mot de passe incorrect, réessayer.";
            // 
            // panelConn
            // 
            this.panelConn.BackColor = System.Drawing.Color.Transparent;
            this.panelConn.Controls.Add(this.cBoxMDP);
            this.panelConn.Controls.Add(this.btnConn);
            this.panelConn.Controls.Add(this.btnBack);
            this.panelConn.Controls.Add(this.label1);
            this.panelConn.Controls.Add(this.label2);
            this.panelConn.Controls.Add(this.txtLogin);
            this.panelConn.Controls.Add(this.txtPassword);
            this.panelConn.Location = new System.Drawing.Point(12, 66);
            this.panelConn.Name = "panelConn";
            this.panelConn.Size = new System.Drawing.Size(248, 352);
            this.panelConn.TabIndex = 7;
            // 
            // cBoxMDP
            // 
            this.cBoxMDP.AutoSize = true;
            this.cBoxMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMDP.ForeColor = System.Drawing.Color.White;
            this.cBoxMDP.Location = new System.Drawing.Point(42, 244);
            this.cBoxMDP.Name = "cBoxMDP";
            this.cBoxMDP.Size = new System.Drawing.Size(193, 20);
            this.cBoxMDP.TabIndex = 7;
            this.cBoxMDP.Text = "afficher le mot de passe";
            this.cBoxMDP.UseVisualStyleBackColor = true;
            this.cBoxMDP.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(78, 308);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 41);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMenuInscr
            // 
            this.btnMenuInscr.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuInscr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuInscr.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMenuInscr.FlatAppearance.BorderSize = 3;
            this.btnMenuInscr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuInscr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuInscr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInscr.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuInscr.ForeColor = System.Drawing.Color.White;
            this.btnMenuInscr.Location = new System.Drawing.Point(52, 117);
            this.btnMenuInscr.Name = "btnMenuInscr";
            this.btnMenuInscr.Size = new System.Drawing.Size(158, 41);
            this.btnMenuInscr.TabIndex = 5;
            this.btnMenuInscr.Text = "S\'inscrire";
            this.btnMenuInscr.UseVisualStyleBackColor = false;
            this.btnMenuInscr.Click += new System.EventHandler(this.btnMenuInscr_Click);
            // 
            // btnMenuConn
            // 
            this.btnMenuConn.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuConn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuConn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMenuConn.FlatAppearance.BorderSize = 3;
            this.btnMenuConn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuConn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuConn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuConn.ForeColor = System.Drawing.Color.White;
            this.btnMenuConn.Location = new System.Drawing.Point(52, 27);
            this.btnMenuConn.Name = "btnMenuConn";
            this.btnMenuConn.Size = new System.Drawing.Size(158, 41);
            this.btnMenuConn.TabIndex = 5;
            this.btnMenuConn.Text = "Se connecter";
            this.btnMenuConn.UseVisualStyleBackColor = false;
            this.btnMenuConn.Click += new System.EventHandler(this.btnMenuConn_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.btnMenuConn);
            this.panelMenu.Controls.Add(this.btnMenuInscr);
            this.panelMenu.Location = new System.Drawing.Point(326, 150);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(248, 186);
            this.panelMenu.TabIndex = 8;
            // 
            // panelInscr
            // 
            this.panelInscr.BackColor = System.Drawing.Color.Transparent;
            this.panelInscr.Controls.Add(this.comboDroit);
            this.panelInscr.Controls.Add(this.labDroit);
            this.panelInscr.Controls.Add(this.labConf);
            this.panelInscr.Controls.Add(this.txtConf);
            this.panelInscr.Controls.Add(this.btnInscr1);
            this.panelInscr.Controls.Add(this.btnBack1);
            this.panelInscr.Controls.Add(this.labIdd);
            this.panelInscr.Controls.Add(this.labPwd);
            this.panelInscr.Controls.Add(this.txtIdd);
            this.panelInscr.Controls.Add(this.txtPwd);
            this.panelInscr.Location = new System.Drawing.Point(624, 20);
            this.panelInscr.Name = "panelInscr";
            this.panelInscr.Size = new System.Drawing.Size(248, 418);
            this.panelInscr.TabIndex = 8;
            // 
            // comboDroit
            // 
            this.comboDroit.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3"});
            this.comboDroit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboDroit.FormattingEnabled = true;
            this.comboDroit.Items.AddRange(new object[] {
            ""});
            this.comboDroit.Location = new System.Drawing.Point(42, 279);
            this.comboDroit.Name = "comboDroit";
            this.comboDroit.Size = new System.Drawing.Size(175, 21);
            this.comboDroit.TabIndex = 10;
            // 
            // labDroit
            // 
            this.labDroit.AutoSize = true;
            this.labDroit.BackColor = System.Drawing.Color.Transparent;
            this.labDroit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDroit.ForeColor = System.Drawing.Color.White;
            this.labDroit.Location = new System.Drawing.Point(85, 247);
            this.labDroit.Name = "labDroit";
            this.labDroit.Size = new System.Drawing.Size(83, 29);
            this.labDroit.TabIndex = 9;
            this.labDroit.Text = "Droit :";
            // 
            // labConf
            // 
            this.labConf.AutoSize = true;
            this.labConf.BackColor = System.Drawing.Color.Transparent;
            this.labConf.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConf.ForeColor = System.Drawing.Color.White;
            this.labConf.Location = new System.Drawing.Point(57, 180);
            this.labConf.Name = "labConf";
            this.labConf.Size = new System.Drawing.Size(148, 29);
            this.labConf.TabIndex = 7;
            this.labConf.Text = "Confirmer  :";
            // 
            // txtConf
            // 
            this.txtConf.Location = new System.Drawing.Point(42, 212);
            this.txtConf.Name = "txtConf";
            this.txtConf.PasswordChar = '*';
            this.txtConf.Size = new System.Drawing.Size(175, 20);
            this.txtConf.TabIndex = 8;
            // 
            // btnInscr1
            // 
            this.btnInscr1.BackColor = System.Drawing.Color.Transparent;
            this.btnInscr1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscr1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInscr1.FlatAppearance.BorderSize = 3;
            this.btnInscr1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInscr1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInscr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscr1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscr1.ForeColor = System.Drawing.Color.White;
            this.btnInscr1.Location = new System.Drawing.Point(65, 330);
            this.btnInscr1.Name = "btnInscr1";
            this.btnInscr1.Size = new System.Drawing.Size(135, 41);
            this.btnInscr1.TabIndex = 4;
            this.btnInscr1.Text = "Inscription";
            this.btnInscr1.UseVisualStyleBackColor = false;
            this.btnInscr1.Click += new System.EventHandler(this.btnInscri1_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.BackColor = System.Drawing.Color.Transparent;
            this.btnBack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnBack1.FlatAppearance.BorderSize = 3;
            this.btnBack1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack1.Location = new System.Drawing.Point(78, 368);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(108, 41);
            this.btnBack1.TabIndex = 6;
            this.btnBack1.Text = "Retour";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // labIdd
            // 
            this.labIdd.AutoSize = true;
            this.labIdd.BackColor = System.Drawing.Color.Transparent;
            this.labIdd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIdd.ForeColor = System.Drawing.Color.White;
            this.labIdd.Location = new System.Drawing.Point(57, 17);
            this.labIdd.Name = "labIdd";
            this.labIdd.Size = new System.Drawing.Size(143, 29);
            this.labIdd.TabIndex = 0;
            this.labIdd.Text = "Identifiant :";
            // 
            // labPwd
            // 
            this.labPwd.AutoSize = true;
            this.labPwd.BackColor = System.Drawing.Color.Transparent;
            this.labPwd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPwd.ForeColor = System.Drawing.Color.White;
            this.labPwd.Location = new System.Drawing.Point(37, 98);
            this.labPwd.Name = "labPwd";
            this.labPwd.Size = new System.Drawing.Size(180, 29);
            this.labPwd.TabIndex = 1;
            this.labPwd.Text = "Mot de passe :";
            // 
            // txtIdd
            // 
            this.txtIdd.Location = new System.Drawing.Point(42, 49);
            this.txtIdd.Name = "txtIdd";
            this.txtIdd.Size = new System.Drawing.Size(175, 20);
            this.txtIdd.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(42, 136);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(175, 20);
            this.txtPwd.TabIndex = 3;
            // 
            // connForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelInscr);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelConn);
            this.Controls.Add(this.erreurs);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "connForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenêtre de connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelConn.ResumeLayout(false);
            this.panelConn.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelInscr.ResumeLayout(false);
            this.panelInscr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnExit;
        private Label erreurs;
		private Panel panelConn;
        private Button btnMenuInscr;
        private Button btnMenuConn;
        private Panel panelMenu;
        private Button btnBack;
        private Panel panelInscr;
        private Label labConf;
        private TextBox txtConf;
        private Button btnInscr1;
        private Button btnBack1;
        private Label labIdd;
        private Label labPwd;
        private TextBox txtIdd;
        private TextBox txtPwd;
        private Label labDroit;
        private ComboBox comboDroit;
        private CheckBox cBoxMDP;
    }
}

