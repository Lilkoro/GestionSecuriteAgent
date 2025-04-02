namespace Forms
{
    partial class gestPerso
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
            this.radEns = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBNom = new System.Windows.Forms.TextBox();
            this.btnVal = new System.Windows.Forms.Button();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.txtBPre = new System.Windows.Forms.TextBox();
            this.labPre = new System.Windows.Forms.Label();
            this.txtBHeure = new System.Windows.Forms.TextBox();
            this.labHeure = new System.Windows.Forms.Label();
            this.txtBService = new System.Windows.Forms.TextBox();
            this.labSer = new System.Windows.Forms.Label();
            this.listBPerso = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // radEns
            // 
            this.radEns.AutoSize = true;
            this.radEns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEns.Location = new System.Drawing.Point(119, 66);
            this.radEns.Name = "radEns";
            this.radEns.Size = new System.Drawing.Size(132, 22);
            this.radEns.TabIndex = 0;
            this.radEns.TabStop = true;
            this.radEns.Text = "ENSEIGNANT";
            this.radEns.UseVisualStyleBackColor = true;
            this.radEns.CheckedChanged += new System.EventHandler(this.radEns_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // txtBNom
            // 
            this.txtBNom.Location = new System.Drawing.Point(303, 171);
            this.txtBNom.Name = "txtBNom";
            this.txtBNom.Size = new System.Drawing.Size(100, 20);
            this.txtBNom.TabIndex = 2;
            // 
            // btnVal
            // 
            this.btnVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVal.Location = new System.Drawing.Point(12, 341);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(561, 29);
            this.btnVal.TabIndex = 3;
            this.btnVal.Text = "VALIDER";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdmin.Location = new System.Drawing.Point(347, 66);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(149, 22);
            this.radAdmin.TabIndex = 4;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "ADMINISTRATIF";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // txtBPre
            // 
            this.txtBPre.Location = new System.Drawing.Point(303, 220);
            this.txtBPre.Name = "txtBPre";
            this.txtBPre.Size = new System.Drawing.Size(100, 20);
            this.txtBPre.TabIndex = 6;
            // 
            // labPre
            // 
            this.labPre.AutoSize = true;
            this.labPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPre.Location = new System.Drawing.Point(189, 220);
            this.labPre.Name = "labPre";
            this.labPre.Size = new System.Drawing.Size(67, 18);
            this.labPre.TabIndex = 5;
            this.labPre.Text = "Prénom";
            // 
            // txtBHeure
            // 
            this.txtBHeure.Location = new System.Drawing.Point(303, 272);
            this.txtBHeure.Name = "txtBHeure";
            this.txtBHeure.Size = new System.Drawing.Size(100, 20);
            this.txtBHeure.TabIndex = 8;
            this.txtBHeure.Visible = false;
            // 
            // labHeure
            // 
            this.labHeure.AutoSize = true;
            this.labHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeure.Location = new System.Drawing.Point(119, 274);
            this.labHeure.Name = "labHeure";
            this.labHeure.Size = new System.Drawing.Size(137, 18);
            this.labHeure.TabIndex = 7;
            this.labHeure.Text = "Nombre d\'heures";
            this.labHeure.Visible = false;
            // 
            // txtBService
            // 
            this.txtBService.Location = new System.Drawing.Point(303, 303);
            this.txtBService.Name = "txtBService";
            this.txtBService.Size = new System.Drawing.Size(100, 20);
            this.txtBService.TabIndex = 10;
            this.txtBService.Visible = false;
            // 
            // labSer
            // 
            this.labSer.AutoSize = true;
            this.labSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSer.Location = new System.Drawing.Point(192, 305);
            this.labSer.Name = "labSer";
            this.labSer.Size = new System.Drawing.Size(64, 18);
            this.labSer.TabIndex = 9;
            this.labSer.Text = "Service";
            this.labSer.Visible = false;
            // 
            // listBPerso
            // 
            this.listBPerso.FormattingEnabled = true;
            this.listBPerso.Location = new System.Drawing.Point(12, 386);
            this.listBPerso.Name = "listBPerso";
            this.listBPerso.Size = new System.Drawing.Size(561, 134);
            this.listBPerso.TabIndex = 11;
            // 
            // gestPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 530);
            this.Controls.Add(this.listBPerso);
            this.Controls.Add(this.txtBService);
            this.Controls.Add(this.labSer);
            this.Controls.Add(this.txtBHeure);
            this.Controls.Add(this.labHeure);
            this.Controls.Add(this.txtBPre);
            this.Controls.Add(this.labPre);
            this.Controls.Add(this.radAdmin);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.txtBNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radEns);
            this.Name = "gestPerso";
            this.Text = "gestPerso";
            this.Load += new System.EventHandler(this.gestPerso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radEns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBNom;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.TextBox txtBPre;
        private System.Windows.Forms.Label labPre;
        private System.Windows.Forms.TextBox txtBHeure;
        private System.Windows.Forms.Label labHeure;
        private System.Windows.Forms.TextBox txtBService;
        private System.Windows.Forms.Label labSer;
        private System.Windows.Forms.ListBox listBPerso;
    }
}