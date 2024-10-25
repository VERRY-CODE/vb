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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdproceduredp = New System.Windows.Forms.Button()
        Me.cmdfunctiondp = New System.Windows.Forms.Button()
        Me.cmdproceduretp = New System.Windows.Forms.Button()
        Me.cmdfunctiontp = New System.Windows.Forms.Button()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnilai1 = New System.Windows.Forms.TextBox()
        Me.txtnilai2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdhitungF = New System.Windows.Forms.Button()
        Me.cmdhitungP = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Procedure dan Function"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Dengan Parameter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(411, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tanpa Parameter"
        '
        'cmdproceduredp
        '
        Me.cmdproceduredp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cmdproceduredp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdproceduredp.Location = New System.Drawing.Point(72, 101)
        Me.cmdproceduredp.Name = "cmdproceduredp"
        Me.cmdproceduredp.Size = New System.Drawing.Size(132, 70)
        Me.cmdproceduredp.TabIndex = 15
        Me.cmdproceduredp.Text = "Procedure"
        Me.cmdproceduredp.UseVisualStyleBackColor = True
        '
        'cmdfunctiondp
        '
        Me.cmdfunctiondp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdfunctiondp.Location = New System.Drawing.Point(72, 213)
        Me.cmdfunctiondp.Name = "cmdfunctiondp"
        Me.cmdfunctiondp.Size = New System.Drawing.Size(132, 70)
        Me.cmdfunctiondp.TabIndex = 16
        Me.cmdfunctiondp.Text = "Function"
        Me.cmdfunctiondp.UseVisualStyleBackColor = True
        '
        'cmdproceduretp
        '
        Me.cmdproceduretp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdproceduretp.Location = New System.Drawing.Point(443, 101)
        Me.cmdproceduretp.Name = "cmdproceduretp"
        Me.cmdproceduretp.Size = New System.Drawing.Size(132, 70)
        Me.cmdproceduretp.TabIndex = 17
        Me.cmdproceduretp.Text = "Procedure"
        Me.cmdproceduretp.UseVisualStyleBackColor = True
        '
        'cmdfunctiontp
        '
        Me.cmdfunctiontp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdfunctiontp.Location = New System.Drawing.Point(443, 213)
        Me.cmdfunctiontp.Name = "cmdfunctiontp"
        Me.cmdfunctiontp.Size = New System.Drawing.Size(132, 70)
        Me.cmdfunctiontp.TabIndex = 18
        Me.cmdfunctiontp.Text = "Function"
        Me.cmdfunctiontp.UseVisualStyleBackColor = True
        '
        'txthasil
        '
        Me.txthasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthasil.Location = New System.Drawing.Point(97, 338)
        Me.txthasil.Multiline = True
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(503, 31)
        Me.txthasil.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Perhitungan"
        '
        'txtnilai1
        '
        Me.txtnilai1.Location = New System.Drawing.Point(199, 440)
        Me.txtnilai1.Multiline = True
        Me.txtnilai1.Name = "txtnilai1"
        Me.txtnilai1.Size = New System.Drawing.Size(224, 47)
        Me.txtnilai1.TabIndex = 21
        '
        'txtnilai2
        '
        Me.txtnilai2.Location = New System.Drawing.Point(199, 523)
        Me.txtnilai2.Multiline = True
        Me.txtnilai2.Name = "txtnilai2"
        Me.txtnilai2.Size = New System.Drawing.Size(224, 47)
        Me.txtnilai2.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 451)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Nilai 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(101, 532)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Nilai 2"
        '
        'cmdhitungF
        '
        Me.cmdhitungF.Location = New System.Drawing.Point(329, 613)
        Me.cmdhitungF.Name = "cmdhitungF"
        Me.cmdhitungF.Size = New System.Drawing.Size(94, 60)
        Me.cmdhitungF.TabIndex = 26
        Me.cmdhitungF.Text = "Hitung F(-)"
        Me.cmdhitungF.UseVisualStyleBackColor = True
        '
        'cmdhitungP
        '
        Me.cmdhitungP.Location = New System.Drawing.Point(199, 613)
        Me.cmdhitungP.Name = "cmdhitungP"
        Me.cmdhitungP.Size = New System.Drawing.Size(111, 60)
        Me.cmdhitungP.TabIndex = 25
        Me.cmdhitungP.Text = "Hitung P(+)"
        Me.cmdhitungP.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.cmdhitungP)
        Me.Panel1.Controls.Add(Me.cmdhitungF)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtnilai2)
        Me.Panel1.Controls.Add(Me.txtnilai1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txthasil)
        Me.Panel1.Controls.Add(Me.cmdfunctiontp)
        Me.Panel1.Controls.Add(Me.cmdproceduretp)
        Me.Panel1.Controls.Add(Me.cmdfunctiondp)
        Me.Panel1.Controls.Add(Me.cmdproceduredp)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(643, 765)
        Me.Panel1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(667, 850)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdproceduredp As Button
    Friend WithEvents cmdfunctiondp As Button
    Friend WithEvents cmdproceduretp As Button
    Friend WithEvents cmdfunctiontp As Button
    Friend WithEvents txthasil As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnilai1 As TextBox
    Friend WithEvents txtnilai2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdhitungF As Button
    Friend WithEvents cmdhitungP As Button
    Friend WithEvents Panel1 As Panel
End Class
