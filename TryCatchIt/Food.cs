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
        int heigth = 20;
        int width = 20;
        int points;
        int speed;
        Random rnd = new Random();

        public Food(Control pb)
        {
            this.imgFood = (PictureBox)pb;
        }

        public PictureBox getPictureBox()
        {
            return imgFood;
        }
    }
}
