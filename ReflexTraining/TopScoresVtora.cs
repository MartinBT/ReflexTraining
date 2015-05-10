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
    public partial class TopScoresVtora : Form
    {
        List<Label> labelPoints;
        List<Label> labelNames;
        List<Player> igraci;

        public TopScoresVtora()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            labelPoints = new List<Label>();
            labelNames = new List<Label>();
            igraci = new List<Player>();

            labelNames.Add(lblIme1);
            labelNames.Add(lblIme2);
            labelNames.Add(lblIme3);
            labelNames.Add(lblIme4);
            labelNames.Add(lblIme5);
            labelNames.Add(lblIme6);
            labelNames.Add(lblIme7);
            labelNames.Add(lblIme8);
            labelNames.Add(lblIme9);
            labelNames.Add(lblIme10);

            labelPoints.Add(lblPoeni1);
            labelPoints.Add(lblPoeni2);
            labelPoints.Add(lblPoeni3);
            labelPoints.Add(lblPoeni4);
            labelPoints.Add(lblPoeni5);
            labelPoints.Add(lblPoeni6);
            labelPoints.Add(lblPoeni7);
            labelPoints.Add(lblPoeni8);
            labelPoints.Add(lblPoeni9);
            labelPoints.Add(lblPoeni10);

            cbCircles.Items.Add("1 Circle");
            cbCircles.Items.Add("2 Circles");
            cbCircles.Items.Add("3 Circles");
            cbCircles.SelectedIndex = 0;

            cbSpeed.Items.Add("Normal");
            cbSpeed.Items.Add("Fast");
            cbSpeed.Items.Add("SuperFast");
            cbSpeed.SelectedIndex = 0;

            deserialize();
        }

        public void deserialize()
        {
            try
            {
                using (Stream stream = File.Open("dataSecond.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    List<Player> playersz = (List<Player>)bin.Deserialize(stream);
                    playersz.Sort(delegate(Player first, Player second)
                    {
                        return second.Score.CompareTo(first.Score);
                    });
                    igraci = playersz;
                    changeAllScores();
                    stream.Dispose();
                    stream.Close();
                }
            }
            catch (IOException)
            {
            }
        }

        public void changeAllScores()
        {
            isprazniLabeli();
            int i = 0;
            foreach (Player player in igraci)
            {
                if (cbCircles.SelectedIndex == 0 && cbSpeed.SelectedIndex == 0 && player.Type == 1)
                {
                    labelPoints[i].Text = player.Score.ToString();
                    labelNames[i].Text = player.Name;
                    i++;
                    if (i == 10)
                        break;
                }
                else if (cbCircles.SelectedIndex == 0 && cbSpeed.SelectedIndex == 1 && player.Type == 2)
                {
                    labelPoints[i].Text = player.Score.ToString();
                    labelNames[i].Text = player.Name;
                    i++;
                    if (i == 10)
                        break;
                }
                else if (cbCircles.SelectedIndex == 0 && cbSpeed.SelectedIndex == 2 && player.Type == 3)
                {
                    labelPoints[i].Text = player.Score.ToString();
                    labelNames[i].Text = player.Name;
                    i++;
                    if (i == 10)
                        break;
                }
                else if (cbCircles.SelectedIndex == 1 && cbSpeed.SelectedIndex == 0 && player.Type == 4)
                {
                    labelPoints[i].Text = player.Score.ToString();
                    labelNames[i].Text = player.Name;
                    i++;
                    if (i == 10)
                        break;
                }
                else if (cbCircles.SelectedIndex == 1 && cbSpeed.SelectedIndex == 1 && player.Type == 5)
                {
                    labelPoints[i].Text = player.Score.ToString();
                    labelNames[i].Text = player.Name;
                    i++;
                    if (i == 10)
                        break;
                }
                else if (cbCircles.SelectedIndex == 1 && cbSpeed.SelectedIndex == 2 && player.Type == 6)
                {
                    labelPoints[i].Text = player.Score.ToString();
                    labelNames[i].Text = player.Name;
                    i++;
                    if (i == 10)
                        break;
                }
                else if (cbCircles.SelectedIndex == 2 && cbSpeed.SelectedIndex == 0 && player.Type == 7)
                {
                    labelPoints[i].Text = player.Score.ToString();
                    labelNames[i].Text = player.Name;
                    i++;
                    if (i == 10)
                        break;
                }
                else if (cbCircles.SelectedIndex == 2 && cbSpeed.SelectedIndex == 1 && player.Type == 8)
                {
                    labelPoints[i].Text = player.Score.ToString();
                    labelNames[i].Text = player.Name;
                    i++;
                    if (i == 10)
                        break;
                }
                else if (cbCircles.SelectedIndex == 2 && cbSpeed.SelectedIndex == 2 && player.Type == 9)
                {
                    labelPoints[i].Text = player.Score.ToString();
                    labelNames[i].Text = player.Name;
                    i++;
                    if (i == 10)
                        break;
                }
            }
        }

        public void isprazniLabeli()
        {
            foreach (Label labela in labelPoints)
            {
                labela.Text = "";
            }

            foreach (Label labela in labelNames)
            {
                labela.Text = "";
            }
        }

        private void cbCircles_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeAllScores();
        }

        private void cbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeAllScores();
        }
    }
}
