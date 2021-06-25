
namespace WindowPhoneSimple
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethongMenuTrip = new System.Windows.Forms.ToolStripMenuItem();
            this.gioiThieuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyMenuTrip = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongMenuTrip,
            this.quanLyMenuTrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hethongMenuTrip
            // 
            this.hethongMenuTrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gioiThieuMenuItem,
            this.thoatMenuItem});
            this.hethongMenuTrip.Name = "hethongMenuTrip";
            this.hethongMenuTrip.Size = new System.Drawing.Size(88, 24);
            this.hethongMenuTrip.Text = "Hệ Thống";
            // 
            // gioiThieuMenuItem
            // 
            this.gioiThieuMenuItem.Name = "gioiThieuMenuItem";
            this.gioiThieuMenuItem.Size = new System.Drawing.Size(159, 26);
            this.gioiThieuMenuItem.Text = "Giới Thiệu";
            // 
            // thoatMenuItem
            // 
            this.thoatMenuItem.Name = "thoatMenuItem";
            this.thoatMenuItem.Size = new System.Drawing.Size(159, 26);
            this.thoatMenuItem.Text = "Thoát";
            // 
            // quanLyMenuTrip
            // 
            this.quanLyMenuTrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.quanLyMenuTrip.Name = "quanLyMenuTrip";
            this.quanLyMenuTrip.Size = new System.Drawing.Size(75, 24);
            this.quanLyMenuTrip.Text = "Quản Lý";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "Chương trình quản lý sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethongMenuTrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem quanLyMenuTrip;
        private System.Windows.Forms.ToolStripMenuItem gioiThieuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
    }
}

