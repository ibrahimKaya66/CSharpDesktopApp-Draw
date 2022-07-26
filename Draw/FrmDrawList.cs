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

namespace Draw
{
    public partial class FrmDrawList : Form
    {
        public FrmDrawList()
        {
            InitializeComponent();
        }

        private void FrmDrawList_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(btnList, "Listele");
            tool.SetToolTip(txtSearchTicketNr, "Bilet Numarasına Göre Ara");
            tool.SetToolTip(txtSearchName, "İsme Göre Ara");
            tool.SetToolTip(txtSearchSurname, "Soyisme Göre Ara");
        }

        SqlConnection conn;
        private void btnList_Click(object sender, EventArgs e)
        {
            SqlConn();
            try
            {
                conn.Open();
                gridFill();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanından Veri Okunurken Hata Oluştu.",
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        string cmdText = "";
        private void gridFill()
        {
            SqlConn();
            try
            {
                conn.Open();
                cmdText = "select * from DrawPersons";
                SqlDataAdapter da = new SqlDataAdapter(cmdText, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewList.DataSource = ds.Tables[0];

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Veriler Aktarılamadı",
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            gridColumnEdit();
        }

        private void gridColumnEdit()
        {
            
            dataGridViewList.Columns[0].HeaderText = "Bilet Numarası";
            dataGridViewList.Columns[1].HeaderText = "Ad";
            dataGridViewList.Columns[2].HeaderText = "Soyad";
            dataGridViewList.Columns[3].HeaderText = "E-Posta";
            dataGridViewList.Columns[4].HeaderText = "Adres";
        }

        private void SqlConn()
        {
            try
            {
                conn = new SqlConnection("Data Source= DESKTOP-TKECF1U\\LOGO; Initial Catalog= Draw;" +
                "User ID= sa; Password= 12345Wq;");
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanına Bağlanılamadı",
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchTicketNr_TextChanged(object sender, EventArgs e)
        {
            SqlConn();
            conn.Open();
            string cmdTxt = " select * from DrawPersons where TicketID like '%"+txtSearchTicketNr.Text+"%'";
            SqlDataAdapter da = new SqlDataAdapter(cmdTxt,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewList.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            SqlConn();
            conn.Open();
            string cmdTxt = " select * from DrawPersons where D_Name like '%" + txtSearchName.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(cmdTxt, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewList.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void txtSearchSurname_TextChanged(object sender, EventArgs e)
        {
            SqlConn();
            conn.Open();
            string cmdTxt = "select * from DrawPersons where D_Surname like '%" + txtSearchSurname.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(cmdTxt, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewList.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from DrawPersons where TicketID= '" + 
                dataGridViewList.SelectedRows[0].Cells[0].Value.ToString() + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gridFill();
        }
    }
}
