using System.Drawing;
using System.Windows.Forms;

public static class DataGridViewStyler
{
    public static void Style(DataGridView dataGridView)
    {
        dataGridView.BorderStyle = BorderStyle.None;
        dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
        dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
        dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        dataGridView.BackgroundColor = Color.White;

        dataGridView.EnableHeadersVisualStyles = false;
        dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
        dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
        dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
        dataGridView.DefaultCellStyle.Font = new Font("Arial", 12);
        dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }
}