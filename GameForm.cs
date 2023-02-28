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
        private PictureBox startPicture = new PictureBox();
        private PictureBox endPicture = new PictureBox();
        private Area area = new Area();
        private Vehicle vehicle = new Vehicle();
        private Score score = new Score();
        private GeneticAlgorithm geneticAlgorithm = new GeneticAlgorithm();
        private Button buttonStart = new Button();
        private Button buttonYes = new Button();
        private Button buttonNo = new Button();
        private bool buttonStartClick = false;
        private Timer ifButtonIsClickedTimer = null;

        public GameForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            //adjust game form size
            this.Size = new Size(800, 530);

            //add start picture
            InitializeStartPicture();

            //add game elements, when Start button is clicked
            InitializeIfButtonIsClickedTimer();

        }

        private void InitializeStartPicture()
        {
            this.Controls.Add(startPicture);
            startPicture.Visible = true;
            startPicture.Location = new Point(0, 0);
            startPicture.Size = new Size(800, 500);
            startPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            startPicture.BringToFront();
            startPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject("start_pic");
            ButtonStart();
        }
        private void ButtonStart()
        {
            buttonStart.Parent = startPicture;
            buttonStart.Size = new Size(156, 46);
            buttonStart.Location = new Point(336, 426);
            buttonStart.BackColor = Color.Black;
            buttonStart.ForeColor = Color.White;
            buttonStart.Text = "START";
            buttonStart.Font = new Font("Impact", 22, FontStyle.Bold);
            buttonStart.Visible = true;
            buttonStart.BringToFront();
            buttonStart.Click += buttonStart_Click;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStartClick = true;
        }

        private void VisibleFalse()
        {
            startPicture.Visible = false;
            buttonStart.Visible = false;
        }

        private void InitializeIfButtonIsClickedTimer()
        {

            ifButtonIsClickedTimer = new Timer();
            ifButtonIsClickedTimer.Tick += IfButtonIsClickedTimer_Tick;
            ifButtonIsClickedTimer.Interval = 1;
            ifButtonIsClickedTimer.Start();
        }

        private void IfButtonIsClickedTimer_Tick(object sender, EventArgs e)
        {
            if (buttonStartClick)
            {
                ifButtonIsClickedTimer.Stop();
                VisibleFalse();
                AddGameElements();
            }

        }

        private void AddGameElements()
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
            this.Controls.Add(area);
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

        private void InitializeEndPicture()
        {
            endPicture.Visible = true;
            endPicture.Location = new Point(40, 30);
            //endPicture.Size = level.Size;
            endPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            endPicture.BringToFront();
            ButtonYes();
            ButtonNo();
        }

        private void ButtonYes()
        {
            buttonYes.Parent = endPicture;
            buttonYes.Size = new Size(80, 40);
            buttonYes.Location = new Point(120, 300);
            buttonYes.Visible = true;
            buttonYes.BringToFront();
        }

        private void ButtonNo()
        {
            buttonNo.Parent = endPicture;
            buttonNo.Size = new Size(80, 40);
            buttonNo.Location = new Point(215, 300);
            buttonNo.Visible = true;
            buttonNo.BringToFront();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            //RestartGame();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
