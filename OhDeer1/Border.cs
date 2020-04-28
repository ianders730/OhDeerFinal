using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace OhDeer1
{
    public class Border : PictureBox
    {
        //Properties


        public int ParentHeight { get; set; }
        public int ParentWidth { get; set; }

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
        public int FreewayAmount { get; set; }

        public Border(int parentHeight, int parentWidth, int locationX, int locationY)
        {
            ParentHeight = parentHeight;
            ParentWidth = parentWidth;
            Image = Properties.Resources.Border;
            //Makes sure that the picture fits specified boundries
            SizeMode = PictureBoxSizeMode.StretchImage;
            //Sets size of Deer picturebox
            Size = new System.Drawing.Size(80, 450);
            LocationX = locationX;
            LocationY = locationY;
        }
    }
}

