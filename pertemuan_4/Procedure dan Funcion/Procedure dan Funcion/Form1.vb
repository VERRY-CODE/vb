Public Class Form1


    Private Sub tampilpesanparameter(ByVal pesan As String)
        txthasil.Text = pesan
    End Sub

    Private Function tampilpesanparameterfuncion(ByVal pesan As String)
        txthasil.Text = pesan
        Return pesan
    End Function

    Private Sub cmdproceduredp_Click(sender As Object, e As EventArgs) Handles cmdproceduredp.Click
        tampilpesanparameter("prosedure di panggil dengan parameter")
    End Sub

    Private Sub cmdfunctiondp_Click(sender As Object, e As EventArgs) Handles cmdfunctiondp.Click
        txthasil.Text = tampilpesanparameterfuncion("fungsi dipanggil dengan parameter")
    End Sub

    Private Sub proseduretampilkanpesan()
        txthasil.Text = "Prosedure di panggil Tanpa Parameter"
    End Sub

    Private Sub cmdproceduretp_Click(sender As Object, e As EventArgs) Handles cmdproceduretp.Click
        proseduretampilkanpesan()
    End Sub

    Private Function tampilpesanfungsi() As String
        Return "fungsi dipanggil tanpa parameter"
    End Function

    Private Sub cmdfunctiontp_Click(sender As Object, e As EventArgs) Handles cmdfunctiontp.Click
        txthasil.Text = tampilpesanfungsi()
    End Sub


    Private Function hitungf(ByVal nilai As Integer, ByVal nilai2 As Integer) As Integer
        Dim hasil As Integer
        hasil = nilai - nilai2
        Return hasil
    End Function

    Private Function hitungp(ByVal nilai As Integer, ByVal nilai1 As Integer) As Integer
        Dim hasil As Integer
        hasil = nilai + nilai1
        Return hasil
    End Function


    Private Sub cmdhitungP_Click(sender As Object, e As EventArgs) Handles cmdhitungP.Click
        txthasil.Text = hitungp(txtnilai1.Text, txtnilai2.Text)
    End Sub

    Private Sub cmdhitungF_Click(sender As Object, e As EventArgs) Handles cmdhitungF.Click
        txthasil.Text = hitungf(txtnilai1.Text, txtnilai2.Text)
    End Sub
End Class
