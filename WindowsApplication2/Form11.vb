Public Class Form11

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Visible = False
        Label4.Text = "Forgot your email address or password?"
        Label1.Text = "Credit card number"
        Label2.Text = "First name"
        Label3.Text = "Last name"
        Label5.Text = "PIN code"
        Label6.Text = "Password"
        Label7.Text = "City"
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Credit card is valid")
        Form9.Button1.Visible = True
        Form9.Label8.Visible = True
        Form9.Label8.Text = Val(Form9.Label2.Text) + Val(Form9.Label4.Text) + Val(Form9.Label6.Text)
        Form9.Label9.Visible = True
        Form9.Label9.Text = "$"
        RadioButton1.Checked = True

        Me.Hide()
    End Sub
End Class