using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TestServices
{
    public partial class ListOfUsing : Form

    {
        Database db = new Database();
        private int rowIndex;
        public ListOfUsing()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            db.openConnection();

            string query = "SELECT * FROM `list_of_using` ORDER BY `ID`";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            BindingList<string[]> data = new BindingList<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

            MySqlDataAdapter comboAdapter = new MySqlDataAdapter("SELECT `TypesOfServices` FROM `list_of_services`", db.getConnection());
            DataTable comboDt = new DataTable();
            comboAdapter.Fill(comboDt);

            typeOfService_comboBox.DataSource = comboDt;
            typeOfService_comboBox.DisplayMember = "TypesOfServices";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if(i == 0 || i % 2 == 0) {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    } else if(i%2 == 1)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
            }
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            rowIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

            MySqlCommand deletecommand = new MySqlCommand("DELETE FROM `list_of_using` WHERE `list_of_using`.`ID` = " + rowIndex, db.getConnection());

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

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (FIO_field.Text == "")
            {
                MessageBox.Show("Введите ФИО запросчика");
                return;
            }

            MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `list_of_using` (`FIO`, `TypeOfService`, `Date`) VALUES ('" + FIO_field.Text + "', '" + typeOfService_comboBox.Text + "', @date)", db.getConnection());
            sqlCommand.Parameters.Add("@date", MySqlDbType.Date).Value = currentDate.Value.Date;

            db.openConnection();

            sqlCommand.ExecuteNonQuery();

            db.closeConnection();

            String updateService = typeOfService_comboBox.Text;
            //MessageBox.Show(updateService);

            MySqlCommand findCount = new MySqlCommand("SELECT `TotalCount` FROM `list_of_services` WHERE `list_of_services`.`TypesOfServices` = '" + updateService +"'", db.getConnection());
            int updateCount = 0;

            db.openConnection();
            MySqlDataReader reader = findCount.ExecuteReader();
            while (reader.Read())
            {
                updateCount = Convert.ToInt32(reader[0].ToString());
            }
            
            db.closeConnection();
            //MessageBox.Show(updateCount.ToString());
            updateCount++;
            
            MySqlCommand update = new MySqlCommand("UPDATE `list_of_services` SET `TotalCount` = '" + updateCount + "' WHERE `list_of_services`.`TypesOfServices` = '" + updateService + "'", db.getConnection());

            db.openConnection();
            update.ExecuteNonQuery();
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
