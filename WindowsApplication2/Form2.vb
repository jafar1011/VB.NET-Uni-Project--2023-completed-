Public Class Form2

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "XPS" Then
            PictureBox2.Image = My.Resources.notebook_xps_15_9530_silver_800x550
            PictureBox2.Visible = True
            Button1.Visible = True
            RichTextBox2.Text = "-Starting at $599.00" + Environment.NewLine + "-Multitask between intensive programs" + Environment.NewLine + "-Produce video, photography and music" + Environment.NewLine + "-Create & edit digital content" + Environment.NewLine + "-Be productive anywhere"
            RichTextBox3.Text = "Creators and Creativity"
            Button1.Text = "Shop XPS"

        End If
        If ComboBox1.Text = "G series" Then
            PictureBox2.Image = My.Resources.notebook_g16_7630_black_800x550
            PictureBox2.Visible = True
            Button1.Visible = True
            Button1.Text = "Shop G series"
            RichTextBox3.Text = "Gaming Performance"
            RichTextBox2.Text = "-Starting at $599.99" + Environment.NewLine + "-Boost your gaming experience" + Environment.NewLine + "-Create videos & online content" + Environment.NewLine + "-Connect with gaming community"
        End If
        If ComboBox1.Text = "Vostro" Then
            PictureBox2.Image = My.Resources.dv7620nt_cnb_05000ff090_nonfpr_bk
            PictureBox2.Visible = True
            Button1.Visible = True
            Button1.Text = "Shop Vostro"
            RichTextBox3.Text = "Small Business Productivity"
            RichTextBox2.Text = "-Starting at $749.00" + Environment.NewLine + "-Protect data with essential security" + Environment.NewLine + "-Power business applications" + Environment.NewLine + "-Collaborate with video conferencing"

        End If
        If ComboBox1.Text = "Inspiron" Then
            PictureBox2.Image = My.Resources.Inspiron
            PictureBox2.Visible = True
            Button1.Visible = True
            Button1.Text = "Shop Inspiron"
            RichTextBox3.Text = "Versatile Performance"
            RichTextBox2.Text = "-Starting at $329.99" + Environment.NewLine + "-Perform personal & home office tasks" + Environment.NewLine + "-Stream, browse and multitask" + Environment.NewLine + "-Video chat with enhanced audio & visuals"
        End If
        If ComboBox1.Text = "Alienware" Then
            PictureBox2.Image = My.Resources.Alienware
            PictureBox2.Visible = True
            Button1.Visible = True
            Button1.Text = "Shop Alienware"
            RichTextBox3.Text = "Immersive Gaming Experiences"
            RichTextBox2.Text = "-Starting at $1,399.99" + Environment.NewLine + "-Power any game with exceptional cooling" + Environment.NewLine + "-Experience smooth gaming with fast refresh rates" + Environment.NewLine + "-Express yourself with AlienFX lighting"
        End If
        If ComboBox1.Text = "Latitude" Then
            PictureBox2.Image = My.Resources.Latitude1
            PictureBox2.Visible = True
            Button1.Visible = True
            Button1.Text = "Shop Latitude"
            RichTextBox3.Text = "Business Performance and Collaboration"
            RichTextBox2.Text = "-Starting at $709.00" + Environment.NewLine + "-Collaborate with privacy & security" + Environment.NewLine + "-Enhance performance with Dell Optimizer" + Environment.NewLine + "-Work seamlessly with intelligent connectivity"
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "XPS" Then
            PictureBox3.Image = My.Resources.notebook_xps_15_9530_silver_800x550
            PictureBox3.Visible = True
            Button2.Visible = True
            Button2.Text = "Shop XPS"
            RichTextBox4.Text = "-Starting at $599.00" + Environment.NewLine + "-Multitask between intensive programs" + Environment.NewLine + "-Produce video, photography and music" + Environment.NewLine + "-Create & edit digital content" + Environment.NewLine + "-Be productive anywhere"
            RichTextBox5.Text = "Creators and Creativity"
        End If
        If ComboBox2.Text = "G series" Then
            PictureBox3.Image = My.Resources.notebook_g16_7630_black_800x550
            PictureBox3.Visible = True
            Button2.Visible = True
            Button2.Text = "Shop G series"
            RichTextBox5.Text = "Gaming Performance"
            RichTextBox4.Text = "-Starting at $599.99" + Environment.NewLine + "-Boost your gaming experience" + Environment.NewLine + "-Create videos & online content" + Environment.NewLine + "-Connect with gaming community"

        End If
        If ComboBox2.Text = "Vostro" Then
            PictureBox3.Image = My.Resources.dv7620nt_cnb_05000ff090_nonfpr_bk
            PictureBox3.Visible = True
            Button2.Visible = True
            Button2.Text = "Shop Vostro"
            RichTextBox5.Text = "Small Business Productivity"
            RichTextBox4.Text = "-Starting at $749.00" + Environment.NewLine + "-Protect data with essential security" + Environment.NewLine + "-Power business applications" + Environment.NewLine + "-Collaborate with video conferencing"
        End If
        If ComboBox2.Text = "Inspiron" Then
            PictureBox3.Image = My.Resources.Inspiron
            PictureBox3.Visible = True
            Button2.Visible = True
            Button2.Text = "Shop Inspiron"
            RichTextBox5.Text = "Versatile Performance"
            RichTextBox4.Text = "-Starting at $329.99" + Environment.NewLine + "-Perform personal & home office tasks" + Environment.NewLine + "-Stream, browse and multitask" + Environment.NewLine + "-Video chat with enhanced audio & visuals"

        End If
        If ComboBox2.Text = "Alienware" Then
            PictureBox3.Image = My.Resources.Alienware
            PictureBox3.Visible = True
            Button2.Visible = True
            Button2.Text = "Shop Alienware"
            RichTextBox5.Text = "Immersive Gaming Experiences"
            RichTextBox4.Text = "-Starting at $1,399.99" + Environment.NewLine + "-Power any game with exceptional cooling" + Environment.NewLine + "-Experience smooth gaming with fast refresh rates" + Environment.NewLine + "-Express yourself with AlienFX lighting"

        End If
        If ComboBox2.Text = "Latitude" Then
            PictureBox3.Image = My.Resources.Latitude1
            PictureBox3.Visible = True
            Button2.Visible = True
            Button2.Text = "Shop Latitude"
            RichTextBox5.Text = "Business Performance and Collaboration"
            RichTextBox4.Text = "-Starting at $709.00" + Environment.NewLine + "-Collaborate with privacy & security" + Environment.NewLine + "-Enhance performance with Dell Optimizer" + Environment.NewLine + "-Work seamlessly with intelligent connectivity"

        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "XPS" Then
            PictureBox4.Image = My.Resources.notebook_xps_15_9530_silver_800x550
            PictureBox4.Visible = True
            Button3.Visible = True
            Button3.Text = "Shop XPS"
            RichTextBox6.Text = "-Starting at $599.00" + Environment.NewLine + "-Multitask between intensive programs" + Environment.NewLine + "-Produce video, photography and music" + Environment.NewLine + "-Create & edit digital content" + Environment.NewLine + "-Be productive anywhere"
            RichTextBox7.Text = "Creators and Creativity"
        End If
        If ComboBox3.Text = "G series" Then
            PictureBox4.Image = My.Resources.notebook_g16_7630_black_800x550
            PictureBox4.Visible = True
            Button3.Visible = True
            Button3.Text = "Shop G series"
            RichTextBox7.Text = "Gaming Performance"
            RichTextBox6.Text = "-Starting at $599.99" + Environment.NewLine + "-Boost your gaming experience" + Environment.NewLine + "-Create videos & online content" + Environment.NewLine + "-Connect with gaming community"

        End If
        If ComboBox3.Text = "Vostro" Then
            PictureBox4.Image = My.Resources.dv7620nt_cnb_05000ff090_nonfpr_bk
            PictureBox4.Visible = True
            Button3.Visible = True
            Button3.Text = "Shop Vostro"
            RichTextBox7.Text = "Small Business Productivity"
            RichTextBox6.Text = "-Starting at $749.00" + Environment.NewLine + "-Protect data with essential security" + Environment.NewLine + "-Power business applications" + Environment.NewLine + "-Collaborate with video conferencing"


        End If
        If ComboBox3.Text = "Inspiron" Then
            PictureBox4.Image = My.Resources.Inspiron
            PictureBox4.Visible = True
            Button3.Visible = True
            Button3.Text = "Shop Inspiron"
            RichTextBox7.Text = "Versatile Performance"
            RichTextBox6.Text = "-Starting at $329.99" + Environment.NewLine + "-Perform personal & home office tasks" + Environment.NewLine + "-Stream, browse and multitask" + Environment.NewLine + "-Video chat with enhanced audio & visuals"

        End If
        If ComboBox3.Text = "Alienware" Then
            PictureBox4.Image = My.Resources.Alienware
            PictureBox4.Visible = True
            Button3.Visible = True
            Button3.Text = "Shop Alienware"
            RichTextBox7.Text = "Immersive Gaming Experiences"
            RichTextBox6.Text = "-Starting at $1,399.99" + Environment.NewLine + "-Power any game with exceptional cooling" + Environment.NewLine + "-Experience smooth gaming with fast refresh rates" + Environment.NewLine + "-Express yourself with AlienFX lighting"

        End If
        If ComboBox3.Text = "Latitude" Then
            PictureBox4.Image = My.Resources.Latitude1
            PictureBox4.Visible = True
            Button3.Visible = True
            Button3.Text = "Shop Latitude"
            RichTextBox7.Text = "Business Performance and Collaboration"
            RichTextBox6.Text = "-Starting at $709.00" + Environment.NewLine + "-Collaborate with privacy & security" + Environment.NewLine + "-Enhance performance with Dell Optimizer" + Environment.NewLine + "-Work seamlessly with intelligent connectivity"

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form5.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RadioButton2.Checked = True
        If RadioButton2.Checked = True Then
            If ComboBox2.Text = "XPS" Then
                Form8.Label1.Text = "XPS 15 Laptop"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i7-13700H()" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: Intel® Arc™ Graphics A370M" + Environment.NewLine + "Memory: 16 GB (DDR5)" + Environment.NewLine + "Storage: 512 GB (SSD)" + Environment.NewLine + "Display: 15.6-in. display Full HD+ (1920X1200)"
                Form8.PictureBox2.Image = My.Resources.notebook_xps_15_9530_silver_800x550
                Form8.Label2.Text = "1500$"
            ElseIf ComboBox2.Text = "Inspiron" Then
                Form8.PictureBox2.Image = My.Resources.Inspiron
                Form8.Label1.Text = "Inspiron 15 Laptop"
                Form8.Label2.Text = "350$"
                Form8.RichTextBox1.Text = "Processor: AMD Ryzen™ 5 7530U" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: AMD Radeon™ Graphics" + Environment.NewLine + "Memory: 8 GB (DDR4)" + Environment.NewLine + "Storage: 512 GB (SSD)" + Environment.NewLine + "Display: 15.6-in. touch display Full HD (1920X1080)"
            ElseIf ComboBox2.Text = "Vostro" Then
                Form8.PictureBox2.Image = My.Resources.dv7620nt_cnb_05000ff090_nonfpr_bk
                Form8.Label1.Text = "Vostro 15 Laptop"
                Form8.Label2.Text = "850$"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i5-1335U" + Environment.NewLine + "OS: Windows 11 Pro" + Environment.NewLine + "Graphics: Intel® Iris® Xe Graphics" + Environment.NewLine + "Memory: 16 GB (DDR4)" + Environment.NewLine + "Storage: 1 TB (SSD)" + Environment.NewLine + "Display: 15.6-in. display Full HD (1920X1080)"
            ElseIf ComboBox2.Text = "G series" Then
                Form8.PictureBox2.Image = My.Resources.notebook_g16_7630_black_800x550
                Form8.Label1.Text = "G16 Gaming Laptop"
                Form8.Label2.Text = "950$"
                Form8.RichTextBox1.Text = "Processor: 12th Gen Intel® Core™ i7-12700H" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: NVIDIA® GeForce RTX™ 3060" + Environment.NewLine + "Memory: 16 GB (DDR5)" + Environment.NewLine + "Storage: 1 TB (SSD)" + Environment.NewLine + "Display: 16.0-in. display Quad HD+ (2560X1600) 165Hz"
            ElseIf ComboBox2.Text = "Alienware" Then
                Form8.PictureBox2.Image = My.Resources.Alienware
                Form8.Label1.Text = "Alienware x14 R2 Gaming Laptop"
                Form8.Label2.Text = "1500$"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i7-13620H" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: NVIDIA® GeForce RTX™ 4060" + Environment.NewLine + "Memory: 16 GB (LPDDR5)" + Environment.NewLine + "Storage: 1 TB (SSD)" + Environment.NewLine + "Display: 14.0-in. display Quad HD+ (2560X1600)"
            ElseIf ComboBox2.Text = "Latitude" Then
                Form8.PictureBox2.Image = My.Resources.Latitude
                Form8.Label1.Text = "Latitude 3540 Laptop"
                Form8.Label2.Text = "1090$"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i7-1355U" + Environment.NewLine + "OS: Windows 11 Pro" + Environment.NewLine + "Graphics: Integrated Intel® Iris® Xe" + Environment.NewLine + "Memory: 16 GB (DDR4)" + Environment.NewLine + "Storage: 256 GB (SSD)" + Environment.NewLine + "Display: 15.6-in. display Full HD (1920X1080)"

            End If

        End If
        Form8.Show()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        ComboBox1.Text = "Choose..."
        ComboBox2.Text = "Choose..."
        ComboBox3.Text = "Choose..."
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form6.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RadioButton1.Checked = True
        If RadioButton1.Checked = True Then
            If ComboBox1.Text = "XPS" Then
                Form8.Label1.Text = "XPS 15 Laptop"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i7-13700H()" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: Intel® Arc™ Graphics A370M" + Environment.NewLine + "Memory: 16 GB (DDR5)" + Environment.NewLine + "Storage: 512 GB (SSD)" + Environment.NewLine + "Display: 15.6-in. display Full HD+ (1920X1200)"
                Form8.PictureBox2.Image = My.Resources.notebook_xps_15_9530_silver_800x550
                Form8.Label2.Text = "1500$"
            ElseIf ComboBox1.Text = "Inspiron" Then
                Form8.PictureBox2.Image = My.Resources.Inspiron
                Form8.Label1.Text = "Inspiron 15 Laptop"
                Form8.Label2.Text = "350$"
                Form8.RichTextBox1.Text = "Processor: AMD Ryzen™ 5 7530U" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: AMD Radeon™ Graphics" + Environment.NewLine + "Memory: 8 GB (DDR4)" + Environment.NewLine + "Storage: 512 GB (SSD)" + Environment.NewLine + "Display: 15.6-in. touch display Full HD (1920X1080)"
            ElseIf ComboBox1.Text = "Vostro" Then
                Form8.PictureBox2.Image = My.Resources.dv7620nt_cnb_05000ff090_nonfpr_bk
                Form8.Label1.Text = "Vostro 15 Laptop"
                Form8.Label2.Text = "850$"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i5-1335U" + Environment.NewLine + "OS: Windows 11 Pro" + Environment.NewLine + "Graphics: Intel® Iris® Xe Graphics" + Environment.NewLine + "Memory: 16 GB (DDR4)" + Environment.NewLine + "Storage: 1 TB (SSD)" + Environment.NewLine + "Display: 15.6-in. display Full HD (1920X1080)"
            ElseIf ComboBox1.Text = "G series" Then
                Form8.PictureBox2.Image = My.Resources.notebook_g16_7630_black_800x550
                Form8.Label1.Text = "G16 Gaming Laptop"
                Form8.Label2.Text = "950$"
                Form8.RichTextBox1.Text = "Processor: 12th Gen Intel® Core™ i7-12700H" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: NVIDIA® GeForce RTX™ 3060" + Environment.NewLine + "Memory: 16 GB (DDR5)" + Environment.NewLine + "Storage: 1 TB (SSD)" + Environment.NewLine + "Display: 16.0-in. display Quad HD+ (2560X1600) 165Hz"
            ElseIf ComboBox1.Text = "Alienware" Then
                Form8.PictureBox2.Image = My.Resources.Alienware
                Form8.Label1.Text = "Alienware x14 R2 Gaming Laptop"
                Form8.Label2.Text = "1500$"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i7-13620H" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: NVIDIA® GeForce RTX™ 4060" + Environment.NewLine + "Memory: 16 GB (LPDDR5)" + Environment.NewLine + "Storage: 1 TB (SSD)" + Environment.NewLine + "Display: 14.0-in. display Quad HD+ (2560X1600)"
            ElseIf ComboBox1.Text = "Latitude" Then
                Form8.PictureBox2.Image = My.Resources.Latitude
                Form8.Label1.Text = "Latitude 3540 Laptop"
                Form8.Label2.Text = "1090$"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i7-1355U" + Environment.NewLine + "OS: Windows 11 Pro" + Environment.NewLine + "Graphics: Integrated Intel® Iris® Xe" + Environment.NewLine + "Memory: 16 GB (DDR4)" + Environment.NewLine + "Storage: 256 GB (SSD)" + Environment.NewLine + "Display: 15.6-in. display Full HD (1920X1080)"

            End If

        End If
        Form8.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        RadioButton3.Checked = True
        If RadioButton3.Checked = True Then
            If ComboBox3.Text = "XPS" Then
                Form8.Label1.Text = "XPS 15 Laptop"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i7-13700H()" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: Intel® Arc™ Graphics A370M" + Environment.NewLine + "Memory: 16 GB (DDR5)" + Environment.NewLine + "Storage: 512 GB (SSD)" + Environment.NewLine + "Display: 15.6-in. display Full HD+ (1920X1200)"
                Form8.PictureBox2.Image = My.Resources.notebook_xps_15_9530_silver_800x550
                Form8.Label2.Text = "1500$"
            ElseIf ComboBox3.Text = "Inspiron" Then
                Form8.PictureBox2.Image = My.Resources.Inspiron
                Form8.Label1.Text = "Inspiron 15 Laptop"
                Form8.Label2.Text = "350$"
                Form8.RichTextBox1.Text = "Processor: AMD Ryzen™ 5 7530U" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: AMD Radeon™ Graphics" + Environment.NewLine + "Memory: 8 GB (DDR4)" + Environment.NewLine + "Storage: 512 GB (SSD)" + Environment.NewLine + "Display: 15.6-in. touch display Full HD (1920X1080)"
            ElseIf ComboBox3.Text = "Vostro" Then
                Form8.PictureBox2.Image = My.Resources.dv7620nt_cnb_05000ff090_nonfpr_bk
                Form8.Label1.Text = "Vostro 15 Laptop"
                Form8.Label2.Text = "850$"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i5-1335U" + Environment.NewLine + "OS: Windows 11 Pro" + Environment.NewLine + "Graphics: Intel® Iris® Xe Graphics" + Environment.NewLine + "Memory: 16 GB (DDR4)" + Environment.NewLine + "Storage: 1 TB (SSD)" + Environment.NewLine + "Display: 15.6-in. display Full HD (1920X1080)"
            ElseIf ComboBox3.Text = "G series" Then
                Form8.PictureBox2.Image = My.Resources.notebook_g16_7630_black_800x550
                Form8.Label1.Text = "G16 Gaming Laptop"
                Form8.Label2.Text = "950$"
                Form8.RichTextBox1.Text = "Processor: 12th Gen Intel® Core™ i7-12700H" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: NVIDIA® GeForce RTX™ 3060" + Environment.NewLine + "Memory: 16 GB (DDR5)" + Environment.NewLine + "Storage: 1 TB (SSD)" + Environment.NewLine + "Display: 16.0-in. display Quad HD+ (2560X1600) 165Hz"
            ElseIf ComboBox3.Text = "Alienware" Then
                Form8.PictureBox2.Image = My.Resources.Alienware
                Form8.Label1.Text = "Alienware x14 R2 Gaming Laptop"
                Form8.Label2.Text = "1500$"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i7-13620H" + Environment.NewLine + "OS: Windows 11 Home" + Environment.NewLine + "Graphics: NVIDIA® GeForce RTX™ 4060" + Environment.NewLine + "Memory: 16 GB (LPDDR5)" + Environment.NewLine + "Storage: 1 TB (SSD)" + Environment.NewLine + "Display: 14.0-in. display Quad HD+ (2560X1600)"
            ElseIf ComboBox3.Text = "Latitude" Then
                Form8.PictureBox2.Image = My.Resources.Latitude
                Form8.Label1.Text = "Latitude 3540 Laptop"
                Form8.Label2.Text = "1090$"
                Form8.RichTextBox1.Text = "Processor: 13th Gen Intel® Core™ i7-1355U" + Environment.NewLine + "OS: Windows 11 Pro" + Environment.NewLine + "Graphics: Integrated Intel® Iris® Xe" + Environment.NewLine + "Memory: 16 GB (DDR4)" + Environment.NewLine + "Storage: 256 GB (SSD)" + Environment.NewLine + "Display: 15.6-in. display Full HD (1920X1080)"

            End If

        End If
        Form8.Show()

    End Sub

    Private Sub RichTextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox7.TextChanged

    End Sub

    Private Sub RichTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        If ComboBox1.Text = "XPS" Then
            PictureBox2.Image = My.Resources.XPS_SHOP
        End If
        If ComboBox1.Text = "Inspiron" Then
            PictureBox2.Image = My.Resources.Inspiron_SHOP
        End If
        If ComboBox1.Text = "G series" Then
            PictureBox2.Image = My.Resources.G_series_SHOP
        End If
        If ComboBox1.Text = "Alienware" Then
            PictureBox2.Image = My.Resources.Alienware_SHOP
        End If
        If ComboBox1.Text = "Latitude" Then
            PictureBox2.Image = My.Resources.Latitude_shop
        End If
        If ComboBox1.Text = "Vostro" Then
            PictureBox2.Image = My.Resources.Vostro_SHOP
        End If
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        If ComboBox1.Text = "XPS" Then
            PictureBox2.Image = My.Resources.notebook_xps_15_9530_silver_800x550
        End If
        If ComboBox1.Text = "Inspiron" Then
            PictureBox2.Image = My.Resources.Inspiron
        End If
        If ComboBox1.Text = "G series" Then
            PictureBox2.Image = My.Resources.notebook_g16_7630_black_800x550
        End If
        If ComboBox1.Text = "Alienware" Then
            PictureBox2.Image = My.Resources.Alienware
        End If
        If ComboBox1.Text = "Latitude" Then
            PictureBox2.Image = My.Resources.Latitude1
        End If
        If ComboBox1.Text = "Vostro" Then
            PictureBox2.Image = My.Resources.dv7620nt_cnb_05000ff090_nonfpr_bk
        End If
    End Sub

    
    Private Sub PictureBox3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        If ComboBox2.Text = "XPS" Then
            PictureBox3.Image = My.Resources.XPS_SHOP
        End If
        If ComboBox2.Text = "Inspiron" Then
            PictureBox3.Image = My.Resources.Inspiron_SHOP
        End If
        If ComboBox2.Text = "G series" Then
            PictureBox3.Image = My.Resources.G_series_SHOP
        End If
        If ComboBox2.Text = "Alienware" Then
            PictureBox3.Image = My.Resources.Alienware_SHOP
        End If
        If ComboBox2.Text = "Latitude" Then
            PictureBox3.Image = My.Resources.Latitude_shop
        End If
        If ComboBox2.Text = "Vostro" Then
            PictureBox3.Image = My.Resources.Vostro_SHOP
        End If
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        If ComboBox2.Text = "XPS" Then
            PictureBox3.Image = My.Resources.notebook_xps_15_9530_silver_800x550
        End If
        If ComboBox2.Text = "Inspiron" Then
            PictureBox3.Image = My.Resources.Inspiron
        End If
        If ComboBox2.Text = "G series" Then
            PictureBox3.Image = My.Resources.notebook_g16_7630_black_800x550
        End If
        If ComboBox2.Text = "Alienware" Then
            PictureBox3.Image = My.Resources.Alienware
        End If
        If ComboBox2.Text = "Latitude" Then
            PictureBox3.Image = My.Resources.Latitude1
        End If
        If ComboBox2.Text = "Vostro" Then
            PictureBox3.Image = My.Resources.dv7620nt_cnb_05000ff090_nonfpr_bk
        End If
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        If ComboBox3.Text = "XPS" Then
            PictureBox4.Image = My.Resources.XPS_SHOP
        End If
        If ComboBox3.Text = "Inspiron" Then
            PictureBox4.Image = My.Resources.Inspiron_SHOP
        End If
        If ComboBox3.Text = "G series" Then
            PictureBox4.Image = My.Resources.G_series_SHOP
        End If
        If ComboBox3.Text = "Alienware" Then
            PictureBox4.Image = My.Resources.Alienware_SHOP
        End If
        If ComboBox3.Text = "Latitude" Then
            PictureBox4.Image = My.Resources.Latitude_shop
        End If
        If ComboBox3.Text = "Vostro" Then
            PictureBox4.Image = My.Resources.Vostro_SHOP
        End If
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        If ComboBox3.Text = "XPS" Then
            PictureBox4.Image = My.Resources.notebook_xps_15_9530_silver_800x550
        End If
        If ComboBox3.Text = "Inspiron" Then
            PictureBox4.Image = My.Resources.Inspiron
        End If
        If ComboBox3.Text = "G series" Then
            PictureBox4.Image = My.Resources.notebook_g16_7630_black_800x550
        End If
        If ComboBox3.Text = "Alienware" Then
            PictureBox4.Image = My.Resources.Alienware
        End If
        If ComboBox3.Text = "Latitude" Then
            PictureBox4.Image = My.Resources.Latitude1
        End If
        If ComboBox3.Text = "Vostro" Then
            PictureBox4.Image = My.Resources.dv7620nt_cnb_05000ff090_nonfpr_bk
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form7.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form12.Show()
        Me.Hide()
    End Sub

    Private Sub RichTextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox6.TextChanged

    End Sub
End Class