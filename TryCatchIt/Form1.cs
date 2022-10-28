using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatchIt
{
    public partial class Frm_Main : Form
    {
        int playerSpeed = 5;
        bool movingLeft, movingRight;
        List<Food> foodList = new List<Food>();
        Random rnd = new Random();

        public Frm_Main()
        {
            InitializeComponent();

            for(int i = 0; i < 27; i++)
            {   
                foodList.Add(new Food(this.Controls["imgFood" + (i + 1)]));
                Console.WriteLine(foodList[i].getPictureBox().Name);
            }

        }

        private void Frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                movingLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                movingRight = true;
            }
        }

        private void Frm_Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                movingLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                movingRight = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            gameTimer.Enabled = true;
            foodSpawTimer.Enabled = true;
            foodPosition();
        }

        private void foodPosition()
        {
            int posY = -rnd.Next(1, 300);
            int iterator = 0;
            foreach (Food f in foodList)
            {
                PictureBox pbx = f.getPictureBox();
                pbx.Location = new Point(rnd.Next(2,300), posY - iterator);
                iterator += rnd.Next(40, 150);
            }
        }

        private void foodSpawTimer_Tick(object sender, EventArgs e)
        {
            foreach (Food f in foodList)
            {
                PictureBox pbx = f.getPictureBox();
                pbx.Location = new Point(pbx.Location.X, pbx.Location.Y + 2);
            }
        }

        private void GameTick(object sender, EventArgs e)
        {
            if (movingLeft && imgPlayer.Location.X > 0)
            {
                imgPlayer.Location = new Point(imgPlayer.Location.X - playerSpeed, imgPlayer.Location.Y); 
            }
            if (movingRight && imgPlayer.Location.X < 531)
            {
                imgPlayer.Location = new Point(imgPlayer.Location.X + playerSpeed, imgPlayer.Location.Y);
            }

            Console.WriteLine(foodList.Count);
        }
    }
}
