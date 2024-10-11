Public Class Form1

    Private Property Harga As String


    Private Sub txtchoco_TextChanged(sender As Object, e As EventArgs) Handles txtchoco.TextChanged
        txtjumlah.Text = Val(txtnasi.Text) + Val(txtayam.Text) + Val(txtkentang.Text) + Val(txtchoco.Text)
    End Sub

    Private Sub cmdhasil_Click(sender As Object, e As EventArgs) Handles cmdhasil.Click

        'mendeklarasikan variabel constanta PPN 10%'
        Const PPN As Single = 0.1
        Dim Harga As Single


        'untuk menghitung harga PPN 10%'
        Harga = txtjumlah.Text
        txtppn.Text = Harga * PPN

        'untuk menghitung jumlah yang akan dibayarkan dari hasil jumah + potongan PPN'
        txttotal.Text = Harga + Val(txtppn.Text)
    End Sub

    Private Sub txtkentang_TextChanged(sender As Object, e As EventArgs) Handles txtkentang.TextChanged
        txtjumlah.Text = Val(txtnasi.Text) + Val(txtayam.Text) + Val(txtkentang.Text) + Val(txtchoco.Text)
    End Sub

    Private Sub txtnasi_TextChanged(sender As Object, e As EventArgs) Handles txtnasi.TextChanged
        txtjumlah.Text = Val(txtnasi.Text) + Val(txtayam.Text) + Val(txtkentang.Text) + Val(txtchoco.Text) + Val(txtes.Text) + Val(txtbaso.Text)
    End Sub


    Private Sub txtayam_TextChanged(sender As Object, e As EventArgs) Handles txtayam.TextChanged
        txtjumlah.Text = Val(txtnasi.Text) + Val(txtayam.Text) + Val(txtkentang.Text) + Val(txtchoco.Text) + Val(txtes.Text) + Val(txtbaso.Text)
    End Sub

    Private Sub txtes_TextChanged(sender As Object, e As EventArgs) Handles txtes.TextChanged
        txtjumlah.Text = Val(txtnasi.Text) + Val(txtayam.Text) + Val(txtkentang.Text) + Val(txtchoco.Text) + Val(txtes.Text) + Val(txtbaso.Text)
    End Sub


    Private Sub txtbaso_TextChanged(sender As Object, e As EventArgs) Handles txtbaso.TextChanged
        txtjumlah.Text = Val(txtnasi.Text) + Val(txtayam.Text) + Val(txtkentang.Text) + Val(txtchoco.Text) + Val(txtes.Text) + Val(txtbaso.Text)
    End Sub
End Class
