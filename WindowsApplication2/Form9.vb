Public Class Form9

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form7.Show()

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form12.Show()
        Me.Hide()
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Label8.Visible = False
        Label9.Visible = False
        Button1.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        If Label1.Text = "Shopping cart is empty" Then
            Label7.Visible = False
            PictureBox1.Visible = False
            PictureBox2.Visible = False
        Else
            Label7.Visible = True
            PictureBox1.Visible = True
            PictureBox2.Visible = True
        End If
        Label7.Text = "Choose Payment Method: "
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form5.Show()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form6.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Button5.Text <> "ali" Then
            MessageBox.Show("Please sign in first")
            Form5.Show()

        ElseIf Form10.RadioButton1.Checked = False Then
            Form10.Show()
        ElseIf Form10.RadioButton1.Checked = True Then
            MessageBox.Show("Signed in successfully")
            Button1.Visible = True
            Label8.Visible = True
            Label8.Text = Val(Label2.Text) + Val(Label4.Text) + Val(Label6.Text)
            Label9.Visible = True
            Label9.Text = "$"
            RadioButton1.Checked = True
         
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If Button5.Text <> "ali" Then
            MessageBox.Show("Please sign in first")
            Form5.Show()

        ElseIf Form11.RadioButton1.Checked = False Then
            Form11.Show()
        ElseIf Form11.RadioButton1.Checked = True Then
            MessageBox.Show("Card information already saved")
            Button1.Visible = True
            Label8.Visible = True
            Label8.Text = Val(Label2.Text) + Val(Label4.Text) + Val(Label6.Text)
            Label9.Visible = True
            Label9.Text = "$"
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Thank you for buying from us")
        Label1.Text = "Shopping cart is empty"
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        Label7.Visible = False
        Button1.Visible = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class