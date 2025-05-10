namespace habilitation2024.view
{
    partial class FrmHabilitations
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
            this.dgvLesDev = new System.Windows.Forms.DataGridView();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnChangerpwd = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.gbLesDev = new System.Windows.Forms.GroupBox();
            this.gbAjouterDev = new System.Windows.Forms.GroupBox();
            this.cboLstProfil = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblProfil = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.gbChangerPwd = new System.Windows.Forms.GroupBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtValider = new System.Windows.Forms.TextBox();
            this.lblValider = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.btnEnregistrerPwd = new System.Windows.Forms.Button();
            this.btnAnnulerPwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesDev)).BeginInit();
            this.gbLesDev.SuspendLayout();
            this.gbAjouterDev.SuspendLayout();
            this.gbChangerPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLesDev
            // 
            this.dgvLesDev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLesDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesDev.Location = new System.Drawing.Point(12, 21);
            this.dgvLesDev.MultiSelect = false;
            this.dgvLesDev.Name = "dgvLesDev";
            this.dgvLesDev.RowHeadersVisible = false;
            this.dgvLesDev.RowHeadersWidth = 51;
            this.dgvLesDev.RowTemplate.Height = 24;
            this.dgvLesDev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLesDev.Size = new System.Drawing.Size(761, 206);
            this.dgvLesDev.TabIndex = 0;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 233);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnChangerpwd
            // 
            this.btnChangerpwd.Location = new System.Drawing.Point(174, 233);
            this.btnChangerpwd.Name = "btnChangerpwd";
            this.btnChangerpwd.Size = new System.Drawing.Size(103, 23);
            this.btnChangerpwd.TabIndex = 2;
            this.btnChangerpwd.Text = "changer pwd";
            this.btnChangerpwd.UseVisualStyleBackColor = true;
            this.btnChangerpwd.Click += new System.EventHandler(this.btnChangerpwd_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(93, 233);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(75, 23);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // gbLesDev
            // 
            this.gbLesDev.Controls.Add(this.dgvLesDev);
            this.gbLesDev.Controls.Add(this.btnChangerpwd);
            this.gbLesDev.Controls.Add(this.btnSupp);
            this.gbLesDev.Controls.Add(this.btnModifier);
            this.gbLesDev.Location = new System.Drawing.Point(3, 4);
            this.gbLesDev.Name = "gbLesDev";
            this.gbLesDev.Size = new System.Drawing.Size(795, 265);
            this.gbLesDev.TabIndex = 4;
            this.gbLesDev.TabStop = false;
            this.gbLesDev.Text = "les développeurs";
            // 
            // gbAjouterDev
            // 
            this.gbAjouterDev.Controls.Add(this.cboLstProfil);
            this.gbAjouterDev.Controls.Add(this.btnEnregistrer);
            this.gbAjouterDev.Controls.Add(this.btnAnnuler);
            this.gbAjouterDev.Controls.Add(this.txtMail);
            this.gbAjouterDev.Controls.Add(this.txtTel);
            this.gbAjouterDev.Controls.Add(this.txtPrenom);
            this.gbAjouterDev.Controls.Add(this.txtNom);
            this.gbAjouterDev.Controls.Add(this.lblMail);
            this.gbAjouterDev.Controls.Add(this.lblTel);
            this.gbAjouterDev.Controls.Add(this.lblProfil);
            this.gbAjouterDev.Controls.Add(this.lblPrenom);
            this.gbAjouterDev.Controls.Add(this.lblNom);
            this.gbAjouterDev.Location = new System.Drawing.Point(3, 275);
            this.gbAjouterDev.Name = "gbAjouterDev";
            this.gbAjouterDev.Size = new System.Drawing.Size(795, 174);
            this.gbAjouterDev.TabIndex = 5;
            this.gbAjouterDev.TabStop = false;
            this.gbAjouterDev.Text = "ajouter un développeur";
            // 
            // cboLstProfil
            // 
            this.cboLstProfil.FormattingEnabled = true;
            this.cboLstProfil.Location = new System.Drawing.Point(497, 99);
            this.cboLstProfil.Name = "cboLstProfil";
            this.cboLstProfil.Size = new System.Drawing.Size(214, 24);
            this.cboLstProfil.TabIndex = 18;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 134);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(85, 23);
            this.btnEnregistrer.TabIndex = 17;
            this.btnEnregistrer.Text = "enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(118, 134);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(497, 29);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(276, 22);
            this.txtMail.TabIndex = 15;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(497, 61);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(276, 22);
            this.txtTel.TabIndex = 14;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(106, 64);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(277, 22);
            this.txtPrenom.TabIndex = 12;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(106, 32);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(277, 22);
            this.txtNom.TabIndex = 11;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(424, 35);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 16);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "mail";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(424, 64);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(27, 16);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "Tel";
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Location = new System.Drawing.Point(424, 99);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(36, 16);
            this.lblProfil.TabIndex = 8;
            this.lblProfil.Text = "profil";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(9, 64);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(53, 16);
            this.lblPrenom.TabIndex = 7;
            this.lblPrenom.Text = "prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(9, 35);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(33, 16);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "nom";
            // 
            // gbChangerPwd
            // 
            this.gbChangerPwd.Controls.Add(this.txtPwd);
            this.gbChangerPwd.Controls.Add(this.txtValider);
            this.gbChangerPwd.Controls.Add(this.lblValider);
            this.gbChangerPwd.Controls.Add(this.lblPwd);
            this.gbChangerPwd.Controls.Add(this.btnEnregistrerPwd);
            this.gbChangerPwd.Controls.Add(this.btnAnnulerPwd);
            this.gbChangerPwd.Location = new System.Drawing.Point(3, 455);
            this.gbChangerPwd.Name = "gbChangerPwd";
            this.gbChangerPwd.Size = new System.Drawing.Size(795, 100);
            this.gbChangerPwd.TabIndex = 6;
            this.gbChangerPwd.TabStop = false;
            this.gbChangerPwd.Text = "changer le mot de passe";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(93, 26);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(296, 22);
            this.txtPwd.TabIndex = 5;
            // 
            // txtValider
            // 
            this.txtValider.Location = new System.Drawing.Point(497, 26);
            this.txtValider.Name = "txtValider";
            this.txtValider.PasswordChar = '*';
            this.txtValider.Size = new System.Drawing.Size(276, 22);
            this.txtValider.TabIndex = 4;
            // 
            // lblValider
            // 
            this.lblValider.AutoSize = true;
            this.lblValider.Location = new System.Drawing.Point(424, 32);
            this.lblValider.Name = "lblValider";
            this.lblValider.Size = new System.Drawing.Size(48, 16);
            this.lblValider.TabIndex = 3;
            this.lblValider.Text = "valider";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(18, 29);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(32, 16);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "pwd";
            // 
            // btnEnregistrerPwd
            // 
            this.btnEnregistrerPwd.Location = new System.Drawing.Point(12, 71);
            this.btnEnregistrerPwd.Name = "btnEnregistrerPwd";
            this.btnEnregistrerPwd.Size = new System.Drawing.Size(85, 23);
            this.btnEnregistrerPwd.TabIndex = 1;
            this.btnEnregistrerPwd.Text = "enregistrer";
            this.btnEnregistrerPwd.UseVisualStyleBackColor = true;
            this.btnEnregistrerPwd.Click += new System.EventHandler(this.btnEnregistrerPwd_Click);
            // 
            // btnAnnulerPwd
            // 
            this.btnAnnulerPwd.Location = new System.Drawing.Point(118, 71);
            this.btnAnnulerPwd.Name = "btnAnnulerPwd";
            this.btnAnnulerPwd.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerPwd.TabIndex = 0;
            this.btnAnnulerPwd.Text = "annuler";
            this.btnAnnulerPwd.UseVisualStyleBackColor = true;
            this.btnAnnulerPwd.Click += new System.EventHandler(this.btnAnnulerPwd_Click);
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 564);
            this.Controls.Add(this.gbChangerPwd);
            this.Controls.Add(this.gbAjouterDev);
            this.Controls.Add(this.gbLesDev);
            this.Name = "FrmHabilitations";
            this.Text = "FrmHabilitations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesDev)).EndInit();
            this.gbLesDev.ResumeLayout(false);
            this.gbAjouterDev.ResumeLayout(false);
            this.gbAjouterDev.PerformLayout();
            this.gbChangerPwd.ResumeLayout(false);
            this.gbChangerPwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLesDev;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnChangerpwd;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.GroupBox gbLesDev;
        private System.Windows.Forms.GroupBox gbAjouterDev;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox gbChangerPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtValider;
        private System.Windows.Forms.Label lblValider;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Button btnEnregistrerPwd;
        private System.Windows.Forms.Button btnAnnulerPwd;
        private System.Windows.Forms.ComboBox cboLstProfil;
    }
}

