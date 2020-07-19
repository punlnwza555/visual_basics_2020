Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim User, Pass As String
        User = InputBox("กรุณาป้อนชื่อของคุณ")
        Pass = InputBox("กรุณาป้อนรหัส")
        If User = "Piyatida" And Pass = "1234" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\piyatida\All_Images\photo01.jpg")
        ElseIf User = "ปิยธิดา" And Pass = "4321" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\piyatida\All_Images\kid01.jpg")
        ElseIf User = "พงศนันท์" And Pass = "2121" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\piyatida\All_Images\user_tonyod.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If
    End Sub
End Class
