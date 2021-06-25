using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

/*
   Ado.net
    1. Giữ kết nối: Đọc dữ liệu --> Object DataReader
    2. Connectless: Sự kết không xảy ra liên tục, mà sẽ được quản lý bởi pool
   Connection <--> DatAcapter(bridge) <--> Dataset <--> Data-Table <--> WindowsForm
*/


namespace WindowPhoneSimple
{
    public partial class FrmDanhMuc : Form
    {
        SqlConnection conn;
        public FrmDanhMuc()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string query = "select * from Categories";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            txtCateID.ReadOnly = false;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(dt);
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvDanhSach.DataSource = dt;
        }
        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnectionstring"].ConnectionString);

            LoadData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    //Mở đc thì insert data
                    string query = "insert Categories values(@id, @name)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", txtCateID.Text);
                    cmd.Parameters.AddWithValue("@name", txtCateName.Text);


                    //Execution query
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        LoadData(); //cập nhật lại datagridView
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thêm danh mục");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Có thể giống với insert 

            //C2: Dùng Store
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Sp_DeleteCate", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.NVarChar, 5);
                    cmd.Parameters["@id"].Value = txtCateID.Text;

                    //Execution query
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        LoadData(); //cập nhật lại datagridView
                        MessageBox.Show("Delete thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi xóa danh mục");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvDanhSach_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                txtCateID.Text = dgvDanhSach.SelectedRows[0].Cells["id"].Value.ToString();
                txtCateName.Text = dgvDanhSach.SelectedRows[0].Cells["name"].Value.ToString();
            }
            txtCateID.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();

                    //Mở đc thì update data
                    string query = "UPDATE Categories set name = @name where id = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtCateName.Text);
                    cmd.Parameters.AddWithValue("@id", txtCateID.Text);

                    //Execution query
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        LoadData(); //cập nhật lại datagridView
                        MessageBox.Show("Update thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi Update danh mục");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
