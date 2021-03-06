﻿namespace XoSoKienThiet.Presentation
{
    partial class frmKetQuaXoSo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetQuaXoSo));
            this.barManagerBASE = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNap = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelHeader = new DevExpress.XtraEditors.PanelControl();
            this.lbHeader = new DevExpress.XtraEditors.LabelControl();
            this.groupInfo = new DevExpress.XtraEditors.GroupControl();
            this.lcInfo = new DevExpress.XtraLayout.LayoutControl();
            this.lkLoaiVe = new DevExpress.XtraEditors.LookUpEdit();
            this.lkDotPhatHanh = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNgayXoSo = new DevExpress.XtraEditors.TextEdit();
            this.lcgInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ssRight = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupBASE = new DevExpress.XtraEditors.GroupControl();
            this.gcBASE = new DevExpress.XtraGrid.GridControl();
            this.gvBASE = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colMaChiTietKQXS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaGiaiThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKetQuaXoSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienTrung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongVeTrung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerBASE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).BeginInit();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcInfo)).BeginInit();
            this.lcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiVe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDotPhatHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayXoSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBASE)).BeginInit();
            this.groupBASE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBASE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBASE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerBASE
            // 
            this.barManagerBASE.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManagerBASE.DockControls.Add(this.barDockControlTop);
            this.barManagerBASE.DockControls.Add(this.barDockControlBottom);
            this.barManagerBASE.DockControls.Add(this.barDockControlLeft);
            this.barManagerBASE.DockControls.Add(this.barDockControlRight);
            this.barManagerBASE.Form = this;
            this.barManagerBASE.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNap,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnIn,
            this.btnXuat,
            this.btnDong});
            this.barManagerBASE.MainMenu = this.bar2;
            this.barManagerBASE.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnNap
            // 
            this.btnNap.Caption = "Nạp";
            this.btnNap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNap.Glyph")));
            this.btnNap.Id = 0;
            this.btnNap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNap.LargeGlyph")));
            this.btnNap.Name = "btnNap";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 1;
            this.btnThem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThem.LargeGlyph")));
            this.btnThem.Name = "btnThem";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSua.Glyph")));
            this.btnSua.Id = 2;
            this.btnSua.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSua.LargeGlyph")));
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 3;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLuu.Glyph")));
            this.btnLuu.Id = 4;
            this.btnLuu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLuu.LargeGlyph")));
            this.btnLuu.Name = "btnLuu";
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Glyph = ((System.Drawing.Image)(resources.GetObject("btnIn.Glyph")));
            this.btnIn.Id = 5;
            this.btnIn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnIn.LargeGlyph")));
            this.btnIn.Name = "btnIn";
            // 
            // btnXuat
            // 
            this.btnXuat.Caption = "Xuất";
            this.btnXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXuat.Glyph")));
            this.btnXuat.Id = 6;
            this.btnXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXuat.LargeGlyph")));
            this.btnXuat.Name = "btnXuat";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDong.Glyph")));
            this.btnDong.Id = 7;
            this.btnDong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDong.LargeGlyph")));
            this.btnDong.Name = "btnDong";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(842, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 490);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(842, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 466);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(842, 24);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 466);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lbHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 24);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(842, 41);
            this.panelHeader.TabIndex = 13;
            // 
            // lbHeader
            // 
            this.lbHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Appearance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbHeader.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Location = new System.Drawing.Point(2, 2);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(838, 37);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "KẾT QUẢ XỔ SỐ";
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lcInfo);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupInfo.Location = new System.Drawing.Point(0, 65);
            this.groupInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(842, 76);
            this.groupInfo.TabIndex = 14;
            this.groupInfo.Text = "Thông tin kết quả xổ số";
            // 
            // lcInfo
            // 
            this.lcInfo.Controls.Add(this.lkLoaiVe);
            this.lcInfo.Controls.Add(this.lkDotPhatHanh);
            this.lcInfo.Controls.Add(this.txtNgayXoSo);
            this.lcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcInfo.Location = new System.Drawing.Point(2, 20);
            this.lcInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lcInfo.Name = "lcInfo";
            this.lcInfo.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(956, 240, 947, 692);
            this.lcInfo.Root = this.lcgInfo;
            this.lcInfo.Size = new System.Drawing.Size(838, 54);
            this.lcInfo.TabIndex = 0;
            this.lcInfo.Text = "layoutControl1";
            // 
            // lkLoaiVe
            // 
            this.lkLoaiVe.Location = new System.Drawing.Point(531, 12);
            this.lkLoaiVe.MenuManager = this.barManagerBASE;
            this.lkLoaiVe.Name = "lkLoaiVe";
            this.lkLoaiVe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiVe.Properties.NullText = "";
            this.lkLoaiVe.Size = new System.Drawing.Size(95, 20);
            this.lkLoaiVe.StyleController = this.lcInfo;
            this.lkLoaiVe.TabIndex = 6;
            // 
            // lkDotPhatHanh
            // 
            this.lkDotPhatHanh.Location = new System.Drawing.Point(93, 12);
            this.lkDotPhatHanh.MenuManager = this.barManagerBASE;
            this.lkDotPhatHanh.Name = "lkDotPhatHanh";
            this.lkDotPhatHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDotPhatHanh.Properties.NullText = "";
            this.lkDotPhatHanh.Properties.PopupSizeable = false;
            this.lkDotPhatHanh.Properties.PopupWidth = 380;
            this.lkDotPhatHanh.Size = new System.Drawing.Size(353, 20);
            this.lkDotPhatHanh.StyleController = this.lcInfo;
            this.lkDotPhatHanh.TabIndex = 4;
            this.lkDotPhatHanh.EditValueChanged += new System.EventHandler(this.lkDotPhatHanh_EditValueChanged);
            // 
            // txtNgayXoSo
            // 
            this.txtNgayXoSo.Location = new System.Drawing.Point(711, 12);
            this.txtNgayXoSo.MenuManager = this.barManagerBASE;
            this.txtNgayXoSo.Name = "txtNgayXoSo";
            this.txtNgayXoSo.Properties.ReadOnly = true;
            this.txtNgayXoSo.Size = new System.Drawing.Size(115, 20);
            this.txtNgayXoSo.StyleController = this.lcInfo;
            this.txtNgayXoSo.TabIndex = 5;
            // 
            // lcgInfo
            // 
            this.lcgInfo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgInfo.GroupBordersVisible = false;
            this.lcgInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ssRight,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.lcgInfo.Location = new System.Drawing.Point(0, 0);
            this.lcgInfo.Name = "lcgInfo";
            this.lcgInfo.OptionsItemText.TextToControlDistance = 4;
            this.lcgInfo.Size = new System.Drawing.Size(838, 54);
            this.lcgInfo.TextVisible = false;
            // 
            // ssRight
            // 
            this.ssRight.AllowHotTrack = false;
            this.ssRight.Location = new System.Drawing.Point(0, 24);
            this.ssRight.Name = "ssRight";
            this.ssRight.Size = new System.Drawing.Size(818, 10);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lkDotPhatHanh;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(438, 24);
            this.layoutControlItem1.Text = "Đợt phát hành: ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNgayXoSo;
            this.layoutControlItem2.Location = new System.Drawing.Point(618, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.Text = "Ngày xổ số: ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lkLoaiVe;
            this.layoutControlItem3.Location = new System.Drawing.Point(438, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(180, 24);
            this.layoutControlItem3.Text = "Loại vé: ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // groupBASE
            // 
            this.groupBASE.Controls.Add(this.gcBASE);
            this.groupBASE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBASE.Location = new System.Drawing.Point(0, 141);
            this.groupBASE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBASE.Name = "groupBASE";
            this.groupBASE.Size = new System.Drawing.Size(842, 349);
            this.groupBASE.TabIndex = 24;
            this.groupBASE.Text = "Danh sách kết quả xổ số";
            // 
            // gcBASE
            // 
            this.gcBASE.DataSource = this.bindingSource1;
            this.gcBASE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBASE.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBASE.Location = new System.Drawing.Point(2, 20);
            this.gcBASE.MainView = this.gvBASE;
            this.gcBASE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBASE.MenuManager = this.barManagerBASE;
            this.gcBASE.Name = "gcBASE";
            this.gcBASE.Size = new System.Drawing.Size(838, 327);
            this.gcBASE.TabIndex = 0;
            this.gcBASE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBASE});
            // 
            // gvBASE
            // 
            this.gvBASE.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaChiTietKQXS,
            this.colMaGiaiThuong,
            this.colMaKetQuaXoSo,
            this.colTen,
            this.colSoTienTrung,
            this.colSoGiai,
            this.colSoLuongVeTrung,
            this.colTongTien});
            this.gvBASE.GridControl = this.gcBASE;
            this.gvBASE.Name = "gvBASE";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(XoSoKienThiet.DTO.CT_KETQUAXOSO_VIEW);
            // 
            // colMaChiTietKQXS
            // 
            this.colMaChiTietKQXS.FieldName = "MaChiTietKQXS";
            this.colMaChiTietKQXS.Name = "colMaChiTietKQXS";
            this.colMaChiTietKQXS.Visible = true;
            this.colMaChiTietKQXS.VisibleIndex = 0;
            // 
            // colMaGiaiThuong
            // 
            this.colMaGiaiThuong.FieldName = "MaGiaiThuong";
            this.colMaGiaiThuong.Name = "colMaGiaiThuong";
            this.colMaGiaiThuong.Visible = true;
            this.colMaGiaiThuong.VisibleIndex = 1;
            // 
            // colMaKetQuaXoSo
            // 
            this.colMaKetQuaXoSo.FieldName = "MaKetQuaXoSo";
            this.colMaKetQuaXoSo.Name = "colMaKetQuaXoSo";
            this.colMaKetQuaXoSo.Visible = true;
            this.colMaKetQuaXoSo.VisibleIndex = 2;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 3;
            // 
            // colSoTienTrung
            // 
            this.colSoTienTrung.FieldName = "SoTienTrung";
            this.colSoTienTrung.Name = "colSoTienTrung";
            this.colSoTienTrung.Visible = true;
            this.colSoTienTrung.VisibleIndex = 4;
            // 
            // colSoGiai
            // 
            this.colSoGiai.FieldName = "SoGiai";
            this.colSoGiai.Name = "colSoGiai";
            this.colSoGiai.Visible = true;
            this.colSoGiai.VisibleIndex = 5;
            // 
            // colSoLuongVeTrung
            // 
            this.colSoLuongVeTrung.FieldName = "SoLuongVeTrung";
            this.colSoLuongVeTrung.Name = "colSoLuongVeTrung";
            this.colSoLuongVeTrung.Visible = true;
            this.colSoLuongVeTrung.VisibleIndex = 6;
            // 
            // colTongTien
            // 
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 7;
            // 
            // frmKetQuaXoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 490);
            this.Controls.Add(this.groupBASE);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKetQuaXoSo";
            this.Text = "Kết quả xổ số";
            this.Load += new System.EventHandler(this.frmKetQuaXoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerBASE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).EndInit();
            this.groupInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcInfo)).EndInit();
            this.lcInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiVe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDotPhatHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayXoSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBASE)).EndInit();
            this.groupBASE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBASE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBASE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerBASE;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNap;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnXuat;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelHeader;
        private DevExpress.XtraEditors.LabelControl lbHeader;
        private DevExpress.XtraEditors.GroupControl groupInfo;
        private DevExpress.XtraLayout.LayoutControl lcInfo;
        private DevExpress.XtraLayout.LayoutControlGroup lcgInfo;
        private DevExpress.XtraEditors.GroupControl groupBASE;
        private DevExpress.XtraGrid.GridControl gcBASE;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBASE;
        private DevExpress.XtraEditors.LookUpEdit lkLoaiVe;
        private DevExpress.XtraEditors.LookUpEdit lkDotPhatHanh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtNgayXoSo;
        private DevExpress.XtraLayout.SimpleSeparator ssRight;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChiTietKQXS;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGiaiThuong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKetQuaXoSo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienTrung;
        private DevExpress.XtraGrid.Columns.GridColumn colSoGiai;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongVeTrung;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
    }
}