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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String username1 = textBox1.Text.ToString();
            String password1 = textBox2.Text.ToString();

            ConnectionClass connectionClass = new ConnectionClass();
            connectionClass.openConnection();

            /*String sql1 = "select username,password from StudentInfo";
            String sql2 = "select count(username) from StudentInfo";



            int number_of_users = ;*/
        }
    }
}
