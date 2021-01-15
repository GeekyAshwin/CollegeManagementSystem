using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBCTutorial11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            String rollno = textBox7.Text.ToString();
            String username = textBox1.Text.ToString();
            String firstname = textBox2.Text.ToString();
            String lastname = textBox3.Text.ToString();
            String password = textBox4.Text.ToString();
            String branch = comboBox1.SelectedItem.ToString();
            String mobile = textBox5.Text.ToString();
            String email = textBox6.Text.ToString();
            String dob = dateTimePicker1.Text.ToString();
            String semester = comboBox2.SelectedItem.ToString();
            Char gender= ' ';
            if (radioButton1.Checked == true)
                gender = 'M' ;
            if (radioButton2.Checked == true)
                gender = 'F';

            ConnectionClass connectionClass = new ConnectionClass();
            connectionClass.openConnection();

            String sql = "insert into StudentInfo values('"+rollno+ "','" + username + "','" + firstname+ "','" + lastname+ "','" + gender+ "','" + password + "','" + branch + "','" + dob+ "','" + semester+ "','" + mobile + "','" + email + "')";
            connectionClass.InsertQueryMethod(sql);   

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }
    }
}
