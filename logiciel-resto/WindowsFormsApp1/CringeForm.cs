using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class CringeForm : Form
    {

        MySqlConnection connection = new MySqlConnection("database=restaurant_manager; server=localhost; user id=root; password=");

        public CringeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM plats WHERE idPlat = " + textBoxID.Text;
                connection.Open();
                MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("USER DELETED");
                }
                else
                {
                    MessageBox.Show("USER NOT DELETED");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

        }

        private void editionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
