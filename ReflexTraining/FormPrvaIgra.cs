using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflexTraining
{
    public partial class FormPrvaIgra : Form
    {
        Timer timer, timer2, timer3;
        int secondsCounter, randomNumber, obidiZaIgra, sekundiZaIgra, averageSuma;
        Random random;
        Circle circle;
        bool isFirst, hard;
        List<int> sumaNaKlikoj;
        List<float> sumaRezultati;
        Stopwatch stopWatch;
        List<Player> players;

        public FormPrvaIgra()
        {
            InitializeComponent();

            averageSuma = 0;

            lblGameStart.Location = new Point(this.Width / 2 - 140, this.Height / 2 - 100);

            sumaNaKlikoj = new List<int>();
            sumaRezultati = new List<float>();
            players = new List<Player>();

            deserialize();

            najdobarRezultat();
           
            secondsCounter = 0;
            obidiZaIgra = 0;
            sekundiZaIgra = 3;
            isFirst = true;
            hard = false;

            cbTezina.Items.Add("Normal");
            cbTezina.Items.Add("Hard");

            cbTezina.SelectedIndex = 0;

            stopWatch = new Stopwatch();

            newGame();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void newGame()
        {
            lblGameStart.Text = "Game will Start in " + sekundiZaIgra + " seconds";
            lblAverage.Text = "";

            random = new Random();
            randomNumber = random.Next(2, 8);

            refreshLabels();

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;

            timer2 = new Timer();
            timer2.Tick += new EventHandler(timer_Tick2);
            timer2.Interval = 1000;

            timer3 = new Timer();
            timer3.Tick += new EventHandler(timer_Tick3);
            timer3.Interval = 1000;
            timer3.Start();
        }

        private void timer_Tick3(object sender, EventArgs e)
        {
            if (sekundiZaIgra == 1)
            {
                isFirst = false;
                circle = new Circle(pnlIgra.Width / 2, pnlIgra.Height / 2);
                pnlIgra.Invalidate();
                timer2.Start();
                timer3.Stop();
                lblGameStart.Text = "";
            }
            else
            {
                sekundiZaIgra--;
                lblGameStart.Text = "Game will Start in " + sekundiZaIgra + " seconds";
            }
        }

        private void timer_Tick2(object sender, EventArgs e)
        {
            if (obidiZaIgra < 10)
            {
                secondsCounter++;
                if (secondsCounter == randomNumber)
                {
                    timer2.Stop();
                    timer.Start();
                    if (hard == false)
                        circle.changeToYellow();
                    else
                    {
                        circle.changeToYellow();
                        random = new Random();
                        circle.changePosition(random.Next(15, pnlIgra.Width - 15), random.Next(15, pnlIgra.Height - 15));
                    }
                    pnlIgra.Invalidate();
                    stopWatch.Start();
                }
            }
            else
            {
                if (!hard)
                    players.Add(new Player(Form1.Ime, averageSuma, 1));
                else
                    players.Add(new Player(Form1.Ime, averageSuma, 2));
                serialize();
                najdobarRezultat();
                stopGame();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            obidiZaIgra++;
            setLabelRezultat(obidiZaIgra, 1000);
            sumaNaKlikoj.Add(1000);
            presmetajProsek();
            timer.Stop();
            if (obidiZaIgra < 10)
                reset();
            else
            {
                if (!hard)
                    players.Add(new Player(Form1.Ime, averageSuma, 1));
                else
                    players.Add(new Player(Form1.Ime, averageSuma, 2));
                serialize();
                najdobarRezultat();
                stopGame();
            }

            if (hard)
                circle.changePosition(pnlIgra.Width / 2, pnlIgra.Height / 2);
        }

        private void pnlIgra_Paint(object sender, PaintEventArgs e)
        {
            if (!isFirst)
            {
                if (circle != null)
                    circle.Draw(e.Graphics);
            }
        }

        private void pnlIgra_MouseClick(object sender, MouseEventArgs e)
        {
            if (circle != null)
            {
                if (circle.Clicked(e.X, e.Y))
                {
                    if (circle.GetColor().Name == "ffff0000")
                    {
                        obidiZaIgra++;
                        setLabelRezultat(obidiZaIgra, 1000);
                        sumaNaKlikoj.Add(1000);
                        stopWatch.Reset();
                    }
                    else
                    {
                        obidiZaIgra++;
                        int z = stopWatch.Elapsed.Milliseconds;
                        stopWatch.Reset();
                        setLabelRezultat(obidiZaIgra, z);
                        sumaNaKlikoj.Add(z);
                    }
                }
                else
                {
                    obidiZaIgra++;
                    setLabelRezultat(obidiZaIgra, 1000);
                    sumaNaKlikoj.Add(1000);
                    stopWatch.Reset();
                }

                presmetajProsek();
            }

            if (obidiZaIgra < 10)
                reset();
            else
            {
                if (!hard)
                    players.Add(new Player(Form1.Ime, averageSuma, 1));
                else
                    players.Add(new Player(Form1.Ime, averageSuma, 2));
                serialize();
                najdobarRezultat();
                stopGame();
            }
        }

        public void setLabelRezultat(int obidi, int time)
        {
            if (obidi == 1)
                labela1.Text = time.ToString() + " ms";
            else if (obidi == 2)
                labela2.Text = time.ToString() + " ms";
            else if (obidi == 3)
                labela3.Text = time.ToString() + " ms";
            else if (obidi == 4)
                labela4.Text = time.ToString() + " ms";
            else if (obidi == 5)
                labela5.Text = time.ToString() + " ms";
            else if (obidi == 6)
                labela6.Text = time.ToString() + " ms";
            else if (obidi == 7)
                labela7.Text = time.ToString() + " ms";
            else if (obidi == 8)
                labela8.Text = time.ToString() + " ms";
            else if (obidi == 9)
                labela9.Text = time.ToString() + " ms";
            else if (obidi == 10)
                labela10.Text = time.ToString() + " ms";
        }

        public void reset()
        {
            timer2.Start();
            timer.Stop();

            if (circle != null)
                circle.changeToRed();

            if (hard && circle != null)
                circle.changePosition(pnlIgra.Width / 2, pnlIgra.Height / 2);

            randomNumber = random.Next(3, 8);

            secondsCounter = 0;

            pnlIgra.Invalidate();
        }

        public void stopGame()
        {
            timer.Stop();
            timer2.Stop();
            timer3.Stop();

            sumaNaKlikoj.Clear();

            if (circle != null)
                circle.changeBrush(pnlIgra.BackColor);

            circle = null;

            pnlIgra.Refresh();

            obidiZaIgra = 0;

            isFirst = true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            stopGame();
            sekundiZaIgra = 3;
            if (cbTezina.SelectedIndex == 1)
                hard = true;
            else
                hard = false;
            newGame();
        }

        public void refreshLabels()
        {
            labela1.Text = "";
            labela2.Text = "";
            labela3.Text = "";
            labela4.Text = "";
            labela5.Text = "";
            labela6.Text = "";
            labela7.Text = "";
            labela8.Text = "";
            labela9.Text = "";
            labela10.Text = "";
        }

        public void presmetajProsek()
        {
            float suma = 0;
            foreach (int item in sumaNaKlikoj)
            {
                suma += item;
            }
            if (sumaNaKlikoj.Count > 0)
                averageSuma = (int)suma / sumaNaKlikoj.Count;
            suma /= 1000;
            lblAverage.Text = String.Format("{0:0.000}", suma / sumaNaKlikoj.Count);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopGame();
            sekundiZaIgra = 3;
            newGame();
        }

        public void serialize()
        {
            try
            {
                using (Stream stream = File.Open("dataFirst.bin", FileMode.OpenOrCreate))
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
                using (Stream stream = File.Open("dataFirst.bin", FileMode.Open))
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

        private void btnTopScores_Click(object sender, EventArgs e)
        {
            stopGame();
            lblGameStart.Text = "";
            TopScoresPrva tsP = new TopScoresPrva();
            tsP.Visible = false;
            tsP.ShowDialog();
            tsP.Close();
        }

        public void najdobarRezultat()
        {
            if (players.Count > 0)
            {
                int min = 100000;
                foreach (Player player in players)
                {
                    if (player.Score < min && player.Name == Form1.Ime)
                        min = player.Score;
                }

                if (min == 100000)
                    lblBestScore.Text = "0";
                else
                    lblBestScore.Text = min.ToString();
            }
        }
    }
}
