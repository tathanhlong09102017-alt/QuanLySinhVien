' Sử dụng các thư viện cần thiết của SQL Server
Imports System.Data.SqlClient

Public Class Form1
    ' Khai báo một biến cờ để biết khi nào đang ở chế độ "Thêm mới" hoặc "Sửa"
    Private dangThem As Boolean

#Region "Các hàm xử lý chính"

    ' Sự kiện này sẽ tự động chạy khi Form được mở lên
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tải dữ liệu chính lên bảng
        LoadData()
        ' Tải danh sách lớp vào ComboBox Lớp
        LoadComboBoxLop()
    End Sub

    ' Hàm dùng để tải dữ liệu từ CSDL lên DataGridView
    Private Sub LoadData()
        MoKetNoi()

        Dim sql As String = "SELECT * FROM SinhVien"
        Dim adapter As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        DgvXuat.DataSource = dt 'Sửa theo tên của bạn

        DongKetNoi()
    End Sub

    ' Hàm dùng để tải danh sách các lớp học vào ComboBox Lớp
    Private Sub LoadComboBoxLop()
        MoKetNoi()

        Dim sql As String = "SELECT MaLop FROM Lop"
        Dim adapter As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        ' Thiết lập cho ComboBox Lớp
        CbLop.DataSource = dt 'Sửa theo tên của bạn
        CbLop.DisplayMember = "MaLop" ' Hiển thị cột MaLop
        CbLop.ValueMember = "MaLop"   ' Giá trị thực sự là MaLop

        DongKetNoi()
    End Sub

#End Region


#Region "Sự kiện các nút bấm và DataGridView"

    ' Khi bấm vào một dòng trên bảng, hiển thị thông tin lên các ô nhập liệu
    Private Sub dgvSinhVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvXuat.CellClick
        Dim dongChon As Integer = e.RowIndex
        If dongChon >= 0 Then
            tbMasv.Text = DgvXuat.Rows(dongChon).Cells("MaSV").Value.ToString()
            tbHoten.Text = DgvXuat.Rows(dongChon).Cells("HoTen").Value.ToString()
            dtpNgaysinh.Value = CDate(DgvXuat.Rows(dongChon).Cells("NgaySinh").Value)
            CbGioiTinh.Text = DgvXuat.Rows(dongChon).Cells("GioiTinh").Value.ToString()
            tbDiachi.Text = DgvXuat.Rows(dongChon).Cells("DiaChi").Value.ToString()
            CbLop.Text = DgvXuat.Rows(dongChon).Cells("MaLop").Value.ToString()
        End If
    End Sub


    ' Nút Thêm: Chuẩn bị để nhập mới
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        ' Xóa trắng các ô nhập liệu
        tbMasv.Clear()
        tbHoten.Clear()
        tbDiachi.Clear()
        tbMasv.Focus() ' Đưa con trỏ vào ô Mã SV

        ' Bật cờ "đang thêm"
        dangThem = True
        ' Cho phép nhập Mã SV
        tbMasv.Enabled = True
    End Sub


    ' Nút Sửa: Chuẩn bị để sửa thông tin
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        ' Kiểm tra xem đã chọn sinh viên chưa
        If tbMasv.Text = "" Then
            MessageBox.Show("Bạn chưa chọn sinh viên để sửa!")
            Return
        End If

        ' Tắt cờ "đang thêm", nghĩa là đang sửa
        dangThem = False
        ' Không cho phép sửa Mã SV (vì là khóa chính)
        tbMasv.Enabled = False
    End Sub


    ' Nút Xóa: Xóa sinh viên đang chọn
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If tbMasv.Text = "" Then
            MessageBox.Show("Bạn chưa chọn sinh viên để xóa!")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên '" & tbHoten.Text & "' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MoKetNoi()
            Dim sql As String = "DELETE FROM SinhVien WHERE MaSV = @MaSV"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaSV", tbMasv.Text)
            cmd.ExecuteNonQuery()
            DongKetNoi()
            MessageBox.Show("Đã xóa sinh viên thành công!")
            LoadData()
        End If
    End Sub


    ' Nút Lưu: Lưu thông tin (cả Thêm mới và Sửa)
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        MoKetNoi()
        Dim cmd As SqlCommand

        If dangThem = True Then
            ' --- CHẾ ĐỘ THÊM MỚI ---
            Dim sqlInsert As String = "INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop) VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @MaLop)"
            cmd = New SqlCommand(sqlInsert, conn)
        Else
            ' --- CHẾ ĐỘ SỬA ---
            Dim sqlUpdate As String = "UPDATE SinhVien SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi, MaLop=@MaLop WHERE MaSV=@MaSV"
            cmd = New SqlCommand(sqlUpdate, conn)
        End If

        ' Gán giá trị từ các ô nhập liệu vào các tham số
        cmd.Parameters.AddWithValue("@MaSV", tbMasv.Text)
        cmd.Parameters.AddWithValue("@HoTen", tbHoten.Text)
        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaysinh.Value)
        cmd.Parameters.AddWithValue("@GioiTinh", CbGioiTinh.Text)
        cmd.Parameters.AddWithValue("@DiaChi", tbDiachi.Text)
        cmd.Parameters.AddWithValue("@MaLop", CbLop.Text)

        ' Thực thi lệnh
        cmd.ExecuteNonQuery()
        DongKetNoi()

        MessageBox.Show("Lưu thành công!")
        ' Tải lại dữ liệu để thấy sự thay đổi
        LoadData()
    End Sub


    ' Nút Hủy: Xóa trắng các ô và thoát chế độ Thêm/Sửa
    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        tbMasv.Clear()
        tbHoten.Clear()
        tbDiachi.Clear()
        tbMasv.Enabled = True ' Bật lại ô Mã SV
    End Sub

    ' (Nút Tìm chưa có code, bạn có thể thêm sau nếu muốn)
    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        MessageBox.Show("Chức năng này sẽ được phát triển sau!")
    End Sub

    Private Sub CbLop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbLop.SelectedIndexChanged

    End Sub

#End Region

End Class