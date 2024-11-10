using Microsoft.VisualBasic.ApplicationServices;
using MinesweeperClasses;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;


namespace MineSweeperGUI
{
    public partial class Form1 : Form
    {
        //instance of the Baord class used to manage the game data
        Board board;
        //2D array of buttons used to represent the game board in the GUI
        Button[,] buttons;
        //reference to FormStartGame
        private FormStartGame formStartGame;
        int difficulty = 0;
        int elapsed = 0;
        int timeScore = 0;
        int clickScore = 0;
        int winScore = 0;
        int score = 0;
        double duration = 0;

        //creating the player for the background music
        WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();

        //creating a player for the event music
        WMPLib.WindowsMediaPlayer eventPlayer = new WMPLib.WindowsMediaPlayer();


        private string calmMusic = @"C:\Users\kydec\Desktop\Lindsey School\CST - 250\Week 1\Milestone 1\MineSweeperGUI\Images\calm.mp3";
        private string technoMusic = @"C:\Users\kydec\Desktop\Lindsey School\CST - 250\Week 1\Milestone 1\MineSweeperGUI\Images\techno.mp3";
        private string clickMusic = @"C:\Users\kydec\Desktop\Lindsey School\CST - 250\Week 1\Milestone 1\MineSweeperGUI\Images\click.mp3";
        private string bombMusic = @"C:\Users\kydec\Desktop\Lindsey School\CST - 250\Week 1\Milestone 1\MineSweeperGUI\Images\bomb.mp3";
        private string flagMusic = @"C:\Users\kydec\Desktop\Lindsey School\CST - 250\Week 1\Milestone 1\MineSweeperGUI\Images\flag.mp3";
        private string winMusic = @"C:\Users\kydec\Desktop\Lindsey School\CST - 250\Week 1\Milestone 1\MineSweeperGUI\Images\win.mp3";



        public Form1(int size, int difficulty, FormStartGame formStartGame = null)
        {
            board = new Board(size, difficulty);
            InitializeComponent();
            //initialize the button array
            buttons = new Button[board.Size, board.Size];
            //setting initial timeScore based on the size of the board
            if (difficulty == 1)
            {
                timeScore = 150;
            }
            else if (difficulty == 2)
            {
                timeScore = 200;
            }
            else if (difficulty == 3)

            {
                timeScore = 250;
            }

            this.formStartGame = formStartGame;
            SetUpButtons();
            timer.Start();
            lblTime.Text = TimeSpan.FromSeconds(elapsed).ToString(@"hh\:mm\.ss");



        }
        //method to initialize the buttons on the board for the game play
        private void SetUpButtons()
        {
            //setting up the game boards grid of buttons based on the size of the board
            int buttonSize = panelGameBoard.Width / board.Size;
            //Making it be square
            panelGameBoard.Height = panelGameBoard.Width;

            //Creating buttons to fill the board
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    //creates the button and immediately places it
                    buttons[row, col] = new Button();
                    //Making it square
                    buttons[row, col].Width = buttonSize;
                    buttons[row, col].Height = buttonSize;
                    buttons[row, col].Left = col * buttonSize;
                    buttons[row, col].Top = row * buttonSize;
                    //creating an event for a button click
                    buttons[row, col].MouseDown += GridButtons_MouseDown;

                    //Tag will store the row and column of the button (can store any property)
                    buttons[row, col].Tag = new Point(row, col);
                    //add the button to the panel
                    buttons[row, col].BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Start.png");
                    buttons[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                    panelGameBoard.Controls.Add(buttons[row, col]);

                }
            }
        }
        //displaying or flaggin the specfici button that is clicked based on a right or left click as well as what the cell's value is
        private void GridButtons_MouseDown(object sender, MouseEventArgs e)
        {

            Button clickedButton = sender as Button;
            Point position = (Point)clickedButton.Tag;
            int row = position.X;
            int col = position.Y;
            Cell cell = board.Cells[row, col];
            clickScore = clickScore + 10;

            if (e.Button == MouseButtons.Right)
            {
                // play flag music
                eventPlayer.URL = flagMusic;
                eventPlayer.controls.play();

                cell.IsVisited = true;
                //take away flag if it was already flagged
                if (cell.IsFlag)
                {
                    
                    cell.IsFlag = false;
                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Start.png");
                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (cell.IsBomb)
                {
                    

                    cell.IsFlag = true;
                    cell.IsVisited = false;
                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Flag.png");
                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    cell.IsFlag = true;
                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Flag.png");
                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                }

            }
            else
            {
                if (clickedButton != null)
                {
                    if (!cell.IsVisited)
                    {
                        if (cell.IsBomb)
                        {
                            //play bomb music                            
                            eventPlayer.URL = bombMusic;
                            eventPlayer.controls.play();

                            timer.Stop();
                            clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Skull.png");
                            clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                            calculateScore();
                            MessageBox.Show("Boom! You lost.");
                            this.DialogResult = DialogResult.OK;
                            FormName frm = new FormName();
                            frm.ShowDialog();
                            string playerName = frm.nameInput;
                            duration = TimeSpan.ParseExact(lblTime.Text, @"hh\:mm\:ss", null).TotalSeconds;
                            FrmScores frmScore = new FrmScores(playerName, score, duration);
                            frmScore.ShowDialog();
                        }
                        else
                        {
                            eventPlayer.URL = clickMusic;
                            eventPlayer.controls.play();

                            if (cell.AdjacentBombs == 0)
                            {
                                board.FloodFill(row, col);
                                PrintFloodFill();
                            }
                            else
                            {
                                cell.IsVisited = true;
                                if (cell.AdjacentBombs == 1)
                                {
                                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\1.png");
                                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                                }
                                else if (cell.AdjacentBombs == 2)
                                {
                                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\2.png");
                                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                                }
                                else if (cell.AdjacentBombs == 3)
                                {
                                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\3.png");
                                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                                }
                                else if (cell.AdjacentBombs == 4)
                                {
                                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\4.png");
                                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                                }
                            }

                            // Check if the game is won
                            if (board.DetermineGameStatus(board, row, col) == 3)
                            {
                                if (difficulty == 1)
                                {
                                    winScore = 200;
                                }
                                else if (difficulty == 2)
                                {
                                    winScore = 400;
                                }
                                else if (difficulty == 3)
                                {
                                    winScore = 600;
                                }
                                //winning music
                                eventPlayer.URL = winMusic;
                                eventPlayer.controls.play();

                                timer.Stop();
                                calculateScore();
                                MessageBox.Show("Congratulations, you won!");
                                this.DialogResult = DialogResult.OK;

                                FormName frm = new FormName();
                                frm.ShowDialog();
                                string playerName = frm.nameInput;
                                duration = TimeSpan.ParseExact(lblTime.Text, @"hh\:mm\:ss", null).TotalSeconds;
                                FrmScores frmScore = new FrmScores(playerName, score, duration);
                                frmScore.ShowDialog();
                            }
                        }
                    }
                }
            }
        }
        //Clearing out the game and prompting the user to start a new game when the new game buttons is clicked
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            formStartGame.CreatingNewGame();

            this.Close();
        }

        //when a button is selected that is not a bomb and has no corresponding bombs, this method will reveal all of the buttons that are touching this button and the same.
        private void PrintFloodFill()
        {

            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    Cell cell = board.Cells[row, col];
                    if (cell.IsVisited && cell.AdjacentBombs == 0)
                    {
                        buttons[row, col].BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Tile .png");
                        buttons[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
        }
        //elapsing the timer and updating the total score based on the time it is taking the user to complete the game
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsed++;
            lblTime.Text = TimeSpan.FromSeconds(elapsed).ToString(@"hh\:mm\:ss");

            //for every 30 seconds that havce passed, the timescore is decreased by 10
            if (elapsed % 30 == 0)
            {
                timeScore = timeScore - 10;
            }

        }
        //Calculate the score when the game is won or lost
        private void calculateScore()
        {

            score = timeScore + winScore + clickScore;

        }
        //updating the game to have no sound if this is slected
        private void rBtnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnOff.Checked)
            {
                PlayMusic(null);
            }
        }

        //updating the sounds during game play to reflect the "origional" sounds
        private void rBtnCalm_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCalm.Checked)
            {
                PlayMusic(calmMusic);
            }
        }
        //updating the sounds during game play to reflect the "retro" sounds
        private void rBtnTechno_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTechno.Checked)
            {
                PlayMusic(technoMusic);
            }
        }
        private void PlayMusic(string musicPath)
        {
            mediaPlayer.controls.stop();

            if (!string.IsNullOrEmpty(musicPath))
            {
                mediaPlayer.URL = musicPath;
                mediaPlayer.controls.play();
            }
        }
    }

}

