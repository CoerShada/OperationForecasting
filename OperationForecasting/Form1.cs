using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationForecasting
{
    public partial class Form1 : Form
    {
        Handler handler;
        public Form1()
        {
            this.handler = new Handler();
            InitializeComponent();
            InitComponentsContent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void InitComponentsContent()
        {
            Steel[] steels = handler.GetSteels();
            string[] steelsNames = new string[steels.Length];
            for (int i = 0; i<steels.Length; i++)
            {
                steelsNames[i] = steels[i].GetSteelName();
            }
            this.comboBoxMarka.Items.AddRange(steelsNames);
            this.comboBoxMarka.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexSteel = this.comboBoxMarka.SelectedIndex;
            Steel steel = this.handler.GetSteels()[indexSteel];

            string strCurrentTime = this.textBoxR.Text.Replace(',', '.').Trim();
            double currentTime = double.Parse(strCurrentTime, new NumberFormatInfo { NumberDecimalSeparator = "." });
            string strR = this.textBoxR.Text.Replace(',', '.').Trim();
            double R = double.Parse(strR, new NumberFormatInfo { NumberDecimalSeparator = "." });
            string strK = this.textBoxK.Text.Replace(',', '.').Trim();
            double K = double.Parse(strK, new NumberFormatInfo { NumberDecimalSeparator = "." });
            this.labelRRT.Text = this.handler.GetOutMessage(steel, currentTime, R, K);
        }
    }
}
