using habilitation2024.controller;
using habilitation2024.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace habilitation2024.view
{
    public partial class FrmAuthentification : Form
    {
        private FrmAuthentificationController controller;
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            String nom = txtNom.Text;
            String prenom = txtPrenom.Text;
            String pwd = txtPwd.Text;
            if (String.IsNullOrEmpty(nom) || String.IsNullOrEmpty(prenom) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Admin admin = new Admin(nom, prenom, pwd);
                if (controller.ControleAuthentification(admin))
                {
                    FrmHabilitations frm = new FrmHabilitations();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                }
            }
        }
    }
}
