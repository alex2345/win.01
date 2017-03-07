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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("滿漢餐=7200元");
            listBox1.Items.Add("雞腿飯=80元");
            listBox1.Items.Add("菠菜麵=50元");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] s_array; string item; 
            for (int i = 0; i < listBox1.SelectedIndices.Count; i++)
            {
                item = listBox1.SelectedItems[i].ToString();
                s_array = item.Split('='); //[0] = "雞腿飯";  [1] = "80元"
                item = s_array[0];            // item = "雞腿飯"
                // 份數 textBox1.Text
                listBox2.Items.Add(item + "x" + textBox1.Text);
            }//for
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //刪除 listBox2 選定項目
            while (listBox2.SelectedIndices.Count > 0)
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] s_array; string item; int qty=0, price=0, total_price = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                item = listBox2.Items[i].ToString();
                s_array = item.Split('x'); //[0] = "雞腿飯";  [1] = "3"
                item = s_array[0];                               // item = "雞腿飯"
                qty = Convert.ToInt32(s_array[1]); // qty = "3"
                //
                switch (item)
                {
                    case "滿漢餐":
                        price = qty * 7200;
                        break;

                    case "雞腿飯":
                        price = qty * 80;
                        break;

                    case "菠菜麵":
                        price = qty * 50;
                        break;

                    default:
                        break;
                }
                //
                total_price += price; //總價
            }//for
            textBox2.Text = total_price.ToString();
        }
    }
}
