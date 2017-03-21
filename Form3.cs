using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win._01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            this.labelP1.Text = e.KeyCode.ToString();
            this.labelP2.Text = e.KeyValue.ToString();

            Random r = new Random();

            switch (e.KeyValue)
            {
                case 38:
                    this.labelP1.Top -= r.Next(1, 36);
                    this.labelP2.Top -= r.Next(1, 36);
                    break;

                case 40:
                    this.labelP1.Top += r.Next(1, 36);
                    this.labelP2.Top += r.Next(1, 36);
                    break;

                case 37:
                    this.labelP1.Left -= r.Next(1, 36);
                    this.labelP2.Left -= r.Next(1, 36);
                    break;
                case 39:
                    this.labelP1.Left += r.Next(1, 36);
                    this.labelP2.Left += r.Next(1, 36);
                    break;

                default:
                    break;
            }

            if (this.labelP1.Top < 0) this.labelP1.Top = this.panel1.Height;
            if (this.labelP2.Top < 0) this.labelP2.Top = this.panel1.Height;
            if (this.labelP1.Top > this.panel1.Height) this.labelP1.Top = 0;
            if (this.labelP2.Top > this.panel1.Height) this.labelP2.Top = 0;

            if (this.labelP1.Left < 0) this.labelP1.Left = this.panel1.Width;
            if (this.labelP2.Left < 0) this.labelP2.Left = this.panel1.Width;
            if (this.labelP1.Left > this.panel1.Width) this.labelP1.Left = 0;
            if (this.labelP2.Left > this.panel1.Width) this.labelP2.Left = 0;

        }
    }
}
