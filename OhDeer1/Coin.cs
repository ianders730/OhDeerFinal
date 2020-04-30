using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhDeer1
{
    public class Coin : PictureBox
    {
    

        public int ParentHeight { get; set; }
        public int ParentWidth { get; set; }
        private static Random randomGenerator = new Random();
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

        public Coin(int parentHeight, int parentWidth, int locationX, int locationY)
        {
            ParentHeight = parentHeight;
            ParentWidth = parentWidth;
            Image = Properties.Resources.coin1;
            //Makes sure that the picture fits specified boundries
            SizeMode = PictureBoxSizeMode.StretchImage;
            //Sets size of Deer picturebox
            Size = new System.Drawing.Size(10, 10);
            LocationX = locationX;
            LocationY = locationY;
        }

        /*internal object HitTest(Rectangle bounds)
        {
            throw new NotImplementedException();
        }*/
        
        //Idea from Demo Derby
        public bool HitTest(Rectangle rectangle)
        {
            //Tells me whether or not the picturebox of a coin intersects with the player's picturebox.
            return Bounds.IntersectsWith(rectangle);
        }
    }
}
    
    


