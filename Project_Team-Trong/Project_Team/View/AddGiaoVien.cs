﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
namespace Project_Team
{
    public partial class AddGiaoVien : MaterialSkin.Controls.MaterialForm
    {
        public AddGiaoVien()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
            LoadMaKhoa();
            
        }
        private void LoadMaKhoa()
        {
            cbMaKhoa.DataSource = MainForm.BLL.Get_ListMaKhoa_BLL();
        }
        public void text_Clear()
        {
            txtMaGiaoVien.Text = "";
            txtTenGiaoVien.Text = "";
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (ThieuThongTin())
            {
                MessageBox.Show("Thiếu thông tin");
            }
            else
            {
                ChuNhiem giaoVien = new ChuNhiem();
                giaoVien.MaGiaoVien = txtGV.Text + cbMaKhoa.Text + "_" + txtMaGiaoVien.Text;
                giaoVien.TenGiaoVien = txtTenGiaoVien.Text;
                if (MainForm.BLL.Add_GiaoVien_BLL(giaoVien)) MessageBox.Show("Thêm giáo viên thành công");
                else MessageBox.Show("Đã có giáo viên này");
                text_Clear();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            text_Clear();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private bool ThieuThongTin()
        {
            if (string.IsNullOrWhiteSpace(txtMaGiaoVien.Text) || string.IsNullOrWhiteSpace(txtTenGiaoVien.Text))
            {
                return true;
            }
            else return false;
        }
    }
}
