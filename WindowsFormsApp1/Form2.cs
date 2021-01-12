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
    
    public partial class Form2 : Form
    {
         Form1 MyForm = new Form1();
        public Label lab;
        public Label lab2;
        public decimal h=Properties.Settings.Default.save_value2;
        public Form2()
        {
            InitializeComponent();
             
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = "Создание цели";
        }

        private void label1_Click(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Изменить текущую цель? Прошлая цель будет перезаписана.", "Сохранение цели", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result==DialogResult.Yes){
                h = numericUpDown2.Value;
                lab.Text = "Цель: " + Convert.ToString(h) + " руб";
                
                label2.Text = lab.Text;
                Form1 MyForm = new Form1();
                MyForm.tar = this.label2.Text;
                Properties.Settings.Default.save_value2 = Convert.ToDecimal(h);
                Properties.Settings.Default.save_target = MyForm.tar;
                Properties.Settings.Default.Save();
               
                Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

