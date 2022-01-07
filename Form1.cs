using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace SCRABBLE_SCHOOL_VERSION
{
    public partial class Form1 : Form
    {


       



        public static char[] CHARACTERS = { 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'C', 'D', 'D', 'D', 'D', 'E','E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'F', 'F', 'G', 'G', 'G', 'H', 'H', 'I','I', 'I', 'I', 'I', 'I', 'I', 'I', 'I', 'J', 'K', 'L', 'L', 'L', 'L', 'M', 'M', 'N', 'N', 'N', 'N', 'N', 'N', 'O','O', 'O', 'O', 'O', 'O', 'O', 'O', 'P', 'P', 'Q', 'R', 'R', 'R', 'R', 'R', 'R', 'S', 'S', 'S', 'S', 'T', 'T', 'T', 'T', 'T', 'T', 'U', 'U', 'U', 'U', 'V', 'V', 'W', 'W', 'X', 'Y','Y', 'Z',};
        

        static Random Rand = new Random();
        System.Media.SoundPlayer Player = new System.Media.SoundPlayer();
        



        static int NEWletter = Rand.Next(CHARACTERS.Length);
        static int NEWletterB = Rand.Next(CHARACTERS.Length);
        static int NEWletterC = Rand.Next(CHARACTERS.Length);
        static int NEWletterD = Rand.Next(CHARACTERS.Length);
        static int NEWletterE = Rand.Next(CHARACTERS.Length);
        static int NEWletterF = Rand.Next(CHARACTERS.Length);
        static int NEWletterG = Rand.Next(CHARACTERS.Length);

        int score = 0;




        static bool USERNAMEPASS = false;


        

        // FUNCTIONS/SUBROUTINES -----------------------------------------------------------------------------------------------


        // Letter picker code
        //The code below randomises the character array
        public static void LETTERPICK()
        {

            for (int i = 0; i < CHARACTERS.Length - 1; i++)
            {
                int j = Rand.Next(i, CHARACTERS.Length);

                char temp = CHARACTERS[i];

                CHARACTERS[i] = CHARACTERS[j];
                CHARACTERS[j] = temp;
            }

        }


       

        private int SCORESYS(string Userword)
        {
            int WORDscore = 0;
            for (int i = 0; i < Userword.Length; i++)
                {
                    if (Userword[i] == 'A' || Userword[i] =='E' || Userword[i] == 'I' || Userword[i] == 'L' || Userword[i] == 'N' || Userword[i] == 'O' || Userword[i] == 'R' || Userword[i] == 'S' || Userword[i] == 'T' || Userword[i] == 'U')
                    {
                        WORDscore += 1;
                     
                    }

                    if (Userword[i] == 'D'|| Userword[i] == 'G')
                    {
                        WORDscore += 2;
                  
                    }

                    if (Userword[i] == 'B' || Userword[i] == 'C' || Userword[i] == 'M' || Userword[i] == 'P')
                    {
                        WORDscore += 3;
                    
                    }

                    if (Userword[i] == 'F' || Userword[i] == 'H' || Userword[i] == 'V' || Userword[i] == 'W' || Userword[i] == 'Y')
                    {
                        WORDscore += 4;
                    
                    }

                    if (Userword[i] == 'K')
                    {
                        WORDscore += 5;
                    
                    }

                    if (Userword[i] == 'J' || Userword[i] == 'X')
                    {
                        WORDscore += 8;
                  
                    }

                    if (Userword[i] == 'Q' || Userword[i] == 'Z')
                    {
                        WORDscore += 10;

                    }

            }


            return WORDscore;
           
            
        }





        // INITIALISE COMPONENT - START BUTTON - QUICK BUTTON - USERNAME BUTTON ----------------------------------------------------------------

        // Initialise component
        public Form1()
        {
            InitializeComponent();

           

            MAINBOX.Enabled = false;
            START.Enabled = false;

            Player.SoundLocation = @"MUSIC.wav";
            Player.PlayLooping();


        }


        //Start Component
        private void START_Click(object sender, EventArgs e)
        {

            if (USERNAMEPASS = true)
            {
                MessageBox.Show("HELLO YOU FATTY CAN'T BE BOTHERED TO GET OFF YOUR COMPUTER TO PLAY SCRABBLE I SEE");



                START.Enabled = false;
                MAINBOX.Enabled = true;

                LETTERPICK();


                for (int a = 0; a < 1; a++)
                {



                    A.Text = CHARACTERS[NEWletter].ToString();
                    B.Text = CHARACTERS[NEWletterB].ToString();
                    C.Text = CHARACTERS[NEWletterC].ToString();
                    D.Text = CHARACTERS[NEWletterD].ToString();
                    E.Text = CHARACTERS[NEWletterE].ToString();
                    F.Text = CHARACTERS[NEWletterF].ToString();
                    G.Text = CHARACTERS[NEWletterG].ToString();

                    A.Enabled = true;
                    B.Enabled = true;
                    C.Enabled = true;
                    D.Enabled = true;
                    E.Enabled = true;
                    F.Enabled = true;
                    G.Enabled = true;

                    
                    if (ENLETTER.Text.Length > 8)
                    {
                        ENLETTER.Text = "";
                    }
                }


               

            }

            
            
        }



        // quit component
        private void QUIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // USERNAME ENTER BUTTON
        private void Button2_Click(object sender, EventArgs e)
        {
            string UsernamePath = @"USERNAMES.txt";

            string[] USERNAMES = File.ReadAllLines(UsernamePath);



            if (USERNAMES.Contains(USERNAME.Text))
            {
                foreach (string line in File.ReadLines(@"USERNAMES.txt"))
                {
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    if (line.Contains(USERNAME.Text))
                    {
                        PlayerUsername.Text = line + " - ";

                       
                       START.Enabled = true;

                        MessageBox.Show("Your File has been extracted!");

                        LOGINANDUSERNAME.Visible = false;
                       break;


                    }



                }

            }
            else if (!USERNAMES.Contains(USERNAME.Text))
            {


                PlayerUsername.Text = USERNAME.Text + " - ";
               
                START.Enabled = true;

                LOGINANDUSERNAME.Visible = false;


                MessageBox.Show("Your Username is now " + USERNAME.Text);

                string[] TextToSave = { USERNAME.Text };

                File.AppendAllLines("USERNAMES.txt", TextToSave);




            }

        }








            // BUTTON OPERATIONS ---------------------------------------------------------------------------------------------------



        private void A_Click(object sender, EventArgs e)
        {
            ENLETTER.Text += A.Text;
            

            A.Enabled = false;

           char LetteA = char.Parse(A.Text);
        }

        private void B_Click(object sender, EventArgs e)
        {
            ENLETTER.Text += B.Text;
            

            B.Enabled = false;

            char LetteA = char.Parse(B.Text);
        }

        private void C_Click(object sender, EventArgs e)
        {
            ENLETTER.Text += C.Text;
           

            C.Enabled = false;


        }

        private void D_Click(object sender, EventArgs e)
        {
            ENLETTER.Text += D.Text;
           

            D.Enabled = false;
        }

        private void E_Click(object sender, EventArgs e)
        {
            ENLETTER.Text += E.Text;
           

            E.Enabled = false;
        }

        private void F_Click(object sender, EventArgs e)
        {
            ENLETTER.Text += F.Text;
           

            F.Enabled = false;
        }

        private void G_Click(object sender, EventArgs e)
        {
            ENLETTER.Text += G.Text;
            

            G.Enabled = false;

            
            

        }


       



        // Enter button - Clear button - Refill Button - Username Button ---------------------------------------------------------------


       
        // When you click the enter button
        private void Button9_Click(object sender, EventArgs e)
        {
            // Reads File
            string filepath = @"WORDS.txt";

            string[] WORDS = File.ReadAllLines(filepath);


            // Word checker system - If word exists it will execute this code below
            if (WORDS.Contains(ENLETTER.Text))
            {
               
                MessageBox.Show("Well Done, That is a word! Farhan will now bless you!");

                WELDONE.Visible = true;

                System.Threading.Thread.Sleep(2000);

                WELDONE.Visible = false;




                string UserWord = ENLETTER.Text;


                score = score += SCORESYS(UserWord);
                MAINSCORE.Text = "SCORE: " + score;

                PlayerUsername.Text = USERNAME.Text + "-" + score;

                CorrectWords.Items.Add(ENLETTER.Text);
                ENLETTER.Text = "";

                


            }
            else
            {

                // If word does not exist
                MessageBox.Show("Dumbass not real word");

                ENLETTER.Text = "";

                LETTERPICK();

               

                A.Enabled = true;
                B.Enabled = true;
                C.Enabled = true;
                D.Enabled = true;
                E.Enabled = true;
                F.Enabled = true;
                G.Enabled = true;

            }

            
            

        }




        // When you click the clear button
        private void CLEAR_Click(object sender, EventArgs e)
        {
            ENLETTER.Text = "";

            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            E.Enabled = true;
            F.Enabled = true;
            G.Enabled = true;
        }







        // Refill Button
        private void REFILLSET_Click(object sender, EventArgs e)
        {
            LETTERPICK();
           


            A.Text = CHARACTERS[NEWletter].ToString();
            B.Text = CHARACTERS[NEWletterB].ToString();
            C.Text = CHARACTERS[NEWletterC].ToString();
            D.Text = CHARACTERS[NEWletterD].ToString();
            E.Text = CHARACTERS[NEWletterE].ToString();
            F.Text = CHARACTERS[NEWletterF].ToString();
            G.Text = CHARACTERS[NEWletterG].ToString();

            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            E.Enabled = true;
            F.Enabled = true;
            G.Enabled = true;

            ENLETTER.Text = "";
            
        }

        private void RESTORE_Click(object sender, EventArgs e)
        {
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            E.Enabled = true;
            F.Enabled = true;
            G.Enabled = true;

            ENLETTER.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Player.Stop();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
        }
    }





}


   































        
    
