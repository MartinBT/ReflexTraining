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
    public partial class TopScoresPrva : Form
    {
        List<Label> labelPoints;
        List<Label> labelNames;
        List<Player> igraci;

        public TopScoresPrva()
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

            cbTezina.Items.Add("Normal");
            cbTezina.Items.Add("Hard");
            cbTezina.SelectedIndex = 0;

            deserialize();
        }

        public void deserialize()
        {
            try
            {
                using (Stream stream = File.Open("dataFirst.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    List<Player> playersz = (List<Player>)bin.Deserialize(stream);
                    playersz.Sort(delegate(Player first, Player second)
                    {
                        return first.Score.CompareTo(second.Score);
                    });
                    igraci = playersz;
                    if (cbTezina.SelectedIndex == 0)
                        changeScoresNormal();
                    else
                        changeScoresHard();

                    stream.Dispose();
                    stream.Close();
                }
            }
            catch (IOException)
            {
            }
        }

        public void changeScoresNormal()
        {
            isprazniLabeli();
            int i = 0;
            foreach (Player player in igraci)
            {
                if (player.Type == 1)
                {
                    if (player.Score == 1000)
                        labelPoints[i].Text = "1.000 s";
                    else
                        labelPoints[i].Text = "0." + player.Score.ToString() + " s";
                    labelNames[i].Text = player.Name;
                    i++;
                    if (i == 10)
                        break;
                }
            }
        }

        public void changeScoresHard()
        {
            isprazniLabeli();
            int i = 0;
            foreach (Player player in igraci)
            {
                if (player.Type == 2)
                {
                    if (player.Score == 1000)
                        labelPoints[i].Text = "1.000 s";
                    else
                        labelPoints[i].Text = "0." + player.Score.ToString() + " s";
                    labelNames[i].Text = player.Name;
                    i++;
                    if (i == 10)
                        break;
                }
            }
        }

        private void cbTezina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTezina.SelectedIndex != -1)
            {
                if (cbTezina.SelectedIndex == 0)
                    changeScoresNormal();
                else
                    changeScoresHard();
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
    }
}
