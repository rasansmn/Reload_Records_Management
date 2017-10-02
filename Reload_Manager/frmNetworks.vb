Imports system.Data.SqlClient
Public Class frmNetworks
    Dim rmdb As New dbconnect
    Dim showquerystring As String = "SELECT * FROM RMDB_Network"
    Dim selectednetid As Integer

    Sub shownet(ByVal querystring As String)
        Try
            rmdb.Open()
            Dim dadapt As New SqlDataAdapter(querystring, rmdb.objcon)
            Dim countadapt As New SqlClient.SqlDataAdapter(querystring, rmdb.objcon)
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "Network")
            countadapt.Fill(dset, "Count")
            Dim count As Integer = dset.Tables("Count").Rows.Count
            DataGridNet.SetDataBinding(dset, "Network")
            DataGridNet.CaptionText = "Numbers (" & count.ToString & " records)"
            'DataGridNet.DataSource = dset
            'DataGridNet.DataMember = "Network"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rmdb.Close()
        End Try
    End Sub

    Private Sub Networks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        shownet(showquerystring)
    End Sub

    Private Sub DataGridNet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridNet.Click
        Try
            Dim rown As Integer = DataGridNet.CurrentRowIndex
            selectednetid = DataGridNet.Item(rown, 0)
            btnDel.Enabled = True
            btnUpdate.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim result As DialogResult = MessageBox.Show("This network and it's contained numbers and reload records will be deleted permanently." & vbCrLf & "Do you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Try
                rmdb.Open()
                Dim cmd As New SqlCommand("DELETE FROM RMDB_Network WHERE Network_ID=" & selectednetid, rmdb.objcon)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rmdb.Close()
                shownet(showquerystring)
                btnDel.Enabled = False
                btnUpdate.Enabled = False
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim frmupnet As New frmUpnet(selectednetid)
        frmupnet.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frmaddnetwork As New frmAddnetwork()
        frmAddnetwork.Show()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frmreport As New frmRpt(showquerystring, "Network")
        frmreport.MdiParent = MDIParent1
        frmreport.Show()
        frmreport.Activate()
    End Sub
End Class