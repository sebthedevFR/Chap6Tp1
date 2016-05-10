namespace Chap6Tp1
{
    partial class FormSaisieMenagerie
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
            this.btnCreerMenagerie = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblEspece = new System.Windows.Forms.Label();
            this.lblCri = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCri = new System.Windows.Forms.TextBox();
            this.lstEspece = new System.Windows.Forms.ListBox();
            this.btnCreerAnimal = new System.Windows.Forms.Button();
            this.dtgAnimaux = new System.Windows.Forms.DataGridView();
            this.cmdAfficherMenagerie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimaux)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreerMenagerie
            // 
            this.btnCreerMenagerie.Location = new System.Drawing.Point(83, 28);
            this.btnCreerMenagerie.Name = "btnCreerMenagerie";
            this.btnCreerMenagerie.Size = new System.Drawing.Size(267, 56);
            this.btnCreerMenagerie.TabIndex = 0;
            this.btnCreerMenagerie.Text = "Crée la &Ménagerie";
            this.btnCreerMenagerie.UseVisualStyleBackColor = true;
            this.btnCreerMenagerie.Click += new System.EventHandler(this.btnCreerMenagerie_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(59, 129);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(87, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom de l\'animal :";
            // 
            // lblEspece
            // 
            this.lblEspece.AutoSize = true;
            this.lblEspece.Location = new System.Drawing.Point(97, 164);
            this.lblEspece.Name = "lblEspece";
            this.lblEspece.Size = new System.Drawing.Size(49, 13);
            this.lblEspece.TabIndex = 3;
            this.lblEspece.Text = "Espèce :";
            // 
            // lblCri
            // 
            this.lblCri.AutoSize = true;
            this.lblCri.Location = new System.Drawing.Point(121, 213);
            this.lblCri.Name = "lblCri";
            this.lblCri.Size = new System.Drawing.Size(25, 13);
            this.lblCri.TabIndex = 5;
            this.lblCri.Text = "Cri :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(170, 129);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 2;
            // 
            // txtCri
            // 
            this.txtCri.Location = new System.Drawing.Point(170, 210);
            this.txtCri.Name = "txtCri";
            this.txtCri.Size = new System.Drawing.Size(100, 20);
            this.txtCri.TabIndex = 6;
            // 
            // lstEspece
            // 
            this.lstEspece.FormattingEnabled = true;
            this.lstEspece.Items.AddRange(new object[] {
            "canari",
            "chat",
            "poisson rouge"});
            this.lstEspece.Location = new System.Drawing.Point(170, 164);
            this.lstEspece.Name = "lstEspece";
            this.lstEspece.Size = new System.Drawing.Size(120, 30);
            this.lstEspece.TabIndex = 4;
            // 
            // btnCreerAnimal
            // 
            this.btnCreerAnimal.Location = new System.Drawing.Point(83, 257);
            this.btnCreerAnimal.Name = "btnCreerAnimal";
            this.btnCreerAnimal.Size = new System.Drawing.Size(267, 54);
            this.btnCreerAnimal.TabIndex = 7;
            this.btnCreerAnimal.Text = "&Ajouter l\'animal dans la ménagerie";
            this.btnCreerAnimal.UseVisualStyleBackColor = true;
            this.btnCreerAnimal.Click += new System.EventHandler(this.btnCreerAnimal_Click);
            // 
            // dtgAnimaux
            // 
            this.dtgAnimaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAnimaux.Location = new System.Drawing.Point(441, 28);
            this.dtgAnimaux.Name = "dtgAnimaux";
            this.dtgAnimaux.Size = new System.Drawing.Size(405, 207);
            this.dtgAnimaux.TabIndex = 8;
            // 
            // cmdAfficherMenagerie
            // 
            this.cmdAfficherMenagerie.Location = new System.Drawing.Point(498, 257);
            this.cmdAfficherMenagerie.Name = "cmdAfficherMenagerie";
            this.cmdAfficherMenagerie.Size = new System.Drawing.Size(288, 54);
            this.cmdAfficherMenagerie.TabIndex = 9;
            this.cmdAfficherMenagerie.Text = "Afficher les animaux";
            this.cmdAfficherMenagerie.UseVisualStyleBackColor = true;
            this.cmdAfficherMenagerie.Click += new System.EventHandler(this.cmdAfficherMenagerie_Click);
            // 
            // FormSaisieMenagerie
            // 
            this.AcceptButton = this.btnCreerMenagerie;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 345);
            this.Controls.Add(this.cmdAfficherMenagerie);
            this.Controls.Add(this.dtgAnimaux);
            this.Controls.Add(this.btnCreerAnimal);
            this.Controls.Add(this.lstEspece);
            this.Controls.Add(this.txtCri);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblCri);
            this.Controls.Add(this.lblEspece);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnCreerMenagerie);
            this.Name = "FormSaisieMenagerie";
            this.Text = "Gestion d\'une ménagerie";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreerMenagerie;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblEspece;
        private System.Windows.Forms.Label lblCri;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCri;
        private System.Windows.Forms.ListBox lstEspece;
        private System.Windows.Forms.Button btnCreerAnimal;
        private System.Windows.Forms.DataGridView dtgAnimaux;
        private System.Windows.Forms.Button cmdAfficherMenagerie;
    }
}

