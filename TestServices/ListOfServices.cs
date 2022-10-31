using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TestServices
{
    public partial class ListOfServices : Form
    {
        Database db = new Database();

        private MySqlDataAdapter adapter = new MySqlDataAdapter();
        private MySqlCommand command = new MySqlCommand();
        private DataTable dt = new DataTable();
        private int rowIndex;
        private int id;

        public ListOfServices()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            db.openConnection();

            string query = "SELECT * FROM `list_of_services` ORDER BY `ID`";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            adapter.SelectCommand = command;

            MySqlDataReader reader = command.ExecuteReader();

            BindingList<string[]> data = new BindingList<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0 || i % 2 == 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    }
                    else if (i % 2 == 1)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            if (Types.Text == "")
            {
                MessageBox.Show("Введите название услуги");
                return;
            }
            MySqlCommand sqlCopyCommand = new MySqlCommand("SELECT * FROM `list_of_services` WHERE `TypesOfServices` = '"+ Types.Text +"'", db.getConnection());

            adapter.SelectCommand = sqlCopyCommand;
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Такой вид услуги уже есть в таблице");
                dt.Clear();
            }
            else {
                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `list_of_services` (`TypesOfServices`, `TotalCount`) VALUES ('"+ Types.Text +"', '" + Count.Text + "')", db.getConnection());

                db.openConnection();

                sqlCommand.ExecuteNonQuery();

                db.closeConnection();

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                loadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                Types.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Count.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            rowIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells["identific"].Value);


            MySqlCommand deletecommand = new MySqlCommand("DELETE FROM `list_of_services` WHERE `list_of_services`.`ID` = " + rowIndex, db.getConnection());

            db.openConnection();
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                deletecommand.ExecuteNonQuery();
            }  

            db.closeConnection();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            loadData();
            
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            db.openConnection();
            command = new MySqlCommand("UPDATE `list_of_services` SET `TypesOfServices`= '" + Types.Text + "', `TotalCount`= '" + Count.Text + "' WHERE `ID` = '"  + id + "'", db.getConnection());

            command.ExecuteNonQuery();
            db.closeConnection();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            loadData();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
                Close();
                MainMenu main = new MainMenu();
                main.Show();
        }


    }
}