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
    public partial class FormTretaIgra : Form
    {
        Graphics graphics;
        Random random;
        Timer timer, timer2, timer3, timer4;
        int pnlWidth, pnlHeight, poeni, TIMER_INTERVAL, randomX, randomY, timeInt;
        List<CircleTreta> krugovi;
        List<Player> players;
        bool firstTime, hard;

        public FormTretaIgra()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            pnlWidth = pnlIgra.Width;
            pnlHeight = pnlIgra.Height;

            TIMER_INTERVAL = 4000;

            lblStartGame.Location = new Point(this.Width / 2 - 140, this.Height / 2 - 100);

            firstTime = true;

            players = new List<Player>();

            deserialize();

            najdobarRezultat();
            poeni = 0;

            timeInt = 4;

            cbTezina.Items.Add("Normal");
            cbTezina.Items.Add("Hard");

            cbTezina.SelectedIndex = 0;

            hard = false;

            krugovi = new List<CircleTreta>();

            newGame();
        }

        public void newGame()
        {
            graphics = CreateGraphics();
            Show();

            lblStartGame.Text = "Game will start in " + timeInt.ToString() + " seconds";  

            if (hard == true)
            {
                lblMiss.Text = "Game Over";
                lblLeft.Text = "Game Over";
            }
            else
            {
                lblMiss.Text = "-100 pts";
                lblLeft.Text = "-500 pts";
            }

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TIMER_INTERVAL;
            timer.Start();

            if (hard == false)
            {
                timer2 = new Timer();
                timer2.Tick += new EventHandler(timer_Tick2);
                timer2.Interval = TIMER_INTERVAL;
                timer2.Start();
            }
            else
                lblVreme.Text = "Unlimited";

            timer3 = new Timer();
            timer3.Tick += new EventHandler(timer_Tick3);
            timer3.Interval = 200;
            timer3.Start();

            timer4 = new Timer();
            timer4.Tick += new EventHandler(timer_Tick4);
            timer4.Interval = 1000;
            timer4.Start();
        }

        private void timer_Tick4(object sender, EventArgs e)
        {
            timeInt--;
            lblStartGame.Text = "Game will start in " + timeInt.ToString() + " seconds"; 
            pnlIgra.Invalidate();
        }

        private void timer_Tick3(object sender, EventArgs e)
        {
            pulse();
            checkIfShouldBeRemoved();
            pnlIgra.Invalidate();
        }

        private void timer_Tick2(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            int z = int.Parse(lblVreme.Text);
            z--;
            if (z == 0)
            {
                players.Add(new Player(Form1.Ime, poeni, 1));
                serialize();
                najdobarRezultat();
                lblPrethodniPoeni.Text = poeni.ToString();
                stopGame();
            }
            lblVreme.Text = z.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            firstTime = false;
            timer4.Stop();
            lblStartGame.Text = "";
            generateNewCircles();
            pnlIgra.Invalidate();
        }

        private void checkIfShouldBeRemoved()
        {
            foreach (CircleTreta krug in krugovi.Reverse<CircleTreta>())
            {
                if (krug.timeToBeRemoved())
                {
                    if (krug.missedTiming)
                    {
                        if (hard == true)
                        {
                            players.Add(new Player(Form1.Ime, poeni, 2));
                            serialize();
                            lblPrethodniPoeni.Text = poeni.ToString();
                            najdobarRezultat();
                            stopGame();
                            break;
                        }
                        poeni -= 500;
                    }
                    krugovi.Remove(krug);
                }
            }

            lblPoeni.Text = poeni.ToString();
        }

        private void stopGame()
        {
            timer.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();

            krugovi.Clear();

            pnlIgra.Refresh();

            poeni = 0;

            timeInt = 4;

            firstTime = false;
            lblPoeni.Text = "0";
            if (cbTezina.SelectedIndex == 0)
                lblVreme.Text = "120";
            else
                lblVreme.Text = "Unlimited";
        }

        private void generateNewCircles()
        {
            random = new Random();
            randomX = random.Next(15, pnlWidth - 15);
            randomY = random.Next(15, pnlHeight - 15);
            if (krugovi.Count >= 2)
            {
                generateRandomNumber();
                CircleTreta circle = new CircleTreta(randomX, randomY);
                circle.changeBrush(pnlIgra.BackColor);
                krugovi.Add(circle);
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    generateRandomNumber();
                    CircleTreta circle = new CircleTreta(randomX, randomY);
                    circle.changeBrush(pnlIgra.BackColor);
                    krugovi.Add(circle);
                }
            }
        }

        private void generateNewCircleAfterClick()
        {
            if (krugovi.Count <= 3 && krugovi.Count > 0)
            {
                random = new Random();
                generateRandomNumber();
                CircleTreta circle = new CircleTreta(randomX, randomY);
                circle.changeBrush(pnlIgra.BackColor);
                krugovi.Add(circle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TopScoresTreta tf = new TopScoresTreta();
            tf.Visible = false;
            lblStartGame.Text = "";
            stopGame();
            tf.ShowDialog();
            tf.Close();
        }

        private void pnlIgra_Paint(object sender, PaintEventArgs e)
        {
            if (!firstTime)
            {
                foreach (CircleTreta krug in krugovi)
                {
                    krug.Draw(e.Graphics);
                }
            }
        }

        public void pulse()
        {
            if (krugovi.Count > 0)
            {
                foreach (CircleTreta krug in krugovi)
                    krug.Pulse();
            }
        }

        private void pnlIgra_MouseClick(object sender, MouseEventArgs e)
        {
            bool found = false;
            CircleTreta temp = null;
            foreach (CircleTreta krug in krugovi)
            {
                if (krug.Clicked(e.X, e.Y))
                {
                    krug.isClicked = true;
                    krug.changeBrush(pnlIgra.BackColor);
                    generateNewCircleAfterClick();
                    pnlIgra.Invalidate();
                    found = true;
                    poeni += 300;
                    temp = krug;
                    break;
                }
            }

            if (temp != null)
                krugovi.Remove(temp);

            if (found == false)
            {
                if (hard == true)
                {
                    players.Add(new Player(Form1.Ime, poeni, 2));
                    serialize();
                    najdobarRezultat();
                    lblPrethodniPoeni.Text = poeni.ToString();
                    stopGame();
                }
                else
                    poeni -= 100;
            }

            lblPoeni.Text = poeni.ToString();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            stopGame();
            if (cbTezina.SelectedIndex == 1)
                hard = true;
            else
                hard = false;
            newGame();
        }

        public void generateRandomNumber()
        {
            if (krugovi.Count > 0)
            {
                List<int> listX = new List<int>();
                List<int> listY = new List<int>();
                foreach (CircleTreta krug in krugovi)
                {
                    listX.Add(krug.positionX);
                    listY.Add(krug.positionY);
                }

                while (true)
                {
                    bool xCorrect = false, yCorrect = false;
                    randomX = random.Next(15, pnlWidth - 15);
                    randomY = random.Next(15, pnlHeight - 15);

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer2.Stop();
            timer3.Stop();

            krugovi.Clear();

            pnlIgra.Refresh();

            timeInt = 4;

            lblPrethodniPoeni.Text = "0";

            poeni = 0;

            firstTime = false;
            lblPoeni.Text = "0";
            if (cbTezina.SelectedIndex == 0)
                lblVreme.Text = "120";
            else
                lblVreme.Text = "Unlimited";
            newGame();
        }

        public void serialize()
        {
            try
            {
                using (Stream stream = File.Open("dataThird.bin", FileMode.OpenOrCreate))
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
                using (Stream stream = File.Open("dataThird.bin", FileMode.Open))
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
    }
}
