using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public string tar;
        

        public Form1()
        {
            InitializeComponent();
            label1.Text = Properties.Settings.Default.sum_save;
            label2.Text = Convert.ToString(Properties.Settings.Default.save_value);
            label3.Text = Properties.Settings.Default.save_target;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "bank";
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            decimal z=0;
            Form2 newForm = new Form2();
            if (z >= newForm.h) {
                DialogResult j = MessageBox.Show("Цель достигнута. Хотите выбрать новую цель?", "Цель", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (j == DialogResult.Yes) {
                    
                    button5.PerformClick();
                }
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal v = numericUpDown1.Value + Decimal.Parse(label2.Text);
            Convert.ToString(label2.Text);
            label2.Text = Convert.ToString(v);
            label1.Text = "Накопленно: " + label2.Text + " руб";
            Properties.Settings.Default.save_value = v ;
            Properties.Settings.Default.Save();

            if (v > 1000000)
            {
                MessageBox.Show("Значение не может быть больше 1 млн. руб!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label2.Text = "1000000";
                label1.Text = "Накопленно: " + label2.Text + " руб";

            }
                Form2 newForm = new Form2();
                if (v >= newForm.h)
            {
                    DialogResult j = MessageBox.Show("Цель достигнута. Хотите выбрать новую цель?", "Цель", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (j == DialogResult.Yes)
                    {

                    button5.PerformClick();
                    label2.Text = "0";
                    label1.Text = "Накопленно: " + label2.Text + " руб";

                }
                if (j == DialogResult.No) {
                    label2.Text = "0";
                    label1.Text = "Накопленно: " + label2.Text + " руб";

                }
                }
            }
        

            private void Button2_Click(object sender, EventArgs e)
            {
                Properties.Settings.Default.sum_save = label1.Text;
                
                Properties.Settings.Default.Save();
                MessageBox.Show("Готово!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void Button3_Click(object sender, EventArgs e)
            {
                decimal v = Decimal.Parse(label2.Text) - numericUpDown1.Value;
                label2.Text = Convert.ToString(v);
                label1.Text = "Накопленно: " + label2.Text + " руб";
                if (v < 0) {
                    MessageBox.Show("Значение не может быть меньше 0 руб!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label2.Text = "0";
                    label1.Text = "Накопленно: " + label2.Text + " руб";
                }
            }

            private void button4_Click(object sender, EventArgs e)
            {
                DialogResult result = MessageBox.Show("Сбросить?", "Сброс", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    label2.Text = "0";
                    label1.Text = "Накопленно: " + label2.Text + " руб";



                }
            }

            private void label2_Click(object sender, EventArgs e)
            {
            Text = "0";
            }

            private void button5_Click(object sender, EventArgs e)
            {
                Form2 newForm = new Form2();
                newForm.lab = this.label3;
            
            newForm.Show();
            }

            private void label3_Click(object sender, EventArgs e)
            {
          

        }
        }
    }

