Public Class Form1
    Dim pl1 As Integer = 90
    Dim pl3 As Integer = 0
    Dim a As Integer = 0
    Dim t As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        AutoScroll = False
        Label1.Text = "All rights reserved 2023-2024"
        Form9.Label1.Text = "Shopping cart is empty"
        Form9.RadioButton1.Checked = False
        Form9.RadioButton2.Checked = False
        Form9.RadioButton3.Checked = False
        Form9.Label2.Visible = False
        Form9.Label3.Visible = False
        Form9.Label4.Visible = False
        Form9.Label5.Visible = False
        Form9.Label6.Visible = False
        Timer3.Start()
        PictureBox2.Width = 1
        RadioButton1.Checked = True
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton4.Visible = False
        RadioButton5.Visible = False
        Timer2.Start()
        PictureBox2.Image = My.Resources.notebook_xps_15_9530_silver_800x550
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form6.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form5.Show()

    End Sub

    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If pl1 > 360 Then
            Timer1.Stop()
        Else
            Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
            pl1 += 10
        End If
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Timer1.Stop()
        pl1 = 91
    End Sub

    Private Sub Button12_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.MouseHover
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form7.Show()

    End Sub

    Private Sub Button10_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.MouseHover
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
    End Sub

    Private Sub Button9_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.MouseHover
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
    End Sub

    Private Sub Button11_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.MouseHover
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
    End Sub

    Private Sub Button5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseHover
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If pl3 < 100 And RadioButton1.Checked = True Then
            pl3 += 10
        End If
        If pl3 = 100 And RadioButton1.Checked = True Then
            pl3 = 0
            RadioButton1.Checked = False
            RadioButton2.Checked = True
            PictureBox2.Image = My.Resources.pavilion
            PictureBox2.Width = 1
        End If
        If pl3 < 100 And RadioButton2.Checked = True Then
            pl3 += 10
        End If
        If pl3 = 100 And RadioButton2.Checked = True Then
            pl3 = 0
            RadioButton2.Checked = False
            RadioButton3.Checked = True
            PictureBox2.Image = My.Resources.Alienware
            PictureBox2.Width = 1
        End If
        If pl3 < 100 And RadioButton3.Checked = True Then
            pl3 += 10
        End If
        If pl3 = 100 And RadioButton3.Checked = True Then
            pl3 = 0
            RadioButton3.Checked = False
            RadioButton4.Checked = True
            PictureBox2.Image = My.Resources.envy
            PictureBox2.Width = 1
        End If
        If pl3 < 100 And RadioButton4.Checked = True Then
            pl3 += 10
        End If
        If pl3 = 100 And RadioButton4.Checked = True Then
            pl3 = 0
            RadioButton4.Checked = False
            RadioButton5.Checked = True
            PictureBox2.Image = My.Resources.Latitude1
            PictureBox2.Width = 1
        End If
        If pl3 < 100 And RadioButton5.Checked = True Then
            pl3 += 10
        End If
        If pl3 = 100 And RadioButton5.Checked = True Then
            pl3 = 0
            RadioButton5.Checked = False
            RadioButton1.Checked = True
            PictureBox2.Image = My.Resources.notebook_xps_15_9530_silver_800x550
            PictureBox2.Width = 1
        End If




    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If PictureBox2.Width < 680 Then
            PictureBox2.Width += 30

        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form12.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
    

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs)

    End Sub

    Private Sub Form1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles MyBase.Scroll

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class
