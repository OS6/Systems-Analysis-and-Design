﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using XoSoKienThiet.BUS;
using System.Data.Entity;

namespace XoSoKienThiet.Presentation
{
    public partial class frmHoSoDoiTac : DevExpress.XtraEditors.XtraForm
    {
        DOITAC_BUS _DOITAC_BUS = null;
        string _MaLoaiDoiTac = "LDT0000001";
        public frmHoSoDoiTac()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            XoSoKienThiet.DTO.XoSoKienThietDbContext dbContext = new XoSoKienThiet.DTO.XoSoKienThietDbContext();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.DOITACs.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource1.DataSource = dbContext.DOITACs.Local.ToBindingList();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string _Error = _DOITAC_BUS.Insert(_MaLoaiDoiTac, txtTenDoiTac.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text);
            if(_Error == "")
            {
                 MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 bindingSource1.DataSource = _DOITAC_BUS.Select();
            }
            else
            {
                 MessageBox.Show(_Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnLoaiDoiTac_Click(object sender, EventArgs e)
        {
           if(rbtnLoaiDoiTac.SelectedIndex  == 0)
           {
               _MaLoaiDoiTac = "LDT0000001";
           }
           else
           {
               _MaLoaiDoiTac = "LDT0000002";
           }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gvBASE_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }
    }
}