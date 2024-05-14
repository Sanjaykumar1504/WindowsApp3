Public Class searchingfrm
    Dim r As IO.StreamReader
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        r = New IO.StreamReader("C:\Users\waqar com\OneDrive\Desktop\externaldata.txt")
        ListBox.Items.Clear()
        While (r.Peek > -1)
            ListBox.Items.Add(r.ReadLine)
        End While
        r.Close()

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btnlinear.Click
        Dim target As String = txt1.Text
        Dim index As Integer = linearsearch(target)

        If index >= 0 Then
            MessageBox.Show("Item found using linear search at: " & index)
        Else
            MessageBox.Show("item not found using linear search")

        End If
    End Sub
    Public Function linearsearch(ByVal target As String) As Integer
        For i As Integer = 0 To listbox.Items.Count - 1
            If listbox.Items(i) = target Then
                ' Item found, return the index
                Return i
            End If
        Next
        ' item not found
        Return -1
    End Function



    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim data As List(Of String) = listbox.Items.Cast(Of String)().ToList()
        data.Sort()
        listbox.Items.Clear()
        listbox.Items.AddRange(data.ToArray())
        binarysearch(txt1.Text)
    End Sub
    Public Sub binarysearch(ByVal target As String)
        Dim lowerbound As Integer = 0
        Dim upperbound As Integer = listbox.Items.Count - 1
        While lowerbound <= upperbound
            Dim middle As Integer = (lowerbound + upperbound) \ 2
            Dim currentitem As String = listbox.Items(middle)

            If currentitem = target Then
                ' item found, do something with it
                MessageBox.Show("item found using binary search : " & currentitem)
                Exit Sub
            ElseIf currentitem < target Then
                lowerbound = middle + 1
            Else
                upperbound = middle - 1
            End If
        End While
        MessageBox.Show("item not found:" & target)
    End Sub



End Class