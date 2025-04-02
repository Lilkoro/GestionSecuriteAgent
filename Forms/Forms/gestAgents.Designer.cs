namespace Forms
{
    partial class gestAgents
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
            this.comboAgent = new System.Windows.Forms.ComboBox();
            this.txtAgent = new System.Windows.Forms.Label();
            this.btnVal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labSelAgent = new System.Windows.Forms.Label();
            this.labSelLog = new System.Windows.Forms.Label();
            this.labSelMdp = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cBoxMDP = new System.Windows.Forms.CheckBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboAgent
            // 
            this.comboAgent.FormattingEnabled = true;
            this.comboAgent.Location = new System.Drawing.Point(63, 70);
            this.comboAgent.Name = "comboAgent";
            this.comboAgent.Size = new System.Drawing.Size(121, 21);
            this.comboAgent.TabIndex = 0;
            // 
            // txtAgent
            // 
            this.txtAgent.AutoSize = true;
            this.txtAgent.Location = new System.Drawing.Point(85, 41);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(82, 13);
            this.txtAgent.TabIndex = 1;
            this.txtAgent.Text = "Choix de l\'agent";
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(88, 97);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(75, 23);
            this.btnVal.TabIndex = 2;
            this.btnVal.Text = "Valider";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.cBoxMDP);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Controls.Add(this.labSelMdp);
            this.panel1.Controls.Add(this.labSelLog);
            this.panel1.Controls.Add(this.labSelAgent);
            this.panel1.Location = new System.Drawing.Point(249, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 377);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // labSelAgent
            // 
            this.labSelAgent.AutoSize = true;
            this.labSelAgent.Location = new System.Drawing.Point(212, 29);
            this.labSelAgent.Name = "labSelAgent";
            this.labSelAgent.Size = new System.Drawing.Size(109, 13);
            this.labSelAgent.TabIndex = 0;
            this.labSelAgent.Text = "Selection de l\'agent : ";
            // 
            // labSelLog
            // 
            this.labSelLog.AutoSize = true;
            this.labSelLog.Location = new System.Drawing.Point(49, 81);
            this.labSelLog.Name = "labSelLog";
            this.labSelLog.Size = new System.Drawing.Size(85, 13);
            this.labSelLog.TabIndex = 1;
            this.labSelLog.Text = "Changer Login : ";
            // 
            // labSelMdp
            // 
            this.labSelMdp.AutoSize = true;
            this.labSelMdp.Location = new System.Drawing.Point(11, 138);
            this.labSelMdp.Name = "labSelMdp";
            this.labSelMdp.Size = new System.Drawing.Size(123, 13);
            this.labSelMdp.TabIndex = 2;
            this.labSelMdp.Text = "Changer Mot de passe : ";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(141, 81);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(100, 20);
            this.txtLog.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(140, 138);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 4;
            // 
            // cBoxMDP
            // 
            this.cBoxMDP.AutoSize = true;
            this.cBoxMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMDP.ForeColor = System.Drawing.Color.Black;
            this.cBoxMDP.Location = new System.Drawing.Point(48, 164);
            this.cBoxMDP.Name = "cBoxMDP";
            this.cBoxMDP.Size = new System.Drawing.Size(192, 20);
            this.cBoxMDP.TabIndex = 8;
            this.cBoxMDP.Text = "afficher le mot de passe";
            this.cBoxMDP.UseVisualStyleBackColor = true;
            this.cBoxMDP.CheckedChanged += new System.EventHandler(this.cBoxMDP_CheckedChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(215, 203);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Changer";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // gestAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.txtAgent);
            this.Controls.Add(this.comboAgent);
            this.Name = "gestAgents";
            this.Text = "gestAgents";
            this.Load += new System.EventHandler(this.gestAgents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAgent;
        private System.Windows.Forms.Label txtAgent;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labSelAgent;
        private System.Windows.Forms.Label labSelMdp;
        private System.Windows.Forms.Label labSelLog;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox cBoxMDP;
        private System.Windows.Forms.Button btnChange;
    }
}