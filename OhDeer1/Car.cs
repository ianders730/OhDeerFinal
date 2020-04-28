using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OhDeer1
{
    public class Car : PictureBox
    {
        //Properties
        //public int Level { get; set; }
        public int ParentHeight { get; set; }
        public int ParentWidth { get; set; }
        //public List<int> Lanes { get; set; }
        //random number generator
        private static Random randomGenerator = new Random();

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
        //Do we need the Cars to take damage?
        //public int Damage { get; set; }
        //If round = 4, speed = 
        public int Speed { get; set; }
        //Speed dependent on level somehow?
        //Constructor
        public Car(int parentHeight, int parentWidth, int locationX, int locationY)
        {
            ParentHeight = parentHeight;
            ParentWidth = parentWidth;
            //Specified image
            Image = Properties.Resources.Car;
            //Makes sure that the picture fits specified boundries
            SizeMode = PictureBoxSizeMode.StretchImage;
            //Sets size of Deer picturebox
            Size = new System.Drawing.Size(70, 30);
            //Tunnel that car comes out of?
            LocationX = locationX;
            LocationY = locationY;
        }
        //Methods
       
        public void DriveBy1()
        {
            LocationX = LocationX + 10;
        }
        public void DriveBy2()
        {
            LocationX = LocationX + 20;
        }
        public void DriveBy3()
        {
            LocationX = LocationX + 30;
        }
   //Test 2

        //Idea from Demo Derby
        public bool HitTest(Rectangle rectangle)
        {
            //Tells me whether or not the picturebox of a car intersects with the player's picturebox.
            return Bounds.IntersectsWith(rectangle);
        }

       
    }
}

