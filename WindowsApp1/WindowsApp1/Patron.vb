Public Class Patron
    Private Sub addPatronMenubtn_Click(sender As Object, e As EventArgs) Handles addPatronMenubtn.Click
        Dim Patron As New Form
        Add_Patron.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim PatronList As New PatronList
        PatronList.Show()
        Me.Close()
    End Sub
End Class