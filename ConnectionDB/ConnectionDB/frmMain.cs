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
namespace ConnectionDB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            MySqlConnection sqlConnection1 = new MySqlConnection(@"Server=127.0.0.1;Database=cinema;Uid=cineman;Pwd=cine;");
            string r = "SELECT titre FROM films WHERE idFilm="+tbxID.Text;
            MySqlCommand cmd = new MySqlCommand(r,sqlConnection1);
            sqlConnection1.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblResult.Text = reader[0].ToString();

            }

            sqlConnection1.Close();
        }
    }
}
