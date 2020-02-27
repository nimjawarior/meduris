using System;
using System.Windows.Forms;

namespace TP1Luigi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Joueur[] tabJoueurs = new Joueur[3];
            InitializeComponent();
            GameState gameState = new GameState(tabJoueurs);
            this.panel1.BackColor = System.Drawing.Color.FromArgb((int)tabJoueurs[0].getRRgb(tabJoueurs[0]), (int)tabJoueurs[0].getGRgb(tabJoueurs[0]), (int)tabJoueurs[0].getBRgb(tabJoueurs[0]));
            this.panel2.BackColor = System.Drawing.Color.FromArgb((int)tabJoueurs[1].getRRgb(tabJoueurs[1]), (int)tabJoueurs[1].getGRgb(tabJoueurs[1]), (int)tabJoueurs[1].getBRgb(tabJoueurs[1]));
            this.panel3.BackColor = System.Drawing.Color.FromArgb((int)tabJoueurs[2].getRRgb(tabJoueurs[2]), (int)tabJoueurs[2].getGRgb(tabJoueurs[2]), (int)tabJoueurs[2].getBRgb(tabJoueurs[2]));
            gameState.GamePlay();
        }

    }
    public class GameState
    {
        int tour = 0;
        Joueur[] tabTempJoueurs = new Joueur[3];
        Cases[] ensembleCases = new Cases[32];
        Label label1 = new Label();
        ListBox listBox1 = new ListBox();
        Button button1 = new Button();
        Form formChoix = new Form();

        public GameState(Joueur[] tabJoueurs)
        {
            InitialiseJeu(tabJoueurs);
        }

        private void InitialiseJeu(Joueur[] tabJoueurs)
        {
            int j = 0;
            for (int i = 0; i < 3; i++)
            {
                label1.AutoSize = true;
                label1.Location = new System.Drawing.Point(12, 38);
                label1.Name = "label1";
                label1.Size = new System.Drawing.Size(209, 17);
                label1.TabIndex = 0;
                label1.Text = "Choisissez la couleur du Joueur" + (j + 1);
                label1.Size = new System.Drawing.Size(110, 20);

                listBox1.FormattingEnabled = true;
                listBox1.ItemHeight = 16;
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.AddRange(new object[] {
            "Rouge",
            "Vert Clair",
            "Violet",
            "Bleu"});
                }
                listBox1.Location = new System.Drawing.Point(15, 82);
                listBox1.Name = "listBox1";
                listBox1.Size = new System.Drawing.Size(188, 132);
                listBox1.TabIndex = 1;

                button1.Location = new System.Drawing.Point(216, 260);
                button1.Name = "button1";
                button1.Size = new System.Drawing.Size(103, 38);
                button1.TabIndex = 2;
                button1.Text = "Confirmer";
                button1.UseVisualStyleBackColor = true;
                button1.Click += new EventHandler(this.Button1_Click);
                button1.Text = "OK";

                formChoix.ClientSize = new System.Drawing.Size(347, 310);
                formChoix.Controls.Add(button1);
                formChoix.Controls.Add(listBox1);
                formChoix.Controls.Add(label1);
                formChoix.Name = "FormChoix";
                formChoix.Text = "Choix Couleur";
                formChoix.ControlBox = false;
                formChoix.ResumeLayout(false);
                formChoix.PerformLayout();


                formChoix.ShowDialog();
                j++;
            }
            InitialiserRessourcesParCases();
            tour = 0;
            tabJoueurs[0] = tabTempJoueurs[0];
            tabJoueurs[1] = tabTempJoueurs[1];
            tabJoueurs[2] = tabTempJoueurs[2];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Couleur couleur;
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                String option = listBox1.SelectedItems[i].ToString();
                switch (option)
                {
                    case "Rouge":
                        tabTempJoueurs[tour] = new Joueur(couleur = new Couleur(192, 0, 0));
                        break;
                    case "Vert Clair":
                        tabTempJoueurs[tour] = new Joueur(couleur = new Couleur(128, 255, 128));
                        break;
                    case "Violet":
                        tabTempJoueurs[tour] = new Joueur(couleur = new Couleur(128, 128, 255));
                        break;
                    case "Bleu":
                        tabTempJoueurs[tour] = new Joueur(couleur = new Couleur(0, 191, 255));
                        break;
                }
                tour++;
                listBox1.Items.Remove(option);
                formChoix.Close();
            }

        }
        

        private void InitialiserRessourcesParCases()//Cases cases
        {
            //case 0 à côté du druide. Faire chaque case à la fois.
            ensembleCases[0] = new Cases(1, 2);
            ensembleCases[1] = new Cases(3, 0);
            ensembleCases[2] = new Cases(1, 2);
            ensembleCases[3] = new Cases(0, 2);
            ensembleCases[4] = new Cases(3, 0);
            ensembleCases[5] = new Cases(0, 1);
            ensembleCases[6] = new Cases(2, 1);
            ensembleCases[7] = new Cases(0, 3);
            ensembleCases[8] = new Cases(3, 2);
            ensembleCases[9] = new Cases(1, 3);
            ensembleCases[10] = new Cases(2, 0);
            ensembleCases[11] = new Cases(2, 1);
            ensembleCases[12] = new Cases(3, 2);
            ensembleCases[13] = new Cases(1, 0);
            ensembleCases[14] = new Cases(0, 2);
            ensembleCases[15] = new Cases(3, 2);
            ensembleCases[16] = new Cases(0, 1);
            ensembleCases[17] = new Cases(3, 1);
            ensembleCases[18] = new Cases(3, 0);
            ensembleCases[19] = new Cases(1, 2);
            ensembleCases[20] = new Cases(0, 3);
            ensembleCases[21] = new Cases(1, 3);
            ensembleCases[22] = new Cases(0, 2);
            ensembleCases[23] = new Cases(0, 1);
            ensembleCases[24] = new Cases(2, 3);
            ensembleCases[25] = new Cases(0, 3);
            ensembleCases[26] = new Cases(1, 0);
            ensembleCases[27] = new Cases(2, 1);
            ensembleCases[28] = new Cases(2, 0);
            ensembleCases[29] = new Cases(1, 3);
            ensembleCases[30] = new Cases(3, 2);
            ensembleCases[31] = new Cases(1, 3);
        }
        public void GamePlay()
        {
            switch (tour)
            {
                case 0: //Joueur 1 //méthode pour faire une action attendre imput. Dépendamment imput = on fait action différente
                        //et on passe en paramètre le joueur. 
                    tour++;
                    break;
                case 1: //Joueur 2
                    tour++;
                    break;
                case 2: //Joueur 3
                    tour = 0;
                    break;
            }
            //avant de rappeler la méthode GamePlay, on fait le changement visuel.
            //rapelle GamePlay à la fin
        }
    }
    public class Cases
    {
        //case 0 : bois, case 1 : laine, case 2 : cuivre, case 3 : pierre
        int[] ressourcesNecessaire = new int[2];
        bool huttePresent = false;
        bool templePresent = false;
        public Cases(int ressource1, int ressource2)
        {
            ressourcesNecessaire[0] = ressource1;
            ressourcesNecessaire[1] = ressource2;
        }
    }
    public class Joueur
    {
        Couleur couleur;
        int[] ressources = new int[4];
        int templesDisponibles = 2;
        int huttesDisponibles = 8;
        int Pointage = 5;

        public Joueur(Couleur couleur)
        {
            this.couleur = couleur;
            ressources[0] = 1;
            ressources[1] = 1;
            ressources[2] = 1;
            ressources[3] = 1;
        }

        public float getRRgb(Joueur joueur)
        {
            return couleur.GetRRgb(joueur);
        }
        public float getGRgb(Joueur joueur)
        {
            return couleur.GetGRgb(joueur);
        }
        public float getBRgb(Joueur joueur)
        {
            return couleur.GetBRgb(joueur);
        }
    }

    public struct Couleur
    {
        float r;
        float g;
        float b;

        public Couleur(float r = 0, float g = 0, float b = 0)
        {
            this.r = r;
            this.g = g;
            this.b = b;

        }

        public float GetRRgb(Joueur joueur)
        {
            return r;
        }
        public float GetGRgb(Joueur joueur)
        {
            return g;
        }
        public float GetBRgb(Joueur joueur)
        {
            return b;
        }
    }
}
