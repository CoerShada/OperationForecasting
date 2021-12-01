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
            dataGridView1.Columns.Add("steelName", "Марка стали");
            dataGridView1.Columns.Add("R", "R");
            dataGridView1.Columns.Add("K", "K зат");
            dataGridView1.Columns.Add("A", "A");
            dataGridView1.Columns.Add("V", "V");
            dataGridView1.Columns.Add("MNI", "MNI");
            dataGridView1.Columns.Add("sigmaL", "σ л");
            dataGridView1.Columns.Add("sigmaD", "σ д");
            dataGridView1.Columns.Add("a1", "α1");
            dataGridView1.Columns.Add("a2", "α2");
            dataGridView1.Columns.Add("s0,2/delta", "S0.2/ δ");
            dataGridView1.Columns.Add("Ksm", "K с-м");
            dataGridView1.Columns.Add("rrt", "Оставшееся время эксплуатации");
            dataGridView1.Columns.Add("result", "Вывод");
            updateGrid();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox SenderCB = (CheckBox)sender;
            if (SenderCB.Checked)
            {
                this.dateTimeFrom.Enabled = false;
                this.dateTimeTo.Enabled = false;
            }
            else
            {
                this.dateTimeFrom.Enabled = true;
                this.dateTimeTo.Enabled = true;
            }
            updateGrid();
        }



        private void updateGrid()
        {
            dataGridView1.Rows.Clear();

            Log[] logs = handler.Logs(this.dateTimeFrom.Value, this.dateTimeTo.Value, this.checkBoxAllTime.Checked);


            for (int i = 0; i < logs.Length; i++)
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells["steelName"].Value = logs[i].steel_name;
                if (logs[i].R != 0) dataGridView1.Rows[rowNumber].Cells["R"].Value = logs[i].R;
                if (logs[i].K != 0) dataGridView1.Rows[rowNumber].Cells["K"].Value = logs[i].K;
                if (logs[i].A != 0) dataGridView1.Rows[rowNumber].Cells["A"].Value = logs[i].A;
                if (logs[i].V != 0) dataGridView1.Rows[rowNumber].Cells["V"].Value = logs[i].V;
                if (logs[i].MNI != 0) dataGridView1.Rows[rowNumber].Cells["MNI"].Value = logs[i].MNI;
                dataGridView1.Rows[rowNumber].Cells["sigmaL"].Value = logs[i].amplitude_of_internal_stress_fields;
                dataGridView1.Rows[rowNumber].Cells["sigmaD"].Value = logs[i].shear_stresses;
                dataGridView1.Rows[rowNumber].Cells["a1"].Value = logs[i].deformation_indicator_1;
                dataGridView1.Rows[rowNumber].Cells["a2"].Value = logs[i].deformation_indicator_2;
                dataGridView1.Rows[rowNumber].Cells["s0,2/delta"].Value = logs[i].ratio_of_yield_strength_to_elongation;
                dataGridView1.Rows[rowNumber].Cells["Ksm"].Value = logs[i].coef_structural_mechanical;
                dataGridView1.Rows[rowNumber].Cells["rrt"].Value = logs[i].residual_operating_time;
                dataGridView1.Rows[rowNumber].Cells["result"].Value = logs[i].result;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

        }

        private void onValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimeFrom.Value> this.dateTimeTo.Value)
            {
                this.dateTimeFrom.Value = this.dateTimeTo.Value;
                return;
            }
            updateGrid();
        }
    }
}
