
namespace WinScrabble
{
    partial class FrmScrabble
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
            this.txtP1 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.Label();
            this.tbP1 = new System.Windows.Forms.TextBox();
            this.tbP2 = new System.Windows.Forms.TextBox();
            this.btnPValider = new System.Windows.Forms.Button();
            this.txtWinner = new System.Windows.Forms.Label();
            this.txtMeilleurMot = new System.Windows.Forms.Label();
            this.txtListeMots = new System.Windows.Forms.Label();
            this.txtManche = new System.Windows.Forms.Label();
            this.txtScoreP1 = new System.Windows.Forms.Label();
            this.txtScoreP2 = new System.Windows.Forms.Label();
            this.txtSelectPlayer = new System.Windows.Forms.Label();
            this.txtMotEnter = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.tbMot = new System.Windows.Forms.TextBox();
            this.tbScoreP1 = new System.Windows.Forms.TextBox();
            this.tbScoreP2 = new System.Windows.Forms.TextBox();
            this.tbMeilleurMot = new System.Windows.Forms.TextBox();
            this.lbMots = new System.Windows.Forms.ListBox();
            this.btnChar1 = new System.Windows.Forms.Button();
            this.btnChar2 = new System.Windows.Forms.Button();
            this.btnChar3 = new System.Windows.Forms.Button();
            this.btnChar4 = new System.Windows.Forms.Button();
            this.btnChar5 = new System.Windows.Forms.Button();
            this.btnChar6 = new System.Windows.Forms.Button();
            this.btnChar7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtP1
            // 
            this.txtP1.AutoSize = true;
            this.txtP1.Location = new System.Drawing.Point(54, 39);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(161, 13);
            this.txtP1.TabIndex = 0;
            this.txtP1.Text = "Entrez le nom du premier joueur: ";
            // 
            // txtP2
            // 
            this.txtP2.AutoSize = true;
            this.txtP2.Location = new System.Drawing.Point(491, 39);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(162, 13);
            this.txtP2.TabIndex = 1;
            this.txtP2.Text = "Entrez le nom du second joueur: ";
            // 
            // tbP1
            // 
            this.tbP1.Location = new System.Drawing.Point(21, 72);
            this.tbP1.Name = "tbP1";
            this.tbP1.Size = new System.Drawing.Size(220, 20);
            this.tbP1.TabIndex = 2;
            this.tbP1.TextChanged += new System.EventHandler(this.tbP1_TextChanged);
            // 
            // tbP2
            // 
            this.tbP2.Location = new System.Drawing.Point(461, 72);
            this.tbP2.Name = "tbP2";
            this.tbP2.Size = new System.Drawing.Size(220, 20);
            this.tbP2.TabIndex = 3;
            this.tbP2.TextChanged += new System.EventHandler(this.tbP2_TextChanged);
            // 
            // btnPValider
            // 
            this.btnPValider.Enabled = false;
            this.btnPValider.Location = new System.Drawing.Point(298, 66);
            this.btnPValider.Name = "btnPValider";
            this.btnPValider.Size = new System.Drawing.Size(101, 30);
            this.btnPValider.TabIndex = 4;
            this.btnPValider.Text = "Lancer la partie";
            this.btnPValider.UseVisualStyleBackColor = true;
            this.btnPValider.Click += new System.EventHandler(this.btnPValider_Click);
            // 
            // txtWinner
            // 
            this.txtWinner.AutoSize = true;
            this.txtWinner.Location = new System.Drawing.Point(95, 136);
            this.txtWinner.Name = "txtWinner";
            this.txtWinner.Size = new System.Drawing.Size(52, 13);
            this.txtWinner.TabIndex = 5;
            this.txtWinner.Text = "gagnant :";
            // 
            // txtMeilleurMot
            // 
            this.txtMeilleurMot.AutoSize = true;
            this.txtMeilleurMot.Location = new System.Drawing.Point(95, 164);
            this.txtMeilleurMot.Name = "txtMeilleurMot";
            this.txtMeilleurMot.Size = new System.Drawing.Size(69, 13);
            this.txtMeilleurMot.TabIndex = 6;
            this.txtMeilleurMot.Text = "Meilleur mot :";
            // 
            // txtListeMots
            // 
            this.txtListeMots.AutoSize = true;
            this.txtListeMots.Location = new System.Drawing.Point(97, 222);
            this.txtListeMots.Name = "txtListeMots";
            this.txtListeMots.Size = new System.Drawing.Size(80, 13);
            this.txtListeMots.TabIndex = 7;
            this.txtListeMots.Text = "Liste des mots :";
            // 
            // txtManche
            // 
            this.txtManche.AutoSize = true;
            this.txtManche.Location = new System.Drawing.Point(603, 127);
            this.txtManche.Name = "txtManche";
            this.txtManche.Size = new System.Drawing.Size(78, 13);
            this.txtManche.TabIndex = 8;
            this.txtManche.Text = "Manche 0 / 10";
            // 
            // txtScoreP1
            // 
            this.txtScoreP1.AutoSize = true;
            this.txtScoreP1.Location = new System.Drawing.Point(560, 289);
            this.txtScoreP1.Name = "txtScoreP1";
            this.txtScoreP1.Size = new System.Drawing.Size(91, 13);
            this.txtScoreP1.TabIndex = 9;
            this.txtScoreP1.Text = "Score du joueur 1";
            // 
            // txtScoreP2
            // 
            this.txtScoreP2.AutoSize = true;
            this.txtScoreP2.Location = new System.Drawing.Point(560, 320);
            this.txtScoreP2.Name = "txtScoreP2";
            this.txtScoreP2.Size = new System.Drawing.Size(91, 13);
            this.txtScoreP2.TabIndex = 10;
            this.txtScoreP2.Text = "Score du joueur 2";
            // 
            // txtSelectPlayer
            // 
            this.txtSelectPlayer.AutoSize = true;
            this.txtSelectPlayer.Location = new System.Drawing.Point(305, 136);
            this.txtSelectPlayer.Name = "txtSelectPlayer";
            this.txtSelectPlayer.Size = new System.Drawing.Size(94, 26);
            this.txtSelectPlayer.TabIndex = 11;
            this.txtSelectPlayer.Text = "Choisissez un nom\r\net lancer la partie !";
            this.txtSelectPlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMotEnter
            // 
            this.txtMotEnter.AutoSize = true;
            this.txtMotEnter.Location = new System.Drawing.Point(274, 192);
            this.txtMotEnter.Name = "txtMotEnter";
            this.txtMotEnter.Size = new System.Drawing.Size(147, 13);
            this.txtMotEnter.TabIndex = 12;
            this.txtMotEnter.Text = "Entre un mot avec les lettres: ";
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(298, 311);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(101, 30);
            this.btnValider.TabIndex = 13;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // tbMot
            // 
            this.tbMot.Enabled = false;
            this.tbMot.Location = new System.Drawing.Point(274, 270);
            this.tbMot.Name = "tbMot";
            this.tbMot.Size = new System.Drawing.Size(147, 20);
            this.tbMot.TabIndex = 14;
            this.tbMot.TextChanged += new System.EventHandler(this.tbMot_TextChanged);
            // 
            // tbScoreP1
            // 
            this.tbScoreP1.Enabled = false;
            this.tbScoreP1.Location = new System.Drawing.Point(657, 286);
            this.tbScoreP1.Name = "tbScoreP1";
            this.tbScoreP1.Size = new System.Drawing.Size(41, 20);
            this.tbScoreP1.TabIndex = 22;
            // 
            // tbScoreP2
            // 
            this.tbScoreP2.Enabled = false;
            this.tbScoreP2.Location = new System.Drawing.Point(657, 317);
            this.tbScoreP2.Name = "tbScoreP2";
            this.tbScoreP2.Size = new System.Drawing.Size(41, 20);
            this.tbScoreP2.TabIndex = 23;
            // 
            // tbMeilleurMot
            // 
            this.tbMeilleurMot.Enabled = false;
            this.tbMeilleurMot.Location = new System.Drawing.Point(87, 189);
            this.tbMeilleurMot.Name = "tbMeilleurMot";
            this.tbMeilleurMot.Size = new System.Drawing.Size(90, 20);
            this.tbMeilleurMot.TabIndex = 24;
            // 
            // lbMots
            // 
            this.lbMots.FormattingEnabled = true;
            this.lbMots.Location = new System.Drawing.Point(73, 241);
            this.lbMots.Name = "lbMots";
            this.lbMots.Size = new System.Drawing.Size(120, 108);
            this.lbMots.TabIndex = 25;
            // 
            // btnChar1
            // 
            this.btnChar1.Enabled = false;
            this.btnChar1.Location = new System.Drawing.Point(244, 222);
            this.btnChar1.Name = "btnChar1";
            this.btnChar1.Size = new System.Drawing.Size(24, 24);
            this.btnChar1.TabIndex = 26;
            this.btnChar1.UseVisualStyleBackColor = true;
            this.btnChar1.Click += new System.EventHandler(this.btnChar1_Click);
            // 
            // btnChar2
            // 
            this.btnChar2.Enabled = false;
            this.btnChar2.Location = new System.Drawing.Point(274, 222);
            this.btnChar2.Name = "btnChar2";
            this.btnChar2.Size = new System.Drawing.Size(24, 24);
            this.btnChar2.TabIndex = 27;
            this.btnChar2.UseVisualStyleBackColor = true;
            this.btnChar2.Click += new System.EventHandler(this.btnChar2_Click);
            // 
            // btnChar3
            // 
            this.btnChar3.Enabled = false;
            this.btnChar3.Location = new System.Drawing.Point(304, 222);
            this.btnChar3.Name = "btnChar3";
            this.btnChar3.Size = new System.Drawing.Size(24, 24);
            this.btnChar3.TabIndex = 28;
            this.btnChar3.UseVisualStyleBackColor = true;
            this.btnChar3.Click += new System.EventHandler(this.btnChar3_Click);
            // 
            // btnChar4
            // 
            this.btnChar4.Enabled = false;
            this.btnChar4.Location = new System.Drawing.Point(334, 222);
            this.btnChar4.Name = "btnChar4";
            this.btnChar4.Size = new System.Drawing.Size(24, 24);
            this.btnChar4.TabIndex = 29;
            this.btnChar4.UseVisualStyleBackColor = true;
            this.btnChar4.Click += new System.EventHandler(this.btnChar4_Click);
            // 
            // btnChar5
            // 
            this.btnChar5.Enabled = false;
            this.btnChar5.Location = new System.Drawing.Point(364, 222);
            this.btnChar5.Name = "btnChar5";
            this.btnChar5.Size = new System.Drawing.Size(24, 24);
            this.btnChar5.TabIndex = 30;
            this.btnChar5.UseVisualStyleBackColor = true;
            this.btnChar5.Click += new System.EventHandler(this.btnChar5_Click);
            // 
            // btnChar6
            // 
            this.btnChar6.Enabled = false;
            this.btnChar6.Location = new System.Drawing.Point(394, 222);
            this.btnChar6.Name = "btnChar6";
            this.btnChar6.Size = new System.Drawing.Size(24, 24);
            this.btnChar6.TabIndex = 31;
            this.btnChar6.UseVisualStyleBackColor = true;
            this.btnChar6.Click += new System.EventHandler(this.btnChar6_Click);
            // 
            // btnChar7
            // 
            this.btnChar7.Enabled = false;
            this.btnChar7.Location = new System.Drawing.Point(424, 222);
            this.btnChar7.Name = "btnChar7";
            this.btnChar7.Size = new System.Drawing.Size(24, 24);
            this.btnChar7.TabIndex = 32;
            this.btnChar7.UseVisualStyleBackColor = true;
            this.btnChar7.Click += new System.EventHandler(this.btnChar7_Click);
            // 
            // FrmScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 361);
            this.Controls.Add(this.btnChar7);
            this.Controls.Add(this.btnChar6);
            this.Controls.Add(this.btnChar5);
            this.Controls.Add(this.btnChar4);
            this.Controls.Add(this.btnChar3);
            this.Controls.Add(this.btnChar2);
            this.Controls.Add(this.btnChar1);
            this.Controls.Add(this.lbMots);
            this.Controls.Add(this.tbMeilleurMot);
            this.Controls.Add(this.tbScoreP2);
            this.Controls.Add(this.tbScoreP1);
            this.Controls.Add(this.tbMot);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtMotEnter);
            this.Controls.Add(this.txtSelectPlayer);
            this.Controls.Add(this.txtScoreP2);
            this.Controls.Add(this.txtScoreP1);
            this.Controls.Add(this.txtManche);
            this.Controls.Add(this.txtListeMots);
            this.Controls.Add(this.txtMeilleurMot);
            this.Controls.Add(this.txtWinner);
            this.Controls.Add(this.btnPValider);
            this.Controls.Add(this.tbP2);
            this.Controls.Add(this.tbP1);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtP1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmScrabble";
            this.Text = "JEU DU SCRABBLE - MODE 2 JOUEURS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label txtP1;
        private System.Windows.Forms.Label txtP2;
        private System.Windows.Forms.TextBox tbP1;
        private System.Windows.Forms.TextBox tbP2;
        private System.Windows.Forms.Button btnPValider;
        private System.Windows.Forms.Label txtWinner;
        private System.Windows.Forms.Label txtMeilleurMot;
        private System.Windows.Forms.Label txtListeMots;
        private System.Windows.Forms.Label txtManche;
        private System.Windows.Forms.Label txtScoreP1;
        private System.Windows.Forms.Label txtScoreP2;
        private System.Windows.Forms.Label txtSelectPlayer;
        private System.Windows.Forms.Label txtMotEnter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox tbMot;
        private System.Windows.Forms.TextBox tbScoreP1;
        private System.Windows.Forms.TextBox tbScoreP2;
        private System.Windows.Forms.TextBox tbMeilleurMot;
        private System.Windows.Forms.ListBox lbMots;
        private System.Windows.Forms.Button btnChar1;
        private System.Windows.Forms.Button btnChar2;
        private System.Windows.Forms.Button btnChar3;
        private System.Windows.Forms.Button btnChar4;
        private System.Windows.Forms.Button btnChar5;
        private System.Windows.Forms.Button btnChar6;
        private System.Windows.Forms.Button btnChar7;
    }
}

