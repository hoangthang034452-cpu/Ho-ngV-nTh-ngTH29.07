<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpNgayBan = New System.Windows.Forms.DateTimePicker()
        Me.cboMaKH = New System.Windows.Forms.ComboBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.cboMaNV = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstChiTietHD = New System.Windows.Forms.ListBox()
        Me.btDong = New System.Windows.Forms.Button()
        Me.btInHD = New System.Windows.Forms.Button()
        Me.btHuyHD = New System.Windows.Forms.Button()
        Me.btThemHD = New System.Windows.Forms.Button()
        Me.btLuuHD = New System.Windows.Forms.Button()
        Me.txtBangChu = New System.Windows.Forms.TextBox()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtGiamGia = New System.Windows.Forms.TextBox()
        Me.txtTenHang = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.cboMaHang = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btTimKiem = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.dtpNgayBan)
        Me.GroupBox1.Controls.Add(Me.cboMaKH)
        Me.GroupBox1.Controls.Add(Me.txtDienThoai)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtTenKH)
        Me.GroupBox1.Controls.Add(Me.txtTenNV)
        Me.GroupBox1.Controls.Add(Me.cboMaNV)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(929, 230)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Chung"
        '
        'dtpNgayBan
        '
        Me.dtpNgayBan.Location = New System.Drawing.Point(193, 77)
        Me.dtpNgayBan.Name = "dtpNgayBan"
        Me.dtpNgayBan.Size = New System.Drawing.Size(250, 22)
        Me.dtpNgayBan.TabIndex = 15
        '
        'cboMaKH
        '
        Me.cboMaKH.FormattingEnabled = True
        Me.cboMaKH.Items.AddRange(New Object() {"KH01", "KH02", "KH03", "KH04", "KH05"})
        Me.cboMaKH.Location = New System.Drawing.Point(699, 40)
        Me.cboMaKH.Name = "cboMaKH"
        Me.cboMaKH.Size = New System.Drawing.Size(173, 24)
        Me.cboMaKH.TabIndex = 14
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(699, 157)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(173, 22)
        Me.txtDienThoai.TabIndex = 13
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(699, 118)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(173, 22)
        Me.txtDiaChi.TabIndex = 12
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(699, 77)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(173, 22)
        Me.txtTenKH.TabIndex = 11
        '
        'txtTenNV
        '
        Me.txtTenNV.Location = New System.Drawing.Point(193, 157)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(184, 22)
        Me.txtTenNV.TabIndex = 10
        '
        'cboMaNV
        '
        Me.cboMaNV.FormattingEnabled = True
        Me.cboMaNV.Items.AddRange(New Object() {"NV01", "NV02", "NV03", "NV04", "NV05"})
        Me.cboMaNV.Location = New System.Drawing.Point(193, 116)
        Me.cboMaNV.Name = "cboMaNV"
        Me.cboMaNV.Size = New System.Drawing.Size(184, 24)
        Me.cboMaNV.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(496, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Số Điện Thoại "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(496, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Địa Chỉ "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(496, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tên Khách Hàng "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(496, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mã Khách Hàng "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tên Nhân Viên "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mã Nhân Viên "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ngày Giờ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstChiTietHD)
        Me.GroupBox2.Controls.Add(Me.btDong)
        Me.GroupBox2.Controls.Add(Me.btInHD)
        Me.GroupBox2.Controls.Add(Me.btHuyHD)
        Me.GroupBox2.Controls.Add(Me.btThemHD)
        Me.GroupBox2.Controls.Add(Me.btLuuHD)
        Me.GroupBox2.Controls.Add(Me.txtBangChu)
        Me.GroupBox2.Controls.Add(Me.txtTongTien)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtThanhTien)
        Me.GroupBox2.Controls.Add(Me.txtDonGia)
        Me.GroupBox2.Controls.Add(Me.txtGiamGia)
        Me.GroupBox2.Controls.Add(Me.txtTenHang)
        Me.GroupBox2.Controls.Add(Me.txtSoLuong)
        Me.GroupBox2.Controls.Add(Me.cboMaHang)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 301)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(928, 350)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông Tin Các Mặt Hàng "
        '
        'lstChiTietHD
        '
        Me.lstChiTietHD.FormattingEnabled = True
        Me.lstChiTietHD.ItemHeight = 16
        Me.lstChiTietHD.Location = New System.Drawing.Point(9, 114)
        Me.lstChiTietHD.Name = "lstChiTietHD"
        Me.lstChiTietHD.Size = New System.Drawing.Size(863, 132)
        Me.lstChiTietHD.TabIndex = 37
        '
        'btDong
        '
        Me.btDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDong.Location = New System.Drawing.Point(805, 302)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(99, 37)
        Me.btDong.TabIndex = 36
        Me.btDong.Text = "Đóng "
        Me.btDong.UseVisualStyleBackColor = True
        '
        'btInHD
        '
        Me.btInHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInHD.Location = New System.Drawing.Point(621, 302)
        Me.btInHD.Name = "btInHD"
        Me.btInHD.Size = New System.Drawing.Size(154, 37)
        Me.btInHD.TabIndex = 35
        Me.btInHD.Text = "In Hóa Đơn"
        Me.btInHD.UseVisualStyleBackColor = True
        '
        'btHuyHD
        '
        Me.btHuyHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHuyHD.Location = New System.Drawing.Point(429, 302)
        Me.btHuyHD.Name = "btHuyHD"
        Me.btHuyHD.Size = New System.Drawing.Size(159, 37)
        Me.btHuyHD.TabIndex = 34
        Me.btHuyHD.Text = "Hủy Hóa Đơn "
        Me.btHuyHD.UseVisualStyleBackColor = True
        '
        'btThemHD
        '
        Me.btThemHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThemHD.Location = New System.Drawing.Point(218, 302)
        Me.btThemHD.Name = "btThemHD"
        Me.btThemHD.Size = New System.Drawing.Size(177, 37)
        Me.btThemHD.TabIndex = 33
        Me.btThemHD.Text = "Thêm Hóa Đơn"
        Me.btThemHD.UseVisualStyleBackColor = True
        '
        'btLuuHD
        '
        Me.btLuuHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLuuHD.Location = New System.Drawing.Point(24, 302)
        Me.btLuuHD.Name = "btLuuHD"
        Me.btLuuHD.Size = New System.Drawing.Size(162, 37)
        Me.btLuuHD.TabIndex = 32
        Me.btLuuHD.Text = "Lưu Hóa Đơn"
        Me.btLuuHD.UseVisualStyleBackColor = True
        '
        'txtBangChu
        '
        Me.txtBangChu.Location = New System.Drawing.Point(594, 268)
        Me.txtBangChu.Name = "txtBangChu"
        Me.txtBangChu.Size = New System.Drawing.Size(244, 22)
        Me.txtBangChu.TabIndex = 31
        '
        'txtTongTien
        '
        Me.txtTongTien.Location = New System.Drawing.Point(175, 268)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Size = New System.Drawing.Size(149, 22)
        Me.txtTongTien.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(474, 265)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 25)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Bằng Chữ "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(40, 265)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 25)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Tổng Tiền "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(623, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 20)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Thành Tiền "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(623, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 20)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Đơn Giá "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(333, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Giảm Giá %"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(333, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Tên Hàng "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Số Lượng "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Mã Hàng "
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(742, 60)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(152, 22)
        Me.txtThanhTien.TabIndex = 20
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(742, 21)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(152, 22)
        Me.txtDonGia.TabIndex = 19
        '
        'txtGiamGia
        '
        Me.txtGiamGia.Location = New System.Drawing.Point(449, 58)
        Me.txtGiamGia.Name = "txtGiamGia"
        Me.txtGiamGia.Size = New System.Drawing.Size(152, 22)
        Me.txtGiamGia.TabIndex = 18
        '
        'txtTenHang
        '
        Me.txtTenHang.Location = New System.Drawing.Point(449, 23)
        Me.txtTenHang.Name = "txtTenHang"
        Me.txtTenHang.Size = New System.Drawing.Size(152, 22)
        Me.txtTenHang.TabIndex = 17
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(147, 58)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(148, 22)
        Me.txtSoLuong.TabIndex = 16
        '
        'cboMaHang
        '
        Me.cboMaHang.FormattingEnabled = True
        Me.cboMaHang.Location = New System.Drawing.Point(146, 23)
        Me.cboMaHang.Name = "cboMaHang"
        Me.cboMaHang.Size = New System.Drawing.Size(145, 24)
        Me.cboMaHang.TabIndex = 16
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(285, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(321, 32)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "HÓA ĐƠN BÁN HÀNG "
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(53, 670)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(132, 25)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Mã Hóa Đơn"
        '
        'btTimKiem
        '
        Me.btTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTimKiem.Location = New System.Drawing.Point(419, 657)
        Me.btTimKiem.Name = "btTimKiem"
        Me.btTimKiem.Size = New System.Drawing.Size(134, 37)
        Me.btTimKiem.TabIndex = 37
        Me.btTimKiem.Text = "Tìm KIếm "
        Me.btTimKiem.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"HD01", "HD02", "HD03"})
        Me.ComboBox1.Location = New System.Drawing.Point(192, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(184, 24)
        Me.ComboBox1.TabIndex = 16
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(194, 667)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(148, 22)
        Me.txtMaHD.TabIndex = 38
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 727)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btTimKiem)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Quán Lý Bán Hàng "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpNgayBan As DateTimePicker
    Friend WithEvents cboMaKH As ComboBox
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents txtTenNV As TextBox
    Friend WithEvents cboMaNV As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtGiamGia As TextBox
    Friend WithEvents txtTenHang As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents cboMaHang As ComboBox
    Friend WithEvents btDong As Button
    Friend WithEvents btInHD As Button
    Friend WithEvents btHuyHD As Button
    Friend WithEvents btThemHD As Button
    Friend WithEvents txtBangChu As TextBox
    Friend WithEvents txtTongTien As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lstChiTietHD As ListBox
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents btLuuHD As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents btTimKiem As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtMaHD As TextBox
End Class
