Public Class frmNumbers
    Dim rmdb As New dbconnect
    Dim selectednumid As Integer
    Dim showquerystring As String = "SELECT N.Number_ID, N.Number, N.Terms, N.Last_Reload, X.Network FROM RMDB_Number N, RMDB_Network X WHERE N.Network_ID=X.Network_ID"

    Sub shownumbers(ByVal querystring As String)
        Try
            rmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter(querystring, rmdb.objcon)
            Dim countadapt As New SqlClient.SqlDataAdapter(querystring, rmdb.objcon)
            Dim dset As New Data.DataSet
            dadapt.Fill(dset, "Numbers")
            countadapt.Fill(dset, "Count")
            Dim count As Integer = dset.Tables("Count").Rows.Count
            DataGridNum.SetDataBinding(dset, "Numbers")
            DataGridNum.CaptionText = "Numbers (" & count.ToString & " records)"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rmdb.Close()
        End Try
    End Sub

    Private Sub frmNumbers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        shownumbers(showquerystring)
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim response As DialogResult = MessageBox.Show("This number and it's contained reload records will be deleted permanently." & vbCrLf & "Do you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = Windows.Forms.DialogResult.Yes Then
            Try
                rmdb.Open()
                Dim cmd As New SqlClient.SqlCommand("DELETE FROM RMDB_Number WHERE Number_ID=" & selectednumid, rmdb.objcon)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record deleted succefully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rmdb.Close()
                btnDel.Enabled = False
                shownumbers(showquerystring)
            End Try
        End If
    End Sub

    Private Sub DataGridNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridNum.Click
        Try
            Dim rown As Integer = DataGridNum.CurrentRowIndex
            selectednumid = DataGridNum.Item(rown, 0)
            btnDel.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim cmbtext As String = cmbLookin.Text
        Dim querytext As String = "N.Number_ID"
        Select Case cmbtext
            Case "Number ID"
                querytext = "N.Number_ID"
            Case "Number"
                querytext = "N.Number"
            Case "Terms"
                querytext = "N.Terms"
            Case "Date"
                querytext = "R.Date"
            Case "Network"
                querytext = "X.Network"
            Case Else
                querytext = "N.Number_ID"
        End Select
        showquerystring = "SELECT N.Number_ID, N.Number, N.Terms, N.Last_Reload, X.Network FROM RMDB_Number N, RMDB_Network X WHERE N.Network_ID=X.Network_ID AND " & querytext & " LIKE '%" & txtSearch.Text & "%'"
        shownumbers(showquerystring)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frmreport As New frmRpt(showquerystring, "Number")
        frmreport.MdiParent = MDIParent1
        frmreport.Show()
        frmreport.Activate()
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        showquerystring = "SELECT N.Number_ID, N.Number, N.Terms, N.Last_Reload, X.Network FROM RMDB_Number N, RMDB_Network X WHERE N.Network_ID=X.Network_ID"
        shownumbers(showquerystring)
    End Sub
End Class