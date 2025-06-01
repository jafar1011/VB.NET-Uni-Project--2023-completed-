Public Class Form10

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Visible = False
        RichTextBox1.Text = "Email Address"
        RichTextBox2.Text = "Password"
        Label1.Text = "Forgot your email address or password?"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RichTextBox1.Text = "ali@gmail.com" And RichTextBox2.Text = "1234" Then
            MessageBox.Show("Signed in successfully")
            Form9.Button1.Visible = True
            Form9.Label8.Visible = True
            Form9.Label8.Text = Val(Form9.Label2.Text) + Val(Form9.Label4.Text) + Val(Form9.Label6.Text)
            Form9.Label9.Visible = True
            Form9.Label9.Text = "$"
            RadioButton1.Checked = True

            Me.Hide()
        Else
            MessageBox.Show("Failed, Check your email address and password")
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class