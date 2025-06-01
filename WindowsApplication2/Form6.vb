Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Email Address"
        Label2.Text = "Problem Faced"
        Label3.Text = "Describe the problem in details"
        Label4.Text = "Help Center"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()

        MessageBox.Show("Feedback Sent, We will look into it as soon as possible")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()


    End Sub
End Class