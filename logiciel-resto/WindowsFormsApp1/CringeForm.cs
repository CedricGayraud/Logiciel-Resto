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
            connection.Open();

            string query = "SELECT * FROM restaurant_manager.categories";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable table = new DataTable();
            adapter.Fill(table);

            ComboBoxCategorie.DisplayMember = "nom";
            ComboBoxCategorie.ValueMember = "id";
            ComboBoxCategorie.DataSource = table;

            connection.Close();

            DataGridViewStyler.Style(dataGridView1);

            // Style le DataGridView
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F);

            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void TestBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxNPlat.Text) || string.IsNullOrEmpty(TextBoxDPPlat.Text) || string.IsNullOrEmpty(TextBoxPPlat.Text) || string.IsNullOrEmpty(ComboBoxCategorie.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de soumettre les données.");
                return;
            }

            decimal prixPlat = decimal.Parse(TextBoxPPlat.Text); // Convertir le prix en décimal

            string insertQuery = "INSERT INTO restaurant_manager.plats(nomPlat, descriptionPlat, prixPlat, categorie) VALUES('" + TextBoxNPlat.Text + "','" + TextBoxDPPlat.Text + "', '" + prixPlat + "', '" + ComboBoxCategorie.Text + "')";


            connection.Open();

            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                int result1 = command.ExecuteNonQuery();

                if (result1 == 1)
                {
                    MessageBox.Show("Données insérées avec succès.");
                }
                else
                {
                    MessageBox.Show("Les données n'ont pas pu être insérées.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();

            //Afficher les plats dans le DataGridView
            connection.Open();
            string query2 = "SELECT * FROM restaurant_manager.plats";
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);

            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            adapter2.SelectCommand = cmd2;

            DataTable table2 = new DataTable();
            adapter2.Fill(table2);

            dataGridView1.DataSource = table2;

            // Appliquer le style personnalisé au DataGridView
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 113, 198);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 113, 198);
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // Ajuster la taille des colonnes du DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Activer le tri sur les colonnes du DataGridView
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.Automatic);

            connection.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idPlat = (int)dataGridView1.SelectedRows[0].Cells["idPlat"].Value;

                string deleteQuery = "DELETE FROM restaurant_manager.plats WHERE idPlat=" + idPlat;

                connection.Open();

                MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Plat supprimé avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("Le plat n'a pas pu être supprimé.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();

                //Actualiser le DataGridView
                string query = "SELECT * FROM restaurant_manager.plats";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un plat à supprimer.");
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
