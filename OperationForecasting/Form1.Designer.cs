
namespace OperationForecasting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxDatchik = new System.Windows.Forms.ComboBox();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.labelK = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.labelMNI = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxMNI = new System.Windows.Forms.TextBox();
            this.textBoxSrok = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelRRT = new System.Windows.Forms.Label();
            this.checkBoxChoose = new System.Windows.Forms.CheckBox();
            this.labelKSM = new System.Windows.Forms.Label();
            this.buttonResidualTimeExploitation = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabPageDataBase = new System.Windows.Forms.TabPage();
            this.groupBoxBeginExport = new System.Windows.Forms.GroupBox();
            this.dateTimeBeginExport = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeEndExport = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageReference = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPageDataBase.SuspendLayout();
            this.groupBoxBeginExport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageReference.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(103, 46);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(132, 22);
            this.textBoxR.TabIndex = 1;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(39, 49);
            this.labelR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(47, 17);
            this.labelR.TabIndex = 2;
            this.labelR.Text = "R (нс)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(544, 201);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Справка";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBoxDatchik
            // 
            this.comboBoxDatchik.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxDatchik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatchik.FormattingEnabled = true;
            this.comboBoxDatchik.Location = new System.Drawing.Point(496, 42);
            this.comboBoxDatchik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDatchik.Name = "comboBoxDatchik";
            this.comboBoxDatchik.Size = new System.Drawing.Size(132, 24);
            this.comboBoxDatchik.TabIndex = 5;
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxMarka.Location = new System.Drawing.Point(496, 92);
            this.comboBoxMarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(132, 24);
            this.comboBoxMarka.TabIndex = 6;
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(29, 91);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(55, 17);
            this.labelK.TabIndex = 7;
            this.labelK.Text = "Кзат = ";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Enabled = false;
            this.labelA.Location = new System.Drawing.Point(52, 49);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(33, 17);
            this.labelA.TabIndex = 8;
            this.labelA.Text = "A = ";
            this.labelA.Visible = false;
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Enabled = false;
            this.labelV.Location = new System.Drawing.Point(52, 91);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(33, 17);
            this.labelV.TabIndex = 9;
            this.labelV.Text = "V = ";
            this.labelV.Visible = false;
            // 
            // labelMNI
            // 
            this.labelMNI.AutoSize = true;
            this.labelMNI.Enabled = false;
            this.labelMNI.Location = new System.Drawing.Point(32, 129);
            this.labelMNI.Name = "labelMNI";
            this.labelMNI.Size = new System.Drawing.Size(48, 17);
            this.labelMNI.TabIndex = 10;
            this.labelMNI.Text = "MNI = ";
            this.labelMNI.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Срок \r\nэксплуатации";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Датчик";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Марка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Кс-м = ";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(103, 87);
            this.textBoxK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(132, 22);
            this.textBoxK.TabIndex = 15;
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxA.Enabled = false;
            this.textBoxA.Location = new System.Drawing.Point(103, 46);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(132, 22);
            this.textBoxA.TabIndex = 16;
            this.textBoxA.Visible = false;
            // 
            // textBoxV
            // 
            this.textBoxV.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxV.Enabled = false;
            this.textBoxV.Location = new System.Drawing.Point(103, 87);
            this.textBoxV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(132, 22);
            this.textBoxV.TabIndex = 17;
            this.textBoxV.Visible = false;
            // 
            // textBoxMNI
            // 
            this.textBoxMNI.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMNI.Enabled = false;
            this.textBoxMNI.Location = new System.Drawing.Point(103, 129);
            this.textBoxMNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMNI.Name = "textBoxMNI";
            this.textBoxMNI.Size = new System.Drawing.Size(132, 22);
            this.textBoxMNI.TabIndex = 18;
            this.textBoxMNI.Visible = false;
            // 
            // textBoxSrok
            // 
            this.textBoxSrok.Location = new System.Drawing.Point(496, 145);
            this.textBoxSrok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSrok.Name = "textBoxSrok";
            this.textBoxSrok.Size = new System.Drawing.Size(132, 22);
            this.textBoxSrok.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 20;
            // 
            // labelRRT
            // 
            this.labelRRT.Location = new System.Drawing.Point(29, 268);
            this.labelRRT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRRT.Name = "labelRRT";
            this.labelRRT.Size = new System.Drawing.Size(332, 47);
            this.labelRRT.TabIndex = 21;
            // 
            // checkBoxChoose
            // 
            this.checkBoxChoose.AutoSize = true;
            this.checkBoxChoose.Checked = true;
            this.checkBoxChoose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChoose.Location = new System.Drawing.Point(33, 7);
            this.checkBoxChoose.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxChoose.Name = "checkBoxChoose";
            this.checkBoxChoose.Size = new System.Drawing.Size(134, 21);
            this.checkBoxChoose.TabIndex = 22;
            this.checkBoxChoose.Text = "Расчет через R";
            this.checkBoxChoose.UseVisualStyleBackColor = true;
            this.checkBoxChoose.CheckedChanged += new System.EventHandler(this.checkBoxChoose_CheckedChanged);
            // 
            // labelKSM
            // 
            this.labelKSM.Location = new System.Drawing.Point(96, 222);
            this.labelKSM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKSM.Name = "labelKSM";
            this.labelKSM.Size = new System.Drawing.Size(133, 28);
            this.labelKSM.TabIndex = 23;
            // 
            // buttonResidualTimeExploitation
            // 
            this.buttonResidualTimeExploitation.Location = new System.Drawing.Point(369, 245);
            this.buttonResidualTimeExploitation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResidualTimeExploitation.Name = "buttonResidualTimeExploitation";
            this.buttonResidualTimeExploitation.Size = new System.Drawing.Size(341, 37);
            this.buttonResidualTimeExploitation.TabIndex = 24;
            this.buttonResidualTimeExploitation.Text = "Расчет остаточного времени эксплуатации";
            this.buttonResidualTimeExploitation.UseVisualStyleBackColor = true;
            this.buttonResidualTimeExploitation.Click += new System.EventHandler(this.buttonResidualTimeExploitation_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabPageDataBase);
            this.tabControl.Controls.Add(this.tabPageReference);
            this.tabControl.Location = new System.Drawing.Point(16, 9);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(777, 367);
            this.tabControl.TabIndex = 25;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.checkBoxChoose);
            this.tabMain.Controls.Add(this.buttonResidualTimeExploitation);
            this.tabMain.Controls.Add(this.button1);
            this.tabMain.Controls.Add(this.labelKSM);
            this.tabMain.Controls.Add(this.textBoxR);
            this.tabMain.Controls.Add(this.labelR);
            this.tabMain.Controls.Add(this.labelRRT);
            this.tabMain.Controls.Add(this.button2);
            this.tabMain.Controls.Add(this.comboBoxDatchik);
            this.tabMain.Controls.Add(this.textBoxSrok);
            this.tabMain.Controls.Add(this.comboBoxMarka);
            this.tabMain.Controls.Add(this.textBoxMNI);
            this.tabMain.Controls.Add(this.labelK);
            this.tabMain.Controls.Add(this.textBoxV);
            this.tabMain.Controls.Add(this.labelA);
            this.tabMain.Controls.Add(this.textBoxA);
            this.tabMain.Controls.Add(this.labelV);
            this.tabMain.Controls.Add(this.textBoxK);
            this.tabMain.Controls.Add(this.labelMNI);
            this.tabMain.Controls.Add(this.label9);
            this.tabMain.Controls.Add(this.label6);
            this.tabMain.Controls.Add(this.label8);
            this.tabMain.Controls.Add(this.label7);
            this.tabMain.Location = new System.Drawing.Point(4, 25);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(4);
            this.tabMain.Size = new System.Drawing.Size(769, 338);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Главная";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabPageDataBase
            // 
            this.tabPageDataBase.Controls.Add(this.groupBoxBeginExport);
            this.tabPageDataBase.Controls.Add(this.groupBox1);
            this.tabPageDataBase.Controls.Add(this.checkBox1);
            this.tabPageDataBase.Controls.Add(this.buttonExport);
            this.tabPageDataBase.Controls.Add(this.dataGridView1);
            this.tabPageDataBase.Location = new System.Drawing.Point(4, 25);
            this.tabPageDataBase.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageDataBase.Name = "tabPageDataBase";
            this.tabPageDataBase.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageDataBase.Size = new System.Drawing.Size(769, 338);
            this.tabPageDataBase.TabIndex = 1;
            this.tabPageDataBase.Text = "База данных";
            this.tabPageDataBase.UseVisualStyleBackColor = true;
            // 
            // groupBoxBeginExport
            // 
            this.groupBoxBeginExport.Controls.Add(this.dateTimeBeginExport);
            this.groupBoxBeginExport.Location = new System.Drawing.Point(541, 106);
            this.groupBoxBeginExport.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBeginExport.Name = "groupBoxBeginExport";
            this.groupBoxBeginExport.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBeginExport.Size = new System.Drawing.Size(217, 49);
            this.groupBoxBeginExport.TabIndex = 7;
            this.groupBoxBeginExport.TabStop = false;
            this.groupBoxBeginExport.Text = "Начало выгрузки";
            // 
            // dateTimeBeginExport
            // 
            this.dateTimeBeginExport.Location = new System.Drawing.Point(4, 17);
            this.dateTimeBeginExport.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeBeginExport.Name = "dateTimeBeginExport";
            this.dateTimeBeginExport.Size = new System.Drawing.Size(200, 22);
            this.dateTimeBeginExport.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeEndExport);
            this.groupBox1.Location = new System.Drawing.Point(541, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(217, 49);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Конец выгрузки";
            // 
            // dateTimeEndExport
            // 
            this.dateTimeEndExport.Location = new System.Drawing.Point(4, 21);
            this.dateTimeEndExport.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeEndExport.Name = "dateTimeEndExport";
            this.dateTimeEndExport.Size = new System.Drawing.Size(204, 22);
            this.dateTimeEndExport.TabIndex = 2;
            this.dateTimeEndExport.Value = new System.DateTime(2021, 11, 30, 21, 26, 11, 0);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(541, 224);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "За все время";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(541, 284);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(217, 43);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "Выгрузить данные из базы";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(525, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.MaximumSize = new System.Drawing.Size(760, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // tabPageReference
            // 
            this.tabPageReference.Controls.Add(this.textBox1);
            this.tabPageReference.Controls.Add(this.label1);
            this.tabPageReference.Location = new System.Drawing.Point(4, 25);
            this.tabPageReference.Name = "tabPageReference";
            this.tabPageReference.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReference.Size = new System.Drawing.Size(769, 338);
            this.tabPageReference.TabIndex = 2;
            this.tabPageReference.Text = "Справка";
            this.tabPageReference.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-4, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(773, 338);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 394);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Структурно-механическй критерий";
            this.tabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabPageDataBase.ResumeLayout(false);
            this.tabPageDataBase.PerformLayout();
            this.groupBoxBeginExport.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageReference.ResumeLayout(false);
            this.tabPageReference.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxDatchik;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelMNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxMNI;
        private System.Windows.Forms.TextBox textBoxSrok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelRRT;
        private System.Windows.Forms.CheckBox checkBoxChoose;

        private System.Windows.Forms.Control[] controls;
        private System.Windows.Forms.Label labelKSM;
        private System.Windows.Forms.Button buttonResidualTimeExploitation;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabPageDataBase;
        private System.Windows.Forms.GroupBox groupBoxBeginExport;
        private System.Windows.Forms.DateTimePicker dateTimeBeginExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeEndExport;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageReference;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

