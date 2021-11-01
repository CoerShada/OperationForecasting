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

        }

    }
}
