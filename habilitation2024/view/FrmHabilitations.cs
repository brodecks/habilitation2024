using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using habilitation2024.controller;
using habilitation2024.dal;
using habilitation2024.model;
using MySql.Data.MySqlClient;

namespace habilitation2024.view
{
    public partial class FrmHabilitations : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifDeveloppeur = false;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        private BindingSource bdgDeveloppeurs = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        private BindingSource bdgProfils = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmHabilitationsController controller;
        public FrmHabilitations()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            controller = new FrmHabilitationsController();
            RemplirListeDeveloppeurs();
            RemplirListeProfils();
            EnCourseModifDeveloppeur(false);
            EnCoursModifPwd(false);
        }
        private void RemplirListeDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = controller.GetLesDeveloppeurs();
            bdgDeveloppeurs.DataSource = lesDeveloppeurs;
            dgvLesDev.DataSource = bdgDeveloppeurs;
            dgvLesDev.Columns["iddeveloppeur"].Visible = false;
            dgvLesDev.Columns["pwd"].Visible = false;
            dgvLesDev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void RemplirListeProfils()
        {
            List<Profil> lesProfils = controller.GetLesProfils();
            bdgProfils.DataSource = lesProfils;
            cboLstProfil.DataSource = bdgProfils;
        }


        

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvLesDev.SelectedRows.Count > 0)
            {
                EnCourseModifDeveloppeur(true);
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                txtNom.Text = developpeur.Nom;
                txtPrenom.Text = developpeur.Prenom;
                txtMail.Text = developpeur.Mail;
                txtTel.Text = developpeur.Tel;
                cboLstProfil.SelectedIndex = cboLstProfil.FindStringExact(developpeur.Profil.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if(dgvLesDev.SelectedRows.Count > 0)
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + developpeur.Nom + " " + developpeur.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelDeveloppeur(developpeur);
                    RemplirListeDeveloppeurs();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnChangerpwd_Click(object sender, EventArgs e)
        {
            if (dgvLesDev.SelectedRows.Count > 0)
            {
                EnCoursModifPwd(true);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboLstProfil.SelectedIndex != -1)
            {
                Profil profil = (Profil)bdgProfils.List[bdgDeveloppeurs.Position];
                if(enCoursDeModifDeveloppeur)
                {
                    Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                    developpeur.Nom = txtNom.Text;
                    developpeur.Prenom = txtPrenom.Text;
                    developpeur.Tel = txtTel.Text;
                    developpeur.Mail = txtMail.Text;
                    developpeur.Profil = profil;
                    controller.UpdateDeveloppeur(developpeur);
                }
                else
                {
                    Developpeur developpeur = new Developpeur(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, profil);
                    controller.AddDeveloppeur(developpeur);
                }
                RemplirListeDeveloppeurs();
                EnCourseModifDeveloppeur(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifDeveloppeur(false);
            }
        }

        private void btnEnregistrerPwd_Click(object sender, EventArgs e)
        {
            if(!txtPwd.Text.Equals("") && !txtValider.Text.Equals("") && txtPwd.Text.Equals(txtValider.Text))
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                developpeur.Pwd = txtPwd.Text;
                controller.UpdatePwd(developpeur);
                EnCoursModifPwd(false);
            }
        }

        private void btnAnnulerPwd_Click(object sender, EventArgs e)
        {
            EnCoursModifPwd(false);
        }
        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un developpeur
        /// </summary>
        /// <param name="modif"></param>
        private void EnCourseModifDeveloppeur(Boolean modif)
        {
            enCoursDeModifDeveloppeur = modif;
            gbAjouterDev.Enabled = !modif;
            if (modif)
            {
                gbAjouterDev.Text = "modifier un développeur";
            }
            else
            {
                gbAjouterDev.Text = "ajouter un développeur";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est ou non en cours de modif du pwd
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifPwd(Boolean modif)
        {
            gbChangerPwd.Enabled = modif;
            gbLesDev.Enabled = !modif;
            gbAjouterDev.Enabled = !modif;
            txtPwd.Text = "";
            txtValider.Text = "";
        }
    }
}
