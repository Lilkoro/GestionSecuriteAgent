namespace Forms
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuDeroulant = new System.Windows.Forms.MenuStrip();
            this.joueursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrementCompetiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeroulant.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuDeroulant
            // 
            this.menuDeroulant.BackColor = System.Drawing.Color.MediumPurple;
            this.menuDeroulant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuDeroulant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDeroulant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joueursToolStripMenuItem,
            this.paramètresToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuDeroulant.Location = new System.Drawing.Point(0, 0);
            this.menuDeroulant.Name = "menuDeroulant";
            this.menuDeroulant.Size = new System.Drawing.Size(979, 26);
            this.menuDeroulant.TabIndex = 0;
            this.menuDeroulant.Text = "menuStrip1";
            // 
            // joueursToolStripMenuItem
            // 
            this.joueursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreToolStripMenuItem,
            this.enregistrementCompetiteurToolStripMenuItem});
            this.joueursToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.joueursToolStripMenuItem.Name = "joueursToolStripMenuItem";
            this.joueursToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.joueursToolStripMenuItem.Text = "Joueurs";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.scoreToolStripMenuItem.Text = "Score";
            this.scoreToolStripMenuItem.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
            // 
            // enregistrementCompetiteurToolStripMenuItem
            // 
            this.enregistrementCompetiteurToolStripMenuItem.Name = "enregistrementCompetiteurToolStripMenuItem";
            this.enregistrementCompetiteurToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.enregistrementCompetiteurToolStripMenuItem.Text = "Enregistrement competiteur";
            this.enregistrementCompetiteurToolStripMenuItem.Click += new System.EventHandler(this.enregistrementCompetiteurToolStripMenuItem_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.gestionPersonnelToolStripMenuItem});
            this.paramètresToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // gestionPersonnelToolStripMenuItem
            // 
            this.gestionPersonnelToolStripMenuItem.Name = "gestionPersonnelToolStripMenuItem";
            this.gestionPersonnelToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gestionPersonnelToolStripMenuItem.Text = "Gestion Personnel";
            this.gestionPersonnelToolStripMenuItem.Click += new System.EventHandler(this.gestionPersonnelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(29, 22);
            this.toolStripMenuItem1.Text = "?";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 416);
            this.Controls.Add(this.menuDeroulant);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuDeroulant;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTION DE JEUX";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuDeroulant.ResumeLayout(false);
            this.menuDeroulant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem joueursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuDeroulant;
        private System.Windows.Forms.ToolStripMenuItem enregistrementCompetiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPersonnelToolStripMenuItem;
    }
}