using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HillClimbRacingWithGeneticAlgorithm
{
    public class Vehicle:PictureBox
    {
        public Vehicle()
        {
            InitializeVehicle();
        }

        private void InitializeVehicle()
        {
     
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject("vehicle");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Location = new Point(200, 200);
            this.Name = "Car";
        }
    }
}
