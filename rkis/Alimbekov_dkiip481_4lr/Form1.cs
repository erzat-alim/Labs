using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Alimbekov_dkiip481_4lr
{
    public partial class Form1 : Form
    {
        string table;
        SQLiteConnection conn;
        public Form1(SQLiteConnection conn,  string table)
        {
            InitializeComponent();
            this.table = table;
            this.conn = conn;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string query = $"SELECT * FROM {table}";
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm(conn, table);
            ef.ShowDialog();

        }
    }
}
