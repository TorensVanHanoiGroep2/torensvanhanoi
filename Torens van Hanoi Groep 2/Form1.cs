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
    }
}
