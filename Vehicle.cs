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
            string v = "vehicle";
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject(v);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Location = new Point(100, 100);
            this.Name = "Car";
        }
    }
}
