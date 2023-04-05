using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class CringeForm : MaterialForm
    {
        MySqlConnection connection = new MySqlConnection("database=restaurant_manager; server=localhost; user id=root; password=");
        public CringeForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Purple700, TextShade.WHITE);

            //PieChart Test 1
            Func<ChartPoint, string> labelPoint = chartPoint =>
           string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
        {
            new PieSeries
            {
                Title = "Maria",
                Values = new ChartValues<double> {3},
                PushOut = 15,
                DataLabels = true,
                LabelPoint = labelPoint
            },
            new PieSeries
            {
                Title = "Charles",
                Values = new ChartValues<double> {4},
                DataLabels = true,
                LabelPoint = labelPoint
            },
            new PieSeries
            {
                Title = "Frida",
                Values = new ChartValues<double> {6},
                DataLabels = true,
                LabelPoint = labelPoint
            },
            new PieSeries
            {
                Title = "Frederic",
                Values = new ChartValues<double> {2},
                DataLabels = true,
                LabelPoint = labelPoint
            }
        };

            pieChart1.LegendLocation = LegendLocation.Bottom;
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


        private void materialButton1_Click(object sender, EventArgs e)
        {
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
