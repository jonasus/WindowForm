Imports System.Data
Imports System.Data.SqlClient

Public Class Add_Patron


    Private Sub Add_Patron_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
        Dim command1 As New SqlCommand("select * from tblAccountType", connection)
        Dim adapter As New SqlDataAdapter(command1)
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.ValueMember = "Account_TypeID"
        ComboBox1.DisplayMember = "Account_TypeID"



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.SelectedIndex = 0 Then
            Me.FirstName.Enabled = False
            Me.MiddleName.Enabled = False
            Me.LastName.Enabled = False
            Me.CompanyName.Enabled = True
            Me.CompanyAddress.Enabled = True
            Me.HomeAddress.Enabled = False
            Me.PatronBalance.Enabled = True
            Me.Label9.Text = "Corporate Revenue"
        ElseIf Me.ComboBox1.SelectedIndex = 1 Then
            Me.FirstName.Enabled = True
            Me.MiddleName.Enabled = True
            Me.LastName.Enabled = True
            Me.CompanyName.Enabled = False
            Me.CompanyAddress.Enabled = False
            Me.HomeAddress.Enabled = True
            Me.PatronBalance.Enabled = False
            Me.Label9.Text = "Individual Non Revenue"

        ElseIf Me.ComboBox1.SelectedIndex = 2 Then
            Me.FirstName.Enabled = True
            Me.MiddleName.Enabled = True
            Me.LastName.Enabled = True
            Me.CompanyName.Enabled = False
            Me.CompanyAddress.Enabled = False
            Me.HomeAddress.Enabled = True
            Me.PatronBalance.Enabled = True
            Me.Label9.Text = "Individual Revenue"
        ElseIf Me.ComboBox1.SelectedIndex = 3 Then
            Me.FirstName.Enabled = True
            Me.MiddleName.Enabled = True
            Me.LastName.Enabled = True
            Me.CompanyName.Enabled = True
            Me.CompanyAddress.Enabled = True
            Me.HomeAddress.Enabled = True
            Me.PatronBalance.Enabled = True
            Me.Label9.Text = "Corporate Individual Revenue"
        ElseIf Me.ComboBox1.SelectedIndex = 4 Then
            Me.FirstName.Enabled = False
            Me.MiddleName.Enabled = False
            Me.LastName.Enabled = False
            Me.CompanyName.Enabled = True
            Me.CompanyAddress.Enabled = True
            Me.HomeAddress.Enabled = False
            Me.PatronBalance.Enabled = False
            Me.Label9.Text = "Corporate Non Revenue"
        Else
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim connection As New SqlConnection("Data Source=DESKTOP-83NBMNA;Initial Catalog=test2;Integrated Security=True;")
        Dim command As New SqlCommand("insert into tblAccount(FirstName, MiddleName, LastName, Home_Address, Company_Name, Company_Address, Account_TypeID, Patron_Balance) values(@fn,@mn,@ln,@ha,@cn,@ca, @at, @pb)", connection)
        command.Parameters.Add("@at", SqlDbType.VarChar).Value = ComboBox1.Text
        command.Parameters.Add("@fn", SqlDbType.VarChar).Value = FirstName.Text
        command.Parameters.Add("@mn", SqlDbType.VarChar).Value = MiddleName.Text
        command.Parameters.Add("@ln", SqlDbType.VarChar).Value = LastName.Text
        command.Parameters.Add("@ha", SqlDbType.VarChar).Value = HomeAddress.Text
        command.Parameters.Add("@cn", SqlDbType.VarChar).Value = CompanyName.Text
        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = CompanyAddress.Text
        command.Parameters.Add("@pb", SqlDbType.Decimal).Value = PatronBalance.Text
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New User Added")

        Else

            MessageBox.Show("User Not Added")
            Me.Refresh()
        End If

        connection.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class