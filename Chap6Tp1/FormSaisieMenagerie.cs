using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libAnimalerie;

namespace Chap6Tp1
{
    public partial class FormSaisieMenagerie : Form
    {
        Menagerie uneMenagerie;

        public FormSaisieMenagerie()
        {
            InitializeComponent();
        }

        private void btnCreerMenagerie_Click(object sender, EventArgs e)
        {
            // création de la ménagerie
            // Si auccune ménagerie, en crée une
            if (uneMenagerie == null)
            {
                uneMenagerie = new Menagerie();
                MessageBox.Show("Votre ménagerie a été créée", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // si déja une ménagerie, message d'erreur
            else
            {
                MessageBox.Show("Une ménagerie éxiste déja", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCreerAnimal_Click(object sender, EventArgs e)
        {
            Animal unAnimal;
            if (uneMenagerie != null)
            {
                string libErr = "";
                if (txtNom.Text.Trim() == "")
                {
                    libErr = "\n Veuillez saisir un nom";
                    txtNom.Focus();
                }
                if (lstEspece.SelectedIndex == -1)
                {
                    libErr = libErr + "\n Veuillez saisir une éspéce";
                    if(txtNom.Focused == false) lstEspece.Focus();
                }
                if (txtCri.Text.Trim() == "")
                {
                    libErr = libErr + "\n Veuillez saisir un cri";
                    if (txtNom.Focused == false && lstEspece.Focused == false) txtCri.Focus();
                }
                if (libErr == "")
                {
                    // création d'un animal
                    unAnimal = new Animal(txtNom.Text, lstEspece.Text, txtCri.Text);
                    // on ajoute l'animal dans la ménagerie
                    uneMenagerie.Arriver(unAnimal);
                    // on fait le nécéssaire pour que aucune valeur
                    // ne soit sélectionnée dans la liste
                    lstEspece.SelectedIndex = -1;
                    MessageBox.Show("Ajouter avec succée.", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Message d'erreur listant les controles du formulaire en erreur
                    MessageBox.Show(libErr, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Auccune ménagerie crée.", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
            
            
        }

        private void cmdAfficherMenagerie_Click(object sender, EventArgs e)
        {
            if (uneMenagerie != null)
            {
                if (uneMenagerie.NombreAnimaux > 0)
                {
                    dtgAnimaux.DataSource = null;
                    dtgAnimaux.DataSource = uneMenagerie.ListeAnimaux();
                    dtgAnimaux.Visible = true;
                }
                else
                {
                    MessageBox.Show("Il n'existe pas d'animal dans la ménagerie !", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Consulation impossible: il n'existe pas de ménagerie !", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
