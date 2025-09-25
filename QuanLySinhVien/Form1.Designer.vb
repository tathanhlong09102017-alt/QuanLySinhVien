<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.tbMasv = New System.Windows.Forms.TextBox()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.txtNgaysinh = New System.Windows.Forms.Label()
        Me.txtgioitinh = New System.Windows.Forms.Label()
        Me.txtLop = New System.Windows.Forms.Label()
        Me.tbHoten = New System.Windows.Forms.TextBox()
        Me.tbDiachi = New System.Windows.Forms.TextBox()
        Me.CbGioiTinh = New System.Windows.Forms.ComboBox()
        Me.dtpNgaysinh = New System.Windows.Forms.DateTimePicker()
        Me.CbLop = New System.Windows.Forms.ComboBox()
        Me.DgvXuat = New System.Windows.Forms.DataGridView()
        Me.txtMaSV = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.Label()
        CType(Me.DgvXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.Cursor = System.Windows.Forms.Cursors.No
        Me.btnThem.Location = New System.Drawing.Point(800, 41)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(104, 27)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(800, 84)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(104, 27)
        Me.btnSua.TabIndex = 3
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(800, 128)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(104, 27)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(800, 171)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(104, 27)
        Me.btnLuu.TabIndex = 5
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'tbMasv
        '
        Me.tbMasv.Location = New System.Drawing.Point(122, 15)
        Me.tbMasv.Name = "tbMasv"
        Me.tbMasv.Size = New System.Drawing.Size(533, 20)
        Me.tbMasv.TabIndex = 6
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(671, 8)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(104, 27)
        Me.btnTim.TabIndex = 7
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(800, 218)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(104, 27)
        Me.btnHuy.TabIndex = 8
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'txtNgaysinh
        '
        Me.txtNgaysinh.AutoSize = True
        Me.txtNgaysinh.Location = New System.Drawing.Point(45, 91)
        Me.txtNgaysinh.Name = "txtNgaysinh"
        Me.txtNgaysinh.Size = New System.Drawing.Size(56, 13)
        Me.txtNgaysinh.TabIndex = 10
        Me.txtNgaysinh.Text = "Ngày Sinh"
        '
        'txtgioitinh
        '
        Me.txtgioitinh.AutoSize = True
        Me.txtgioitinh.Location = New System.Drawing.Point(46, 128)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(47, 13)
        Me.txtgioitinh.TabIndex = 11
        Me.txtgioitinh.Text = "Giới tính"
        '
        'txtLop
        '
        Me.txtLop.AutoSize = True
        Me.txtLop.Location = New System.Drawing.Point(46, 194)
        Me.txtLop.Name = "txtLop"
        Me.txtLop.Size = New System.Drawing.Size(25, 13)
        Me.txtLop.TabIndex = 12
        Me.txtLop.Text = "Lớp"
        '
        'tbHoten
        '
        Me.tbHoten.Location = New System.Drawing.Point(122, 55)
        Me.tbHoten.Name = "tbHoten"
        Me.tbHoten.Size = New System.Drawing.Size(533, 20)
        Me.tbHoten.TabIndex = 14
        '
        'tbDiachi
        '
        Me.tbDiachi.Location = New System.Drawing.Point(122, 151)
        Me.tbDiachi.Name = "tbDiachi"
        Me.tbDiachi.Size = New System.Drawing.Size(533, 20)
        Me.tbDiachi.TabIndex = 15
        '
        'CbGioiTinh
        '
        Me.CbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbGioiTinh.FormattingEnabled = True
        Me.CbGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ", "LGBT"})
        Me.CbGioiTinh.Location = New System.Drawing.Point(122, 124)
        Me.CbGioiTinh.Name = "CbGioiTinh"
        Me.CbGioiTinh.Size = New System.Drawing.Size(121, 21)
        Me.CbGioiTinh.TabIndex = 16
        '
        'dtpNgaysinh
        '
        Me.dtpNgaysinh.Location = New System.Drawing.Point(122, 91)
        Me.dtpNgaysinh.Name = "dtpNgaysinh"
        Me.dtpNgaysinh.Size = New System.Drawing.Size(342, 20)
        Me.dtpNgaysinh.TabIndex = 17
        '
        'CbLop
        '
        Me.CbLop.FormattingEnabled = True
        Me.CbLop.Location = New System.Drawing.Point(122, 194)
        Me.CbLop.Name = "CbLop"
        Me.CbLop.Size = New System.Drawing.Size(121, 21)
        Me.CbLop.TabIndex = 18
        '
        'DgvXuat
        '
        Me.DgvXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvXuat.Location = New System.Drawing.Point(48, 268)
        Me.DgvXuat.Name = "DgvXuat"
        Me.DgvXuat.Size = New System.Drawing.Size(850, 217)
        Me.DgvXuat.TabIndex = 19
        '
        'txtMaSV
        '
        Me.txtMaSV.AutoSize = True
        Me.txtMaSV.Location = New System.Drawing.Point(45, 18)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(39, 13)
        Me.txtMaSV.TabIndex = 20
        Me.txtMaSV.Text = "Mã SV"
        '
        'txtHoTen
        '
        Me.txtHoTen.AutoSize = True
        Me.txtHoTen.Location = New System.Drawing.Point(47, 58)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(39, 13)
        Me.txtHoTen.TabIndex = 21
        Me.txtHoTen.Text = "Họ tên"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.AutoSize = True
        Me.txtDiaChi.Location = New System.Drawing.Point(45, 158)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(40, 13)
        Me.txtDiaChi.TabIndex = 22
        Me.txtDiaChi.Text = "Địa chỉ"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 519)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtMaSV)
        Me.Controls.Add(Me.DgvXuat)
        Me.Controls.Add(Me.CbLop)
        Me.Controls.Add(Me.dtpNgaysinh)
        Me.Controls.Add(Me.CbGioiTinh)
        Me.Controls.Add(Me.tbDiachi)
        Me.Controls.Add(Me.tbHoten)
        Me.Controls.Add(Me.txtLop)
        Me.Controls.Add(Me.txtgioitinh)
        Me.Controls.Add(Me.txtNgaysinh)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnTim)
        Me.Controls.Add(Me.tbMasv)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Name = "Form1"
        Me.Text = "QuanlySinhVien"
        CType(Me.DgvXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents tbMasv As TextBox
    Friend WithEvents btnTim As Button
    Friend WithEvents btnHuy As Button
    Friend WithEvents txtNgaysinh As Label
    Friend WithEvents txtgioitinh As Label
    Friend WithEvents txtLop As Label
    Friend WithEvents tbHoten As TextBox
    Friend WithEvents tbDiachi As TextBox
    Friend WithEvents CbGioiTinh As ComboBox
    Friend WithEvents dtpNgaysinh As DateTimePicker
    Friend WithEvents CbLop As ComboBox
    Friend WithEvents DgvXuat As DataGridView
    Friend WithEvents txtMaSV As Label
    Friend WithEvents txtHoTen As Label
    Friend WithEvents txtDiaChi As Label
End Class
