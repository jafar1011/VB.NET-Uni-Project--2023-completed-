Public Class Form5

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "ali" And TextBox2.Text = "1234" Then MessageBox.Show("Signed in succuessfully")

        If TextBox1.Text = "ali" And TextBox2.Text = "1234" Then Me.Hide()
        If TextBox1.Text = "ali" And TextBox2.Text = "1234" Then Form1.Button5.Text = "ali"
        If TextBox1.Text = "ali" And TextBox2.Text = "1234" Then Form2.Button5.Text = "ali"
        If TextBox1.Text = "ali" And TextBox2.Text = "1234" Then Form3.Button5.Text = "ali"
        If TextBox1.Text = "ali" And TextBox2.Text = "1234" Then Form9.Button5.Text = "ali"
        If TextBox1.Text = "ali" And TextBox2.Text = "1234" Then Form4.Button5.Text = "ali"
        If TextBox1.Text = "ali" And TextBox2.Text = "1234" Then Form12.Button5.Text = "ali"
        If TextBox1.Text = "ali" And TextBox2.Text = "1234" Then Form1.Button5.Visible = True
        If TextBox1.Text = "ali" And TextBox2.Text = "1234" Then Form1.Button5.Enabled = True
        If TextBox1.Text <> "ali" Or TextBox2.Text <> "1234" Then MessageBox.Show("Failed, Check your username and password")

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Username"
        Label2.Text = "Password"
        Label3.Text = "Account Information"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Hide()
    End Sub
End Class