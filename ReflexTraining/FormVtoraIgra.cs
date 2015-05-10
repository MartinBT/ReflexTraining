using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflexTraining
{
    public partial class FormVtoraIgra : Form
    {
        Graphics graphics;
        Random random;
        Timer timer, timer2, timer3;
        int TIMER_INTERVAL;
        int pnlWidth, pnlHeight, randomX, randomY, poeni, kolkuKrugovi;
        List<Circle> krugovi;
        List<Player> players;
        bool firstTime, newGameStarted;

        public FormVtoraIgra()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            DoubleBuffered = true;
            pnlWidth = pnlIgra.Width;
            pnlHeight = pnlIgra.Height;

            TIMER_INTERVAL = 3000;

            lblStartGame.Location = new Point(this.Width / 2 - 140, this.Height / 2 - 100);

            firstTime = true;

            newGameStarted = false;

            players = new List<Player>();

            deserialize();

            najdobarRezultat();

            poeni = 0;

            cbTezina.Items.Add("1 Circle");
            cbTezina.Items.Add("2 Circles");
            cbTezina.Items.Add("3 Circles");

            cbTezina.SelectedIndex = 0;

            cbBrzina.Items.Add("Normal");
            cbBrzina.Items.Add("Fast");
            cbBrzina.Items.Add("SuperFast");

            cbBrzina.SelectedIndex = 0;

            kolkuKrugovi = 1;

            krugovi = new List<Circle>();

            newGame();
        }

        public void newGame()
        {
            graphics = CreateGraphics();
            Show();

            newGameStarted = true;

            lblStartGame.Text = "Game starts in 2 seconds";

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TIMER_INTERVAL;
            timer.Start();

            timer2 = new Timer();
            timer2.Tick += new EventHandler(timer_Tick2);
            timer2.Interval = TIMER_INTERVAL + 1000;
            timer2.Start();

            timer3 = new Timer();
            timer3.Tick += new EventHandler(timer_Tick3);
            timer3.Interval = 1000;
            timer3.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            firstTime = false;
            timer3.Stop();
            if (newGameStarted)
            {
                ChangeSpeed();
                newGameStarted = false;
            }
            lblStartGame.Text = "";
            generateNewCircle();
            pnlIgra.Invalidate();
        }

        private void timer_Tick2(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            int z = int.Parse(lblSeconds.Text);
            z--;
            if (z == 0)
            {
                if (kolkuKrugovi == 1)
                {
                    if (cbBrzina.SelectedIndex == 0)
                        players.Add(new Player(Form1.Ime, poeni, 1));
                    else if (cbBrzina.SelectedIndex == 1)
                        players.Add(new Player(Form1.Ime, poeni, 2));
                    else if (cbBrzina.SelectedIndex == 2)
                        players.Add(new Player(Form1.Ime, poeni, 3));
                }
                else if (kolkuKrugovi == 2)
                {
                    if (cbBrzina.SelectedIndex == 0)
                        players.Add(new Player(Form1.Ime, poeni, 4));
                    else if (cbBrzina.SelectedIndex == 1)
                        players.Add(new Player(Form1.Ime, poeni, 5));
                    else if (cbBrzina.SelectedIndex == 2)
                        players.Add(new Player(Form1.Ime, poeni, 6));
                }
                else if (kolkuKrugovi == 3)
                {
                    if (cbBrzina.SelectedIndex == 0)
                        players.Add(new Player(Form1.Ime, poeni, 7));
                    else if (cbBrzina.SelectedIndex == 1)
                        players.Add(new Player(Form1.Ime, poeni, 8));
                    else if (cbBrzina.SelectedIndex == 2)
                        players.Add(new Player(Form1.Ime, poeni, 9));
                }
                serialize();
                stopGame();
            }
            lblSeconds.Text = z.ToString();
        }

        private void timer_Tick3(object sender, EventArgs e)
        {
            lblStartGame.Text = "Game starts in 1 second";
        }

        public void stopGame()
        {
            timer.Stop();
            timer2.Stop();

            krugovi.Clear();

            pnlIgra.Refresh();

            lblPrethodniPoeni.Text = poeni.ToString();

            najdobarRezultat();

            poeni = 0;

            newGameStarted = true;

            firstTime = false;

            lblPoeni.Text = "0";
            lblSeconds.Text = "120";
        }

        public void generateNewCircle()
        {
            if (kolkuKrugovi == 1)
            {
                krugovi.Clear();
                random = new Random();
                randomX = random.Next(15, pnlWidth - 15);
                randomY = random.Next(15, pnlHeight - 15);
                Circle circle = new Circle(randomX, randomY);
                krugovi.Add(circle);
            }
            else if (kolkuKrugovi == 2)
            {
                krugovi.Clear();
                random = new Random();
                randomX = random.Next(15, pnlWidth - 15);
                randomY = random.Next(15, pnlHeight - 15);
                for (int i = 0; i < 2; i++)
                {
                    generateRandomNumber();
                    Circle circle = new Circle(randomX, randomY);
                    krugovi.Add(circle);
                }
            }
            else if (kolkuKrugovi == 3)
            {
                krugovi.Clear();
                random = new Random();
                randomX = random.Next(15, pnlWidth - 15);
                randomY = random.Next(15, pnlHeight - 15);
                for (int i = 0; i < 3; i++)
                {
                    generateRandomNumber();
                    Circle circle = new Circle(randomX, randomY);
                    krugovi.Add(circle);
                }
            }
        }


        public void generateRandomNumber()
        {
            if (krugovi.Count > 0)
            {
                List<int> listX = new List<int>();
                List<int> listY = new List<int>();
                foreach (Circle krug in krugovi)
                {
                    listX.Add(krug.positionX);
                    listY.Add(krug.positionY);
                }

                while (true)
                {
                    randomX = random.Next(15, pnlWidth - 15);
                    randomY = random.Next(15, pnlHeight - 15);
                    bool xCorrect = false, yCorrect = false;
                    for (int i = 0; i < listX.Count; i++)
                    {
                        if (randomX > listX[i] + 15 || randomX < listX[i] - 15)
                            xCorrect = true;
                    }

                    for (int i = 0; i < listY.Count; i++)
                    {
                        if (randomY > listX[i] + 15 || randomY < listY[i] - 15)
                            yCorrect = true;
                    }

                    if (xCorrect == true && yCorrect == true)
                        break;
                }
            }
        }

        private void pnlIgra_Paint(object sender, PaintEventArgs e)
        {
            if (!firstTime)
            {
                if (krugovi.Count > 0)
                {
                    foreach (Circle krug in krugovi)
                    {
                        krug.Draw(e.Graphics);
                    }
                }
            }
        }

        private void pnlIgra_MouseClick(object sender, MouseEventArgs e)
        {
            if (krugovi.Count > 0)
            {
                bool found = false;
                Circle temp = null;
                foreach (Circle krug in krugovi)
                {
                    if (krug.Clicked(e.X, e.Y))
                    {
                        krug.isClicked = true;
                        krug.changeBrush(pnlIgra.BackColor);
                        pnlIgra.Invalidate();
                        found = true;
                        poeni += 100;
                        temp = krug;
                        break;
                    }
                }

                if (temp != null)
                    krugovi.Remove(temp);

                if (found == false)
                    poeni -= 100;
                lblPoeni.Text = poeni.ToString();
            }
        }

        public void ChangeSpeed()
        {
            if (cbBrzina.SelectedIndex != -1)
            {
                if (cbBrzina.SelectedIndex == 0)
                {
                    timer.Interval = 1500;
                    timer2.Interval = 1500;
                }
                else if (cbBrzina.SelectedIndex == 1)
                {
                    timer.Interval = 1000;
                    timer2.Interval = 1000;
                }
                else
                {
                    timer.Interval = 700;
                    timer2.Interval = 700;
                }
            }
        }

        public void najdobarRezultat()
        {
            if (players.Count > 0)
            {
                int max = 0;
                foreach (Player player in players)
                {
                    if (player.Score > max && player.Name == Form1.Ime)
                        max = player.Score;
                }

                lblBestScore.Text = max.ToString();
            }
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            if (cbTezina.SelectedIndex != -1)
                kolkuKrugovi = cbTezina.SelectedIndex + 1;
            reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            timer.Stop();
            timer2.Stop();

            //circle = null;
            krugovi.Clear();

            pnlIgra.Refresh();

            poeni = 0;

            lblStartGame.Text = "Game starts in 2 seconds";

            firstTime = false;
            lblPoeni.Text = "0";
            lblSeconds.Text = "120";

            timer.Interval = 3000;
            timer2.Interval = 4000;
            timer.Start();
            timer2.Start();
            timer3.Start();

            newGameStarted = true;
        }

        public void serialize()
        {
            try
            {
                using (Stream stream = File.Open("dataSecond.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, players);
                    stream.Dispose();
                    stream.Close();
                }
            }
            catch (IOException)
            {
            }
        }

        public void deserialize()
        {
            try
            {
                using (Stream stream = File.Open("dataSecond.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    List<Player> playersz = (List<Player>)bin.Deserialize(stream);
                    players = playersz;
                    stream.Dispose();
                    stream.Close();
                }
            }
            catch (IOException)
            {
            }
        }

        private void btnTopIgraci_Click(object sender, EventArgs e)
        {
            TopScoresVtora tpf = new TopScoresVtora();
            tpf.Visible = false;
            lblStartGame.Text = "";
            stopGame();
            tpf.ShowDialog();
            tpf.Close();
        }
    }
}
