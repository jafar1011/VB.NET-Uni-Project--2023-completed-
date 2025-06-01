Public Class Form4
    Dim c As Integer = 0
    Dim d As Integer = 0
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        WindowState = FormWindowState.Maximized
        Label2.Text = "850$"
        Label3.Text = "550$"
        RichTextBox5.Text = "Aspire 3 AMD"
        RichTextBox4.Text = "Windows 11 Home" + Environment.NewLine + "AMD Ryzen™ 5 7520U" + Environment.NewLine + "AMD Radeon™ Graphics" + Environment.NewLine + "15.6 Full HD (1920 x 1080)" + Environment.NewLine + "8 GB RAM" + Environment.NewLine + "512 GB SSD"
        RichTextBox1.Text = "Aspire 5 Intel"
        RichTextBox2.Text = "Windows 11 Home 64-bit" + Environment.NewLine + "Intel® Core™ i7-1165G7" + Environment.NewLine + "Intel® Iris® Xe" + Environment.NewLine + "15.6 Full HD (1920 x 1080)" + Environment.NewLine + "12 GB DDR4 RAM" + Environment.NewLine + "512 GB SSD"

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

      
        PictureBox3.Image = My.Resources.aspire_3_amd
        PictureBox6.Image = My.Resources.aspire_5_intel
        Label2.Text = "850$"
        Label3.Text = "550$"
        RichTextBox5.Text = "Aspire 3 AMD"
        RichTextBox4.Text = "Windows 11 Home" + Environment.NewLine + "AMD Ryzen™ 5 7520U" + Environment.NewLine + "AMD Radeon™ Graphics" + Environment.NewLine + "15.6 Full HD (1920 x 1080)" + Environment.NewLine + "8 GB RAM" + Environment.NewLine + "512 GB SSD"
        RichTextBox1.Text = "Aspire 5 Intel"
        RichTextBox2.Text = "Windows 11 Home 64-bit" + Environment.NewLine + "Intel® Core™ i7-1165G7" + Environment.NewLine + "Intel® Iris® Xe" + Environment.NewLine + "15.6 Full HD (1920 x 1080)" + Environment.NewLine + "12 GB DDR4 RAM" + Environment.NewLine + "512 GB SSD"

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

      
        Label3.Text = "900$"
        Label2.Text = "1000$"
        PictureBox3.Image = My.Resources.Nitro_V_15
        PictureBox6.Image = My.Resources.Nitro_5_Intel
        RichTextBox5.Text = "Nitro V 15"
        RichTextBox4.Text = "Windows 11 Home" + Environment.NewLine + "Intel® Core™ i5-13420H" + Environment.NewLine + "NVIDIA® GeForce RTX™ 4050" + Environment.NewLine + "15.6 Full HD (1920 x 1080)" + Environment.NewLine + "16 GB DDR5 SDRAM" + Environment.NewLine + "512 GB SSD"
        RichTextBox1.Text = "Nitro 5 Intel"
        RichTextBox2.Text = "Windows 11 Home" + Environment.NewLine + "Intel® Core™ i5-12450H" + Environment.NewLine + "NVIDIA® GeForce RTX™ 4050" + Environment.NewLine + "17.3 Full HD (1920 x 1080) 144 Hz" + Environment.NewLine + "16 GB DDR5 SDRAM" + Environment.NewLine + "512 GB SSD"

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
     
        Label3.Text = "1050$"
        Label2.Text = "1200$"
        PictureBox3.Image = My.Resources.Swift_go
        PictureBox6.Image = My.Resources.Swift_X_Intel
        RichTextBox5.Text = "Swift Go"
        RichTextBox4.Text = "Windows 11 Home" + Environment.NewLine + "Intel® Core™ i7-13700H" + Environment.NewLine + "Intel® Iris® Xe" + Environment.NewLine + "14 Full HD (2880 x 1800) 90 Hz" + Environment.NewLine + "16 GB LPDDR5 RAM" + Environment.NewLine + "512 GB SSD"
        RichTextBox1.Text = "Swift X Intel"
        RichTextBox2.Text = "Windows 11 Home" + Environment.NewLine + "Intel® Core™ i7-1260P" + Environment.NewLine + "NVIDIA® GeForce RTX™ 3050" + Environment.NewLine + "14 2.2K (2240 x 1400)" + Environment.NewLine + "16 GB LPDDR5 RAM" + Environment.NewLine + "512 GB SSD"


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form5.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form6.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form7.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RichTextBox5.Text = "Aspire 3 AMD" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Aspire 3 AMD"
            Form9.Label2.Text = "550$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Aspire 5 Intel" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Aspire 5 Intel"
            Form9.Label2.Text = "850$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")

        ElseIf RichTextBox5.Text = "Nitro V 15" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Nitro V 15"
            Form9.Label2.Text = "900$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Nitro 5 Intel" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Nitro 5 Intel"
            Form9.Label2.Text = "1000$"
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            Form9.RadioButton1.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift Go" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Swift Go"
            Form9.Label2.Text = "1050$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift X Intel" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Swift X Intel"
            Form9.Label2.Text = "1200$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Aspire 3 AMD" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Aspire 3 AMD"
            Form9.Label4.Text = "550$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Aspire 5 Intel" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Aspire 5 Intel"
            Form9.Label4.Text = "850$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")

        ElseIf RichTextBox5.Text = "Nitro V 15" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Nitro V 15"
            Form9.Label4.Text = "900$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Nitro 5 Intel" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Nitro 5 Intel"
            Form9.Label4.Text = "1000$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift Go" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Swift Go"
            Form9.Label4.Text = "1050$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift X Intel" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Swift X Intel"
            Form9.Label4.Text = "1200$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Aspire 3 AMD" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Aspire 3 AMD"
            Form9.Label6.Text = "550$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Aspire 5 Intel" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Aspire 5 Intel"
            Form9.Label6.Text = "850$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")

        ElseIf RichTextBox5.Text = "Nitro V 15" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Nitro V 15"
            Form9.Label6.Text = "900$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Nitro 5 Intel" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Nitro 5 Intel"
            Form9.Label6.Text = "1000$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift Go" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Swift Go"
            Form9.Label6.Text = "1050$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift X Intel" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Swift X Intel"
            Form9.Label6.Text = "1200$$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Form9.RadioButton3.Checked = True And Form9.RadioButton2.Checked = False Then
            MessageBox.Show("Cart is full")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RichTextBox5.Text = "Aspire 3 AMD" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Aspire 3 AMD"
            Form9.Label2.Text = "550$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Aspire 5 Intel" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Aspire 5 Intel"
            Form9.Label2.Text = "850$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")

        ElseIf RichTextBox5.Text = "Nitro V 15" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Nitro V 15"
            Form9.Label2.Text = "900$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Nitro 5 Intel" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Nitro 5 Intel"
            Form9.Label2.Text = "1000$"
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            Form9.RadioButton1.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift Go" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Swift Go"
            Form9.Label2.Text = "1050$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift X Intel" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Swift X Intel"
            Form9.Label2.Text = "1200$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Aspire 3 AMD" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Aspire 3 AMD"
            Form9.Label4.Text = "550$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Aspire 5 Intel" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Aspire 5 Intel"
            Form9.Label4.Text = "850$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")

        ElseIf RichTextBox5.Text = "Nitro V 15" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Nitro V 15"
            Form9.Label4.Text = "900$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Nitro 5 Intel" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Nitro 5 Intel"
            Form9.Label4.Text = "1000$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift Go" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Swift Go"
            Form9.Label4.Text = "1050$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift X Intel" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Swift X Intel"
            Form9.Label4.Text = "1200$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Aspire 3 AMD" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Aspire 3 AMD"
            Form9.Label6.Text = "550$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Aspire 5 Intel" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Aspire 5 Intel"
            Form9.Label6.Text = "850$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")

        ElseIf RichTextBox5.Text = "Nitro V 15" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Nitro V 15"
            Form9.Label6.Text = "900$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Nitro 5 Intel" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Nitro 5 Intel"
            Form9.Label6.Text = "1000$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift Go" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Swift Go"
            Form9.Label6.Text = "1050$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf RichTextBox5.Text = "Swift X Intel" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Swift X Intel"
            Form9.Label6.Text = "1200$$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Form9.RadioButton3.Checked = True And Form9.RadioButton2.Checked = False Then
            MessageBox.Show("Cart is full")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If c < 100 Then
            PictureBox3.Height = PictureBox3.Height + 2
            PictureBox3.Width = PictureBox3.Width + 2
            c += 5


        End If
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        If RadioButton1.Checked = False Then
            RadioButton1.Checked = True
            Timer1.Start()
            Timer2.Stop()
            c = 0
        End If
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        If RadioButton1.Checked = True Then
            RadioButton1.Checked = False
        Timer1.Stop()
        Timer2.Start()
            c = 0
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If c < 100 Then
            PictureBox3.Height = PictureBox3.Height - 2
            PictureBox3.Width = PictureBox3.Width - 2
            c += 5
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseHover
        If RadioButton2.Checked = False Then
            RadioButton2.Checked = True
            Timer3.Start()
            Timer4.Stop()
            d = 0
        End If
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        If RadioButton2.Checked = True Then
            RadioButton2.Checked = False
            Timer3.Stop()
            Timer4.Start()
            d = 0
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If d < 100 Then
            PictureBox6.Height = PictureBox6.Height + 2
            PictureBox6.Width = PictureBox6.Width + 2
            d += 5
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If d < 100 Then
            PictureBox6.Height = PictureBox6.Height - 2
            PictureBox6.Width = PictureBox6.Width - 2
            d += 5
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form12.Show()
        Me.Hide()

    End Sub
End Class