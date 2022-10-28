using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Social_services
{
    public partial class Form2 : Form
    {
        public Form2()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String constr = "Server=localhost;Database=wdmf;Uid=root;pwd=root;charset=utf-8;";
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
                MessageBox.Show("connect");
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void list_of_servicesBindingNavigatorSaveItem1_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.testDataSet = new Social_services.testDataSet();
            this.test_list_of_servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_list_of_servicesTableAdapter = new Social_services.testDataSetTableAdapters.test_list_of_servicesTableAdapter();
            this.tableAdapterManager = new Social_services.testDataSetTableAdapters.TableAdapterManager();
            this.test_list_of_servicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.test_list_of_servicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.test_list_of_servicesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_list_of_servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_list_of_servicesBindingNavigator)).BeginInit();
            this.test_list_of_servicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_list_of_servicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test_list_of_servicesBindingSource
            // 
            this.test_list_of_servicesBindingSource.DataMember = "test_list_of_services";
            this.test_list_of_servicesBindingSource.DataSource = this.testDataSet;
            // 
            // test_list_of_servicesTableAdapter
            // 
            this.test_list_of_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Social_services.testDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // test_list_of_servicesBindingNavigator
            // 
            this.test_list_of_servicesBindingNavigator.AddNewItem = null;
            this.test_list_of_servicesBindingNavigator.BindingSource = this.test_list_of_servicesBindingSource;
            this.test_list_of_servicesBindingNavigator.CountItem = null;
            this.test_list_of_servicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.test_list_of_servicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.test_list_of_servicesBindingNavigatorSaveItem});
            this.test_list_of_servicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.test_list_of_servicesBindingNavigator.MoveFirstItem = null;
            this.test_list_of_servicesBindingNavigator.MoveLastItem = null;
            this.test_list_of_servicesBindingNavigator.MoveNextItem = null;
            this.test_list_of_servicesBindingNavigator.MovePreviousItem = null;
            this.test_list_of_servicesBindingNavigator.Name = "test_list_of_servicesBindingNavigator";
            this.test_list_of_servicesBindingNavigator.PositionItem = null;
            this.test_list_of_servicesBindingNavigator.Size = new System.Drawing.Size(775, 25);
            this.test_list_of_servicesBindingNavigator.TabIndex = 0;
            this.test_list_of_servicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // test_list_of_servicesBindingNavigatorSaveItem
            // 
            this.test_list_of_servicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.test_list_of_servicesBindingNavigatorSaveItem.Enabled = false;
            this.test_list_of_servicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("test_list_of_servicesBindingNavigatorSaveItem.Image")));
            this.test_list_of_servicesBindingNavigatorSaveItem.Name = "test_list_of_servicesBindingNavigatorSaveItem";
            this.test_list_of_servicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.test_list_of_servicesBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // test_list_of_servicesDataGridView
            // 
            this.test_list_of_servicesDataGridView.AutoGenerateColumns = false;
            this.test_list_of_servicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.test_list_of_servicesDataGridView.DataSource = this.test_list_of_servicesBindingSource;
            this.test_list_of_servicesDataGridView.Location = new System.Drawing.Point(0, 28);
            this.test_list_of_servicesDataGridView.Name = "test_list_of_servicesDataGridView";
            this.test_list_of_servicesDataGridView.Size = new System.Drawing.Size(300, 220);
            this.test_list_of_servicesDataGridView.TabIndex = 1;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(775, 412);
            this.Controls.Add(this.test_list_of_servicesDataGridView);
            this.Controls.Add(this.test_list_of_servicesBindingNavigator);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_list_of_servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_list_of_servicesBindingNavigator)).EndInit();
            this.test_list_of_servicesBindingNavigator.ResumeLayout(false);
            this.test_list_of_servicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_list_of_servicesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String message = "Иванов Н.М.";
            MySqlCommand command = new MySqlCommand("SELECT * FROM `testtable`", db.getConnection());
            //command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = message;

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            test_list_of_servicesDataGridView.DataSource = dt;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.test_list_of_services". При необходимости она может быть перемещена или удалена.
            this.test_list_of_servicesTableAdapter.Fill(this.testDataSet.test_list_of_services);

        }
    }
}
