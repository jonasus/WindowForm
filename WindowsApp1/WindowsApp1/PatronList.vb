Imports System.Data
Imports System.Data.SqlClient
Public Class PatronList
    Private Sub PatronList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
        Dim command1 As New SqlCommand("select * from tblAccountType", connection)
        Dim adapter As New SqlDataAdapter(command1)
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.ValueMember = "Account_TypeID"
        ComboBox1.DisplayMember = "Account_Type_Desc"
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If Me.ComboBox1.SelectedIndex = 0 Then
            Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
            Dim command As New SqlCommand("select * from tblCompanyRevenue", connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            Me.btnMaster.Enabled = True
            DataGridView1.ReadOnly = True
        ElseIf Me.ComboBox1.SelectedIndex = 1 Then
            Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
            Dim command As New SqlCommand("select * from tblIndividualNonRev", connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            Me.btnMaster.Enabled = True
            DataGridView1.ReadOnly = True
        ElseIf Me.ComboBox1.SelectedIndex = 2 Then
            Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
            Dim command As New SqlCommand("select * from tblIndividualRev", connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            Me.btnMaster.Enabled = True
            DataGridView1.ReadOnly = True
        ElseIf Me.ComboBox1.SelectedIndex = 3 Then
            Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
            Dim command As New SqlCommand("select * from tblCorporateIndividualRev", connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            Me.btnMaster.Enabled = True
            DataGridView1.ReadOnly = True
        ElseIf Me.ComboBox1.SelectedIndex = 4 Then
            Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
            Dim command As New SqlCommand("select * from tblCorporateNonRev", connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            Me.btnMaster.Enabled = True
            DataGridView1.ReadOnly = True
        Else
            Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
            Dim command As New SqlCommand("select * from tblMaster", connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            Me.btnMaster.Enabled = True
            DataGridView1.ReadOnly = True

        End If
    End Sub

    Private Sub btnMaster_Click(sender As Object, e As EventArgs) Handles btnMaster.Click
        Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
        Dim command As New SqlCommand("select * from tblMaster", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        Me.btnMaster.Enabled = False
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Patron.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class