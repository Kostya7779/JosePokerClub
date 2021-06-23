using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JosePokerApp
{
    public partial class MainForm : Form
    {
        public int count = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        public void Rash()
        {
            int[] nums = new int[10] { Convert.ToInt32(textBox1.Text),
            Convert.ToInt32(textBox2.Text),
            Convert.ToInt32(textBox3.Text),
            Convert.ToInt32(textBox4.Text),
            Convert.ToInt32(textBox5.Text),
            Convert.ToInt32(textBox6.Text),
            Convert.ToInt32(textBox7.Text),
            Convert.ToInt32(textBox8.Text),
            Convert.ToInt32(textBox9.Text),
            Convert.ToInt32(textBox10.Text)};
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[0] > nums[1])
                {
                  nums[0] = nums[0] - 1;
                  nums[1] = nums[1] + 1;
                  count++;
                } if (nums[0] < nums[1])
                {
                    nums[1] = nums[1] - 1;
                    nums[0] = nums[0] + 1;
                    count++;
                } 
                if (nums[1] > nums [2])
                {
                    nums[1] = nums[1] - 1;
                    nums[2] = nums[2] + 1;
                    count++;
                } if (nums[1] < nums[2])
                {
                    nums[2] = nums[2] - 1;
                    nums[1] = nums[1] + 1;
                    count++;
                }
                if (nums[2] > nums[3])
                {
                    nums[2] = nums[2] - 1;
                    nums[3] = nums[3] + 1;
                    count++;
                }
                if (nums[2] < nums[3])
                {
                    nums[3] = nums[3] - 1;
                    nums[2] = nums[2] + 1;
                    count++;
                }
                if (nums[3] > nums[4])
                {
                    nums[3] = nums[3] - 1;
                    nums[4] = nums[4] + 1;
                    count++;
                }
                if (nums[3] < nums[4])
                {
                    nums[4] = nums[4] - 1;
                    nums[3] = nums[3] + 1;
                    count++;
                }
                if (nums[4] > nums[5])
                {
                    nums[4] = nums[4] - 1;
                    nums[5] = nums[5] + 1;
                    count++;
                }
                if (nums[4] < nums[5])
                {
                    nums[5] = nums[5] - 1;
                    nums[4] = nums[4] + 1;
                    count++;
                }
                if (nums[5] > nums[6])
                {
                    nums[5] = nums[5] - 1;
                    nums[6] = nums[6] + 1;
                    count++;
                }
                if (nums[5] < nums[6])
                {
                    nums[6] = nums[6] - 1;
                    nums[5] = nums[5] + 1;
                    count++;
                }
                if (nums[6] > nums[7])
                {
                    nums[6] = nums[6] - 1;
                    nums[7] = nums[7] + 1;
                    count++;
                }
                if (nums[6] < nums[7])
                {
                    nums[7] = nums[7] - 1;
                    nums[6] = nums[6] + 1;
                    count++;
                }
                if (nums[7] > nums[8])
                {
                    nums[7] = nums[7] - 1;
                    nums[8] = nums[8] + 1;
                    count++;
                }
                if (nums[7] < nums[8])
                {
                    nums[8] = nums[8] - 1;
                    nums[7] = nums[7] + 1;
                    count++;
                }
                if (nums[8] > nums[9])
                {
                    nums[8] = nums[8] - 1;
                    nums[9] = nums[9] + 1;
                    count++;
                }
                if (nums[8] < nums[9])
                {
                    nums[9] = nums[9] - 1;
                    nums[8] = nums[8] + 1;
                    count++;
                }
                if (nums[i] == nums[i])
                {
                   MessageBox.Show("Количество ходов фишек равно =" + count, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != ""  && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "")
            {
                Rash();
            } else { MessageBox.Show("У каждого столика не может быть пустых значений, есоли вы хотите чтоб у игрока не было фишек, то укажите «0».", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
