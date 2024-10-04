Public Class KALKULATOR

    Public Class KALKULATOR
        Friend Hasil As Single = 0
        Dim Operasi As String = ""
        Dim OperasiHitung As Boolean = False
    End Class

    Private Property OperasiHitung As Boolean

    Private Property Operasi As String

    Private Property Hasil As Integer



    Private Sub KALKULATOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OperasiHitung = False
        Operasi = ""
        Hasil = 0
        txtlayar.Text = "0"
    End Sub

    Private Sub cmdbutton1_Click(sender As Object, e As EventArgs) Handles cmdbutton1.Click
        If OperasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "1"
            OperasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "1"
        End If
    End Sub

    Private Sub cmdbutton2_Click(sender As Object, e As EventArgs) Handles cmdbutton2.Click
        If OperasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "2"
            OperasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "2"
        End If
    End Sub

    Private Sub cmdbutton3_Click(sender As Object, e As EventArgs) Handles cmdbutton3.Click
        If OperasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "3"
            OperasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "3"
        End If
    End Sub


    Private Sub cmdbutton4_Click(sender As Object, e As EventArgs) Handles cmdbutton4.Click
        If OperasiHitung() = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "4"
            OperasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "4"
        End If
    End Sub

    Private Sub cmdbutton5_Click(sender As Object, e As EventArgs) Handles cmdbutton5.Click
        If OperasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "5"
            OperasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "5"
        End If
    End Sub

    Private Sub cmdbutton6_Click(sender As Object, e As EventArgs) Handles cmdbutton6.Click
        If OperasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "6"
            OperasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "6"
        End If
    End Sub

    Private Sub cmdbutton7_Click(sender As Object, e As EventArgs) Handles cmdbutton7.Click
        If OperasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "7"
            OperasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "7"
        End If
    End Sub

    Private Sub cmdbutton8_Click(sender As Object, e As EventArgs) Handles cmdbutton8.Click
        If OperasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "8"
            OperasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "8"
        End If
    End Sub

    Private Sub cmdbutton9_Click(sender As Object, e As EventArgs) Handles cmdbutton9.Click
        If OperasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "9"
            OperasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "9"
        End If
    End Sub

    Private Sub cmdbutton0_Click(sender As Object, e As EventArgs) Handles cmdbutton0.Click
        If OperasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "0"
            OperasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "0"
        End If
    End Sub

    Private Sub cmdtambah_Click(sender As Object, e As EventArgs) Handles cmdtambah.Click
        Operasi = "tambah"
        Hasil = Val(txtlayar.Text)
        OperasiHitung = True
    End Sub

    Private Sub cmdkurang_Click(sender As Object, e As EventArgs) Handles cmdkurang.Click
        Operasi = "kurang"
        Hasil = Val(txtlayar.Text)
        OperasiHitung = True
    End Sub

    Private Sub cmdkali_Click(sender As Object, e As EventArgs) Handles cmdkali.Click
        Operasi = "kali"
        Hasil = Val(txtlayar.Text)
        OperasiHitung = True
    End Sub

    Private Sub cmdbagi_Click(sender As Object, e As EventArgs) Handles cmdbagi.Click
        Operasi = "bagi"
        Hasil = Val(txtlayar.Text)
        OperasiHitung = True
    End Sub

    Private Sub panah_Click(sender As Object, e As EventArgs) Handles panah.Click
        Operasi = "pangkat"
        Hasil = Val(txtlayar.Text)
        OperasiHitung = True
    End Sub

    Private Sub cmdsamadengan_Click(sender As Object, e As EventArgs) Handles cmdsamadengan.Click
        Select Case Operasi
            Case "tambah"
                Hasil = Hasil + Val(txtlayar.Text)
            Case "kurang"
                Hasil = Hasil - Val(txtlayar.Text)
            Case "kali"
                Hasil = Hasil * Val(txtlayar.Text)
            Case "bagi"
                Hasil = Hasil / Val(txtlayar.Text)
            Case "pangkat"
                Hasil = Hasil ^ Val(txtlayar.Text)
        End Select
        txtlayar.Text = Hasil
        OperasiHitung = True
    End Sub

    Private Sub cmdhapus_Click(sender As Object, e As EventArgs) Handles cmdhapus.Click
        txtlayar.Text = "0"
        OperasiHitung = True
    End Sub
End Class
