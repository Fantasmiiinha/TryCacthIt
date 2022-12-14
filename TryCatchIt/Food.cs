using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TryCatchIt
{
    class Food
    {
        private PictureBox imgFood;
        int points;
        int speed;
        int type;
        Random rnd = new Random();

        public Food(PictureBox pb, int type)
        {
            this.type = type;
            Configs cfg = new Configs();
            this.imgFood = (PictureBox)pb;
            imgFood.SizeMode = PictureBoxSizeMode.StretchImage;

            switch (type)
            {
                case 1:
                    this.points = 10;
                    imgFood.Image = (Image)TryCatchIt.Properties.Resources.comida1;
                    break;
                case 2:
                    imgFood.Image = (Image)TryCatchIt.Properties.Resources.comida2;
                    this.points = 30;
                    break;
                case 3:
                    imgFood.Image = (Image)TryCatchIt.Properties.Resources.comida3;
                    this.points = 20;
                    break;
                case 4:
                    this.points = 5;
                    imgFood.Image = (Image)TryCatchIt.Properties.Resources.comida4;
                    break;
            }
        }

        public PictureBox getPictureBox()
        {
            return imgFood;
        }

        public int getPoints()
        {
            return points;
        }
    }
}
