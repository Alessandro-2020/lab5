using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _5_lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox3.Text = label13.Text;
            textBox4.Text = label14.Text;
            textBox5.Text = label15.Text;
            textBox6.Text = label16.Text;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string log = "admin";
            string log_p1 = "semenov96";
            string pass_p1 = "1996semen";
            string log_p2 = "razimovSV";
            string pass_p2 = "svyatoslavraz";
            string log_m1 = "Sidorov";
            string log_m2 = "yavsegdatut";
            string pass_m1 = "SID1982";
            string pass_m2 = "pAssWoRd";
            string pass = "admin";
            if (textBox1.Text == log && textBox2.Text == pass)

            {
                MessageBox.Show("Добро пожаловать, ваша роль администратор");
                button10.Visible = true;
                button5.Visible = true;
                button9.Visible = true;
                button6.Visible = true;
                button8.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                groupBox1.Visible = false;
            }
            if (textBox1.Text == log_p1 && textBox2.Text == pass_p1)

            {
                MessageBox.Show("Добро пожаловать, Семёнов А.Д., ваша роль продавец");
                button1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                groupBox1.Visible = false;
            }
            if (textBox1.Text == log_p2 && textBox2.Text == pass_p2)

            {
                MessageBox.Show("Добро пожаловать Разимов С.В., ваша роль продавец");
                button2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                groupBox1.Visible = false;
            }
            if (textBox1.Text == log_m1 && textBox2.Text == pass_m1)

            {
                MessageBox.Show("Добро пожаловать Сидоров А.Г., ваша роль менеджер");
                button7.Visible = true;
                button6.Visible = true;
                button8.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                groupBox1.Visible = false;
            }
            if (textBox1.Text == log_m2 && textBox2.Text == pass_m2)

            {
                MessageBox.Show("Добро пожаловать Cмирнов Г.В., ваша роль менеджер");
                button4.Visible = true;
                button6.Visible = true;
                button8.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                groupBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            groupBox1.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label6.Text = "Семёнов";
            label8.Text = "Александр";
            label10.Text = "Дмитревич";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            groupBox1.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = false;
            label14.Visible = true;
            label15.Visible = false;
            label16.Visible = false;
            label6.Text = "Разимов";
            label8.Text = "Святослав";
            label10.Text = "Владимирович";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            groupBox1.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = true;
            label16.Visible = false;
            label6.Text = "Сидоров";
            label8.Text = "Алексей";
            label10.Text = "Генадьевич";
            label12.Text = "Кол-во рабочих часов:";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            groupBox1.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label6.Text = "Смирнов";
            label8.Text = "Георгий";
            label10.Text = "Валентинович";
            label12.Text = "Кол-во рабочих часов:";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            groupBox1.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label6.Text = "Стульев";
            label8.Text = "Павел";
            label10.Text = "Валентинович";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            groupBox1.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            textBox3.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button11.Visible = true;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            label6.Text = "Семёнов";
            label8.Text = "Александр";
            label10.Text = "Дмитревич";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            groupBox1.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = true;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button11.Visible = false;
            button12.Visible = true;
            button13.Visible = false;
            button14.Visible = false;
            label6.Text = "Разимов";
            label8.Text = "Святослав";
            label10.Text = "Владимирович";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            groupBox1.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = true;
            textBox6.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = true;
            button14.Visible = false;
            label6.Text = "Сидоров";
            label8.Text = "Алексей";
            label10.Text = "Генадьевич";
            label12.Text = "Кол-во рабочих часов:";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            groupBox1.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = true;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = true;
            label6.Text = "Смирнов";
            label8.Text = "Георгий";
            label10.Text = "Валентинович";
            label12.Text = "Кол-во рабочих часов:";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label13.Text = textBox3.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            label16.Text = textBox6.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label14.Text = textBox4.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label15.Text = textBox5.Text;
        }
    }
}  
