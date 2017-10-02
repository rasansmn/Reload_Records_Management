Imports System.Data.SqlClient
Public Class frmReloads
    Dim rmdb As New dbconnect
    Dim selectedrldid As Integer
    Dim selectedrldstat As String
    Dim showquerystring As String = "SELECT R.Reload_ID, N.Number, R.Price, R.Date, R.Time, X.Network, R.Account_Balance, R.Status FROM RMDB_Reload R, RMDB_Number N, RMDB_Network X WHERE R.Number_ID=N.Number_ID AND R.Network_ID=X.Network_ID ORDER BY R.Reload_ID DESC"

    Sub showreloads(ByVal querystring As String)
        Try
            rmdb.Open()
            Dim cmd As New SqlCommand(querystring, rmdb.objcon)
            Dim dadapt As New SqlDataAdapter(querystring, rmdb.objcon)
            Dim countadapt As New SqlDataAdapter
            countadapt.SelectCommand = cmd
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "Reload")
            countadapt.Fill(dset, "Count")
            Dim count As Integer = dset.Tables("Count").Rows.Count
            'DataGridRld.SetDataBinding(dset, "Reload")
            DataGridRld.DataSource = dset
            DataGridRld.DataMember = "Reload"
            DataGridRld.CaptionText = "Reloads (" & count.ToString & " records)"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rmdb.Close()
        End Try
    End Sub

    Private Sub Reloads_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showreloads(showquerystring)
    End Sub

    Private Sub DataGridRld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridRld.Click
        Try
            Dim rown As Integer = DataGridRld.CurrentRowIndex
            selectedrldid = DataGridRld.Item(rown, 0)
            selectedrldstat = DataGridRld.Item(rown, 7)
            btnDeliver.Enabled = True
            btnDel.Enabled = True
            If selectedrldstat = "Pending" Then
                btnDeliver.Text = "Set As Delivered"
            Else
                btnDeliver.Text = "Set As Pending"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDeliver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeliver.Click
        Dim querystring As String
        If selectedrldstat = "Pending" Then
            querystring = "UPDATE RMDB_Reload SET Status ='Delivered' WHERE Reload_ID ='" & selectedrldid & "'"
        Else
            querystring = "UPDATE RMDB_Reload SET Status ='Pending' WHERE Reload_ID ='" & selectedrldid & "'"
        End If
        Try
            rmdb.Open()
            Dim cmd As New SqlCommand(querystring, rmdb.objcon)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Records updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rmdb.Close()
            showreloads(showquerystring)
            btnDeliver.Enabled = False
            btnDel.Enabled = False
        End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim result As DialogResult = MessageBox.Show("You are going to delete this record." & vbCrLf & "Confirm?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Try
                rmdb.Open()
                Dim cmd As New SqlCommand("DELETE FROM RMDB_Reload WHERE Reload_ID=" & selectedrldid, rmdb.objcon)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rmdb.Close()
                showreloads(showquerystring)
                btnDel.Enabled = False
            End Try
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        showquerystring = "SELECT R.Reload_ID, N.Number, R.Price, R.Date, R.Time, X.Network, R.Account_Balance, R.Status FROM RMDB_Reload R, RMDB_Number N, RMDB_Network X WHERE R.Number_ID=N.Number_ID AND R.Network_ID=X.Network_ID AND R.Date LIKE '%" & DateTimePicker1.Value.Date & "%' ORDER BY R.Reload_ID DESC"
        showreloads(showquerystring)
        btnToday.Text = "All"
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim cmbtext As String = cmbLookin.Text
        Dim querytext As String = "R.Reload_ID"
        Select Case cmbtext
            Case "Reload ID"
                querytext = "R.Reload_ID"
            Case "Number"
                querytext = "N.Number"
            Case "Price"
                querytext = "R.Price"
            Case "Date"
                querytext = "R.Date"
            Case "Network"
                querytext = "X.Network"
            Case "Account Balance"
                querytext = "R.Account_Balance"
            Case "Status"
                querytext = "R.Status"
            Case Else
                querytext = "R.Reload_ID"
        End Select
        showquerystring = "SELECT R.Reload_ID, N.Number, R.Price, R.Date, R.Time, X.Network, R.Account_Balance, R.Status FROM RMDB_Reload R, RMDB_Number N, RMDB_Network X WHERE R.Number_ID=N.Number_ID AND R.Network_ID=X.Network_ID AND " & querytext & " LIKE '%" & txtSearch.Text & "%' ORDER BY R.Reload_ID DESC"
        showreloads(showquerystring)
        If txtSearch.Text <> "" Then
            btnToday.Text = "All"
        End If
    End Sub

    Private Sub btnToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToday.Click
        If btnToday.Text = "Today" Then
            showquerystring = "SELECT R.Reload_ID, N.Number, R.Price, R.Date, R.Time, X.Network, R.Account_Balance, R.Status FROM RMDB_Reload R, RMDB_Number N, RMDB_Network X WHERE R.Number_ID=N.Number_ID AND R.Network_ID=X.Network_ID AND R.Date LIKE '%" & Now.Date & "%' ORDER BY R.Reload_ID DESC"
            showreloads(showquerystring)
            btnToday.Text = "All"
        Else
            showquerystring = "SELECT R.Reload_ID, N.Number, R.Price, R.Date, R.Time, X.Network, R.Account_Balance, R.Status FROM RMDB_Reload R, RMDB_Number N, RMDB_Network X WHERE R.Number_ID=N.Number_ID AND R.Network_ID=X.Network_ID ORDER BY R.Reload_ID DESC"
            showreloads(showquerystring)
            btnToday.Text = "Today"
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frmreport As New frmRpt(showquerystring, "Reload")
        frmreport.MdiParent = MDIParent1
        frmreport.Show()
        frmreport.Activate()
    End Sub
End Class