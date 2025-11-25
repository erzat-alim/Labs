using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alimbekov_dkiip481_4lr
{
    public partial class MainForm : Form
    {
        string pathdb;
        string table;
        SQLiteConnection conn;
        public MainForm()
        {
            InitializeComponent();

            pathdb = "URI = File:DB.db";
            conn = new SQLiteConnection(pathdb);
        }


        private void buttonClients_Click(object sender, EventArgs e)
        {
            ChangeTable(conn, "clients");
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pathdb = "URI File:" + ofd.FileName;
                    conn = new SQLiteConnection(pathdb);
                }
            }
            catch { }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoods_Click(object sender, EventArgs e)
        {
            ChangeTable(conn, "goods");
        }
        private void ChangeTable(SQLiteConnection conn, string table)
        {
            Form1 wf = new Form1(conn, table);
            this.Hide();
            wf.ShowDialog();
            this.Show();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            ChangeTable(conn, "orders");
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            ChangeTable(conn, "provider");
        }
    }
}
