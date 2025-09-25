'Sử dụng thư viện của SQL Server
Imports System.Data.SqlClient

Module Module1
    ' Biến này sẽ giữ kết nối của chúng ta
    Public conn As SqlConnection

    ' Một hàm nhỏ để mở kết nối
    Public Sub MoKetNoi()
        Try
            ' !!! QUAN TRỌNG: Sửa lại TEN_MAY_CHU_CUA_BAN cho đúng
            Dim chuoiKetNoi As String = "Server=DESKTOP-K3BGNF1;Database=QLSV;Integrated Security=True;"

            conn = New SqlConnection(chuoiKetNoi)
            If conn.State = ConnectionState.Closed Then
                conn.Open() ' Mở kết nối
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi kết nối: " & ex.Message)
        End Try
    End Sub

    ' Hàm để đóng kết nối
    Public Sub DongKetNoi()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi đóng kết nối: " & ex.Message)
        End Try
    End Sub
End Module