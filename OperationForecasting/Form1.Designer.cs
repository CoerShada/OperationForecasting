
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(68, 69);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 1;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(20, 72);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(36, 13);
            this.labelR.TabIndex = 2;
            this.labelR.Text = "R (нс)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(399, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Справка";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBoxDatchik
            // 
            this.comboBoxDatchik.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxDatchik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatchik.FormattingEnabled = true;
            this.comboBoxDatchik.Location = new System.Drawing.Point(363, 66);
            this.comboBoxDatchik.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDatchik.Name = "comboBoxDatchik";
            this.comboBoxDatchik.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDatchik.TabIndex = 5;
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxMarka.Location = new System.Drawing.Point(363, 107);
            this.comboBoxMarka.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMarka.TabIndex = 6;
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(13, 106);
            this.labelK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(43, 13);
            this.labelK.TabIndex = 7;
            this.labelK.Text = "Кзат = ";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Enabled = false;
            this.labelA.Location = new System.Drawing.Point(30, 72);
            this.labelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(26, 13);
            this.labelA.TabIndex = 8;
            this.labelA.Text = "A = ";
            this.labelA.Visible = false;
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Enabled = false;
            this.labelV.Location = new System.Drawing.Point(30, 106);
            this.labelV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(26, 13);
            this.labelV.TabIndex = 9;
            this.labelV.Text = "V = ";
            this.labelV.Visible = false;
            // 
            // labelMNI
            // 
            this.labelMNI.AutoSize = true;
            this.labelMNI.Enabled = false;
            this.labelMNI.Location = new System.Drawing.Point(15, 137);
            this.labelMNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMNI.Name = "labelMNI";
            this.labelMNI.Size = new System.Drawing.Size(39, 13);
            this.labelMNI.TabIndex = 10;
            this.labelMNI.Text = "MNI = ";
            this.labelMNI.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Срок \r\nэксплуатации";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Датчик";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Марка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Кс-м = ";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(68, 103);
            this.textBoxK.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(100, 20);
            this.textBoxK.TabIndex = 15;
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxA.Enabled = false;
            this.textBoxA.Location = new System.Drawing.Point(68, 69);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 16;
            this.textBoxA.Visible = false;
            // 
            // textBoxV
            // 
            this.textBoxV.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxV.Enabled = false;
            this.textBoxV.Location = new System.Drawing.Point(68, 103);
            this.textBoxV.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(100, 20);
            this.textBoxV.TabIndex = 17;
            this.textBoxV.Visible = false;
            // 
            // textBoxMNI
            // 
            this.textBoxMNI.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMNI.Enabled = false;
            this.textBoxMNI.Location = new System.Drawing.Point(68, 137);
            this.textBoxMNI.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMNI.Name = "textBoxMNI";
            this.textBoxMNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxMNI.TabIndex = 18;
            this.textBoxMNI.Visible = false;
            // 
            // textBoxSrok
            // 
            this.textBoxSrok.Location = new System.Drawing.Point(363, 150);
            this.textBoxSrok.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSrok.Name = "textBoxSrok";
            this.textBoxSrok.Size = new System.Drawing.Size(100, 20);
            this.textBoxSrok.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 20;
            // 
            // labelRRT
            // 
            this.labelRRT.Location = new System.Drawing.Point(13, 250);
            this.labelRRT.Name = "labelRRT";
            this.labelRRT.Size = new System.Drawing.Size(249, 38);
            this.labelRRT.TabIndex = 21;
            // 
            // checkBoxChoose
            // 
            this.checkBoxChoose.AutoSize = true;
            this.checkBoxChoose.Checked = true;
            this.checkBoxChoose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChoose.Location = new System.Drawing.Point(16, 38);
            this.checkBoxChoose.Name = "checkBoxChoose";
            this.checkBoxChoose.Size = new System.Drawing.Size(104, 17);
            this.checkBoxChoose.TabIndex = 22;
            this.checkBoxChoose.Text = "Расчет через R";
            this.checkBoxChoose.UseVisualStyleBackColor = true;
            this.checkBoxChoose.CheckedChanged += new System.EventHandler(this.checkBoxChoose_CheckedChanged);
            // 
            // labelKSM
            // 
            this.labelKSM.Location = new System.Drawing.Point(65, 212);
            this.labelKSM.Name = "labelKSM";
            this.labelKSM.Size = new System.Drawing.Size(100, 23);
            this.labelKSM.TabIndex = 23;
            // 
            // buttonResidualTimeExploitation
            // 
            this.buttonResidualTimeExploitation.Location = new System.Drawing.Point(268, 231);
            this.buttonResidualTimeExploitation.Name = "buttonResidualTimeExploitation";
            this.buttonResidualTimeExploitation.Size = new System.Drawing.Size(256, 30);
            this.buttonResidualTimeExploitation.TabIndex = 24;
            this.buttonResidualTimeExploitation.Text = "Расчет остаточного времени эксплуатации";
            this.buttonResidualTimeExploitation.UseVisualStyleBackColor = true;
            this.buttonResidualTimeExploitation.Click += new System.EventHandler(this.buttonResidualTimeExploitation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 301);
            this.Controls.Add(this.buttonResidualTimeExploitation);
            this.Controls.Add(this.labelKSM);
            this.Controls.Add(this.checkBoxChoose);
            this.Controls.Add(this.labelRRT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSrok);
            this.Controls.Add(this.textBoxMNI);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelMNI);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.comboBoxDatchik);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Структурно-механическй критерий";
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
    }
}

