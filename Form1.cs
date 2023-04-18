using System;
using System.Collections.Generic;
/*using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static void RandomArr(int[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int index = r.Next(arr.Length);
                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }
        }
        public void yxti1()
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = 0; j < listBox4.Items.Count; j++)
                {
                    if (listBox4.Items[j].Equals(listBox1.Items[i]))
                        listBox4.Items.RemoveAt(j);
                }
            }
        }
        public void yxti2()
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                for (int j = 0; j < listBox4.Items.Count; j++)
                {
                    if (listBox4.Items[j].Equals(listBox2.Items[i]))
                    {
                        listBox4.Items.RemoveAt(j);
                    }
                }
            }
        }
        public void quis()
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    if (listBox2.Items[i].Equals(listBox1.Items[j]))
                    {
                        listBox1.Items.RemoveAt(j);
                    }
                }
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (listBox1.Items[i].Equals(listBox1.Items[j]))
                    {
                        listBox1.Items.RemoveAt(i);
                    }
                }
            }
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                for (int j = 0; j < listBox2.Items.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (listBox2.Items[i].Equals(listBox2.Items[j]))
                    {
                        listBox2.Items.RemoveAt(i);
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)//允许输入数字和退格
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)//允许输入数字和退格
                e.Handled = true;
            if (textBox1.Text == "")
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)//允许输入数字和退格
                e.Handled = true;
            if (textBox1.Text == "")
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                MessageBox.Show("座号不能为零");
                textBox3.Clear();
            }
            else if (Convert.ToInt32(textBox3.Text) > Convert.ToInt32(textBox1.Text))
            {
                MessageBox.Show("座号超出范围");
                textBox3.Clear();
            }
            else if (listBox1.Items.Count > Convert.ToInt32(textBox1.Text) - 1)
            {
                MessageBox.Show("人数太多了");
                textBox3.Clear();
            }
            else
            {
                listBox1.Items.Add(textBox3.Text);
                textBox3.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                MessageBox.Show("带头人不能为零");
                textBox2.Clear();
            }
            else if (Convert.ToInt32(textBox2.Text) > Convert.ToInt32(textBox1.Text))
            {
                MessageBox.Show("座号超出范围");
                textBox2.Clear();
            }
            else if (listBox2.Items.Count > Convert.ToInt32(textBox1.Text) - 1)
            {
                MessageBox.Show("人数太多了");
                textBox2.Clear();
            }
            else
            {
                listBox2.Items.Add(textBox2.Text);
                textBox2.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("没法再撤了(＞︿＜)");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                textBox3.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("没法再撤了(＞︿＜)");
            }
            else
            {
                listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
                textBox2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("带头人至少输入一个");
            }
            else
            {
                listBox3.Items.Clear();
                if (listBox4.Items.Count > 0)
                {
                    listBox4.Items.Clear();
                }
                quis();
                if (textBox1.Text == "" || textBox1.Text == "0")
                {
                    MessageBox.Show("人数不能为空或为零");
                    textBox1.Clear();
                }
                for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                {
                    listBox4.Items.Add(Convert.ToString(i + 1));
                }
                yxti2();
                yxti1();

                int arlong = listBox4.Items.Count / listBox2.Items.Count;
                int arlongy = listBox4.Items.Count % listBox2.Items.Count;

                int[] rfuu = new int[listBox4.Items.Count];
                int ptr = 0;
                for (int i = 0; i < listBox4.Items.Count; i++)
                {
                    rfuu[i] = Convert.ToInt32(listBox4.Items[i]);
                }
                RandomArr(rfuu);
                List<string> listzh = new List<string>();
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    string jle = "";
                    for (int j = ptr; j < ptr + arlong; j++)
                    {
                        jle += rfuu[j].ToString() + ",";
                    }
                    jle = jle.Substring(0, jle.Length - 1);
                    ptr += arlong;
                    listzh.Add("第" + (i + 1) + "组—" + listBox2.Items[i].ToString() + " : " + jle);
                }
                foreach (string s in listzh)
                {
                    listBox3.Items.Add(s);
                }

                if (ptr < rfuu.Length)
                {
                    string doyu = "剩余的座号：";
                    for (int i = ptr; i < rfuu.Length; i++)//
                    {
                        doyu += rfuu[i].ToString() + ",";
                    }
                    doyu = doyu.Substring(0, doyu.Length - 1);
                    listBox3.Items.Add(doyu);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            quis();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count != 0)
            {
                string[] str = new string[listBox3.Items.Count];
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    str[i] = listBox3.Items[i].ToString();
                }
                File.WriteAllLines(@".\分组.txt", str);
                MessageBox.Show("创建完成");
            }
            else
            {
                MessageBox.Show("无内容");
            }
        }
    }
}
