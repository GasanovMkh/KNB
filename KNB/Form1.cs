using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using GameLogic;

namespace KNB
{
    public partial class Form1 : Form
    {
        //private readonly IForm1 _iform1;****************
        public Form1() //<-(IForm1 iform1)*****************
        {
            InitializeComponent(); //метод для поддрежки констуктора (инициализирует все компоненты на форме)
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Меню");
            fileItem.DropDownItems.Add("Настройки");
            menuStrip1.Items.Add(fileItem);
            ToolStripMenuItem newGame = new ToolStripMenuItem("Новая игра");
            newGame.Click += new EventHandler(n_Click);
            menuStrip1.Items.Add(newGame);
            ToolStripMenuItem aboutGame = new ToolStripMenuItem("Об игре");
            aboutGame.Click += a_Click;
            menuStrip1.Items.Add(aboutGame);
            //var game = new Game();
            //Start.Click += game.NewGame;
        }

        List<Image> images = new List<Image>();
        Timer myTimer = new Timer();

        private void n_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.rock;
            pictureBox2.Image = Properties.Resources.vs;
            //pictureBox3.Image = Properties.Resources.scissors;
            var rock = Properties.Resources.rock;
            rock.Tag = ThingsTypes.Rock;
            var paper = Properties.Resources.paper;
            paper.Tag = ThingsTypes.Paper;
            var scissors = Properties.Resources.scissors;
            scissors.Tag = ThingsTypes.Scissors;
            images.Add(rock);
            images.Add(paper);
            images.Add(scissors);

            Random rand = new Random();
            pictureBox1.Image = images[rand.Next(0, images.Count - 1)];
            pictureBox3.Image = images[rand.Next(0, images.Count - 1)];
            //if (NewGameClick != null) NewGameClick(this, EventArgs.Empty);
        }

        private void a_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Победитель определяется по следующим правилам: \n"
                            + "1)Камень побеждает ножницы. \n"
                            + "2)Бумага побеждает камень. \n"
                            + "3)Ножницы побеждают бумагу.");
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool _win1;
        bool _win2;
        private void Stop_Click(object sender, EventArgs e)
        {
            //if (StopClick != null) StopClick(this, EventArgs.Empty);
            //statusPic.Image = Properties.Resources.win;
            myTimer.Stop();
            
            if ((ThingsTypes)pictureBox1.Image.Tag == ThingsTypes.Rock &&
                (ThingsTypes)pictureBox3.Image.Tag == ThingsTypes.Scissors ||
                (ThingsTypes)pictureBox1.Image.Tag == ThingsTypes.Paper &&
                     (ThingsTypes)pictureBox3.Image.Tag == ThingsTypes.Rock ||
                     (ThingsTypes)pictureBox1.Image.Tag == ThingsTypes.Scissors &&
                     (ThingsTypes)pictureBox3.Image.Tag == ThingsTypes.Paper)
            {
                _win1 = true;
                _win2 = false;
                statusPic.Image = Properties.Resources.win;
            }
            else if ((ThingsTypes)pictureBox1.Image.Tag == ThingsTypes.Scissors &&
                     (ThingsTypes)pictureBox3.Image.Tag == ThingsTypes.Rock ||
                     (ThingsTypes)pictureBox1.Image.Tag == ThingsTypes.Rock &&
                     (ThingsTypes)pictureBox3.Image.Tag == ThingsTypes.Paper ||
                     (ThingsTypes)pictureBox1.Image.Tag == ThingsTypes.Paper &&
                     (ThingsTypes)pictureBox3.Image.Tag == ThingsTypes.Scissors)
            {
                _win1 = false;
                _win2 = true;
                statusPic.Image = Properties.Resources.lose;
            }
            else
            {
                _win1 = false;
                _win2 = false;
                statusPic.Image = Properties.Resources.draw;
            }

            WinCounter();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //if (StartClick != null) StartClick(this, EventArgs.Empty);
            Random rand = new Random();
            myTimer.Interval = 50;
            myTimer.Start();
            myTimer.Tick += (o, args) => // лямбда-выражение
            {
                pictureBox1.Image = images[rand.Next(0, images.Count - 1)];
                pictureBox3.Image = images[rand.Next(0, images.Count - 1)];
            };
        }

        int counter1 = 0;
        int counter2 = 0;

        private void WinCounter()
        {
            if (_win1 == true && _win2 == false)
            {
                counter1++;
                result1.Text = counter1.ToString();
            }
            else if (_win1 == false && _win2 == true)
            {
                counter2++;
                result2.Text = counter2.ToString();
            }
            else if (_win1 == false && _win2 == false)
            {
                return;
            }
        }
    }
}
