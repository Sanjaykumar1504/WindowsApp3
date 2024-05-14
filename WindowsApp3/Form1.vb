Public Class form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles sortbtn1.Click
        sorting.Show()
        Me.Hide()

    End Sub

    Private Sub searchbtn1_Click(sender As Object, e As EventArgs) Handles searchbtn1.Click
        searchingfrm.Show()
        Me.Hide()

    End Sub
End Class
