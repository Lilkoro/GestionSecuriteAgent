namespace Forms
{
    partial class EnreCompt
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
            this.labNom = new System.Windows.Forms.Label();
            this.txtBNom = new System.Windows.Forms.TextBox();
            this.txtBPrenom = new System.Windows.Forms.TextBox();
            this.labPrenom = new System.Windows.Forms.Label();
            this.txtBAge = new System.Windows.Forms.TextBox();
            this.labAge = new System.Windows.Forms.Label();
            this.labEnre = new System.Windows.Forms.Label();
            this.txt_aff_indivi = new System.Windows.Forms.TextBox();
            this.listCandidats = new System.Windows.Forms.ListBox();
            this.labPlusAge = new System.Windows.Forms.Label();
            this.txtBPlusAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNom.Location = new System.Drawing.Point(148, 139);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(45, 20);
            this.labNom.TabIndex = 0;
            this.labNom.Text = "Nom";
            // 
            // txtBNom
            // 
            this.txtBNom.Location = new System.Drawing.Point(234, 136);
            this.txtBNom.Name = "txtBNom";
            this.txtBNom.Size = new System.Drawing.Size(100, 20);
            this.txtBNom.TabIndex = 1;
            // 
            // txtBPrenom
            // 
            this.txtBPrenom.Location = new System.Drawing.Point(234, 207);
            this.txtBPrenom.Name = "txtBPrenom";
            this.txtBPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtBPrenom.TabIndex = 3;
            // 
            // labPrenom
            // 
            this.labPrenom.AutoSize = true;
            this.labPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labPrenom.Location = new System.Drawing.Point(148, 205);
            this.labPrenom.Name = "labPrenom";
            this.labPrenom.Size = new System.Drawing.Size(70, 20);
            this.labPrenom.TabIndex = 2;
            this.labPrenom.Text = "Prénom";
            // 
            // txtBAge
            // 
            this.txtBAge.Location = new System.Drawing.Point(234, 266);
            this.txtBAge.Name = "txtBAge";
            this.txtBAge.Size = new System.Drawing.Size(100, 20);
            this.txtBAge.TabIndex = 5;
            this.txtBAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBAge_KeyPress);
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labAge.Location = new System.Drawing.Point(148, 264);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(41, 20);
            this.labAge.TabIndex = 4;
            this.labAge.Text = "Age";
            // 
            // labEnre
            // 
            this.labEnre.AutoSize = true;
            this.labEnre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnre.Location = new System.Drawing.Point(100, 34);
            this.labEnre.Name = "labEnre";
            this.labEnre.Size = new System.Drawing.Size(391, 25);
            this.labEnre.TabIndex = 6;
            this.labEnre.Text = "Enregistrement Compétiteur Adultes";
            // 
            // txt_aff_indivi
            // 
            this.txt_aff_indivi.Enabled = false;
            this.txt_aff_indivi.Location = new System.Drawing.Point(105, 310);
            this.txt_aff_indivi.Name = "txt_aff_indivi";
            this.txt_aff_indivi.Size = new System.Drawing.Size(344, 20);
            this.txt_aff_indivi.TabIndex = 7;
            // 
            // listCandidats
            // 
            this.listCandidats.FormattingEnabled = true;
            this.listCandidats.Location = new System.Drawing.Point(105, 357);
            this.listCandidats.Name = "listCandidats";
            this.listCandidats.Size = new System.Drawing.Size(344, 121);
            this.listCandidats.TabIndex = 8;
            // 
            // labPlusAge
            // 
            this.labPlusAge.AutoSize = true;
            this.labPlusAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlusAge.Location = new System.Drawing.Point(152, 481);
            this.labPlusAge.Name = "labPlusAge";
            this.labPlusAge.Size = new System.Drawing.Size(243, 25);
            this.labPlusAge.TabIndex = 9;
            this.labPlusAge.Text = "Candidat le plus agé :";
            // 
            // txtBPlusAge
            // 
            this.txtBPlusAge.Enabled = false;
            this.txtBPlusAge.Location = new System.Drawing.Point(105, 529);
            this.txtBPlusAge.Name = "txtBPlusAge";
            this.txtBPlusAge.Size = new System.Drawing.Size(344, 20);
            this.txtBPlusAge.TabIndex = 10;
            // 
            // EnreCompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 597);
            this.Controls.Add(this.txtBPlusAge);
            this.Controls.Add(this.labPlusAge);
            this.Controls.Add(this.listCandidats);
            this.Controls.Add(this.txt_aff_indivi);
            this.Controls.Add(this.labEnre);
            this.Controls.Add(this.txtBAge);
            this.Controls.Add(this.labAge);
            this.Controls.Add(this.txtBPrenom);
            this.Controls.Add(this.labPrenom);
            this.Controls.Add(this.txtBNom);
            this.Controls.Add(this.labNom);
            this.Name = "EnreCompt";
            this.Text = "EnreCompt";
            this.Load += new System.EventHandler(this.EnreCompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.TextBox txtBNom;
        private System.Windows.Forms.TextBox txtBPrenom;
        private System.Windows.Forms.Label labPrenom;
        private System.Windows.Forms.TextBox txtBAge;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.Label labEnre;
        private System.Windows.Forms.TextBox txt_aff_indivi;
        private System.Windows.Forms.ListBox listCandidats;
        private System.Windows.Forms.Label labPlusAge;
        private System.Windows.Forms.TextBox txtBPlusAge;
    }
}