Public Class Form1
    Private Sub txtuts_TextChanged(sender As Object, e As EventArgs) Handles txtuts.TextChanged

        Const UTS As Single = 0.2
        Dim Rata_uts As Single

        Rata_uts = txtuts.Text

        TextBox1.Text = UTS * Rata_uts

    End Sub

    Private Sub txtuas_TextChanged(sender As Object, e As EventArgs) Handles txtuas.TextChanged
        Const UAS As Single = 0.2
        Dim Rata_uas As Single

        Rata_uas = txtuas.Text

        TextBox2.Text = UAS * Rata_uas
    End Sub

    Private Sub txttugas_TextChanged(sender As Object, e As EventArgs) Handles txttugas.TextChanged
        Const TUGAS As Single = 0.25
        Dim Rata_tugas As Single

        Rata_tugas = txttugas.Text

        TextBox3.Text = TUGAS * Rata_tugas
    End Sub

    Private Sub txtpersentasi_TextChanged(sender As Object, e As EventArgs) Handles txtpersentasi.TextChanged
        Const PERSENTASI As Single = 0.15
        Dim Rata_persentasi As Single

        Rata_persentasi = txtpersentasi.Text
        TextBox4.Text = PERSENTASI * Rata_persentasi

    End Sub

    Private Sub txtkeaktifan_TextChanged(sender As Object, e As EventArgs) Handles txtkeaktifan.TextChanged
        Const KEAKTIFAN As Single = 0.1
        Dim Rata_keaktifan As Single

        Rata_keaktifan = txtkeaktifan.Text
        TextBox5.Text = KEAKTIFAN * Rata_keaktifan
    End Sub

    Private Sub txtpresensi_TextChanged(sender As Object, e As EventArgs) Handles txtpresensi.TextChanged
        Const PERSENSI As Single = 0.1
        Dim Rata_persensi As Single

        Rata_persensi = txtpresensi.Text
        TextBox6.Text = PERSENSI * Rata_persensi
    End Sub
End Class
