using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPhoneSimple
{
    public partial class FrmGioiThieu : Form
    {
        public FrmGioiThieu()
        {
            InitializeComponent();
        }

        private void FrmGioiThieu_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "NỘI DUNG HỌC ADD CƠ BẢN \n" +
                "1.1 Tạo giao diện Mdi Form \n" +
                "1.2 Tạo CSDL dbBanHang có 1 bảng Categories \n" +
                "1.3 Tạo câu Connection String trong file cònig \n" +
                "1.4 Kết nối CSDL thực hiện CRUD \n" +
                "1.5 Thực hiện StoreProcedure cho chức năng Update \n";
        }
    }
}
