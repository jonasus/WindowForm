Imports System.Data
Imports System.Data.SqlClient
Public Class VehicleList
    Private Sub VehicleList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
        Dim command As New SqlCommand("select * from TableVehicle", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Vehicle.Show()
        Me.Close()
    End Sub
End Class