namespace wfaFractionsExercice
{
    partial class frmFractionsAvecSurcharge
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
            this.txtNumFraction1 = new System.Windows.Forms.TextBox();
            this.txtDenomFraction1 = new System.Windows.Forms.TextBox();
            this.txtNumFraction2 = new System.Windows.Forms.TextBox();
            this.txtDenomFraction2 = new System.Windows.Forms.TextBox();
            this.lblLigne1 = new System.Windows.Forms.Label();
            this.lblLigne2 = new System.Windows.Forms.Label();
            this.btnAdditioner = new System.Windows.Forms.Button();
            this.btnSoustraire = new System.Windows.Forms.Button();
            this.btnMultiplier = new System.Windows.Forms.Button();
            this.lblLigne3 = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblNumReponse = new System.Windows.Forms.Label();
            this.lblDenomReponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumFraction1
            // 
            this.txtNumFraction1.Location = new System.Drawing.Point(52, 52);
            this.txtNumFraction1.Name = "txtNumFraction1";
            this.txtNumFraction1.Size = new System.Drawing.Size(58, 20);
            this.txtNumFraction1.TabIndex = 0;
            // 
            // txtDenomFraction1
            // 
            this.txtDenomFraction1.Location = new System.Drawing.Point(52, 104);
            this.txtDenomFraction1.Name = "txtDenomFraction1";
            this.txtDenomFraction1.Size = new System.Drawing.Size(58, 20);
            this.txtDenomFraction1.TabIndex = 1;
            // 
            // txtNumFraction2
            // 
            this.txtNumFraction2.Location = new System.Drawing.Point(334, 52);
            this.txtNumFraction2.Name = "txtNumFraction2";
            this.txtNumFraction2.Size = new System.Drawing.Size(57, 20);
            this.txtNumFraction2.TabIndex = 2;
            // 
            // txtDenomFraction2
            // 
            this.txtDenomFraction2.Location = new System.Drawing.Point(334, 104);
            this.txtDenomFraction2.Name = "txtDenomFraction2";
            this.txtDenomFraction2.Size = new System.Drawing.Size(57, 20);
            this.txtDenomFraction2.TabIndex = 3;
            // 
            // lblLigne1
            // 
            this.lblLigne1.AutoSize = true;
            this.lblLigne1.Location = new System.Drawing.Point(49, 75);
            this.lblLigne1.Name = "lblLigne1";
            this.lblLigne1.Size = new System.Drawing.Size(73, 13);
            this.lblLigne1.TabIndex = 4;
            this.lblLigne1.Text = "___________";
            // 
            // lblLigne2
            // 
            this.lblLigne2.AutoSize = true;
            this.lblLigne2.Location = new System.Drawing.Point(331, 75);
            this.lblLigne2.Name = "lblLigne2";
            this.lblLigne2.Size = new System.Drawing.Size(73, 13);
            this.lblLigne2.TabIndex = 5;
            this.lblLigne2.Text = "___________";
            // 
            // btnAdditioner
            // 
            this.btnAdditioner.Location = new System.Drawing.Point(172, 49);
            this.btnAdditioner.Name = "btnAdditioner";
            this.btnAdditioner.Size = new System.Drawing.Size(93, 23);
            this.btnAdditioner.TabIndex = 6;
            this.btnAdditioner.Text = "Additionne";
            this.btnAdditioner.UseVisualStyleBackColor = true;
            this.btnAdditioner.Click += new System.EventHandler(this.btnAdditioner_Click);
            // 
            // btnSoustraire
            // 
            this.btnSoustraire.Location = new System.Drawing.Point(172, 78);
            this.btnSoustraire.Name = "btnSoustraire";
            this.btnSoustraire.Size = new System.Drawing.Size(93, 23);
            this.btnSoustraire.TabIndex = 7;
            this.btnSoustraire.Text = "Soustraire";
            this.btnSoustraire.UseVisualStyleBackColor = true;
            this.btnSoustraire.Click += new System.EventHandler(this.btnSoustraire_Click);
            // 
            // btnMultiplier
            // 
            this.btnMultiplier.Location = new System.Drawing.Point(172, 107);
            this.btnMultiplier.Name = "btnMultiplier";
            this.btnMultiplier.Size = new System.Drawing.Size(93, 23);
            this.btnMultiplier.TabIndex = 8;
            this.btnMultiplier.Text = "Multiplie";
            this.btnMultiplier.UseVisualStyleBackColor = true;
            this.btnMultiplier.Click += new System.EventHandler(this.btnMultiplier_Click);
            // 
            // lblLigne3
            // 
            this.lblLigne3.AutoSize = true;
            this.lblLigne3.Location = new System.Drawing.Point(185, 282);
            this.lblLigne3.Name = "lblLigne3";
            this.lblLigne3.Size = new System.Drawing.Size(73, 13);
            this.lblLigne3.TabIndex = 11;
            this.lblLigne3.Text = "___________";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(88, 282);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(49, 13);
            this.lblResultat.TabIndex = 12;
            this.lblResultat.Text = "Résultat:";
            // 
            // lblNumReponse
            // 
            this.lblNumReponse.AutoSize = true;
            this.lblNumReponse.Location = new System.Drawing.Point(185, 269);
            this.lblNumReponse.Name = "lblNumReponse";
            this.lblNumReponse.Size = new System.Drawing.Size(29, 13);
            this.lblNumReponse.TabIndex = 13;
            this.lblNumReponse.Text = "Num";
            // 
            // lblDenomReponse
            // 
            this.lblDenomReponse.AutoSize = true;
            this.lblDenomReponse.Location = new System.Drawing.Point(185, 312);
            this.lblDenomReponse.Name = "lblDenomReponse";
            this.lblDenomReponse.Size = new System.Drawing.Size(41, 13);
            this.lblDenomReponse.TabIndex = 14;
            this.lblDenomReponse.Text = "Denom";
            // 
            // frmFractionsAvecSurcharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDenomReponse);
            this.Controls.Add(this.lblNumReponse);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblLigne3);
            this.Controls.Add(this.btnMultiplier);
            this.Controls.Add(this.btnSoustraire);
            this.Controls.Add(this.btnAdditioner);
            this.Controls.Add(this.lblLigne2);
            this.Controls.Add(this.lblLigne1);
            this.Controls.Add(this.txtDenomFraction2);
            this.Controls.Add(this.txtNumFraction2);
            this.Controls.Add(this.txtDenomFraction1);
            this.Controls.Add(this.txtNumFraction1);
            this.Name = "frmFractionsAvecSurcharge";
            this.Text = "Des fractions avec surcharge d\'opérateurs";
            this.Load += new System.EventHandler(this.frmFractionsAvecSurcharge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumFraction1;
        private System.Windows.Forms.TextBox txtDenomFraction1;
        private System.Windows.Forms.TextBox txtNumFraction2;
        private System.Windows.Forms.TextBox txtDenomFraction2;
        private System.Windows.Forms.Label lblLigne1;
        private System.Windows.Forms.Label lblLigne2;
        private System.Windows.Forms.Button btnAdditioner;
        private System.Windows.Forms.Button btnSoustraire;
        private System.Windows.Forms.Button btnMultiplier;
        private System.Windows.Forms.Label lblLigne3;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblNumReponse;
        private System.Windows.Forms.Label lblDenomReponse;
    }
}

