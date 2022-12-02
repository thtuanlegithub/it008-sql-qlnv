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

namespace QLNV
{
    public partial class FormThem : Form
    {
        public FormThem()
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TUAN\TUAN;Initial Catalog=IT008_QLNV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            try { 
            command.CommandText = "INSERT INTO NhanVien VALUES('"+textBoxMSSV.Text+"','"+textBoxHoTen.Text+"','"+DateTime.Parse(dateTimePickerNgSinh.Text)+"','"+DateTime.Parse(dateTimePickerNgVL.Text)+"')";
            command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
                
            }
            DialogResult dialogResult = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void FormThem_Load(object sender, EventArgs e)
        {
            
        }
    }
}
