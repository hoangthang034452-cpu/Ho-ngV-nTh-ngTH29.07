Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Globalization

Public Class Form1
    Dim conn As SqlConnection
    Dim tongtien As Double = 0

    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=LAPTOP-1401PTHN\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True;TrustServerCertificate=True")
        conn.Open()

        LoadCombo("SELECT MaKH FROM KhachHang", cboMaKH)
        LoadCombo("SELECT MaNV FROM NhanVien", cboMaNV)
        LoadCombo("SELECT MaHang FROM HangHoa", cboMaHang)
    End Sub

    Private Sub LoadCombo(sql As String, cbo As ComboBox)
        Dim da As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        cbo.DataSource = dt
        cbo.DisplayMember = dt.Columns(0).ColumnName
        cbo.ValueMember = dt.Columns(0).ColumnName
    End Sub

    Private Sub cboMaKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaKH.SelectedIndexChanged
        Dim sql = "SELECT TenKH, DiaChi, DienThoai FROM KhachHang WHERE MaKH=@makh"
        Using cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@makh", cboMaKH.Text)
            Dim rd = cmd.ExecuteReader()
            If rd.Read() Then
                txtTenKH.Text = rd("TenKH").ToString()
                txtDiaChi.Text = rd("DiaChi").ToString()
                txtDienThoai.Text = rd("DienThoai").ToString()
            End If
            rd.Close()
        End Using
    End Sub

    Private Sub cboMaNV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaNV.SelectedIndexChanged
        Dim sql = "SELECT TenNV FROM NhanVien WHERE MaNV=@manv"
        Using cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@manv", cboMaNV.Text)
            Dim rd = cmd.ExecuteReader()
            If rd.Read() Then txtTenNV.Text = rd("TenNV").ToString()
            rd.Close()
        End Using
    End Sub

    Private Sub cboMaHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaHang.SelectedIndexChanged
        Dim sql = "SELECT TenHang, DonGia FROM HangHoa WHERE MaHang=@mahang"
        Using cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@mahang", cboMaHang.Text)
            Dim rd = cmd.ExecuteReader()
            If rd.Read() Then
                txtTenHang.Text = rd("TenHang").ToString()
                txtDonGia.Text = rd("DonGia").ToString()
            End If
            rd.Close()
        End Using
    End Sub

    Private Sub TinhThanhTien()
        Dim sl = Val(txtSoLuong.Text)
        Dim dg = Val(txtDonGia.Text)
        Dim gg = Val(txtGiamGia.Text)
        Dim tt = (sl * dg) * (1 - gg / 100)
        txtThanhTien.Text = tt.ToString("N0")
    End Sub

    Private Sub txtSoLuong_Leave(sender As Object, e As EventArgs) Handles txtSoLuong.Leave
        TinhThanhTien()
    End Sub

    Private Sub txtDonGia_Leave(sender As Object, e As EventArgs) Handles txtDonGia.Leave
        TinhThanhTien()
    End Sub

    Private Sub txtGiamGia_Leave(sender As Object, e As EventArgs) Handles txtGiamGia.Leave
        TinhThanhTien()
    End Sub

    Private Sub btThemHD_Click(sender As Object, e As EventArgs) Handles btThemHD.Click
        Dim thanhTien As Double = Val(txtDonGia.Text) * Val(txtSoLuong.Text) * (1 - Val(txtGiamGia.Text) / 100)
        txtThanhTien.Text = thanhTien.ToString("N0")

        Dim line = "HH01 - Điện thoại - SL: " & txtSoLuong.Text & " - ĐG: " & txtDonGia.Text & " - GG: " & txtGiamGia.Text & "% - TT: " & txtThanhTien.Text
        lstChiTietHD.Items.Add(line)

        ' Tính tổng tiền
        Dim tong As Double = 0
        For Each item As String In lstChiTietHD.Items
            If item.ToString().Contains("TT:") Then
                Dim start = item.IndexOf("TT:") + 3
                Dim tt = item.Substring(start).Trim().Replace(",", "")
                tong += Val(tt)
            End If
        Next

        txtTongTien.Text = tong.ToString("N0")

    End Sub


    Private Sub TinhTongTien()
        Dim tong As Decimal = 0

        For Each dong As String In lstChiTietHD.Items
            Dim parts() As String = dong.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
            If parts.Length >= 5 Then
                Dim thanhTien As Decimal
                If Decimal.TryParse(parts(parts.Length - 1), thanhTien) Then
                    tong += thanhTien
                End If
            End If
        Next

        ' Hiển thị vào textbox
        txtTongTien.Text = tong.ToString("N0")
    End Sub

    Private Sub btInTien_Click(sender As Object, e As EventArgs) Handles btInHD.Click
        ' Lấy dữ liệu
        Dim maHang As String = cboMaHang.Text
        Dim tenHang As String = txtTenHang.Text
        Dim soLuong As Integer = Val(txtSoLuong.Text)
        Dim donGia As Decimal = Val(txtDonGia.Text)
        Dim giamGia As Decimal = Val(txtGiamGia.Text)

        ' Tính thành tiền
        Dim thanhTien As Decimal = soLuong * donGia * (1 - giamGia / 100)

        ' Thêm vào ListBox
        Dim dong As String = String.Format("{0,-8}{1,-15}{2,5}{3,12:N0}{4,12:N0}", maHang, tenHang, soLuong, donGia, thanhTien)
        lstChiTietHD.Items.Add(dong)

        ' Gọi hàm tính tổng tiền luôn
        TinhTongTien()
    End Sub




    Private Sub btLuuHD_Click(sender As Object, e As EventArgs) Handles btLuuHD.Click
        TinhTongTien()
        Try
            Dim sqlCheck = "SELECT COUNT(*) FROM HoaDon WHERE MaHD=@mahd"
            Using cmdCheck As New SqlCommand(sqlCheck, conn)
                cmdCheck.Parameters.AddWithValue("@mahd", txtMaHD.Text)
                If CInt(cmdCheck.ExecuteScalar()) > 0 Then
                    MessageBox.Show("Mã hóa đơn đã tồn tại!")
                    Return
                End If
            End Using

            Dim sqlHD = "INSERT INTO HoaDon VALUES(@mahd,@makh,@manv,@ngay,@tong)"
            Using cmd As New SqlCommand(sqlHD, conn)
                cmd.Parameters.AddWithValue("@mahd", txtMaHD.Text)
                cmd.Parameters.AddWithValue("@makh", cboMaKH.Text)
                cmd.Parameters.AddWithValue("@manv", cboMaNV.Text)
                cmd.Parameters.AddWithValue("@ngay", dtpNgayBan.Value)
                cmd.Parameters.AddWithValue("@tong", tongtien)
                cmd.ExecuteNonQuery()
            End Using

            For Each item As String In lstChiTietHD.Items
                Dim parts() = item.Split("-"c)
                Dim mahang = parts(0).Trim()
                Dim sl = Val(parts(2).Replace("SL:", "").Trim())
                Dim dg = Val(parts(3).Replace("DG:", "").Replace(",", "").Trim())
                Dim gg = Val(parts(4).Replace("GG:", "").Replace("%", "").Trim())
                Dim tt = Val(parts(5).Replace("TT:", "").Replace(",", "").Trim())

                Dim sqlCT = "INSERT INTO ChiTietHD VALUES(@mahd,@mahang,@sl,@dg,@gg,@tt)"
                Using cmd As New SqlCommand(sqlCT, conn)
                    cmd.Parameters.AddWithValue("@mahd", txtMaHD.Text)
                    cmd.Parameters.AddWithValue("@mahang", mahang)
                    cmd.Parameters.AddWithValue("@sl", sl)
                    cmd.Parameters.AddWithValue("@dg", dg)
                    cmd.Parameters.AddWithValue("@gg", gg)
                    cmd.Parameters.AddWithValue("@tt", tt)
                    cmd.ExecuteNonQuery()
                End Using
            Next

            MessageBox.Show("Lưu hóa đơn thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lưu: " & ex.Message)
        End Try
    End Sub

    Private Sub btInHD_Click(sender As Object, e As EventArgs) Handles btInHD.Click
        TinhTongTien()
        Dim doc As New PrintDocument()
        AddHandler doc.PrintPage, AddressOf PrintHoaDon
        Dim dlg As New PrintPreviewDialog()
        dlg.Document = doc
        dlg.ShowDialog()
    End Sub

    Private Sub PrintHoaDon(sender As Object, e As Printing.PrintPageEventArgs)
        Dim g = e.Graphics
        Dim font = New Font("Arial", 12)
        Dim y = 100

        g.DrawString("HÓA ĐƠN BÁN HÀNG", New Font("Arial", 16, FontStyle.Bold), Brushes.Black, 200, y)
        y += 40
        g.DrawString("Mã HĐ: " & txtMaHD.Text, font, Brushes.Black, 50, y)
        y += 25
        g.DrawString("Khách hàng: " & txtTenKH.Text, font, Brushes.Black, 50, y)
        y += 25
        g.DrawString("Địa chỉ: " & txtDiaChi.Text, font, Brushes.Black, 50, y)
        y += 25
        g.DrawString("Điện thoại: " & txtDienThoai.Text, font, Brushes.Black, 50, y)
        y += 25
        g.DrawString("Nhân viên: " & txtTenNV.Text, font, Brushes.Black, 50, y)
        y += 25
        g.DrawString("Ngày lập: " & dtpNgayBan.Value.ToShortDateString(), font, Brushes.Black, 50, y)
        y += 40

        For Each item As String In lstChiTietHD.Items
            g.DrawString(item.ToString(), font, Brushes.Black, 50, y)
            y += 25
        Next

        g.DrawString("Tổng tiền: " & txtTongTien.Text, font, Brushes.Black, 50, y + 20)
        g.DrawString("Bằng chữ: " & txtBangChu.Text, font, Brushes.Black, 50, y + 50)
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        If txtMaHD.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập mã hóa đơn cần tìm!")
            Return
        End If

        Try
            Dim sqlHD As String = "SELECT * FROM HoaDon WHERE MaHD=@mahd"
            Using cmd As New SqlCommand(sqlHD, conn)
                cmd.Parameters.AddWithValue("@mahd", txtMaHD.Text)
                Dim rd = cmd.ExecuteReader()
                If rd.Read() Then
                    cboMaKH.Text = rd("MaKH").ToString()
                    cboMaNV.Text = rd("MaNV").ToString()
                    dtpNgayBan.Value = CDate(rd("NgayLap"))
                    txtTongTien.Text = rd("TongTien").ToString()
                    rd.Close()
                    cboMaKH_SelectedIndexChanged(Nothing, Nothing)
                    cboMaNV_SelectedIndexChanged(Nothing, Nothing)
                Else
                    MessageBox.Show("Không tìm thấy hóa đơn!")
                    rd.Close()
                    Return
                End If
            End Using

            lstChiTietHD.Items.Clear()
            Dim sqlCT As String = "SELECT c.MaHang,h.TenHang,c.SoLuong,c.DonGia,c.GiamGia,c.ThanhTien 
                                   FROM ChiTietHD c JOIN HangHoa h ON c.MaHang=h.MaHang WHERE MaHD=@mahd"
            Using da As New SqlDataAdapter(sqlCT, conn)
                da.SelectCommand.Parameters.AddWithValue("@mahd", txtMaHD.Text)
                Dim dt As New DataTable
                da.Fill(dt)
                For Each r As DataRow In dt.Rows
                    Dim line As String = r("MaHang") & " - " & r("TenHang") & " - SL:" & r("SoLuong") & " - DG:" & r("DonGia") & " - GG:" & r("GiamGia") & "% - TT:" & r("ThanhTien")
                    lstChiTietHD.Items.Add(line)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tìm kiếm: " & ex.Message)
        End Try
    End Sub

    Private Sub btHuyHD_Click(sender As Object, e As EventArgs) Handles btHuyHD.Click
        txtMaHD.Text = ""
        cboMaKH.SelectedIndex = -1
        cboMaNV.SelectedIndex = -1
        txtTenKH.Clear()
        txtDiaChi.Clear()
        txtDienThoai.Clear()
        txtTenNV.Clear()
        txtTenHang.Clear()
        txtDonGia.Clear()
        txtSoLuong.Clear()
        txtGiamGia.Clear()
        txtThanhTien.Clear()
        txtTongTien.Clear()
        txtBangChu.Clear()
        lstChiTietHD.Items.Clear()
        tongtien = 0
    End Sub

    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub
End Class
