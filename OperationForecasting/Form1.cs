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

            controls = new Control[] {
                labelK, labelA, labelV, labelMNI, labelR, textBoxA, textBoxK, textBoxMNI, textBoxV, textBoxR

            };

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

        private void HideSituationalComponents()
        {
            foreach (Control control in controls)
            {
                control.Visible = !control.Visible;
                control.Enabled = !control.Enabled;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexSteel = this.comboBoxMarka.SelectedIndex;
            Steel steel = this.handler.GetSteels()[indexSteel];
            if (this.checkBoxChoose.Checked)
            {

                string strR = this.textBoxR.Text.Replace(',', '.').Trim();
                double R = double.Parse(strR, new NumberFormatInfo { NumberDecimalSeparator = "." });
                string strK = this.textBoxK.Text.Replace(',', '.').Trim();
                double K = double.Parse(strK, new NumberFormatInfo { NumberDecimalSeparator = "." });
                this.labelKSM.Text = Convert.ToString(this.handler.CoefStructuralMechanical(steel, ConvertHelper.RtoV(R), ConvertHelper.KtoMNI(K)));
            }
            else
            {
                string strA = this.textBoxA.Text.Replace(',', '.').Trim();
                double A = double.Parse(strA, new NumberFormatInfo { NumberDecimalSeparator = "." });


                string strV = this.textBoxA.Text.Replace(',', '.').Trim();
                double V = double.Parse(strV, new NumberFormatInfo { NumberDecimalSeparator = "." });

                string strMNI = this.textBoxMNI.Text.Replace(',', '.').Trim();
                double MNI = double.Parse(strMNI, new NumberFormatInfo { NumberDecimalSeparator = "." });
                this.labelKSM.Text = Convert.ToString(this.handler.CoefStructuralMechanical(steel, V, MNI, A));
            }
              
        }

        private void checkBoxChoose_CheckedChanged(object sender, EventArgs e)
        {
            HideSituationalComponents();
        }

        private void buttonResidualTimeExploitation_Click(object sender, EventArgs e)
        {
            int indexSteel = this.comboBoxMarka.SelectedIndex;
            Steel steel = this.handler.GetSteels()[indexSteel];

            string strCurrentTime = this.textBoxSrok.Text.Replace(',', '.').Trim();
            double currentTime = double.Parse(strCurrentTime, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (this.checkBoxChoose.Checked)
            {
                string strR = this.textBoxR.Text.Replace(',', '.').Trim();
                double R = double.Parse(strR, new NumberFormatInfo { NumberDecimalSeparator = "." });
                string strK = this.textBoxK.Text.Replace(',', '.').Trim();
                double K = double.Parse(strK, new NumberFormatInfo { NumberDecimalSeparator = "." });
                this.labelKSM.Text = Convert.ToString(this.handler.CoefStructuralMechanical(steel, ConvertHelper.RtoV(R), ConvertHelper.KtoMNI(K)));
                this.labelRRT.Text = this.handler.GetOutMessage(steel, currentTime, ConvertHelper.RtoV(R), ConvertHelper.KtoMNI(K));
            }
            else
            {
                string strA = this.textBoxA.Text.Replace(',', '.').Trim();
                double A = double.Parse(strA, new NumberFormatInfo { NumberDecimalSeparator = "." });

                
                string strV = this.textBoxA.Text.Replace(',', '.').Trim();
                double V = double.Parse(strV, new NumberFormatInfo { NumberDecimalSeparator = "." });

                string strMNI = this.textBoxMNI.Text.Replace(',', '.').Trim();
                double MNI = double.Parse(strMNI, new NumberFormatInfo { NumberDecimalSeparator = "." });
                this.labelKSM.Text = Convert.ToString(this.handler.CoefStructuralMechanical(steel, V, MNI, A));
                this.labelRRT.Text = this.handler.GetOutMessage(steel, currentTime, V, MNI, A);
            }
        }
    }
}
