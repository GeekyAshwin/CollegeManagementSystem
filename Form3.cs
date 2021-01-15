using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCTutorial11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text.ToString();
            String firstname = textBox2.Text.ToString();
            String lastname= textBox3.Text.ToString();
            String ID = textBox6.Text.ToString();
            String mobile = textBox5.Text.ToString();
            String dob = dateTimePicker1.Text.ToString();
            String email = textBox7.Text.ToString();
            String password = textBox4.Text.ToString();
            String branch = comboBox1.SelectedItem.ToString();
            Char gender= ' ';
            if (radioButton1.Checked == true)
                gender = 'M';
            if (radioButton2.Checked == true)
                gender = 'F';


            ConnectionClass connectionClass = new ConnectionClass();
            connectionClass.openConnection();

            String sql = "insert into FacultyInfo values('"+ID+ "','" + username + "','" + firstname + "','" + lastname+ "','" + gender+ "','" + password+ "','" + branch+ "','" + dob + "','" + mobile + "','" + email + "')";
            connectionClass.InsertQueryMethod(sql);

            connectionClass.closeConnection();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
