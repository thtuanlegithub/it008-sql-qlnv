using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM NhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewNV.DataSource = table;
        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TUAN\TUAN;Initial Catalog=IT008_QLNV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormThem formThem = new FormThem();
            //this.Hide();
            formThem.ShowDialog();
            //this.Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (dialogResult == DialogResult.Yes)
            {
                command.Connection.CreateCommand();
                command.CommandText = "DELETE FROM NhanVien WHERE MSNV = '" + textBoxMSSV.Text + "'";
                command.ExecuteNonQuery();
                loadData();
            }
            else
            {

            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                command.Connection.CreateCommand();
                command.CommandText = "UPDATE NhanVien SET HoTen = '"+textBoxHoTen.Text+"', NgSinh = '"+DateTime.Parse(dateTimePickerNgSinh.Text)+"', NgVL = '"+DateTime.Parse(dateTimePickerNgVL.Text)+"' WHERE MSNV = '"+textBoxMSSV.Text+"'  ";
                command.ExecuteNonQuery();
                loadData();
            }
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = dataGridViewNV;
            int i = e.RowIndex;
            if (i >= 0)
            {
                textBoxMSSV.Text = dgv.Rows[i].Cells[0].Value.ToString();
                textBoxHoTen.Text = dgv.Rows[i].Cells[1].Value.ToString();
                dateTimePickerNgSinh.Value = DateTime.Parse(dgv.Rows[i].Cells[2].Value.ToString());
                dateTimePickerNgVL.Value = DateTime.Parse(dgv.Rows[i].Cells[3].Value.ToString());
            }
        }
    }
}
