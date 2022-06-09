using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationForecasting
{
    public partial class FormFormuleEditor : Form
    {

        string Operators = "()|+-/*^";
        string Numbers = "0123456789";
        int SizeFocuse = 0;

        public FormFormuleEditor(string name)
        {
            InitializeComponent();
            this.Text += " " + name;
        }

        private void buttonAddVariable_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TextBox editor = this.TextBoxEditor;

            string var = button.Name.Substring(button.Name.IndexOf("buttonAdd") + "buttonAdd".Length);

            editor.Text = editor.Text.Substring(0, editor.SelectionStart) + var + editor.Text.Substring(editor.SelectionStart);

            this.SizeFocuse += var.Length;
            TextBoxEditor.SelectionStart = this.SizeFocuse;
            TextBoxEditor.Focus();


            
        }


        private void ButtonAddOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string symbol = "";
            string name = button.Name.Substring(button.Name.IndexOf("buttonAdd") + "buttonAdd".Length);
            switch (name)
            {
                case "Plus":
                    symbol = "+";
                    break;
                case "Minuse":
                    symbol = "-";
                    break;
                case "Multiply":
                    symbol = "*";
                    break;
                case "Divide":
                    symbol = "/";
                    break;
                case "Pow":
                    symbol = "^";
                    break;

            }
            TextBox editor = this.TextBoxEditor;
            if (editor.Text.Length != 0 && !editor.Text[editor.Text.Length - 1].Equals("+") && !editor.Text[editor.Text.Length - 1].Equals("*") && !editor.Text[editor.Text.Length - 1].Equals("/") && !editor.Text[editor.Text.Length - 1].Equals("^"))
            {
                editor.Text = editor.Text.Substring(0, editor.SelectionStart) + " " +symbol + " " + editor.Text.Substring(editor.SelectionStart);
                this.SizeFocuse+=3;
                TextBoxEditor.SelectionStart = this.SizeFocuse;
                TextBoxEditor.Focus();
            }
        }

        private void ButtonAddLogicalOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string symbol = "";
            string name = button.Name.Substring(button.Name.IndexOf("buttonAdd") + "buttonAdd".Length);
            switch (name)
            {
                case "Larger":
                    symbol = ">";
                    break;
                case "Smaller":
                    symbol = "<";
                    break;
                case "Equals":
                    symbol = "=";
                    break;
                case "NotEquals":
                    symbol = "!=";
                    break;
                case "LargerOrEquals":
                    symbol = ">=";
                    break;
                case "SmallerOrEquals":
                    symbol = "<=";
                    break;
            }
            TextBox editor = this.TextBoxEditor;
            int counter = 0;
            for (int i = 0; i < editor.SelectionStart; i++)
            {
                if (editor.Text[i].Equals('|'))
                {
                    counter++;
                }
            }
            if (counter % 2 != 0)
            {
                editor.Text = editor.Text.Substring(0, editor.SelectionStart) + symbol + editor.Text.Substring(editor.SelectionStart);
                
                this.SizeFocuse+= symbol.Length;
                editor.SelectionStart = SizeFocuse;
                editor.Focus();
            }

        }

        public void LoadFormule(string formule)
        {
            int i = 0;
            int quantity = 0;
            formule = formule.Replace("| ", "|").Replace(".", ",");
            while (i < formule.Length)
            {
                if (formule[i] == '|')
                {
                    quantity++;
                    if (quantity % 2 == 0)
                    {
                        formule = formule.Substring(0, i + 1) + "\r\n" + formule.Substring(i + 1);
                        i += 2;
                    }
                    if (i != 0 && quantity % 2 != 0)
                    {
                        formule = formule.Substring(0, i) + "\r\n" + formule.Substring(i);
                        i += 2;
                    }
                }

                i++;
            }
            TextBoxEditor.Text = formule;

            this.SizeFocuse = formule.Length;
        }

        public string GetFormule()
        {
            return TextBoxEditor.Text.Replace("\r", "").Replace("\n", "").Replace(".", ",");
        }

        private void ButtonAddNumber_Click(object sender, EventArgs e)
        {
            string text = TextBoxEditor.Text.Trim();

            if (text.Length == 0 || Numbers.Contains(text.Last()) || Operators.Contains(text.Last()))
            {
                TextBoxEditor.Text = TextBoxEditor.Text.Substring(0, TextBoxEditor.SelectionStart) + ((Button)sender).Text.Trim() + TextBoxEditor.Text.Substring(TextBoxEditor.SelectionStart);
            }
            this.SizeFocuse++;
            TextBoxEditor.SelectionStart = this.SizeFocuse;
            TextBoxEditor.Focus();
        }

        private void buttonAddIf_Click(object sender, EventArgs e)
        {
            string text = TextBoxEditor.Text.Trim();


            string condition = "";
            if (text.Length != 0)
            {
                condition += "\r\n";
            }

            condition += "||\r\n";
            TextBoxEditor.Text = TextBoxEditor.Text.Substring(0, TextBoxEditor.SelectionStart) + condition + TextBoxEditor.Text.Substring(TextBoxEditor.SelectionStart);

            this.SizeFocuse += condition.Length-3;
            TextBoxEditor.SelectionStart = this.SizeFocuse;
            TextBoxEditor.Focus();
        }

        private void TextBoxEditor_CursorChanged(object sender, EventArgs e)
        {
            this.SizeFocuse = ((TextBox)sender).SelectionStart;

        }

        private void TextBoxEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char number = e.KeyChar;

            if (number == 8 )
            {
                this.SizeFocuse --;
            }
            else
            {
                this.SizeFocuse++;

            }
            Console.WriteLine(this.SizeFocuse);

        }
    }
}
