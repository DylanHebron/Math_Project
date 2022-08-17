using System.Media;
namespace MathProject
{
    
    public partial class Form1 : Form
    {
        //variables for whole game
        int life;
        int streak;
        int number1;
        int number2;
        int number3;
        int questionAnswer;
        int seconds;
        string name;
        string question;
        

        //variable objects
        SoundPlayer soundPlayerMusic = new SoundPlayer("music_zapsplat_astro_race.wav");
        SoundPlayer soundPlayCheer = new SoundPlayer("human_crowd_approx_150_people_cheer_indoors.wav");
        SoundPlayer soundPlayLoss = new SoundPlayer("sound_ex_machina_small_female_group_of_10_people_shouting_aaaah_with_disappointment._unison_663.wav");
        Random randomNumber = new Random();

        public Form1()
        {
            InitializeComponent();

            //make tab headings invisible
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;

            //play game music
            soundPlayerMusic.PlayLooping();
        }        

        //Events for changing tabs
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabGameSettings;    
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabRules;
        }

        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabScoreBoard;
            lsbScore.Sorted = true;

        }

        private void btnBackRules_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabHome;
        }

        private void btnBackScore_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabHome;
        }

        private void btnBackSettings_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabHome;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {            
            soundPlayerMusic.PlayLooping();
            timer1.Enabled = false;
            lsbScore.Items.Add("Name: " + name + " Streak: " + streak);
            tabControl.SelectedTab = tabHome; 
        }

        //Method for working out question and answer
        private void calcSum()
        {
            //variables
            int index;
            int index2;
            question = "";
            questionAnswer = 0;

            //input
            number1 = randomNumber.Next(0, 10);
            number2 = randomNumber.Next(0, 10);
            number3 = randomNumber.Next(0, 10);

            string[] operatorsString = {"-", "+", "*"};
      
            //process
            if (cbxDifficulty.SelectedItem == "Easy")
            {
                if (cbxTypeOfMath.SelectedItem == "Addition")
                {
                    question = number1 + "+" + number2;
                    questionAnswer = number1 + number2;                    
                }
                else if (cbxTypeOfMath.SelectedItem == "Subtraction")
                {
                    question = number1 + "-" + number2;
                    questionAnswer = number1 - number2;
                }
                else if (cbxTypeOfMath.SelectedItem == "Multiplication")
                {
                    question = number1 + "*" + number2;
                    questionAnswer = number1 * number2;                    
                }
                else if (cbxTypeOfMath.SelectedItem == "Mixed")
                {
                    index = randomNumber.Next(1, 4);

                    switch (index)
                    {
                        case 1:
                            question = number1 + "+" + number2;
                            questionAnswer = number1 + number2;
                            break;
                        case 2:
                            question = number1 + "-" + number2;
                            questionAnswer = number1 - number2;
                            break;
                        case 3:
                            question = number1 + "*" + number2;
                            questionAnswer = number1 * number2;
                            break;
                    }
                }
            }
            else if (cbxDifficulty.SelectedItem == "Hard")
            {
                if (cbxTypeOfMath.SelectedItem == "Addition")
                {
                    question = number1 + "+" + number2 + "+" + number3;
                    questionAnswer = number1 + number2 + number3;
                }
                else if (cbxTypeOfMath.SelectedItem == "Subtraction")
                {
                    question = number1 + "-" + number2 + "-" + number3;
                    questionAnswer = number1 - number2 - number3;
                }
                else if (cbxTypeOfMath.SelectedItem == "Multiplication")
                {
                    question = number1 + "*" + number2 + "*" + number3;
                    questionAnswer = number1 * number2 * number3;
                }
                else if (cbxTypeOfMath.SelectedItem == "Mixed")
                {
                    //random index in array
                    index = randomNumber.Next(0, 3);
                    index2 = randomNumber.Next(0, 3);                                      
                    
                    question = number1 +operatorsString[index]+ number2 +operatorsString[index2]+ number3;
                    
                    if(operatorsString[index] == "*")
                    {
                        questionAnswer = number1 * number2;
                    }
                    else if(operatorsString[index] == "+")
                    {
                        questionAnswer = number1 + number2;       
                    }
                    else
                    {
                        questionAnswer = number1 - number2;           
                    }

                    if(operatorsString[index2] == "*")
                    {
                        questionAnswer *= number3;
                    }
                    else if(operatorsString[index2] == "+")
                    {
                        questionAnswer += number3;
                    }
                    else
                    {
                        questionAnswer -= number3;    
                    }
                }
            }
            txtQuestion.Text = question;
            timer1.Enabled = true;
        }//end of method

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            //input
            life = 3;
            streak = 0;
            seconds = 60;

            lblLife.Text = life.ToString();
            lblStreak.Text = streak.ToString();
            

            //process
            if (cbxDifficulty.SelectedItem == null || cbxTypeOfMath.SelectedItem == null || txtName.Text == "")
            {               
                MessageBox.Show("You need to select difficulty, type of math and name");
            }
            else
            {
                soundPlayerMusic.Stop();
                tabControl.SelectedTab = tabGame;   //change settings panel to game panel
                calcSum();               
            }
            
        }//end of startGameMethod

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(seconds >= 0)
            {
                lblTimer.Text = Convert.ToString(seconds);                
            }
            else
            {
                timer1.Stop();
                life--;
                lblLife.Text = life.ToString();
                soundPlayLoss.Play();
                MessageBox.Show("Time has finished");              
                checkIfDead();
            }
            seconds--;
        }//end of timer tick method
        
        private void checkIfDead()
        {
            //input
            name = txtName.Text;

            //process
            if (life == 0)
            {
                MessageBox.Show("You have died");
                lsbScore.Items.Add("Name: " + name + " Streak: " + streak);
                tabControl.SelectedTab = tabHome;
                soundPlayerMusic.PlayLooping();
            }
            else
            {
                //variables
                seconds = 60;
                txtAnswer.Text = "";

                //process
                timer1.Start();
                calcSum();
            }
        }//end of checkIfDead method

        private void checkCorrectAnswer()
        {

            //variables               
            bool flag = false;
            int answerInput = 0;

            //input            
            flag = int.TryParse(txtAnswer.Text, out answerInput);

            //process
            if (answerInput == questionAnswer)
            {
                streak++;
                lblStreak.Text = streak.ToString();
                soundPlayCheer.Play();
                MessageBox.Show("Correct!!");
            }
            else
            {
                life--;
                lblLife.Text = life.ToString();
                soundPlayLoss.Play();
                MessageBox.Show("Incorrect!!");
            }

        }//end of checkCorrect method

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //variables    
            bool flag = false;
            int answerInput = 0;

            //input            
            flag = int.TryParse(txtAnswer.Text, out answerInput);
            timer1.Stop();
            
            //process
            if (!flag)
            {
                MessageBox.Show("You must enter a number not text");
                timer1.Start();
            }
            else
            {
                timer1.Enabled = false;
                checkCorrectAnswer();
                checkIfDead();
            }
            
        }//end of submit event
       
    }//end of class

}//enf of project