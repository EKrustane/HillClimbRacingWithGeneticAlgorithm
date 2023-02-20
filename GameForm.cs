using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HillClimbRacingWithGeneticAlgorithm
{
    public partial class GameForm : Form
    {
        Area area = new Area();
        Vehicle vehicle = new Vehicle();
        Score score = new Score();
        GeneticAlgorithm geneticAlgorithm = new GeneticAlgorithm();

        public GameForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            //add key down event handler
            //this.KeyDown += Game_KeyDown;

            //inicialize and add area
            AddArea();

            //adding vehicle to the game
            AddVehicle();

            //adding score to the game
            AddScore();

            //adding GA to the game
            AddGeneticAlgorithm();

            //UpdateScoreLabel();
        }

        private void AddArea()
        {
            //this.Controls.Add(area);
            //area.BringToFront();
        }

        private void AddVehicle()
        {
            this.Controls.Add(vehicle);
            vehicle.BringToFront();
        }

        private void AddScore()
        {

        }

        private void AddGeneticAlgorithm()
        {

        }
    }
}
