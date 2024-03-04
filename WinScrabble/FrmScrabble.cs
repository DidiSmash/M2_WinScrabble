using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinScrabble
{
    public partial class FrmScrabble : Form
    {
        int player = 0;
        double manche = 1;
        bool Entered = false;

        Joueur Player1;
        Joueur Player2;
        public FrmScrabble()
        {
            InitializeComponent();
        }

        private void tbP1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbP1.Text) || String.IsNullOrEmpty(tbP2.Text))
                btnPValider.Enabled = false;
            else
                btnPValider.Enabled = true;
        }

        private void tbP2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbP1.Text) || String.IsNullOrEmpty(tbP2.Text))
                btnPValider.Enabled = false;
            else
                btnPValider.Enabled = true;
        }

        private void btnPValider_Click(object sender, EventArgs e)
        {
            string NPlayer1 = tbP1.Text;
            string NPlayer2 = tbP2.Text;

            Player1 = new Joueur(NPlayer1);
            Player2 = new Joueur(NPlayer2);

            Random rng = new Random();
            player = rng.Next(1, 3);
            if (player == 1)
            {
                txtSelectPlayer.Text = Player1.GetNom() + "\nà toi d’entrer un mot!";
            } else
            {
                txtSelectPlayer.Text = Player2.GetNom() + "\nà toi d’entrer un mot!";
            }

            txtManche.Text = "Manche " + manche + " / 10";

            //ramdom tout les nbr
            tbL1.Text = Utilitaire.RandomChar();
            tbL2.Text = Utilitaire.RandomChar();
            tbL3.Text = Utilitaire.RandomChar();
            tbL4.Text = Utilitaire.RandomChar();
            tbL5.Text = Utilitaire.RandomChar();
            tbL6.Text = Utilitaire.RandomChar();
            tbL7.Text = Utilitaire.RandomChar();

            btnPValider.Enabled = false;
            tbP1.Enabled = false;
            tbP2.Enabled = false;

            tbMot.Enabled = true;

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (manche > 10)
            {
                btnValider.Enabled = false;

                if (player == 1)
                {
                    player = 2;
                    manche += 0.5;
                    Player1.AjouterMot(tbMot.Text);
                    tbScoreP1.Text = Player1.GetTotalPoints().ToString();
                    txtSelectPlayer.Text = Player2.GetNom() + "\nà toi d’entrer un mot!";
                }
                else
                {
                    player = 1;
                    manche += 0.5;
                    Player2.AjouterMot(tbMot.Text);
                    tbScoreP2.Text = Player2.GetTotalPoints().ToString();
                    txtSelectPlayer.Text = Player1.GetNom() + "\nà toi d’entrer un mot!";
                }

                if (Player1.GetTotalPoints() > Player2.GetTotalPoints())
                {
                    txtWinner.Text = "gagnant : " + Player1.GetNom();
                    tbMeilleurMot.Text = Player1.MotMeilleur();

                    foreach (var mots in Player1.GetLesMots())
                    {
                        lbMots.Items.Add(mots);
                    }
                } else
                {
                    txtWinner.Text = "gagnant : " + Player2.GetNom();
                    tbMeilleurMot.Text = Player2.MotMeilleur();

                    foreach (var mots in Player2.GetLesMots())
                    {
                        lbMots.Items.Add(mots);
                    }
                }
            } else
            {
                if (player == 1)
                {
                    player = 2;
                    manche += 0.5;
                    Player1.AjouterMot(tbMot.Text);
                    tbScoreP1.Text = Player1.GetTotalPoints().ToString();
                    txtSelectPlayer.Text = Player2.GetNom() + "\nà toi d’entrer un mot!";
                }
                else
                {
                    player = 1;
                    manche += 0.5;
                    Player2.AjouterMot(tbMot.Text);
                    tbScoreP2.Text = Player2.GetTotalPoints().ToString();
                    txtSelectPlayer.Text = Player1.GetNom() + "\nà toi d’entrer un mot!";
                }

                if (manche > 9.5)
                {
                    txtManche.Text = "Dernière Manche !";
                } else
                {
                    txtManche.Text = "Manche " + Math.Floor(manche) + " / 10";
                }
                
                tbMot.Text = "";

                //ramdom tout les nbr
                tbL1.Text = Utilitaire.RandomChar();
                tbL2.Text = Utilitaire.RandomChar();
                tbL3.Text = Utilitaire.RandomChar();
                tbL4.Text = Utilitaire.RandomChar();
                tbL5.Text = Utilitaire.RandomChar();
                tbL6.Text = Utilitaire.RandomChar();
                tbL7.Text = Utilitaire.RandomChar();
            }
        }

        private void tbMot_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMot.Text))
                btnValider.Enabled = false;
            else
                btnValider.Enabled = true;
        }

        private void btnChar1_Click(object sender, EventArgs e)
        {

            if (Entered == false)
            {
                Entered = true;

                tbMot.Text += btnChar1.Text;
                Console.WriteLine(btnChar1.Text);
            } else
            {
                Entered = false;

                //tbMot.Text -= btnChar1.Text;
                Console.WriteLine("supr L");
            }
        }

        private void btnChar2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("entre A");
        }
    }
}
