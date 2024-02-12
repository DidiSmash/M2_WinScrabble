using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinScrabble
{
    public partial class FrmScrabble : Form
    {
        int player = 0;
        double manche = 1;

        Joueur Player1;
        Joueur Player2;
        public FrmScrabble()
        {
            InitializeComponent();
        }

        private void FrmScrabble_Load(object sender, EventArgs e)
        {

        }

        private void btnPValider_Click(object sender, EventArgs e)
        {
            string NPlayer1 = tbP1.Text;
            string NPlayer2 = tbP2.Text;

            Player1 = new Joueur(NPlayer1);
            Player2 = new Joueur(NPlayer2);

            Random rng = new Random();
            player = rng.Next(1, 3);
            txtSelectPlayer.Text = "Joueur " + player + "\nà toi d’entrer un mot!";



        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (manche > 10)
            {
                Console.WriteLine("{0} | {1}", Player1, Player2);
            } else
            {
                if (player == 1)
                {
                    player = 2;
                    manche += 0.5;
                    tbScoreP1.Text = Player1.GetTotalPoints().ToString();
                }
                else
                {
                    player = 1;
                    manche += 0.5;
                    tbScoreP2.Text = Player2.GetTotalPoints().ToString();
                }
                txtSelectPlayer.Text = "Joueur " + player + "\nà toi d’entrer un mot!";
                txtManche.Text = "Manche " + manche + " / 10";
            }
        }
    }
}
