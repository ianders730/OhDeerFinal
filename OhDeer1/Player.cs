using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhDeer1
{
    public class Player : PictureBox
    {
        //Properties
        //A form has children picture boxes
        //Represent H/W of form where picturebox will move around on
        public int ParentHeight { get; set; }
        public int ParentWidth { get; set; }
        public int Lives { get; set; }
        public int Score { get; set; }

        //At top left corner of picturebox
        public int LocationX
        {
            get
            {
                //backing field
                return Left;
            }
            set
            {
                //to set an appropriate value
                if (value > 0 && value < ParentWidth - Width)
                {
                    Left = value;
                }
            }
        }

        public int LocationY
        {
            get
            {
                //backing field
                return Top;
            }
            set
            {
                //to set an appropriate value
                if (value > 0 && value < ParentHeight - Height)
                {
                    Top = value;
                }
            }
        }
      

        //Constructor
        public Player(int parentHeight, int parentWidth, int lives)
        {
        
            ParentHeight = parentHeight;
            ParentWidth = parentWidth;
            Lives = lives;
            //Specified image
            Image = Properties.Resources.Deer5;
            //Makes sure that the picture fits specified boundries
            SizeMode = PictureBoxSizeMode.StretchImage;
            //Sets size of Deer picturebox
            Size = new System.Drawing.Size(40, 60);
            LocationX = 415;
            LocationY = 375;
        }
        //From Demo Derby and modified
      
        //From Demo Derby
        public void MoveRight()
        {
            LocationX = LocationX + 10;
        }

        public void MoveLeft()
        {
            LocationX = LocationX - 10;
        }

        public void MoveBack()
        {
            LocationY = LocationY + 10;
        }

        public void MoveForward()
        {
            LocationY = LocationY - 10;
        }

        public void PlayerReset()
        {
            LocationX = 415;
            LocationY = 375;
        }

    }


}
      


