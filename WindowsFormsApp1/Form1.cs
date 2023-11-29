using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReterieve_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from tb_teacher";
                var cmd = new OleDbCommand(sql, conn);
                conn.Open();
                var rdr = cmd.ExecuteReader();
                var result = "";
                while (rdr.Read())
                {
                    result += $"Id: {rdr.GetInt32(0)}; First name: {rdr.GetString(1)}; Last name: {rdr.GetString(2)}; Address: {rdr.GetString(3)}; Phone: {rdr.GetString(4)}";
                    result += "\n";
                }

                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if ((conn.State != ConnectionState.Closed))
                {
                    conn.Close();
                }
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = $@"
insert into tb_teacher (last_name, first_name, address, phone) 
values('{tbxLastName.Text}', '{tbxFirstName.Text}', '{tbxAddress.Text}', '{tbxPhone.Text}')";

                var cmd = new OleDbCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if ((conn.State != ConnectionState.Closed))
                {
                    conn.Close();
                }
            }

        }
    }
}
