Imports System.Drawing.Imaging
Imports System.Windows.Media.Imaging
Imports System.Windows.Interop.Imaging
Imports System.IO
Imports System.Windows

Public Class Form1
    Dim i As Integer = 0
    Dim img As Image
    Dim bm_dest
    Dim mW = 47, mH = 107 'full
    Dim endf As String = "1"
    Dim ct1 As New Bitmap(50, 150), ct2 As New Bitmap(50, 150), ct3 As New Bitmap(50, 150)
    Dim lastPath As String = ""
    Dim line As New List(Of Point)
    Dim L1, L2, L3 As New List(Of Rectangle)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("hello")
        If File.Exists("amask01.gif") Then
            Dim ct1_t = New Bitmap("amask01.gif")
            ct1 = New Bitmap(ct1_t.Width, ct1_t.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            Dim gfx As Graphics = Graphics.FromImage(ct1)
            gfx.DrawImage(ct1_t, 0, 0)
        Else
            Dim gf1 = Graphics.FromImage(ct1)
            gf1.Clear(Color.White)
        End If
        If File.Exists("amask02.gif") Then
            Dim ct2_t = New Bitmap("amask02.gif")
            ct2 = New Bitmap(ct2_t.Width, ct2_t.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            Dim gfx As Graphics = Graphics.FromImage(ct2)
            gfx.DrawImage(ct2_t, 0, 0)
        Else
            Dim gf2 = Graphics.FromImage(ct2)
            gf2.Clear(Color.White)
        End If
        If File.Exists("amask03.gif") Then
            Dim ct3_t = New Bitmap("amask03.gif")
            ct3 = New Bitmap(ct3_t.Width, ct3_t.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            Dim gfx As Graphics = Graphics.FromImage(ct3)
            gfx.DrawImage(ct3_t, 0, 0)
        Else
            Dim gf3 = Graphics.FromImage(ct3)
            gf3.Clear(Color.White)
        End If
        Try
            If File.Exists("areas.txt") Then
                Dim s As String
                s = My.Computer.FileSystem.ReadAllText("areas.txt")
                Dim sa As String() = s.Split(vbLf)
                If sa(0).Length > 0 Then
                    Dim sr As String() = sa(0).Split(" ")
                    For Each r As String In sr
                        Dim ra As String() = r.Split(",")
                        L1.Add(New Rectangle(ra(0), ra(1), ra(2), ra(3)))
                    Next
                End If
                If sa(1).Length > 0 Then
                    Dim sr As String() = sa(1).Split(" ")
                    For Each r As String In sr
                        Dim ra As String() = r.Split(",")
                        L2.Add(New Rectangle(ra(0), ra(1), ra(2), ra(3)))
                    Next
                End If
                If sa(2).Length > 0 Then
                    Dim sr As String() = sa(2).Split(" ")
                    For Each r As String In sr
                        Dim ra As String() = r.Split(",")
                        L3.Add(New Rectangle(ra(0), ra(1), ra(2), ra(3)))
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox("Ошибка при загрузке регионов" & vbCrLf & ex.Message, vbCritical)
        End Try
        RadioButtonMask1_CheckedChanged(sender, e)
    End Sub

    Function check_file(name As String)
        Return name.ToLower.EndsWith(".gif") Or name.ToLower.EndsWith(".bmp") Or name.ToLower.EndsWith(".png")
    End Function

    Private Sub fill_pattern(ByRef bm_dest As Bitmap)

        Dim pat As Bitmap = ct1

        If RadioButtonMask1.Checked Then
            pat = ct1
        End If
        If RadioButtonMask2.Checked Then
            pat = ct2
        End If
        If RadioButtonMask3.Checked Then
            pat = ct3
        End If

        For y As Integer = 0 To pat.Height - 1
            For x As Integer = 0 To pat.Width - 1
                Dim ctc As Color = pat.GetPixel(x, y)
                If (ctc.R = 255 And ctc.G = 255 And ctc.B = 255) Or (ctc.R = 0 And ctc.G = 0 And ctc.B = 0) Then
                    bm_dest.SetPixel(x, y, Color.Black)
                Else
                    If CheckBoxInvert.Checked Then
                        Dim c As Color = bm_dest.GetPixel(x, y)
                        Dim MyColor = Color.FromArgb(225, 255 - c.R, 255 - c.G, 255 - c.B)
                        bm_dest.SetPixel(x, y, MyColor)
                    End If
                End If
            Next
        Next
    End Sub

    Private Function cut_image(mymW As Integer, mymH As Integer)

        Dim myrY = 0, myrH = 0, myrX = 0, myrW = 0
        If mymW <= mymH Then
            myrY = 0
            myrH = img.Height
            myrX = (img.Width - (img.Height / mymH) * mymW) / 2
            myrW = (img.Height / mymH) * mymW
        Else
            myrX = 0
            myrW = img.Width
            myrY = (img.Height - (img.Width / mymW) * mymH) / 2
            myrH = (img.Width / mymW) * mymH
        End If

        Dim rect As Rectangle = New Rectangle(myrX, myrY, myrW, myrH)

        Dim bm_source As New Bitmap(img)

        Dim bm_dest1 As Bitmap = New Bitmap(CInt(myrW), CInt(myrH), PixelFormat.Format24bppRgb)
        Dim gr_dest1 As Graphics = Graphics.FromImage(bm_dest1)
        gr_dest1.DrawImage(bm_source, 0, 0, rect, GraphicsUnit.Pixel)

        Return bm_dest1
    End Function

    Private Sub draw_pic(gr_dest As Graphics)

        If ListBox1.Items.Count > 0 Then
            For Each r As Rectangle In ListBox1.Items
                Dim bm_dest1 As Bitmap = cut_image(r.Width, r.Height)
                gr_dest.DrawImage(bm_dest1, r)
            Next
        Else
            Dim bm_dest1 As Bitmap = cut_image(mW, mH)
            gr_dest.DrawImage(bm_dest1, 0, 0, mW, mH)
        End If
        Return
    End Sub

    Private Function cut_imageh(mymW As Integer, mymH As Integer, i As Integer)

        Dim myrY = 0, myrX = 0, myrW = 1, myrH = 1

        If RadioButtonDownUp.Checked Then
            myrY = i * NumericUpDownStep.Value
            myrX = 0
            myrW = img.Width
            myrH = (img.Width / mymW) * mymH
        End If

        If RadioButtonUpDown.Checked Then
            myrY = (get_fps() - i) * NumericUpDownStep.Value
            myrX = 0
            myrW = img.Width
            myrH = (img.Width / mymW) * mymH
        End If

        Dim rect As Rectangle = New Rectangle(myrX, myrY, myrW, myrH)

        Dim bm_source As New Bitmap(img)

        'Dim gr_dest2 As Graphics = Graphics.FromImage(bm_source)
        'gr_dest2.DrawRectangle(Pens.Yellow, rect)
        'PictureBox1.Image = bm_source

        Dim bm_dest1 As Bitmap = New Bitmap(CInt(myrW), CInt(myrH), PixelFormat.Format24bppRgb)
        Dim gr_dest1 As Graphics = Graphics.FromImage(bm_dest1)
        gr_dest1.DrawImage(bm_source, 0, 0, rect, GraphicsUnit.Pixel)

        Return bm_dest1
    End Function

    Private Sub draw_pic2(gr_dest As Graphics, i As Integer)
        Dim bm_dest1 As Bitmap = cut_imageh(mW, mH, i)
        gr_dest.DrawImage(bm_dest1, 0, 0, mW, mH)
    End Sub

    Function get_fps()
        If RadioButtonUpDown.Checked Or RadioButtonDownUp.Checked Then
            Dim myrH = (img.Width / mW) * mH
            Debug.WriteLine("h " & myrH)
            Return Math.Floor((img.Height - myrH) / NumericUpDownStep.Value)
        End If

        Return 1
    End Function

    Private Sub resized()
        If StatusLabelPath.Text.EndsWith(".gif") Then
            If bm_dest Is Nothing Or i = 0 Then
                bm_dest = New Bitmap(CInt(mW), CInt(mH), PixelFormat.Format24bppRgb)
                Dim filg As Graphics = Graphics.FromImage(bm_dest)
                filg.Clear(Color.Black)
            End If
            Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
            draw_pic(gr_dest)
            fill_pattern(bm_dest)
            PictureBox3.Image = bm_dest
        Else
            If RadioButtonNone.Checked Then
                MsgBox("Файл не является GIF, выберите эффект прокрутки", MsgBoxStyle.Exclamation)
                Return
            End If
            If bm_dest Is Nothing Or i = 0 Then
                bm_dest = New Bitmap(CInt(mW), CInt(mH), PixelFormat.Format24bppRgb)
                Dim filg As Graphics = Graphics.FromImage(bm_dest)
                filg.Clear(Color.Black)
            End If
            Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
            draw_pic2(gr_dest, i)
            'fill_pattern(bm_dest)
            PictureBox3.Image = bm_dest
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButtonNone.Checked Then
            If check_file(StatusLabelPath.Text) = False Then
                MsgBox("Сперва откройте файл", MsgBoxStyle.Exclamation)
                Return
            End If
            If StatusLabelPath.Text.EndsWith(".gif") = False Then
                MsgBox("Файл не является GIF, выберите эффект прокрутки", MsgBoxStyle.Exclamation)
                Return
            End If
            Dim fps = img.GetFrameCount(FrameDimension.Time)
            LabelFrames.Text = "Frame " & (i + 1) & " of " & fps
            img.SelectActiveFrame(FrameDimension.Time, i)
            PictureBox1.Image = New Bitmap(img)
            resized()
            i += 1
            If i = fps Then
                i = 0
            End If
        Else
            Dim fps = get_fps()
            LabelFrames.Text = "Frame " & (i + 1) & " of " & fps
            PictureBox1.Image = New Bitmap(img)
            resized()
            i += 1
            If i = fps Then
                i = 0
            End If
        End If
    End Sub

    Private Sub loadfile(path As String)
        StatusLabelPath.Text = path
        img = Image.FromFile(path)
        img.SelectActiveFrame(FrameDimension.Time, 0)
        PictureBox1.Image = New Bitmap(img)
        i = 0
    End Sub

    Private Sub ButtonReload_Click(sender As Object, e As EventArgs) Handles ButtonReload.Click
        If check_file(StatusLabelPath.Text) = False Then
            MsgBox("Сперва откройте файл", MsgBoxStyle.Exclamation)
            Return
        End If
        loadfile(StatusLabelPath.Text)
    End Sub

    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            loadfile(OpenFileDialog1.FileName)
            ReverseListBox1.Items.Clear()
            ReverseListBox1.Items.AddRange(OpenFileDialog1.FileNames)
        End If
    End Sub

    Private Sub RadioButtonMask1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMask1.CheckedChanged, RadioButtonMask1.Click
        mW = ct1.Width
        mH = ct1.Height
        PictureBox2.Image = ct1
        endf = "1"
        i = 0
        If My.Computer.FileSystem.FileExists(StatusLabelPath.Text) Then
            loadfile(StatusLabelPath.Text)
        End If
        ListBox1.Items.Clear()
        For Each r As Rectangle In L1
            ListBox1.Items.Add(r)
        Next
    End Sub

    Private Sub RadioButtonMask2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMask2.CheckedChanged, RadioButtonMask2.Click
        mW = ct2.Width
        mH = ct2.Height
        PictureBox2.Image = ct2
        endf = "2"
        i = 0
        If My.Computer.FileSystem.FileExists(StatusLabelPath.Text) Then
            loadfile(StatusLabelPath.Text)
        End If
        ListBox1.Items.Clear()
        For Each r As Rectangle In L2
            ListBox1.Items.Add(r)
        Next
    End Sub

    Private Sub RadioButtonMask3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMask3.CheckedChanged, RadioButtonMask3.Click
        mW = ct3.Width
        mH = ct3.Height
        PictureBox2.Image = ct3
        endf = "3"
        i = 0
        If My.Computer.FileSystem.FileExists(StatusLabelPath.Text) Then
            loadfile(StatusLabelPath.Text)
        End If
        ListBox1.Items.Clear()
        For Each r As Rectangle In L3
            ListBox1.Items.Add(r)
        Next
    End Sub

    Private Sub to_gif(path As String)
        Dim encoder As New GifBitmapEncoder
        Dim bitmaps As New List(Of Bitmap)
        If path.EndsWith("gif") Then
            Dim fps = img.GetFrameCount(FrameDimension.Time)
            For j As Integer = 0 To fps - 1
                img.SelectActiveFrame(FrameDimension.Time, j)
                Dim bm_destG = New Bitmap(CInt(mW), CInt(mH), PixelFormat.Format24bppRgb)
                Dim gr_dest2 As Graphics = Graphics.FromImage(bm_destG)
                gr_dest2.Clear(Color.Black)
                draw_pic(gr_dest2)
                fill_pattern(bm_destG)
                bitmaps.Add(bm_destG)
            Next
        Else
            Dim fps = get_fps()
            For j As Integer = 0 To fps - 1
                Dim bm_destG = New Bitmap(CInt(mW), CInt(mH), PixelFormat.Format24bppRgb)
                Dim gr_dest2 As Graphics = Graphics.FromImage(bm_destG)
                gr_dest2.Clear(Color.Black)
                draw_pic2(gr_dest2, j)
                fill_pattern(bm_destG)
                bitmaps.Add((bm_destG))
            Next
        End If
        bitmaps.ForEach(Sub(bitmap)
                            encoder.Frames.Add(BitmapFrame.Create(CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions())))
                        End Sub)

        Dim ms As New MemoryStream
        encoder.Save(ms)
        Dim fileBytes = ms.ToArray()
        '                      21   FF  0B  4E  45  54  53  43  41  50
        Dim apExt As Byte() = {33, 255, 11, 78, 69, 84, 83, 67, 65, 80, 69, 50, 46, 48, 3, 1, 0, 0, 0}
        Dim newBytes As New List(Of Byte)
        For i As Integer = 0 To 12
            newBytes.Add(fileBytes(i))
        Next
        newBytes.AddRange(apExt)
        For i As Integer = 13 To fileBytes.Length - 1
            newBytes.Add(fileBytes(i))
        Next
        'encoder.Save(New FileStream("F:\test.gif", FileMode.Create))
        Dim pth As String() = path.Split("\")
        Dim nm = pth(pth.Length - 1)
        Dim ph = ""
        For j As Integer = 0 To pth.Length - 2
            ph &= pth(j) & "\"
        Next
        If Not System.IO.Directory.Exists(ph & endf & "\") Then
            System.IO.Directory.CreateDirectory(ph & endf & "\")
        End If
        lastPath = ph & endf & "\" & nm.Substring(0, nm.Length - 3) & "0" & endf & ".gif"
        File.WriteAllBytes(lastPath, newBytes.ToArray())
        If path.EndsWith("gif") Then
            img.SelectActiveFrame(FrameDimension.Time, i)
        End If
    End Sub

    Private Sub ButtonToGif_Click(sender As Object, e As EventArgs) Handles ButtonToGif.Click
        If check_file(StatusLabelPath.Text) = False Then
            MsgBox("Сперва откройте файл", MsgBoxStyle.Exclamation)
            Return
        End If
        to_gif(StatusLabelPath.Text)
        MsgBox("ok")
    End Sub

    Private Sub ButtonToGifAll_Click(sender As Object, e As EventArgs) Handles ButtonToGifAll.Click
        If ReverseListBox1.Items.Count > 0 Then
            For Each pic In ReverseListBox1.Items
                loadfile(pic)
                Me.Refresh()
                to_gif(pic)
            Next
        End If
        MsgBox("ok")
    End Sub

    Private Sub ButtonOpenGif_Click(sender As Object, e As EventArgs) Handles ButtonOpenGif.Click
        If lastPath.EndsWith(".gif") = False Then
            MsgBox("Сначала нажмите 'to GIF'", MsgBoxStyle.Exclamation)
            Return
        End If
        Process.Start(lastPath)
    End Sub

    Private Sub ReverseListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReverseListBox1.SelectedIndexChanged
        If ReverseListBox1.SelectedIndex <> -1 Then
            StatusLabelPath.Text = ReverseListBox1.SelectedItem
            loadfile(StatusLabelPath.Text)
        End If
    End Sub

    Private Sub fill_line(img As Bitmap, x As Integer, y As Integer)
        If x < img.Width And y < img.Height Then
            Dim c = img.GetPixel(x, y)
            Dim w = Color.FromArgb(255, 255, 255, 255)
            If c.Equals(w) = False And line.Contains(New Point(x, y)) = False Then
                line.Add(New Point(x, y))
                For i As Integer = x To 0 Step -1
                    Dim ci = img.GetPixel(i, y)
                    If ci.Equals(w) = False Then
                        If line.Contains(New Point(i, y)) = False Then
                            line.Add(New Point(i, y))
                        End If
                    Else
                        Exit For
                    End If
                Next
                For i As Integer = x To img.Width - 1
                    Dim ci = img.GetPixel(i, y)
                    If ci.Equals(w) = False Then
                        If line.Contains(New Point(i, y)) = False Then
                            line.Add(New Point(i, y))
                        End If
                    Else
                        Exit For
                    End If
                Next
                For i As Integer = x To 0 Step -1
                    If line.Contains(New Point(i, y)) Then
                        If y < img.Height - 1 And line.Contains(New Point(i, y + 1)) = False Then
                            Dim cu = img.GetPixel(i, y + 1)
                            If cu.Equals(w) = False Then
                                fill_line(img, i, y + 1)
                            End If
                        End If
                        If y > 0 And line.Contains(New Point(i, y - 1)) = False Then
                            Dim cu = img.GetPixel(i, y - 1)
                            If cu.Equals(w) = False Then
                                fill_line(img, i, y - 1)
                            End If
                        End If
                    End If
                Next
                For i As Integer = x To img.Width - 1
                    If line.Contains(New Point(i, y)) Then
                        If y < img.Height - 1 And line.Contains(New Point(i, y + 1)) = False Then
                            Dim cu = img.GetPixel(i, y + 1)
                            If cu.Equals(w) = False Then
                                fill_line(img, i, y + 1)
                            End If
                        End If
                        If y > 0 And line.Contains(New Point(i, y - 1)) = False Then
                            Dim cu = img.GetPixel(i, y - 1)
                            If cu.Equals(w) = False Then
                                fill_line(img, i, y - 1)
                            End If
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As MouseEventArgs) Handles PictureBox2.Click
        Dim MyBitmap As Bitmap
        MyBitmap = New Bitmap(PictureBox2.Image)
        fill_line(MyBitmap, e.X, e.Y)
        If line.Count = 0 Then
            Return
        End If
        Dim minx = e.X, miny = e.Y, maxx = e.X, maxy = e.Y
        For Each p As Point In line
            MyBitmap.SetPixel(p.X, p.Y, Color.Magenta)
            If p.X < minx Then
                minx = p.X
            End If
            If p.X > maxx Then
                maxx = p.X
            End If
            If p.Y < miny Then
                miny = p.Y
            End If
            If p.Y > maxy Then
                maxy = p.Y
            End If
        Next
        LabelRegion.Text = minx & "," & miny & "," & (maxx - minx + 1) & "," & (maxy - miny + 1)
        PictureBox2.Image = MyBitmap
    End Sub

    Private Sub PictureBox2_Move(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        StatusLabelCords.Text = e.X & "," & e.Y
    End Sub


    Private Sub ButtonResetRegion_Click(sender As Object, e As EventArgs) Handles ButtonResetRegion.Click
        LabelRegion.Text = "0,0,0,0"
        line.Clear()
        If RadioButtonMask1.Checked Then
            PictureBox2.Image = ct1
        End If
        If RadioButtonMask2.Checked Then
            PictureBox2.Image = ct2
        End If
        If RadioButtonMask3.Checked Then
            PictureBox2.Image = ct3
        End If
    End Sub

    Private Sub sync_list()
        If RadioButtonMask1.Checked Then
            L1.Clear()
            For Each r As Rectangle In ListBox1.Items
                L1.Add(r)
            Next
        End If
        If RadioButtonMask2.Checked Then
            L2.Clear()
            For Each r As Rectangle In ListBox1.Items
                L2.Add(r)
            Next
        End If
        If RadioButtonMask3.Checked Then
            L3.Clear()
            For Each r As Rectangle In ListBox1.Items
                L3.Add(r)
            Next
        End If
        Dim s As String = ""
        For Each r As Rectangle In L1
            s &= r.X & "," & r.Y & "," & r.Width & "," & r.Height & " "
        Next
        s = s.TrimEnd(" ") & vbLf
        For Each r As Rectangle In L2
            s &= r.X & "," & r.Y & "," & r.Width & "," & r.Height & " "
        Next
        s = s.TrimEnd(" ") & vbLf
        For Each r As Rectangle In L3
            s &= r.X & "," & r.Y & "," & r.Width & "," & r.Height & " "
        Next
        s = s.TrimEnd(" ")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("areas.txt", False)
        file.Write(s)
        file.Close()
    End Sub

    Private Sub ButtonListAdd_Click(sender As Object, e As EventArgs) Handles ButtonListAdd.Click
        Dim t = LabelRegion.Text
        Dim s = t.Split(",")
        ListBox1.Items.Add(New Rectangle(CInt(s(0)), CInt(s(1)), CInt(s(2)), CInt(s(3))))
        ButtonResetRegion_Click(sender, e)
        sync_list()
    End Sub

    Private Sub ButtonListDel_Click(sender As Object, e As EventArgs) Handles ButtonListDel.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        sync_list()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ButtonResetRegion_Click(sender, e)
        Dim MyBitmap = New Bitmap(PictureBox2.Image)
        Dim gfx = Graphics.FromImage(MyBitmap)
        Dim r As Rectangle = ListBox1.SelectedItem
        gfx.DrawRectangle(New Pen(Color.Magenta), r)
        PictureBox2.Image = MyBitmap
    End Sub

    Private Sub ButtonListUp_Click(sender As Object, e As EventArgs) Handles ButtonListUp.Click
        If ListBox1.Items.Count > 0 Then
            Dim index As Integer = ListBox1.SelectedIndex - 1
            If index >= 0 Then
                ListBox1.Items.Insert(index, ListBox1.SelectedItem)
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.SelectedIndex = index
            End If
            sync_list()
        End If
    End Sub

    Private Sub ButtonListDown_Click(sender As Object, e As EventArgs) Handles ButtonListDown.Click
        If ListBox1.Items.Count > 0 Then
            Dim index As Integer = ListBox1.SelectedIndex + 1
            If index <= ListBox1.Items.Count - 1 Then
                ListBox1.Items.Insert(index + 1, ListBox1.SelectedItem)
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.SelectedIndex = index
            End If
            sync_list()
        End If
    End Sub

    Private Sub ButtonListShow_Click(sender As Object, e As EventArgs) Handles ButtonListShow.Click
        ButtonResetRegion_Click(sender, e)
        Dim MyBitmap = New Bitmap(PictureBox2.Image)
        Dim gfx = Graphics.FromImage(MyBitmap)
        For Each r As Rectangle In ListBox1.Items
            gfx.DrawRectangle(New Pen(Color.Magenta), r)
        Next
        PictureBox2.Image = MyBitmap
    End Sub

End Class
