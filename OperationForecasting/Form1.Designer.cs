
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxDatchik = new System.Windows.Forms.ComboBox();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxMINI = new System.Windows.Forms.TextBox();
            this.textBoxSrok = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelRRT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 240);
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
            this.textBoxR.Location = new System.Drawing.Point(91, 85);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(132, 22);
            this.textBoxR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "R (нс)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(532, 241);
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
            this.comboBoxDatchik.Location = new System.Drawing.Point(484, 81);
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
            this.comboBoxMarka.Location = new System.Drawing.Point(484, 132);
            this.comboBoxMarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(132, 24);
            this.comboBoxMarka.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кзат = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "A = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "V = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "MINI = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Срок \r\nэксплуатации";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Датчик";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Марка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Кс-м = ";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(91, 127);
            this.textBoxK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(132, 22);
            this.textBoxK.TabIndex = 15;
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.Color.Red;
            this.textBoxA.Location = new System.Drawing.Point(91, 169);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(132, 22);
            this.textBoxA.TabIndex = 16;
            // 
            // textBoxV
            // 
            this.textBoxV.BackColor = System.Drawing.Color.Red;
            this.textBoxV.Location = new System.Drawing.Point(91, 210);
            this.textBoxV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(132, 22);
            this.textBoxV.TabIndex = 17;
            // 
            // textBoxMINI
            // 
            this.textBoxMINI.BackColor = System.Drawing.Color.Red;
            this.textBoxMINI.Location = new System.Drawing.Point(91, 252);
            this.textBoxMINI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMINI.Name = "textBoxMINI";
            this.textBoxMINI.Size = new System.Drawing.Size(132, 22);
            this.textBoxMINI.TabIndex = 18;
            // 
            // textBoxSrok
            // 
            this.textBoxSrok.Location = new System.Drawing.Point(484, 185);
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
            this.label10.Size = new System.Drawing.Size(240, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Структурно-механическй критерий";
            // 
            // labelRRT
            // 
            this.labelRRT.Location = new System.Drawing.Point(87, 313);
            this.labelRRT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRRT.Name = "labelRRT";
            this.labelRRT.Size = new System.Drawing.Size(612, 47);
            this.labelRRT.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 432);
            this.Controls.Add(this.labelRRT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSrok);
            this.Controls.Add(this.textBoxMINI);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.comboBoxDatchik);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxDatchik;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxMINI;
        private System.Windows.Forms.TextBox textBoxSrok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelRRT;
    }
}

