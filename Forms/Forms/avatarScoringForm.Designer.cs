namespace Forms
{
    partial class frm_score
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_score));
            this.btnExit = new System.Windows.Forms.Button();
            this.rBtnF = new System.Windows.Forms.RadioButton();
            this.rBtnM = new System.Windows.Forms.RadioButton();
            this.rBtnH1 = new System.Windows.Forms.RadioButton();
            this.rBtnH3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listPlatform = new System.Windows.Forms.ComboBox();
            this.imgChange = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ajt_score = new System.Windows.Forms.Button();
            this.tot_scr = new System.Windows.Forms.Label();
            this.valid_score = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lab_score = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rBtnH2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgChange)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Brown;
            this.btnExit.Location = new System.Drawing.Point(742, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rBtnF
            // 
            this.rBtnF.AutoSize = true;
            this.rBtnF.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnF.ForeColor = System.Drawing.Color.White;
            this.rBtnF.Location = new System.Drawing.Point(17, 143);
            this.rBtnF.Name = "rBtnF";
            this.rBtnF.Size = new System.Drawing.Size(95, 26);
            this.rBtnF.TabIndex = 9;
            this.rBtnF.Text = "Féminin";
            this.rBtnF.UseVisualStyleBackColor = true;
            // 
            // rBtnM
            // 
            this.rBtnM.AutoSize = true;
            this.rBtnM.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnM.ForeColor = System.Drawing.Color.White;
            this.rBtnM.Location = new System.Drawing.Point(134, 143);
            this.rBtnM.Name = "rBtnM";
            this.rBtnM.Size = new System.Drawing.Size(101, 26);
            this.rBtnM.TabIndex = 10;
            this.rBtnM.Text = "Masculin";
            this.rBtnM.UseVisualStyleBackColor = true;
            // 
            // rBtnH1
            // 
            this.rBtnH1.AutoSize = true;
            this.rBtnH1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnH1.Location = new System.Drawing.Point(18, 142);
            this.rBtnH1.Name = "rBtnH1";
            this.rBtnH1.Size = new System.Drawing.Size(124, 26);
            this.rBtnH1.TabIndex = 7;
            this.rBtnH1.Text = "1- 6 heures";
            this.rBtnH1.UseVisualStyleBackColor = true;
            // 
            // rBtnH3
            // 
            this.rBtnH3.AutoSize = true;
            this.rBtnH3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnH3.Location = new System.Drawing.Point(18, 174);
            this.rBtnH3.Name = "rBtnH3";
            this.rBtnH3.Size = new System.Drawing.Size(155, 26);
            this.rBtnH3.TabIndex = 8;
            this.rBtnH3.Text = "12 heures et + ";
            this.rBtnH3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Temps de jeu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Plateforme(s) : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPseudo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rBtnM);
            this.panel1.Controls.Add(this.rBtnF);
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(231, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 205);
            this.panel1.TabIndex = 16;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(107, 98);
            this.txtAge.MaxLength = 2;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(135, 29);
            this.txtAge.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Age :";
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(109, 51);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(135, 29);
            this.txtPseudo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pseudo : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Joueur";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.rBtnH2);
            this.panel2.Controls.Add(this.listPlatform);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rBtnH3);
            this.panel2.Controls.Add(this.rBtnH1);
            this.panel2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(493, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 205);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listPlatform
            // 
            this.listPlatform.FormattingEnabled = true;
            this.listPlatform.Items.AddRange(new object[] {
            "Ordinateur",
            "Nintendo Switch",
            "Playstation 5",
            "Playstation 4",
            "Xbox serie S",
            "Xbox One",
            "Xbox 360"});
            this.listPlatform.Location = new System.Drawing.Point(61, 53);
            this.listPlatform.Name = "listPlatform";
            this.listPlatform.Size = new System.Drawing.Size(203, 30);
            this.listPlatform.TabIndex = 16;
            this.listPlatform.SelectedIndexChanged += new System.EventHandler(this.list_plat_SelectedIndexChanged);
            // 
            // imgChange
            // 
            this.imgChange.BackColor = System.Drawing.Color.Transparent;
            this.imgChange.Location = new System.Drawing.Point(534, 343);
            this.imgChange.Name = "imgChange";
            this.imgChange.Size = new System.Drawing.Size(258, 144);
            this.imgChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgChange.TabIndex = 18;
            this.imgChange.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.ajt_score);
            this.panel3.Controls.Add(this.tot_scr);
            this.panel3.Controls.Add(this.valid_score);
            this.panel3.Controls.Add(this.txtScore);
            this.panel3.Controls.Add(this.lab_score);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(222, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 171);
            this.panel3.TabIndex = 20;
            this.panel3.Visible = false;
            // 
            // ajt_score
            // 
            this.ajt_score.BackColor = System.Drawing.Color.Transparent;
            this.ajt_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajt_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajt_score.ForeColor = System.Drawing.Color.Green;
            this.ajt_score.Location = new System.Drawing.Point(193, 32);
            this.ajt_score.Name = "ajt_score";
            this.ajt_score.Size = new System.Drawing.Size(100, 32);
            this.ajt_score.TabIndex = 23;
            this.ajt_score.Text = "Ajouter";
            this.ajt_score.UseVisualStyleBackColor = false;
            this.ajt_score.Click += new System.EventHandler(this.button1_Click);
            // 
            // tot_scr
            // 
            this.tot_scr.AutoSize = true;
            this.tot_scr.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_scr.ForeColor = System.Drawing.Color.White;
            this.tot_scr.Location = new System.Drawing.Point(6, 85);
            this.tot_scr.Name = "tot_scr";
            this.tot_scr.Size = new System.Drawing.Size(135, 17);
            this.tot_scr.TabIndex = 22;
            this.tot_scr.Text = "Totale des scores : ";
            this.tot_scr.Visible = false;
            // 
            // valid_score
            // 
            this.valid_score.BackColor = System.Drawing.Color.Transparent;
            this.valid_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valid_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid_score.ForeColor = System.Drawing.Color.Green;
            this.valid_score.Location = new System.Drawing.Point(63, 116);
            this.valid_score.Name = "valid_score";
            this.valid_score.Size = new System.Drawing.Size(181, 33);
            this.valid_score.TabIndex = 21;
            this.valid_score.Text = "Calcul score";
            this.valid_score.UseVisualStyleBackColor = false;
            this.valid_score.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(193, 6);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 19;
            this.txtScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // lab_score
            // 
            this.lab_score.AutoSize = true;
            this.lab_score.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_score.ForeColor = System.Drawing.Color.White;
            this.lab_score.Location = new System.Drawing.Point(89, 7);
            this.lab_score.Name = "lab_score";
            this.lab_score.Size = new System.Drawing.Size(74, 17);
            this.lab_score.TabIndex = 18;
            this.lab_score.Text = "SCORE : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Scoring : ";
            // 
            // rBtnH2
            // 
            this.rBtnH2.AutoSize = true;
            this.rBtnH2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnH2.Location = new System.Drawing.Point(182, 154);
            this.rBtnH2.Name = "rBtnH2";
            this.rBtnH2.Size = new System.Drawing.Size(129, 26);
            this.rBtnH2.TabIndex = 17;
            this.rBtnH2.Text = "7-11 heures";
            this.rBtnH2.UseVisualStyleBackColor = true;
            // 
            // frm_score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 945);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.imgChange);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Score";
            this.Load += new System.EventHandler(this.frm_score_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgChange)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rBtnF;
        private System.Windows.Forms.RadioButton rBtnM;
        private System.Windows.Forms.RadioButton rBtnH1;
        private System.Windows.Forms.RadioButton rBtnH3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox listPlatform;
		private System.Windows.Forms.PictureBox imgChange;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lab_score;
		private System.Windows.Forms.Button valid_score;
		private System.Windows.Forms.TextBox txtScore;
		private System.Windows.Forms.Label tot_scr;
		private System.Windows.Forms.Button ajt_score;
        private System.Windows.Forms.RadioButton rBtnH2;
    }
}