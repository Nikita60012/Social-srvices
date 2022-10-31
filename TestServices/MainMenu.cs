using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestServices
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void List_of_services_button_Click(object sender, EventArgs e)
        {
            Hide();
            ListOfServices listOfServices = new ListOfServices();
            listOfServices.Show();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void List_of_using_button_Click(object sender, EventArgs e)
        {
            Hide();
            ListOfUsing listOfUsing = new ListOfUsing();
            listOfUsing.Show();
        }
    }
}
