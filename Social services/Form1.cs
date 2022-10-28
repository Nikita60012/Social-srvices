using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_services
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 listOfServices = new Form2();
            listOfServices.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String message = "Иванов Н.М.";
            MySqlCommand command = new MySqlCommand("SELECT * FROM `testtable`", db.getConnection());
            //command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = message;

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }

      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
