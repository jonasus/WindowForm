Imports System.Data
Imports System.Data.SqlClient
Public Class AssignVehicle
    Private Sub AssignVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
        Dim command As New SqlCommand("select * from TableVehicle", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Dim connection1 As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
        Dim command1 As New SqlCommand("select * from tblAccountAndVehicle", connection)
        Dim adapter1 As New SqlDataAdapter(command1)
        Dim table1 As New DataTable()
        adapter1.Fill(table1)
        DataGridView1.DataSource = table1
        adapter.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.ValueMember = "Vehicle_ID"
        ComboBox1.DisplayMember = "Vehicle_Model"



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If (DataGridView1.SelectedRows.Count = 0) Then
            FirstName.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            MiddleName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            LastName.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            CompanyName.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        End If



    End Sub
End Class