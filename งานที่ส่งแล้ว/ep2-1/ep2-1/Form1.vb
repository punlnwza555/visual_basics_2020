Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstName As String
        FirstName = "Piyatida"
        Label4.Text = FirstName
        FirstName = "Sripoompruek"
        Label5.Text = FirstName
        FirstName = "Pun"
        Label6.Text = FirstName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณาป้อนชื่อ"
        FullName = InputBox(Prompt)
        Label4.Text = FullName
        Prompt = "กรุณาป้อนนามสุกล"
        FullName = InputBox(Prompt)
        Label5.Text = FullName
        Prompt = "กรุณาป้อนชื่อเล่น"
        FullName = InputBox(Prompt)
        Label6.Text = FullName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(Prompt)
        MsgBox(FullName, , "ชื่อและนามสกุลของคุณ")
    End Sub
End Class
