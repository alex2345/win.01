using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace win._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\Images\火隱.jpg");
            // 執行路徑 E:\106ERPA06\a_蔡宏松老師\win.01\bin\Debug\
            // 圖片路徑 E:\106ERPA06\a_蔡宏松老師\win.01\images\
            // 結論：必須回溯兩層到 E:\106ERPA06\a_蔡宏松老師\win.01\
            // 或是直接把圖片存檔到 E:\106ERPA06\a_蔡宏松老師\win.01\bin\Debug\
            // 然後下達 pictureBox1.Image = Image.FromFile(@".\火隱之一.jpg");

            listBox1.Items.Add("333");
            listBox1.Items.Add("111");
            listBox1.Items.Add("222");

            //string s1; // unicode 轉換 = http://www.ifreesite.com/unicode-ascii-ansi.htm
            //s1 = "\u4e00\u4e01\u4e02\u4e03"; //一丁丂七
            //textBox1.Text = s1;

            //char a1, a2, a3, a4; 
            //a1 = '\u4e00'; //一丁丂七
            //a2 = '\u4e01'; //丁
            //a3 = '\u4e02'; //丂
            //a4 = '\u4e03'; //七
            // textBox1.Text = a1.ToString() + a2.ToString() + a3.ToString() + a4.ToString();
            // MessageBox.Show(a1.ToString() + a2.ToString() + a3.ToString() + a4.ToString());

            //int n1, n2;
            //n1 = (int)'一'; n2 = (int)'丁';
            //n1 = (int)s1[0]; n2 = (int)s1[1];
            //textBox2.Text = Convert.ToString(n1, 16).ToUpper() + " " + Convert.ToString(n2, 16).ToUpper();
            //MessageBox.Show(Convert.ToString(n1, 16).ToUpper() + " " + Convert.ToString(n2, 16).ToUpper());
        }

        private void button1_Click(object sender, EventArgs e)// [Tenary]
        {
            sbyte n1 = 5;  MessageBox.Show("n1 is " + Convert.ToString(n1, 2).PadLeft( 8,'0') );
            sbyte n2 = -6; MessageBox.Show("n2 is " + Convert.ToString(n2, 2).PadLeft(8, '0'));

            //int a1 = Convert.ToInt32(textBox1.Text);
            //int b1 = Convert.ToInt32(textBox2.Text);
            //int max1 = a1 > b1 ? a1 : b1; 
            //MessageBox.Show("the max (a1, b1)  is " + max1.ToString());

            long a2 = Convert.ToInt64(textBox1.Text);
            long b2 = Convert.ToInt64(textBox2.Text);
            long max2 = a2 > b2 ? a2 : b2; 
            MessageBox.Show("the max (a2, b2) is " + max2.ToString());
        }

        private void button2_Click(object sender, EventArgs e)// [If else]
        {
            long a2 = Convert.ToInt64(textBox1.Text);
            long b2 = Convert.ToInt64(textBox2.Text);
            long max2;
            if (a2 > b2) { max2 = a2; }  else { max2 = b2; }
            MessageBox.Show("the max (a2, b2) is " + max2.ToString());
        }

        private void button3_Click(object sender, EventArgs e) //[Division]
        {   double a, b, c;
            a = 5 / 3;    //1
            MessageBox.Show("a=\t" + a.ToString());
            b = 5 / 3.0;  //1.66666666
            MessageBox.Show("b=\n" + b.ToString());
            c = 5 % 3;    //2  remainder
            MessageBox.Show("c=\n\n" + c.ToString());
        }

        private void button4_Click(object sender, EventArgs e)// [Boolean] 
        {
            bool b1 = true, b2 = false;   string s1, s2;
            // s1 = (b1) ? "true" : "false";     MessageBox.Show(s1);
            // s2 = (b2) ? "true" : "false";     MessageBox.Show(s2);
            s1 = (b1 && b2) ? "true" : "false";   MessageBox.Show(s1);
            s2 = (b1 || b2) ? "true" : "false";     MessageBox.Show(s2);

        }
        private void AdjustDataGridViewSizing()
        {   dataGridView1.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //
            int firstColumn = 0, secondColumn = 1;
            dataGridView1.Columns[firstColumn].Width = 40;
            dataGridView1.Columns[secondColumn].Width = 40;
        }//private void AdjustDataGridViewSizing()
        private void button5_Click(object sender, EventArgs e)// [Truth table]
        {   // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnCount = 5;
            dataGridView1.ColumnHeadersVisible = true;
            AdjustDataGridViewSizing();

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle =  new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Aqua;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dataGridView1.Columns[0].Name = "A";
            dataGridView1.Columns[1].Name = "B";
            dataGridView1.Columns[2].Name = "A && B";
            dataGridView1.Columns[3].Name = "A || B";
            dataGridView1.Columns[4].Name = "!A";

            // Populate the rows.
            bool A, B, Ans1, Ans2, Ans3;
            //
            A = true; B = true; Ans1 = A && B; Ans2 = A || B; Ans3 = !A;
            string[] row1 = new string[] { A.ToString(), B.ToString(), Ans1.ToString(), Ans2.ToString(), Ans3.ToString() };
            A = true; B = false; Ans1 = A && B; Ans2 = A || B; Ans3 = !A;
            string[] row2 = new string[] { A.ToString(), B.ToString(), Ans1.ToString(), Ans2.ToString(), Ans3.ToString() };

            A = false; B = true; Ans1 = A && B; Ans2 = A || B; Ans3 = !A;
            string[] row3 = new string[] { A.ToString(), B.ToString(), Ans1.ToString(), Ans2.ToString(), Ans3.ToString() };
            A = false; B = false; Ans1 = A && B; Ans2 = A || B; Ans3 = !A;
            string[] row4 = new string[] { A.ToString(), B.ToString(), Ans1.ToString(), Ans2.ToString(), Ans3.ToString() };
            //
            object[] rows = new object[] { row1, row2, row3, row4 };
            foreach (string[] rowArray in rows) { dataGridView1.Rows.Add(rowArray); }
            //
            // Set the row header style.
            DataGridViewCellStyle rowHeaderStyle = new DataGridViewCellStyle();
            rowHeaderStyle.BackColor = Color.Lime;
            rowHeaderStyle.Font = new Font("Verdana", 7, FontStyle.Italic);
            dataGridView1.RowHeadersDefaultCellStyle = rowHeaderStyle;
            //
            dataGridView1.Rows[0].HeaderCell.Value = "a";
            dataGridView1.Rows[1].HeaderCell.Value = "b";
            dataGridView1.Rows[2].HeaderCell.Value = "c";
            dataGridView1.Rows[3].HeaderCell.Value = "d";
            //
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 7);

        }//private void button5_Click(object sender, EventArgs e)

        private void button6_Click(object sender, EventArgs e)// RichTextBox
        {     
            richTextBox1.Text = "(1,1)" + "\t" + "(1,2)" + '\t' + "(1,3)" + "\n" 
                              + "(2,1)" + "\t" + "(2,2)" + '\t' + "(2,3)";

            //string[] 與 richTextBox 的溝通 (大同世界)
            string[] str = new string[] { "早安", "午安", "晚安" };
            richTextBox1.Lines = str;

            //listBox 與 richTextBox 的溝通 (大同世界)
            listBox1.Items.AddRange(richTextBox1.Lines); 

            //建立相同成員個數之動態陣列
            string[] ary = new string[richTextBox1.Lines.Count()];
            richTextBox1.Lines.CopyTo(ary, 0); //copy to array

            //陣列排序
            Array.Sort(ary);
            foreach (string p in ary)
            {
                MessageBox.Show(p);
            }

        }

        private void CreateMyListView()
        {
            // Create a new ListView control.
            ListView listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(200, 200), new Size(300, 1000));

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0); //first row
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1); //second row
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0); //third row
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);
            
            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();
            
            /*
            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage1.bmp"));
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage2.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("C:\\MyLargeImage1.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("C:\\MyLargeImage2.bmp"));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;
            */

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
        }
        private void button7_Click(object sender, EventArgs e)// ListView
        {
            CreateMyListView();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
            // Shift operator  >> << (page 2-20)
            byte a, b;
            a = 20 >> 1;    //10
            b = 20 << 1;    //40
            MessageBox.Show("20>>1 = " + a.ToString() + " [10]");
            MessageBox.Show("20<<1 = " + b.ToString() + " [10]");
            MessageBox.Show("20=" + Convert.ToString(20, 2)  + " [2]"
                + "\n20>>1=" + Convert.ToString(a, 2) + " [2]"
                + "\n20<<1=" + Convert.ToString(b, 2) + " [2]" );
             */

            // String.Format() https://msdn.microsoft.com/zh-tw/library/bb311038.aspx

            /*
            //string to char to hexadecimal 字串轉字元轉十六進
            string input = "Hello World!"; char[] values = input.ToCharArray();
            foreach (char letter in values)
            {   // Get the integral value of the character.
                int value = Convert.ToInt32(letter);
                // Convert the decimal value to a hexadecimal value in string form.
                string hexOutput = String.Format("{0:X}", value);
                // String.Format() https://msdn.microsoft.com/zh-tw/library/txafckwd(v=vs.110).aspx
                MessageBox.Show("Hexadecimal value of " + letter + " is " + hexOutput);
            }//for 
            */

            //string to char to unicode 字串轉字元轉 unicode
            string input = "Hi 一非"; char[] values = input.ToCharArray();
            foreach (char letter in values)
            {   // Get the integral value of the character.
                int value = Convert.ToInt32(letter);
                // Convert the integer value to a unicode value in string form.
                string unicodeOutput = "\\u" + value.ToString("X").PadLeft(4, '0');
                // String.Format() https://msdn.microsoft.com/zh-tw/library/txafckwd(v=vs.110).aspx
                MessageBox.Show("Unicode of " + letter + " is " + unicodeOutput );
            }//for 

            /*
            //Chinese char fetching 中文字串擷取
            string str = "一非 عثمان"; string out_str =""; char ch = ' '; int number = 0;
            for (int i = 0; i < str.Length; i++)
            {   ch = str[i]; number = (int)ch; //char to integer
                out_str=str[i] + "=" + String.Format("{0:X}", number); //number to hex
                if (number >= 128) { MessageBox.Show( out_str ); }
             }
            */

            // How to encode and decode Broken Chinese/Unicode characters?
            // http://stackoverflow.com/questions/10967786/how-to-encode-and-decode-broken-chinese-unicode-characters
            // What is happening when you save the "bad" string in a text file 
            // with a meta tag delaring the correct encoding is that your text editor is saving the file 
            // with Windows-1252 encoding, but the browser is reading the file and interpreting it as UTF-8. Since the "bad" string is incorrectly decoded UTF-8 bytes with the Windows-1252 encoding, you are reversing the process by encoding the file as Windows-1252 and decoding as UTF-8. Here's an example:
            string s = "具有靜電產生裝置之影像輸入裝置"; // Unicode
            Encoding Windows1252 = Encoding.GetEncoding("Windows-1252");
            Encoding Utf8 = Encoding.UTF8;
            byte[] utf8Bytes = Utf8.GetBytes(s); // Unicode -> UTF-8
            string badDecode = Windows1252.GetString(utf8Bytes); // Mis-decode as Latin1
            MessageBox.Show(badDecode, "Mis-decoded");  // Shows your garbage string.
            string goodDecode = Utf8.GetString(utf8Bytes); // Correctly decode as UTF-8
            MessageBox.Show(goodDecode, "Correctly decoded");
            // Recovering from bad decode...
            byte[] originalBytes = Windows1252.GetBytes(badDecode);
            goodDecode = Utf8.GetString(originalBytes);
            MessageBox.Show("Recovering from bad decode = " + goodDecode, "Re-decoded");
            //Even with correct decoding, you'll still need a font that supports the characters
            //being displayed. If you default font doesn't support Chinese, you still might not see the correct characters.
            //The correct thing to do is figure out why the string you have was decoded as Windows-1252 in the first place. Sometimes, though, data in a database is stored incorrectly to begin with and you have to resort to these games to fix the problem.

            // UTF-8 definition = http://www.ietf.org/rfc/rfc3629.txt
            //UTF-8 is defined by the Unicode Standard [UNICODE].  Descriptions and
            //formulae can also be found in Annex D of ISO/IEC 10646-1 [ISO.10646]

            //In UTF-8, characters from the U+0000..U+10FFFF range 
            //(the UTF-16 accessible range) are encoded using sequences of 1 to 4 octets.  
            //The only octet of a "sequence" of one has the higher-order bit set to 0,
            //the remaining 7 bits being used to encode the character number.  
            //In a sequence of n octets, n>1, the initial octet has the n higher-order bits set to 1, 
            //followed by a bit set to 0.  The remaining bit(s) of
            //that octet contain bits from the number of the character to be encoded.  
            //The following octet(s) all have the higher-order bit set to 1 
            //and the following bit set to 0, leaving 6 bits in each to contain bits from the character to be encoded.

            //The table below summarizes the format of these different octet types.
            //The letter x indicates bits available for encoding bits of the character number.

            //    Char. number range | UTF-8 octet sequence
            //             (hexadecimal)   |         (binary)
            //--------------------+---------------------------------------------
            //0000 0000-0000 007F | 0xxxxxxx
            //0000 0080-0000 07FF | 110xxxxx 10xxxxxx
            //0000 0800-0000 FFFF | 1110xxxx 10xxxxxx 10xxxxxx
            //0001 0000-0010 FFFF | 11110xxx 10xxxxxx 10xxxxxx 10xxxxxx

            //Encoding a character to UTF-8 proceeds as follows:
            //1.  Determine the number of octets required from the character number
            //    and the first column of the table above.  
            //    It is important to note that the rows of the table are mutually exclusive, i.e.,
            //    there is only one valid way to encode a given character.

            //2.  Prepare the high-order bits of the octets as per the second column of the table.

            //3.  Fill in the bits marked x from the bits of the character number,
            //    expressed in binary.  Start by putting the lowest-order bit of
            //    the character number in the lowest-order position of the last
            //    octet of the sequence, then put the next higher-order bit of the
            //    character number in the next higher-order position of that octet,
            //    etc.  When the x bits of the last octet are filled in, move on to
            //    the next to last octet, then to the preceding one, etc. until all x bits are filled in.
         }

        private void button9_Click(object sender, EventArgs e)
        {   int a = 2, b = 2, c = 2;
            //複合指定運算子   a +1 後   再指定 給 a
            a = a + 1; MessageBox.Show("a=2; a=a+1;  =>  a=" + a.ToString());
            //複合指定運算子   b +1 後   再指定 給 b
            b += 1; MessageBox.Show("b=2; b+=1;  =>  b=" + b.ToString());
            //複合指定運算子   c *2 後   再指定 給 c
            c *= 2; MessageBox.Show("c=2; c*=2;  =>  c=" + c.ToString());

            int i = 10, k;   k = i++;   // 後遞增
            MessageBox.Show("i=10; k = i++;  =>  k=" + k.ToString()+ ", i=" + i.ToString());
            k = ++i;                           // 前遞增
            MessageBox.Show("i=10; k = ++i;  =>  k=" + k.ToString() + ", i=" + i.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {  //C# page 3-4 (a work which assignment by Teacher Tsai)
            int n1=3, n2=4, n3=5; string max="";
            if (n1 > n2 && n1 > n3) { max = "n1"; }
            else { if (n2 > n3) max = "n2"; else max = "n3"; }
            MessageBox.Show( "n1=" + n1+";  n2="
                + n2+";  n3=" + n3 +";\nmax(n1, n2, n3) is " + max );
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int n; string s; s = textBox3.Text;
            if (int.TryParse(textBox3.Text, out n))// if it's a number!
            {  //http://stackoverflow.com/questions/6733652/how-can-i-check-if-a-string-is-a-number
                n = Convert.ToInt32(textBox3.Text);
                switch (n)
                {
                    case 1: MessageBox.Show("1"); break;
                    case 2: MessageBox.Show("2"); break;
                    case 3: MessageBox.Show("3"); break;
                    default: MessageBox.Show("other"); break;
                }//switch (n)
            }//if (int.TryParse(textBox3.Text, out n))
            else
            {
                switch (s)
                {
                    case "a": MessageBox.Show("a"); break;
                    case "bb": MessageBox.Show("bb"); break;
                    case "ccc": MessageBox.Show("ccc"); break;
                    default: MessageBox.Show("other"); break;
                }//switch (s)
            }//else
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {   
                if (i == 2)  continue; // 不進行下列原碼
                if (i == 3)   break;      // 離開迴圈
                MessageBox.Show( i.ToString());
            }//for 

        }

        private void seed(out int s)//[4-39] 
        { //see [4-39] of "Visual C# 2015" for detail
            Random r = new Random();
            s = r.Next(1, 47);
        }  
        private void button13_Click(object sender, EventArgs e)
        {
            int[] numbers; // declare numbers as an int array of any size
            numbers = new int[6];  // numbers is a 6-element array

            Random r = new Random();   label1.Text = "";
            for (int i = 0; i <= 5; i++)
            {
                // numbers[i] = r.Next(1, 47); //採用一般陣列.產生樂透  1..46
                seed(out numbers[i]);  //採用 out 識別字.產生樂透  1..46 [4-39] 
                if (i > 0)
                {
                    while (numbers[i] == numbers[i - 1]) //if 重複
                    {
                        //numbers[i] = r.Next(1, 47); //再次.採用一般陣列.產生樂透  1..46
                        seed(out numbers[i]);  //再次.採用 out 識別字.產生樂透  1..46 [4-39] 
                    }
                }
                label1.Text += numbers[i].ToString() + ", ";
            }
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 2);
        }


        private void button14_Click(object sender, EventArgs e)
        {   //The menu for one week 一週菜單 (陣列練習)
            string[,] s1 = new string[7, 3] { 
            {"aa1","bb1","cc1"}, //Monday
            {"aa2","bb2","cc2"}, //Tuesday
            {"aa3","bb3","cc3"}, //Wednesday
            {"aa4","bb4","cc4"}, //Thursday
            {"aa5","bb5","cc5"}, //Friday
            {"aa6","bb6","cc6"}, //Saturday
            {"aa7","bb7","cc7"} //Sunday
            };

            for (int y = 0; y <7; y++)
                   MessageBox.Show( s1[y, 0] 
                       + "; " + s1[y, 1] + "; " + s1[y, 2] );

            foreach (string s2 in s1)
                MessageBox.Show( s2 );

            }

        private int add(ref int x, ref int y)// [4-37] 
        {//call by reference of x, y
            x += 1; y += 2; return x + y;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            int x = 1, y = 1, z;
            z = add(ref x, ref y);
            MessageBox.Show("x=" + x.ToString());  //x=1+1=2
            MessageBox.Show("y=" + y.ToString());  //y=1+2=3
            MessageBox.Show("z=" + z.ToString());  //z=x+y
        }

        private double area_of_circle( double r)
        {//call by value of r
            return Math.PI * r * r;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show( area_of_circle(3.0).ToString() );
        }

        private static int addout(out int a, out int b)
        {
            a = 1;  b = 2;  int c = a + b;  return c;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            int x, y, z;  
            z=addout(out x, out y);
            MessageBox.Show( "z = " + z.ToString());
        }

        private static void sub(ref int[] ary2)
        {
            for (int i = 0; i < 3; i++)  MessageBox.Show(ary2[i].ToString());
        }
        private void button18_Click(object sender, EventArgs e)
        {
            int[] ary = new int[] { 1, 2, 3, 4, 5 };
            sub(ref ary);
        }
        class A
        {   private static int age = 29;
            public static string name = "john";
            protected internal  int money = 22000;
        }

        class B : A
        {   private int no = 4;
            public int get_higher_money()
            {
                money = 44000;
                return money;
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            B peter = new B(); int m; 
            
            MessageBox.Show( "class1 name=" + A.name);
            MessageBox.Show("peter's original money =" + peter.money.ToString ()  );
            //MessageBox.Show(class1.money.ToString());  can't do it
            m = peter.get_higher_money();   MessageBox.Show("peter's current money =" + m.ToString());

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // MessageBox.Show("Paint");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MessageBox.Show("Resize");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tw.stock.yahoo.com/");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string[] str = new string[] { "111", "222", "333" };
            textBox1.Lines = str;

            MessageBox.Show("Enter");

            lblA.Text = textBox1.Lines[0];
            lblB.Text = textBox1.Lines[1];
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //作業  學員訂便當系統
            string[] ary = new string[listBox1.Items.Count];

            //將物件 listBox1 所有項目(.Items) 複製到陣列 ary, 起始位址 0
            listBox1.Items.CopyTo(ary, 0);

            //將陣列 ary 排序;  將陣列 ary 反轉;
            Array.Sort(ary); Array.Reverse(ary);

            //列印陣列 ary 之每個成員
            foreach (string p in ary) MessageBox.Show(p);

            //將物件 listBox1 所有項目(.Items) 清除
            listBox1.Items.Clear();

            //將陣列 ary 之每個成員 加入物件 listBox1
            listBox1.Items.AddRange(ary);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); f2.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string s; //必須手動選定：專案→加入參考 [v] Microsoft.VisualBasic
            s = Microsoft.VisualBasic.Interaction.InputBox("Prompt text", "This is title text", "default value");
            MessageBox.Show(s);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            checkedListBox1.CheckOnClick = true;
            string[] ary = new string[] { "慢跑", "游泳", "登山", "體操" };
            checkedListBox1.Items.AddRange(ary);
        }

        int i = 0; bool runner = false;
        private void button25_Click(object sender, EventArgs e)
        {
            // 循序播放
            int cnt = imageList1.Images.Count;
            if (i > cnt - 1) i = 0;
            pictureBox1.Image = imageList1.Images[i];
            button25.Text = imageList1.Images.Keys[i].ToString();
            i++;

            //// 隨機播放
            //Random r = new Random(); int n;
            //n = r.Next(0, imageList1.Images.Count);
            //pictureBox1.Image = imageList1.Images[n];
            //button25.Text = imageList1.Images.Keys[n].ToString();

            if (i > 4) { runner = true; i = 0; } // 是否播放 慢跑動畫
        }

        int m = 5; int timer_counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (runner) // 播放 慢跑動畫
            {
                if (m > 8) m = 5; pictureBox1.Image = imageList1.Images[m++];
                timer_counter++;
            }

            //偵測 [播放 慢跑動畫] 經過時間 30 * 100 = 3000 ms 
            if (timer_counter >= 30) { timer_counter = 0; runner = false; }
            
        }
        //
    }//public partial class Form1 : Form
}//namespace win._01
