Public Class Form3
    Dim pl2 As Integer = 5

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton2.Checked = True
        PictureBox2.Image = My.Resources.pavilion
        Label1.Text = "HP Pavilion X360"
        Label3.Text = "850$"
        RichTextBox1.Text = "Windows 11 Home" + Environment.NewLine + " Intel® Core™ i5-1235U" + Environment.NewLine + "Intel® Iris® Xe Graphics" + Environment.NewLine + "8 GB DDR4-32 SDRAM" + Environment.NewLine + "256 GB PCIe® NVMe™ M.2 SSD"
        PictureBox3.Image = My.Resources.Omen
        Label2.Text = "Omen 16"
        Label4.Text = "999$"
        RichTextBox2.Text = "Windows 11 Home" + Environment.NewLine + "Intel® Core™ i7-13700HX" + Environment.NewLine + "NVIDIA® GeForce RTX™ 4060" + Environment.NewLine + "16 GB DDR5" + Environment.NewLine + "512 GB PCIe® NVMe™ TLC M.2 SSD"
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click


        If RadioButton2.Checked = True Then
            PictureBox2.Image = My.Resources.victus
            Label1.Text = "Victus 15"
            Label3.Text = "750$"
            RichTextBox1.Text = "Windows 11 Home" + Environment.NewLine + "AMD Ryzen™ 5 7535HS" + Environment.NewLine + "NVIDIA® GeForce RTX™ 2050" + Environment.NewLine + "8 GB DDR4-4800" + Environment.NewLine + "512 GB PCIe® NVMe™ TLC M.2 SSD"
            PictureBox3.Image = My.Resources.dragonfly
            Label2.Text = "HP Dragonfly"
            Label4.Text = "900$"
            RichTextBox2.Text = "Windows 11 Pro" + Environment.NewLine + "Intel® Core™ i7-1365U" + Environment.NewLine + "Intel® Iris® Xᵉ Graphics" + Environment.NewLine + "16 GB DDR4" + Environment.NewLine + "512 GB SSD"
            RadioButton2.Checked = False
            RadioButton3.Checked = True
            Timer1.Start()

        ElseIf RadioButton3.Checked = True Then
            PictureBox2.Image = My.Resources.envy
            Label1.Text = "HP Envy 16"
            Label3.Text = "1200$"
            RichTextBox1.Text = "Windows 11 Home" + Environment.NewLine + "Intel® Core™ i7-13700H" + Environment.NewLine + "Intel® Arc™ A370M Graphics" + Environment.NewLine + "16 GB DDR5-5200 MHz RAM" + Environment.NewLine + "512 GB PCIe® NVMe™ TLC M.2 SSD"
            PictureBox3.Image = My.Resources.spectre
            Label2.Text = "HP Spectre x360"
            Label4.Text = "1250$"
            RichTextBox2.Text = "Windows 11 Home" + Environment.NewLine + "13th Generation Intel® Core™ i7" + Environment.NewLine + "Intel® Iris® Xᵉ" + Environment.NewLine + "16 GB DDR5 RAM" + Environment.NewLine + "512 GB SSD"
            RadioButton3.Checked = False
            RadioButton1.Checked = True
            Timer1.Start()
           
        ElseIf RadioButton1.Checked = True Then
            PictureBox2.Image = My.Resources.pavilion
            Label1.Text = "HP Pavilion X360"
            Label3.Text = "850$"
            RichTextBox1.Text = "Windows 11 Home" + Environment.NewLine + " Intel® Core™ i5-1235U" + Environment.NewLine + "Intel® Iris® Xe Graphics" + Environment.NewLine + "8 GB DDR4-32 SDRAM" + Environment.NewLine + "256 GB PCIe® NVMe™ M.2 SSD"
            PictureBox3.Image = My.Resources.Omen
            Label2.Text = "Omen 16"
            Label4.Text = "999$"
            RichTextBox2.Text = "Windows 11 Home" + Environment.NewLine + "Intel® Core™ i7-13700HX" + Environment.NewLine + "NVIDIA® GeForce RTX™ 4060" + Environment.NewLine + "16 GB DDR5" + Environment.NewLine + "512 GB PCIe® NVMe™ TLC M.2 SSD"
            RadioButton1.Checked = False
            RadioButton2.Checked = True
            Timer1.Start()
          
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

        If RadioButton2.Checked = True Then
         PictureBox2.Image = My.Resources.envy
            Label1.Text = "HP Envy 16"
            Label3.Text = "1200$"
            RichTextBox1.Text = "Windows 11 Home" + Environment.NewLine + "Intel® Core™ i7-13700H" + Environment.NewLine + "Intel® Arc™ A370M Graphics" + Environment.NewLine + "16 GB DDR5-5200 MHz RAM" + Environment.NewLine + "512 GB PCIe® NVMe™ TLC M.2 SSD"
            PictureBox3.Image = My.Resources.spectre
            Label2.Text = "HP Spectre x360"
            Label4.Text = "1250$"
            RichTextBox2.Text = "Windows 11 Home" + Environment.NewLine + "13th Generation Intel® Core™ i7" + Environment.NewLine + "Intel® Iris® Xᵉ" + Environment.NewLine + "16 GB DDR5 RAM" + Environment.NewLine + "512 GB SSD"
            RadioButton2.Checked = False
            RadioButton1.Checked = True
            Timer1.Start()

        ElseIf RadioButton3.Checked = True Then
             PictureBox2.Image = My.Resources.pavilion
            Label1.Text = "HP Pavilion X360"
            Label3.Text = "850$"
            RichTextBox1.Text = "Windows 11 Home" + Environment.NewLine + " Intel® Core™ i5-1235U" + Environment.NewLine + "Intel® Iris® Xe Graphics" + Environment.NewLine + "8 GB DDR4-32 SDRAM" + Environment.NewLine + "256 GB PCIe® NVMe™ M.2 SSD"
            PictureBox3.Image = My.Resources.Omen
            Label2.Text = "Omen 16"
            Label4.Text = "999$"
            RichTextBox2.Text = "Windows 11 Home" + Environment.NewLine + "Intel® Core™ i7-13700HX" + Environment.NewLine + "NVIDIA® GeForce RTX™ 4060" + Environment.NewLine + "16 GB DDR5" + Environment.NewLine + "512 GB PCIe® NVMe™ TLC M.2 SSD"
            RadioButton3.Checked = False
            RadioButton2.Checked = True
            Timer1.Start()

        ElseIf RadioButton1.Checked = True Then
         PictureBox2.Image = My.Resources.victus
            Label1.Text = "Victus 15"
            Label3.Text = "750$"
            RichTextBox1.Text = "Windows 11 Home" + Environment.NewLine + "AMD Ryzen™ 5 7535HS" + Environment.NewLine + "NVIDIA® GeForce RTX™ 2050" + Environment.NewLine + "8 GB DDR4-4800" + Environment.NewLine + "512 GB PCIe® NVMe™ TLC M.2 SSD"
            PictureBox3.Image = My.Resources.dragonfly
            Label2.Text = "HP Dragonfly"
            Label4.Text = "900$"
            RichTextBox2.Text = "Windows 11 Pro" + Environment.NewLine + "Intel® Core™ i7-1365U" + Environment.NewLine + "Intel® Iris® Xᵉ Graphics" + Environment.NewLine + "16 GB DDR4" + Environment.NewLine + "512 GB SSD"
            RadioButton1.Checked = False
            RadioButton3.Checked = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If pl2 > 237 Then
            Timer1.Stop()
            pl2 = 5
        Else
            PictureBox2.Height = pl2
            PictureBox3.Height = pl2
            pl2 += 20
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form7.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form5.Show()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form6.Show()

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label1.Text = "HP Pavilion X360" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "HP Pavilion X360"
            Form9.Label2.Text = "850$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Omen 16" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Omen 16"
            Form9.Label2.Text = "999$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")

        ElseIf Label1.Text = "Victus 15" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Victus 15"
            Form9.Label2.Text = "750$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "HP Dragonfly" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "HP Dragonfly"
            Form9.Label2.Text = "900$"
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            Form9.RadioButton1.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "HP Envy 16" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "HP Envy 16"
            Form9.Label2.Text = "1200$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "HP Spectre x360" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "HP Spectre x360"
            Form9.Label2.Text = "1250$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "HP Pavilion X360" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "HP Pavilion X360"
            Form9.Label4.Text = "850$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Omen 16" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Omen 16"
            Form9.Label4.Text = "999$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")

        ElseIf Label1.Text = "Victus 15" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Victus 15"
            Form9.Label4.Text = "750$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "HP Dragonfly" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "HP Dragonfly"
            Form9.Label4.Text = "900$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "HP Envy 16" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "HP Envy 16"
            Form9.Label4.Text = "1200$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "HP Spectre x360" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "HP Spectre x360"
            Form9.Label4.Text = "1250$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "HP Pavilion X360" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "HP Pavilion X360"
            Form9.Label6.Text = "850$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "Omen 16" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Omen 16"
            Form9.Label6.Text = "999$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")

        ElseIf Label1.Text = "Victus 15" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Victus 15"
            Form9.Label6.Text = "750$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "HP Dragonfly" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "HP Dragonfly"
            Form9.Label6.Text = "900$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "HP Envy 16" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "HP Envy 16"
            Form9.Label6.Text = "1200$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label1.Text = "HP Spectre x360" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "HP Spectre x360"
            Form9.Label6.Text = "1250$$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Form9.RadioButton3.Checked = True And Form9.RadioButton2.Checked = False Then
            MessageBox.Show("Cart is full")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label2.Text = "HP Pavilion X360" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "HP Pavilion X360"
            Form9.Label2.Text = "850$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "Omen 16" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Omen 16"
            Form9.Label2.Text = "999$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")

        ElseIf Label2.Text = "Victus 15" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "Victus 15"
            Form9.Label2.Text = "750$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "HP Dragonfly" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "HP Dragonfly"
            Form9.Label2.Text = "900$"
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            Form9.RadioButton1.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "HP Envy 16" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "HP Envy 16"
            Form9.Label2.Text = "1200$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "HP Spectre x360" And Form9.RadioButton1.Checked = False And Form9.RadioButton2.Checked = False And Form9.RadioButton3.Checked = False Then
            Form9.Label2.Visible = True
            Form9.Label1.Text = "HP Spectre x360"
            Form9.Label2.Text = "1250$"
            Form9.RadioButton1.Checked = True
            Form9.Label7.Visible = True
            Form9.PictureBox1.Visible = True
            Form9.PictureBox2.Visible = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "HP Pavilion X360" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "HP Pavilion X360"
            Form9.Label4.Text = "850$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "Omen 16" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Omen 16"
            Form9.Label4.Text = "999$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")

        ElseIf Label2.Text = "Victus 15" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "Victus 15"
            Form9.Label4.Text = "750$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "HP Dragonfly" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "HP Dragonfly"
            Form9.Label4.Text = "900$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "HP Envy 16" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "HP Envy 16"
            Form9.Label4.Text = "1200$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "HP Spectre x360" And Form9.RadioButton1.Checked = True And Form9.RadioButton2.Checked = False Then
            Form9.Label3.Visible = True
            Form9.Label4.Visible = True
            Form9.Label3.Text = "HP Spectre x360"
            Form9.Label4.Text = "1250$"
            Form9.RadioButton1.Checked = False
            Form9.RadioButton2.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "HP Pavilion X360" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "HP Pavilion X360"
            Form9.Label6.Text = "850$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "Omen 16" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Omen 16"
            Form9.Label6.Text = "999$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")

        ElseIf Label2.Text = "Victus 15" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "Victus 15"
            Form9.Label6.Text = "750$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "HP Dragonfly" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "HP Dragonfly"
            Form9.Label6.Text = "900$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "HP Envy 16" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "HP Envy 16"
            Form9.Label6.Text = "1200$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Label2.Text = "HP Spectre x360" And Form9.RadioButton2.Checked = True And Form9.RadioButton3.Checked = False Then
            Form9.Label5.Visible = True
            Form9.Label6.Visible = True
            Form9.Label5.Text = "HP Spectre x360"
            Form9.Label6.Text = "1250$$"
            Form9.RadioButton2.Checked = False
            Form9.RadioButton3.Checked = True
            MessageBox.Show("Item added to the cart")
        ElseIf Form9.RadioButton3.Checked = True And Form9.RadioButton2.Checked = False Then
            MessageBox.Show("Cart is full")
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form12.Show()
        Me.Hide()
    End Sub
End Class