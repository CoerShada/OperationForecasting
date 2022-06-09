using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace OperationForecasting
{
    public partial class FormMain : Form
    {
        private Dictionary<string, TextBox> _FormulesTextBoxes;
        private Dictionary<string, Button> _EditButtons;

        public FormMain()
        {
            InitializeComponent();

            controls = new Control[] {
                labelK, labelA, labelV, labelMNI, labelR, textBoxA, textBoxK, textBoxMNI, textBoxV, textBoxR

            };
            dataGridView1.Columns.Add("name", "Марка стали");
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
            UpdateGrid();
            UpdateMaterialsLists();
            CanCreateMaterial();
            CanUpdateMaterial();
            CanDeleteMaterial();
            _FormulesTextBoxes = new Dictionary<string, TextBox>()
            {
                { "SigmaL", RegistryMaterialsTextBoxFormulaSigmaL},
                { "SigmaD", RegistryMaterialsTextBoxFormulaSigmaD},
                { "A1", RegistryMaterialsTextBoxFormulaA1},
                { "A2", RegistryMaterialsTextBoxFormulaA2},
                { "SDelta", RegistryMaterialsTextBoxFormulaSDelta}
            };

            _EditButtons = new Dictionary<string, Button>()
            {
                { "SigmaL", RegistryMaterialsButtonEditSigmaL},
                { "SigmaD", RegistryMaterialsButtonEditSigmaD},
                { "A1", RegistryMaterialsButtonEditA1},
                { "A2", RegistryMaterialsButtonEditA2},
                { "SDelta", RegistryMaterialsButtonEditSDelta}
            };

        }

        private void HideSituationalComponents()
        {
            foreach (Control control in controls)
            {
                control.Visible = !control.Visible;
                control.Enabled = !control.Enabled;
            }
        }

        private void UpdateMaterialsLists()
        {
            RegistryMaterialsList.Items.Clear();
            comboBoxMarka.Items.Clear();
            Dictionary<string, Material> materials = Handler.Instance.GetMaterials();
            string[] materialsNames = materials.Keys.ToArray();
            comboBoxMarka.Items.AddRange(materialsNames);
            comboBoxMarka.SelectedIndex = 0;
            RegistryMaterialsList.Items.AddRange(materialsNames);
        }

        private bool CorrectFields()
        {
            string name = RegistryMaterialsTextBoxName.Text.Trim();
            string K = RegistryMaterialsTextBoxKsm.Text.Trim();
            string FSigmaL = RegistryMaterialsTextBoxFormulaSigmaL.Text.Trim();
            string FSigmaD = RegistryMaterialsTextBoxFormulaSigmaD.Text.Trim();
            string FA1 = RegistryMaterialsTextBoxFormulaA1.Text.Trim();
            string FA2 = RegistryMaterialsTextBoxFormulaA2.Text.Trim();
            string FSDelta = RegistryMaterialsTextBoxFormulaSDelta.Text.Trim();

            return name.Length > 0 && (!RegistryMaterialsList.Items.Contains(name) || RegistryMaterialsList.SelectedItem.Equals(name)) && (K.Length > 0 && !K[K.Length-1].Equals('.') && Convert.ToDouble(K) > 0 && Convert.ToDouble(K) < 1) && FSigmaL.Length > 0 && FSigmaD.Length > 0 && FA1.Length > 0 && FA2.Length > 0 && FSDelta.Length > 0;
        }

        private void CanCreateMaterial()
        {
            string name = RegistryMaterialsTextBoxName.Text.Trim();
            if (CorrectFields() && !RegistryMaterialsList.Items.Contains(name))
            {
                RegistryMaterialsButtonCreate.Enabled = true;

            }
            else
            {
                RegistryMaterialsButtonCreate.Enabled = false;
            }
        }

        private void CanUpdateMaterial()
        {

            if (RegistryMaterialsList.SelectedIndex >= 0 && CorrectFields())
            {
                RegistryMaterialsButtonEdit.Enabled = true;

            }
            else
            {
                RegistryMaterialsButtonEdit.Enabled = false;
            }
        }

        private void CanDeleteMaterial()
        {

            if (RegistryMaterialsList.SelectedIndex >= 0)
            {
                RegistryMaterialsButtonDelete.Enabled = true;

            }
            else
            {
                RegistryMaterialsButtonDelete.Enabled = false;
            }
        }

        private void ButtonCount_Click(object sender, EventArgs e)
        {
            string materialName = comboBoxMarka.SelectedItem.ToString();
            Material material = Handler.Instance.GetMaterials()[materialName];
            if (checkBoxChoose.Checked)
            {

                string strR = textBoxR.Text.Replace(',', '.').Trim();
                double R = double.Parse(strR, new NumberFormatInfo { NumberDecimalSeparator = "." });
                string strK = textBoxK.Text.Replace(',', '.').Trim();
                double K = double.Parse(strK, new NumberFormatInfo { NumberDecimalSeparator = "." });
                labelKSM.Text = Convert.ToString(Handler.Instance.CoefStructuralMechanical(material, R, K));
            }
            else
            {
                string strA = textBoxA.Text.Replace(',', '.').Trim();
                double A = double.Parse(strA, new NumberFormatInfo { NumberDecimalSeparator = "." });


                string strV = textBoxA.Text.Replace(',', '.').Trim();
                double V = double.Parse(strV, new NumberFormatInfo { NumberDecimalSeparator = "." });

                string strMNI = textBoxMNI.Text.Replace(',', '.').Trim();
                double MNI = double.Parse(strMNI, new NumberFormatInfo { NumberDecimalSeparator = "." });
                string Ksm = Handler.Instance.CoefStructuralMechanical(material, V, MNI, A).ToString("F", CultureInfo.CreateSpecificCulture("eu-ES"));
                labelKSM.Text = Ksm;
            }

        }

        private void CheckBoxChoose_CheckedChanged(object sender, EventArgs e)
        {
            HideSituationalComponents();
        }

        private void ButtonResidualTimeExploitation_Click(object sender, EventArgs e)
        {


            Handler handler = Handler.Instance;
            string materialName = comboBoxMarka.SelectedItem.ToString();
            Material material = Handler.Instance.GetMaterials()[materialName];

            string strCurrentTime = textBoxSrok.Text.Replace(',', '.').Trim();
            double currentTime = double.Parse(strCurrentTime, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (checkBoxChoose.Checked)
            {
                string strR = textBoxR.Text.Replace(',', '.').Trim();
                double R = double.Parse(strR, new NumberFormatInfo { NumberDecimalSeparator = "." });
                string strK = textBoxK.Text.Replace(',', '.').Trim();
                double K = double.Parse(strK, new NumberFormatInfo { NumberDecimalSeparator = "." });
                string Ksm = Handler.Instance.CoefStructuralMechanical(material, R, K).ToString("G", CultureInfo.CreateSpecificCulture("eu-ES"));

                labelKSM.Text = Ksm;
                labelRRT.Text = handler.GetOutMessage(material, currentTime, R, K);
            }
            else
            {
                string strA = textBoxA.Text.Replace(',', '.').Trim();
                double A = double.Parse(strA, new NumberFormatInfo { NumberDecimalSeparator = "." });
                string strV = textBoxA.Text.Replace(',', '.').Trim();
                double V = double.Parse(strV, new NumberFormatInfo { NumberDecimalSeparator = "." });

                string strMNI = textBoxMNI.Text.Replace(',', '.').Trim();
                double MNI = double.Parse(strMNI, new NumberFormatInfo { NumberDecimalSeparator = "." });
                string Ksm = Handler.Instance.CoefStructuralMechanical(material, V, MNI, A).ToString("G", CultureInfo.CreateSpecificCulture("eu-ES"));
                labelKSM.Text = Ksm;
                labelRRT.Text = handler.GetOutMessage(material, currentTime, V, MNI, A);
            }


        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox SenderCB = (CheckBox)sender;
            if (SenderCB.Checked)
            {
                dateTimeFrom.Enabled = false;
                dateTimeTo.Enabled = false;
            }
            else
            {
                dateTimeFrom.Enabled = true;
                dateTimeTo.Enabled = true;
            }
            UpdateGrid();
        }



        private void UpdateGrid()
        {
            Handler handler = Handler.Instance;
            dataGridView1.Rows.Clear();

            Log[] logs = handler.Logs(dateTimeFrom.Value, dateTimeTo.Value, checkBoxAllTime.Checked);
            List<Material> materials = handler.GetMaterials().Values.ToList();

            for (int i = 0; i < logs.Length; i++)
            {
                int rowNumber = dataGridView1.Rows.Add();
                Material currentMaterial = null;
                foreach (Material material in materials)
                {
                    if (material.GetId() == logs[i].MaterialId)
                    {
                        currentMaterial = material;
                        break;
                    }
                }
                dataGridView1.Rows[rowNumber].Cells["name"].Value = currentMaterial.GetName();
                if (logs[i].R != 0) dataGridView1.Rows[rowNumber].Cells["R"].Value = logs[i].R;
                if (logs[i].K != 0) dataGridView1.Rows[rowNumber].Cells["K"].Value = logs[i].K;
                if (logs[i].A != 0) dataGridView1.Rows[rowNumber].Cells["A"].Value = logs[i].A;
                if (logs[i].V != 0) dataGridView1.Rows[rowNumber].Cells["V"].Value = logs[i].V;
                if (logs[i].MNI != 0) dataGridView1.Rows[rowNumber].Cells["MNI"].Value = logs[i].MNI;
                dataGridView1.Rows[rowNumber].Cells["sigmaL"].Value = logs[i].SigmaL;
                dataGridView1.Rows[rowNumber].Cells["sigmaD"].Value = logs[i].SigmaD;
                dataGridView1.Rows[rowNumber].Cells["a1"].Value = logs[i].A1;
                dataGridView1.Rows[rowNumber].Cells["a2"].Value = logs[i].A2;
                dataGridView1.Rows[rowNumber].Cells["s0,2/delta"].Value = logs[i].SDelta;
                dataGridView1.Rows[rowNumber].Cells["Ksm"].Value = logs[i].Ksm;
                dataGridView1.Rows[rowNumber].Cells["rrt"].Value = logs[i].ResidualOperatingTime;
                dataGridView1.Rows[rowNumber].Cells["result"].Value = logs[i].Result;
            }
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {

        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            if (dateTimeFrom.Value > dateTimeTo.Value)
            {
                dateTimeFrom.Value = dateTimeTo.Value;
                return;
            }
            UpdateGrid();
        }

        private void ButtonFromulaEdit_Click(object sender, EventArgs e)
        {
            FormFormuleEditor form = new FormFormuleEditor("");
            Button button = (Button)sender;

            string name = button.Name.Substring("RegistryMaterialsButtonEdit".Length);
            TextBox formulaTextBox = _FormulesTextBoxes[name];
            form.LoadFormule(formulaTextBox.Text);

            if (form.ShowDialog() == DialogResult.Yes)
            {
                formulaTextBox.Text = form.GetFormule();
            }
            form.Close();
        }

        private void RegistryMaterialsTextBoxKsm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            TextBox textBox = (TextBox)sender;


            if (!char.IsDigit(number) && number != 8 && (number != ',' || (textBox.Text.Trim().Length==0 || textBox.Text.Contains(","))))
            {
                e.Handled = true;
            }
        }

        private void RegistryMaterialsList_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (listBox.SelectedItem == null) return;
            Material currentMaterial = Handler.Instance.GetMaterials()[(string)listBox.SelectedItem];
            RegistryMaterialsTextBoxName.Text = currentMaterial.Name;
            RegistryMaterialsTextBoxKsm.Text = Convert.ToString(currentMaterial.K);
            RegistryMaterialsTextBoxFormulaSigmaL.Text = currentMaterial.FSigmaL;
            RegistryMaterialsTextBoxFormulaSigmaD.Text = currentMaterial.FSigmaD;
            RegistryMaterialsTextBoxFormulaA1.Text = currentMaterial.FA1;
            RegistryMaterialsTextBoxFormulaA2.Text = currentMaterial.FA2;
            RegistryMaterialsTextBoxFormulaSDelta.Text = currentMaterial.FSDelta;
            RegistryMaterialsButtonCreate.Enabled = true;
            CanCreateMaterial();
            CanUpdateMaterial();
            CanDeleteMaterial();
        }

        private void RegistryMaterialsButtonCreate_Click(object sender, EventArgs e)
        {

            Material material = new Material
            {
                Name = RegistryMaterialsTextBoxName.Text,
                K = Convert.ToDouble(RegistryMaterialsTextBoxKsm.Text),
                FSigmaL = RegistryMaterialsTextBoxFormulaSigmaL.Text,
                FSigmaD = RegistryMaterialsTextBoxFormulaSigmaD.Text,
                FA1 = RegistryMaterialsTextBoxFormulaA1.Text,
                FA2 = RegistryMaterialsTextBoxFormulaA2.Text,
                FSDelta = RegistryMaterialsTextBoxFormulaSDelta.Text
            };

            DBHandler.Instance.AddMaterial(material);
            Handler.Instance.UpdateMaterials();
            UpdateMaterialsLists();
        }

        private void RegistryMaterialsButtonEdit_Click(object sender, EventArgs e)
        {
            Material material = Handler.Instance.GetMaterials()[(string)RegistryMaterialsList.SelectedItem];
            material.Name = RegistryMaterialsTextBoxName.Text.Trim();
            material.K = Convert.ToDouble(RegistryMaterialsTextBoxKsm.Text);
            material.FSigmaL = RegistryMaterialsTextBoxFormulaSigmaL.Text.Trim();
            material.FSigmaD = RegistryMaterialsTextBoxFormulaSigmaD.Text.Trim();
            material.FA1 = RegistryMaterialsTextBoxFormulaA1.Text.Trim();
            material.FA2 = RegistryMaterialsTextBoxFormulaA2.Text.Trim();
            material.FSDelta = RegistryMaterialsTextBoxFormulaSDelta.Text.Trim();

            DBHandler.Instance.UpdateMaterial(material);
            Handler.Instance.UpdateMaterials();
            UpdateMaterialsLists();
        }

        private void RegistryMaterialsButtonDelete_Click(object sender, EventArgs e)
        {
            Material material = Handler.Instance.GetMaterials()[(string)RegistryMaterialsList.SelectedItem];
            DBHandler.Instance.DeleteMaterial(material);
            Handler.Instance.UpdateMaterials();
            UpdateMaterialsLists();
        }

        private void RegistryMaterialsTextBoxes_TextChanged(object sender, EventArgs e)
        {
            CanCreateMaterial();
            CanUpdateMaterial();
            CanDeleteMaterial();
        }
    }
}
