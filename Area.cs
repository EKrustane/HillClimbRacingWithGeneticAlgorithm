using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HillClimbRacingWithGeneticAlgorithm
{
    public class Area:PictureBox
    {
        private Vehicle vehicle = new Vehicle();
        public Area()
        {
            InitalizeSky();
        }

        private void InitalizeSky()
        {
            this.BackColor = Color.DeepSkyBlue;
            this.Size = new Size(800, 600);
            this.Location = new Point(0, 0);
            this.Name = "Sky";
            this.Controls.Add(vehicle);
            vehicle.BringToFront();
            vehicle.Location = new Point(140, 100);

        }

    }
}
