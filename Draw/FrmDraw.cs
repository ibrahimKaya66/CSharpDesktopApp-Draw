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
    public partial class frmDraw : Form
    {
        public frmDraw()
        {
            InitializeComponent();
        }

        private void frmDraw_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(btnDice, "Rastgele Bilet Numarası Üret");
            tool.SetToolTip(btnControl, "Kontrol Et");
            tool.SetToolTip(btnDrawList, "Çekiliş Listesi");
            btnSave.Enabled = false;
        }

        Random rnd = new Random();
        int ticketNr = 0;
        private void btnDice_Click(object sender, EventArgs e)
        {
            ticketNr = rnd.Next(100000, 1000000);
            txtTicketNr.Text = ticketNr.ToString();
        }

        SqlConnection conn;
        string cmdText = "";
        SqlCommand cmd;
        SqlDataReader dr;
        private void btnControl_Click(object sender, EventArgs e)
        {
            SqlConn();

            try
            {
                conn.Open();
                cmdText = "select * from DrawPersons where TicketID = " + Convert.ToInt32(txtTicketNr.Text) + "";
                cmd = new SqlCommand(cmdText, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Kullanılıyor");
                    btnControl.BackgroundImage = Properties.Resources.X_icon;
                    txtName.Text = dr["D_Name"].ToString();
                    txtSurname.Text = dr["D_Surname"].ToString();
                    txtEposta.Text = dr["D_EPosta"].ToString();
                    txtAddress.Text = dr["D_Address"].ToString();
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Başarılı");
                    btnControl.BackgroundImage = Properties.Resources.Ok_icon;
                    txtName.Text = "";
                    txtSurname.Text = "";
                    txtEposta.Text = "";
                    txtAddress.Text = "";
                    btnSave.Enabled = true;
                }

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanından Kontrol Edilirken Hata Oluştu.", 
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void btnDrawList_Click(object sender, EventArgs e)
        {
            FrmDrawList fdl;
            if (Application.OpenForms["FrmDrawList"] == null)
                fdl = new FrmDrawList();
            else
                fdl = (FrmDrawList)Application.OpenForms["FrmDrawList"];
            fdl.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtSurname.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("İlgili Alanları Doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                conn.Open();
                cmdText = "insert into DrawPersons(TicketID,D_Name,D_Surname,D_Address) " +
                    "values(@ticketNr,@name,@surname,@address)";

                cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@ticketNr", txtTicketNr.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanına Aktarım Sırasında Hata Oluştu", 
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
