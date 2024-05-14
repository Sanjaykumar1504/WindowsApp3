Public Class sorting
    Dim randomnumbers(6) As Integer

    Private Sub btnsort_Click(sender As Object, e As EventArgs) Handles btnsort.Click
        For i = 0 To 6
            randomnumbers(i) = CInt(Rnd() * 100) + 1

        Next
        ListBoxsort.Items.Clear()

        ListBoxsort.Items.Add("unsorted:")
        For i = 0 To 6
            ListBoxsort.Items.Add(randomnumbers(i).ToString())
        Next
        Dim swapped As Boolean = True
        Do While swapped
            swapped = False
        Loop

        For i = 0 To UBound(randomnumbers) - 1
            If randomnumbers(i) > randomnumbers(i) Then

                Dim temp As Integer = randomnumbers(i)
                randomnumbers(i + 1) = temp
                swapped = True

            End If
        Next

        ListBoxsort.Items.Add("")
        ListBoxsort.Items.Add("sorted:")
        For i = 0 To 6
            ListBoxsort.Items.Add(randomnumbers(i).ToString())
        Next



    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        For i = 0 To 6
            randomnumbers(i) = CInt(Rnd() * 100) + 1

        Next
        ListBoxsort.Items.Clear()

        ListBoxsort.Items.Add("unsorted:")
        For i = 0 To 6
            ListBoxsort.Items.Add(randomnumbers(i).ToString())

        Next

        For i = 1 To 6
            Dim key As Integer = randomnumbers(i)
            Dim j As Integer = i - 1
            While j >= 0 AndAlso randomnumbers(i)
                randomnumbers(j + 1) = randomnumbers(j)
                j -= 1
                If j > 0 Then Exit While
            End While
            randomnumbers(j + 1) = key

        Next
        ListBoxsort.Items.Add("")
        ListBoxsort.Items.Add("sorted:")
        For i = 0 To 6
            ListBoxsort.Items.Add(randomnumbers(i).ToString())
        Next


    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        form1.Show()
        Me.Hide()

    End Sub
End Class