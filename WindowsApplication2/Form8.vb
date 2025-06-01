Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        If Label1.Text = "XPS 15 Laptop" Then
            PictureBox2.Image = My.Resources.XPS_SHOP
        ElseIf Label1.Text = "Inspiron 15 Laptop" Then
            PictureBox2.Image = My.Resources.Inspiron_SHOP
        ElseIf Label1.Text = "Vostro 15 Laptop" Then
            PictureBox2.Image = My.Resources.Vostro_SHOP
        ElseIf Label1.Text = "G16 Gaming Laptop" Then
            PictureBox2.Image = My.Resources.G_series_SHOP
        ElseIf Label1.Text = "Alienware x14 R2 Gaming Laptop" Then
            PictureBox2.Image = My.Resources.Alienware_SHOP
        ElseIf Label1.Text = "Latitude 3540 Laptop" Then
            PictureBox2.Image = My.Resources.Latitude_shop
        End If
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        If Label1.Text = "XPS 15 Laptop" Then
            PictureBox2.Image = My.Resources.notebook_xps_15_9530_silver_800x550
        ElseIf Label1.Text = "Inspiron 15 Laptop" Then
            PictureBox2.Image = My.Resources.Inspiron
        ElseIf Label1.Text = "Vostro 15 Laptop" Then
            PictureBox2.Image = My.Resources.dv7620nt_cnb_05000ff090_nonfpr_bk
        ElseIf Label1.Text = "G16 Gaming Laptop" Then
            PictureBox2.Image = My.Resources.notebook_g16_7630_black_800x550
        ElseIf Label1.Text = "Alienware x14 R2 Gaming Laptop" Then
            PictureBox2.Image = My.Resources.Alienware
        ElseIf Label1.Text = "Latitude 3540 Laptop" Then
            PictureBox2.Image = My.Resources.Latitude

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label1.Text = "XPS 15 Laptop" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "XPS 15 Laptop"
            Form9.Label2.Text = "1500$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "G16 Gaming Laptop" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "G16 Gaming Laptop"
            Form9.Label2.Text = "950$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")

        ElseIf Label1.Text = "Alienware x14 R2 Gaming Laptop" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Alienware x14 R2 Gaming Laptop"
            Form9.Label2.Text = "1500$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Vostro 15 Laptop" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Vostro 15 Laptop"
            Form9.Label2.Text = "850$"
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            Form9.RadioButton1.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Latitude 3540 Laptop" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Latitude 3540 Laptop"
            Form9.Label2.Text = "1090$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Inspiron 15 Laptop" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Inspiron 15 Laptop"
            Form9.Label2.Text = "350$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "XPS 15 Laptop" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "XPS 15 Laptop"
            Form9.Label4.Text = "1500$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "G16 Gaming Laptop" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "G16 Gaming Laptop"
            Form9.Label4.Text = "950$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")

        ElseIf Label1.Text = "Alienware x14 R2 Gaming Laptop" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Alienware x14 R2 Gaming Laptop"
            Form9.Label4.Text = "1500$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Vostro 15 Laptop" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Vostro 15 Laptop"
            Form9.Label4.Text = "850$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Latitude 3540 Laptop" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Latitude 3540 Laptop"
            Form9.Label4.Text = "1090$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Inspiron 15 Laptop" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Inspiron 15 Laptop"
            Form9.Label4.Text = "350$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "XPS 15 Laptop" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "XPS 15 Laptop"
            Form9.Label6.Text = "1500$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "G16 Gaming Laptop" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "G16 Gaming Laptop"
            Form9.Label6.Text = "950$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")

        ElseIf Label1.Text = "Alienware x14 R2 Gaming Laptop" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Alienware x14 R2 Gaming Laptop"
            Form9.Label6.Text = "1500$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Vostro 15 Laptop" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Vostro 15 Laptop"
            Form9.Label6.Text = "850$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Latitude 3540 Laptop" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Latitude 3540 Laptop"
            Form9.Label6.Text = "1090$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Inspiron 15 Laptop" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Inspiron 15 Laptop"
            Form9.Label6.Text = "350$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Form9.RadioButton3.Checked = True And Form9.RadioButton2.Checked = False Then
            MessageBox.Show("Cart is full")
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class