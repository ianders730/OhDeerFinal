using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhDeer1
{
    public partial class Game : Form
    {
        //C O N S T R U C T O R\\
        public Game()
        {
            InitializeComponent();
        }

        //P R O P E R T I E S\\
        
        public Player Deer { get; set; }
        //Cars is the garage of the list of Car objects
        public List<Car> Cars { get; set; }
        public List<Border> gameBorder { get; set; }
        public Coin BonusPoints { get; set; } 
        //Tests
        public List<Freeway> Road { get; set; }
        public List<Water> Pond { get; set; }
        public List<Coin> Coins { get; set; }
        public GrassBackground Background { get; set; }
        public int numberOfLives = 3;
        public int level = 1;
        private int score = 0;
        public bool isPlaying = true;
        private static Random randomGenerator = new Random();
        private DateTime gameTime = DateTime.Now;
        //Lanes list containts the four y coordinates coorsponding with each lane.
        public List<int> Lanes { get; set; }
        
        //private bool invalidated = true;

        //M E T H O D S\\

        //G A M E  L O A D\\
        private void Game_Load(object sender, EventArgs e)
        {
            //B O R D E R\\
            gameBorder = new List<Border>();
            gameBorder.Add(new Border(Height, Width, 0, 0));
            gameBorder.Add(new Border(Height, Width, 760, 0));
            for (int i = 0; i < gameBorder.Count; i++)
            {
                Controls.Add(gameBorder[i]);
            }
            //D E E R\\
            Deer = new Player(Height, Width, numberOfLives);
            Controls.Add(Deer);
            //C A R S\\
            Cars = new List<Car>();
            Cars.Add(new Car(Height, Width, 400, 75));
            Cars.Add(new Car(Height, Width, 300, 125));
            Cars.Add(new Car(Height, Width, 350, 275));
            Cars.Add(new Car(Height, Width, 250, 325));
            Cars.Add(new Car(Height, Width, 200, 75));
            Cars.Add(new Car(Height, Width, 150, 275));
            Cars.Add(new Car(Height, Width, 0, 125));
            Cars.Add(new Car(Height, Width, 0, 325));
            Cars.Add(new Car(Height, Width, 0, 75));
            Cars.Add(new Car(Height, Width, 0, 275));
            for (int i = 0; i < Cars.Count; i++)
            {
                Controls.Add(Cars[i]);
            }
            //R O A D\\

            Road = new List<Freeway>();
            Road.Add(new Freeway(Height, Width, 1, 75 ));
            Road.Add(new Freeway(Height, Width, 1, 275));
            for (int i = 0; i < Road.Count; i++)
            {
                Controls.Add(Road[i]);
            }
          
            //C O I N S\\
            Coins = new List<Coin>();
            Coins.Add(new Coin(Height, Width, 300, 200));
            Coins.Add(new Coin(Height, Width, 600, 20));
            for (int i = 0; i < Coins.Count; i++)
            {
                Controls.Add(Coins[i]);
            }
            //W A T E R\\
            Pond = new List<Water>();
            Pond.Add(new Water(Height, Width, 100, 200)); //Make x and y coords random numbers within range
            Pond.Add(new Water(Height, Width, 500, 20));
            for (int i = 0; i < Pond.Count; i++)
            {
                Controls.Add(Pond[i]);
            }
            //G R A S S  B A C K G R O U N D\\ 
            Background = new GrassBackground(Height, Width, 1, 1);
            Controls.Add(Background);
            //G A M E  T I M E R  E N A B L E D\\
            GameTimer.Enabled = true;
           
            //Restart Level\\
            
        }





        //G A M E  T I M E R




        int randomDelay1 = randomGenerator.Next(0, 1000);
        int randomDelay2 = randomGenerator.Next(1000, 1500);
        int randomDelay3 = randomGenerator.Next(2000, 2200);
        int randomDelay4 = randomGenerator.Next(2050, 2300);
        //ADDS ELEMENTS TO FORM
        // private DateTime gameTime = DateTime.Now;
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            int randomLane = randomGenerator.Next(0, 4);
            //6 cars start spread out on board when game starts, 
            //then the four others start at x = 0(under left border) and each start moving at a random time between 0 and 2 seconds.
            for (int i = 0; i < 4; i++)
            {
                if (DateTime.Now.Subtract(gameTime) > TimeSpan.FromMilliseconds(0))
                {
                    if (level == 1)
                    {
                        Cars[i].DriveBy1();
                        CarReset(randomLane);
                    }
                    else if (level == 2)
                    {
                        Cars[i].DriveBy2();
                        CarReset(randomLane);
                    }
                    else if (level == 3)
                    {
                        Cars[i].DriveBy3();
                        CarReset(randomLane);
                    }
                }
            }
           
            if (DateTime.Now.Subtract(gameTime) > TimeSpan.FromMilliseconds(0))
            {
                if (level == 1)
                {
                    Cars[4].DriveBy1();
                    CarReset(randomLane);
                }
                else if (level == 2)
                {
                    Cars[4].DriveBy2();
                    CarReset(randomLane);
                }
                else if (level == 3)
                {
                    Cars[4].DriveBy3();
                    CarReset(randomLane);
                }
            }
            if (DateTime.Now.Subtract(gameTime) > TimeSpan.FromMilliseconds(0))
            {
                if (level == 1)
                {
                    Cars[5].DriveBy1();
                    CarReset(randomLane);
                }
                else if (level == 2)
                {
                    Cars[5].DriveBy2();
                    CarReset(randomLane);
                }
                else if (level == 3)
                {
                    Cars[5].DriveBy3();
                    CarReset(randomLane);
                }
            }
            if (DateTime.Now.Subtract(gameTime) > TimeSpan.FromMilliseconds(randomDelay1))
            {
                if (level == 1)
                {
                    Cars[6].DriveBy1();
                    CarReset(randomLane);
                }
                else if (level == 2)
                {
                    Cars[6].DriveBy2();
                    CarReset(randomLane);
                }
                else if (level == 3)
                {
                    Cars[6].DriveBy3();
                    CarReset(randomLane);
                }
            }
            if (DateTime.Now.Subtract(gameTime) > TimeSpan.FromMilliseconds(randomDelay2))
            {
                if (level == 1)
                {
                    Cars[7].DriveBy1();
                    CarReset(randomLane);
                }
                else if (level == 2)
                {
                    Cars[7].DriveBy2();
                    CarReset(randomLane);
                }
                else if (level == 3)
                {
                    Cars[7].DriveBy3();
                    CarReset(randomLane);
                }
            }
            if (DateTime.Now.Subtract(gameTime) > TimeSpan.FromMilliseconds(randomDelay3))
            {
                if (level == 1)
                {
                    Cars[8].DriveBy1();
                    CarReset(randomLane);
                }
                else if (level == 2)
                {
                    Cars[8].DriveBy2();
                    CarReset(randomLane);
                }
                else if (level == 3)
                {
                    Cars[8].DriveBy3();
                    CarReset(randomLane);
                }
            }
            if (DateTime.Now.Subtract(gameTime) > TimeSpan.FromMilliseconds(randomDelay4))
            {
                if (level == 1)
                {
                    Cars[9].DriveBy1();
                    CarReset(randomLane);
                }
                else if (level == 2)
                {
                    Cars[9].DriveBy2();
                    CarReset(randomLane);
                }
                else if (level == 3)
                {
                    Cars[9].DriveBy3();
                    CarReset(randomLane);
                }
            }
            //Tests to see if the player runs into any cars
            var roadKill = from vehicle in Cars
                              where vehicle.HitTest(Deer.Bounds)
                              select vehicle;
            var crashList = roadKill.ToList();
            //When a player hits a car, the player is reset to the start point and loses a life.
            //There will also be a message telling the player how many lives they have left.
           foreach (var vehicle in crashList)
           {
               numberOfLives--;
               Deer.PlayerReset();
                if (numberOfLives > 0)
                {
                    if (numberOfLives == 2)
                    {
                        MessageBox.Show($"You were hit! You now have 2 lives remaining!");
                    }
                    else
                    {
                        MessageBox.Show($"You were hit! You now have 1 life remaining!");
                    }
                    
                }
           }
               //Stops game when player runs out of lives
            if (numberOfLives == 0)
           {
               isPlaying = false;
               GameTimer.Enabled = false;
               RenderOutput();
           }
            // Tests to see if the player runs into any coins
            /*var coinsCollected = from tallies in Coins
                                 where tallies.HitTest(Deer.Bounds)
                                 select tallies;
            var totalPoints = coinsCollected.ToList();
            //Coins add 15 points to total
            foreach (var tallies in totalPoints)
            {
                score = score + 15;
            }*/
            //The level will increase by one and reset the player when they pass y = 50.
            //Points will increase by 10 everytime the deer gets to y=50
            //It will also send a message with the new level.
            if (Deer.LocationY < 50)
            {
                Deer.PlayerReset();
                level++;
                score = score + 10;
                ScoreLabel.Text = score.ToString();
                LevelLabel.Text = level.ToString();
                if (level < 4)
                {
                    MessageBox.Show($"Level {level}");
                }
                else
                {
                    MessageBox.Show("You Win!");
                    Application.Exit();
                }
                
            }
            //Inserted code to lower the frequency of cars being on top of each other.
            for (int k = 0; k < 9; k++)
            {

                for (int i = 0; i < 9; i++)

                {
                    if (Cars[k].LocationX < 700)
                    {
                        if (Cars[k].HitTest(Cars[i].Bounds))
                        {
                            if (k != i)
                            {
                                Cars[k].LocationY = Lanes[randomGenerator.Next(0, 4)];
                                Cars[k].LocationX = 1;
                                
                                

                            }
                            

                        }
                    }

                   

                }

            }

            //Tests to see if tthe player ran into any coins
            //CoinsCollection();
        }
        // not sure how to add the code to add the score and pick it up
         /*private void CoinsCollection()
        {
            if (Deer.Bounds.IntersectsWith(BonusPoints.Bounds))
            {
                score = score + 15;
                ScoreLabel.Text = score.ToString();
            }

        }*/
        //G A M E  K E Y  C O N T R O L S

        //FOR THE PLAYER TO MOVE IN ALL DIRECTIONS
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
               case Keys.Up:
                    Deer.MoveForward();
                    break;
                case Keys.W:
                    Deer.MoveForward();
                    break;
                case Keys.Down:
                    Deer.MoveBack();
                    break;
                case Keys.S:
                    Deer.MoveBack();
                    break;
                case Keys.Right:
                    Deer.MoveRight();
                    break;
                case Keys.D:
                    Deer.MoveRight();
                    break;
                case Keys.Left:
                    Deer.MoveLeft();
                    break;
                case Keys.A:
                    Deer.MoveLeft();
                    break;

                
            }
        }
        
        private void ProcessInput()
        {

        }
        private void RenderOutput()
        {
            // Adds to the score 
            //ScoreLabel.Text = score.ToString();

            if (!isPlaying)
            {
                MessageBox.Show("Game Over");
                Application.Exit();
            }


        }
        //Cars restart at x = 1 and change y to one of 4 random numbers(lanes) when they 
        //move passed x = 740. This is what makes the cars coming on a loop.
        public void CarReset(int randomGen)
        {
            Lanes = new List<int>();
            Lanes.Add(75);
            Lanes.Add(125);
            Lanes.Add(275);
            Lanes.Add(325);

            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].LocationX > 740)
                {
                    Cars[i].LocationY = Lanes[randomGen];
                    Cars[i].LocationX = 1;
                }
            }
            
        }

        private void car1_Tick(object sender, EventArgs e)
        {

        }


    }
}
