using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torens_van_Hanoi_Groep_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void forLoopButton_Click(object sender, EventArgs e)
        {
            try
            {
                ulong powerint = ulong.Parse(forLoopTextBox.Text);
                ulong numberint = 2;
                ulong resultint = 1;

                for (ulong i = 0; i < powerint; i++)
                {
                    resultint *= numberint;
                }

                resultint--;

                forLoopLabel.Text = resultint.ToString();
                forLoopTextBox.Clear();
            }
            catch
            {
                MessageBox.Show("vul een aantal in tussen de 1 en 64");
            }
        }

        private void machtsverheffingButton_Click(object sender, EventArgs e)
        {
            try
            {
                double number;
                long result = 0;
                number = double.Parse(machtsverheffingTextBox.Text);



                result = (long)Math.Pow(2, number) - 1;


                machtsverheffingLabel.Text = result.ToString();
                machtsverheffingTextBox.Clear();
            }
            catch
            {
                MessageBox.Show("vul een aantal in tussen de 1 en 64");
            }
                
        }
        static ulong count(ulong zetten, ulong huidigeschijf, ulong schijven)
        {
            if (huidigeschijf > schijven)
            {
                return zetten;
            }
            else
            {
                zetten = zetten * 2 + 1;
                ulong resultaat = count(zetten, huidigeschijf + 1, schijven);

                return resultaat;
            }
        }


        private void recursieButton_Click(object sender, EventArgs e)
        {
            ulong discs;
            bool gelukt = ulong.TryParse(RecursieTextBox.Text, out discs);
            double seconden = double.Parse(RecursieTextBox.Text);
            double input = double.Parse(RecursieTextBox.Text);

            if (discs <= 64 && discs >= 1)
            {
                if (!gelukt)
                {
                   
                }
                else
                {
                    ulong result = count(0, 1, discs);
                    recursieLabel.Text = string.Format(" {1} ", discs, result);
                    seconden = Math.Pow(2, input) - 1;
                    ulong seconds = result % 60;
                    ulong minutes = result / 60 % 60;
                    ulong hours = result / 60 / 60 % 24;
                    ulong days = result / 24 / 60 / 60 % 7;
                    ulong weeks = result / 7 / 24 / 60 / 60 % 4;
                    ulong months = result / 4 / 7 / 24 / 60 / 60 % 12;
                    ulong years = result / 12 / 4 / 7 / 24 / 60 / 60 % 10;
                    ulong decenia = result / 10 / 12 / 4 / 7 / 24 / 60 / 60 % 100;
                    ulong centuries = result / 100 / 10 / 12 / 4 / 7 / 24 / 60 / 60;

                    timeLabel.Text = centuries.ToString() + " eeuwen " + decenia.ToString() + " decenia " + years.ToString() + " jaren " + months.ToString() + " maanden " + weeks.ToString() + " weken " + days.ToString() + " dagen " + hours.ToString() + " uren " + minutes.ToString() + " minuten " + seconds.ToString() + " seconden ";
                    RecursieTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Invoer Ongeldig");
            }

        }

       
    }
}
