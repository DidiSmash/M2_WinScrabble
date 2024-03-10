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
        bool C1Entered = false;
        bool C2Entered = false;
        bool C3Entered = false;
        bool C4Entered = false;
        bool C5Entered = false;
        bool C6Entered = false;
        bool C7Entered = false;

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

            //upd
            btnChar1.Text = Utilitaire.RandomChar();
            btnChar2.Text = Utilitaire.RandomChar();
            btnChar3.Text = Utilitaire.RandomChar();
            btnChar4.Text = Utilitaire.RandomChar();
            btnChar5.Text = Utilitaire.RandomChar();
            btnChar6.Text = Utilitaire.RandomChar();
            btnChar7.Text = Utilitaire.RandomChar();

            btnPValider.Enabled = false;
            tbP1.Enabled = false;
            tbP2.Enabled = false;

            btnChar1.Enabled = true;
            btnChar2.Enabled = true;
            btnChar3.Enabled = true;
            btnChar4.Enabled = true;
            btnChar5.Enabled = true;
            btnChar6.Enabled = true;
            btnChar7.Enabled = true;

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            C1Entered = false;
            C2Entered = false;
            C3Entered = false;
            C4Entered = false;
            C5Entered = false;
            C6Entered = false;
            C7Entered = false;

            if (manche > 10)
            {
                btnValider.Enabled = false;

                btnChar1.Enabled = false;
                btnChar2.Enabled = false;
                btnChar3.Enabled = false;
                btnChar4.Enabled = false;
                btnChar5.Enabled = false;
                btnChar6.Enabled = false;
                btnChar7.Enabled = false;

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

                //upd
                btnChar1.Text = Utilitaire.RandomChar();
                btnChar2.Text = Utilitaire.RandomChar();
                btnChar3.Text = Utilitaire.RandomChar();
                btnChar4.Text = Utilitaire.RandomChar();
                btnChar5.Text = Utilitaire.RandomChar();
                btnChar6.Text = Utilitaire.RandomChar();
                btnChar7.Text = Utilitaire.RandomChar();
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

            if (C1Entered == false)
            {
                C1Entered = true;

                tbMot.Text += btnChar1.Text;
            } else
            {
                C1Entered = false;

                tbMot.Text = tbMot.Text.Remove(tbMot.Text.IndexOf(btnChar1.Text), 1);
            }
        }

        private void btnChar2_Click(object sender, EventArgs e)
        {
            if (C2Entered == false)
            {
                C2Entered = true;

                tbMot.Text += btnChar2.Text;
            }
            else
            {
                C2Entered = false;

                tbMot.Text = tbMot.Text.Remove(tbMot.Text.IndexOf(btnChar2.Text), 1);
            }
        }

        private void btnChar3_Click(object sender, EventArgs e)
        {
            if (C3Entered == false)
            {
                C3Entered = true;

                tbMot.Text += btnChar3.Text;
            }
            else
            {
                C3Entered = false;

                tbMot.Text = tbMot.Text.Remove(tbMot.Text.IndexOf(btnChar3.Text), 1);
            }
        }

        private void btnChar4_Click(object sender, EventArgs e)
        {
            if (C4Entered == false)
            {
                C4Entered = true;

                tbMot.Text += btnChar4.Text;
            }
            else
            {
                C4Entered = false;

                tbMot.Text = tbMot.Text.Remove(tbMot.Text.IndexOf(btnChar4.Text), 1);
            }
        }

        private void btnChar5_Click(object sender, EventArgs e)
        {
            if (C5Entered == false)
            {
                C5Entered = true;

                tbMot.Text += btnChar5.Text;
            }
            else
            {
                C5Entered = false;

                tbMot.Text = tbMot.Text.Remove(tbMot.Text.IndexOf(btnChar5.Text), 1);
            }
        }

        private void btnChar6_Click(object sender, EventArgs e)
        {
            if (C6Entered == false)
            {
                C6Entered = true;

                tbMot.Text += btnChar6.Text;
            }
            else
            {
                C6Entered = false;

                tbMot.Text = tbMot.Text.Remove(tbMot.Text.IndexOf(btnChar6.Text), 1);
            }
        }

        private void btnChar7_Click(object sender, EventArgs e)
        {
            if (C7Entered == false)
            {
                C7Entered = true;

                tbMot.Text += btnChar7.Text;
            }
            else
            {
                C7Entered = false;

                tbMot.Text = tbMot.Text.Remove(tbMot.Text.IndexOf(btnChar7.Text), 1);
            }
        }
    }
}
