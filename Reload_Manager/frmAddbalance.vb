Public Class frmAddbalance
    Dim rmdb As New dbconnect
    Dim bal As Decimal
    Dim upid As Integer
    Dim editnet As String

    Private Sub frmAddbalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dadapt As New SqlClient.SqlDataAdapter("SELECT * FROM RMDB_Network ORDER BY Last_Update DESC", rmdb.objcon)
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "Network")
            cmbNetwork.DataSource = dset.Tables("Network")
            cmbNetwork.DisplayMember = "Network"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rmdb.Close()
        End Try
    End Sub

    Private Sub cmbNetwork_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNetwork.SelectedIndexChanged
        editnet = cmbNetwork.Text
        If cmbNetwork.Text <> "" Then
            Try
                rmdb.Open()
                Dim cmd As New SqlClient.SqlCommand("SELECT * FROM RMDB_Network WHERE Network='" & editnet & "'", rmdb.objcon)
                Dim read As SqlClient.SqlDataReader = cmd.ExecuteReader()
                While read.Read = True
                    upid = read("Network_ID")
                    bal = read("Balance").ToString
                    editnet = read("Network").ToString
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rmdb.Close()
            End Try
        End If
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim amount As String
        amount = Val(txtRs.Text & "." & txtCts.Text)
        Dim newbal As Decimal = bal + amount
        If txtRs.Text = "" And txtCts.Text = "" Then
            MessageBox.Show("Please specify an amount to add.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("You are going to update account balance" & vbCrLf & vbCrLf & "Network: " & editnet & vbCrLf & "Current balance: " & Val(bal) & vbCrLf & "New Balance: " & newbal & vbCrLf & vbCrLf & "Is above details are correct?", "Update", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                Try
                    rmdb.Open()
                    Dim cmd As New SqlClient.SqlCommand("UPDATE RMDB_Network SET Balance='" & newbal & "', Last_Update='" & DateTime.Now & "' WHERE Network='" & editnet & "'", rmdb.objcon)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Records updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    rmdb.Close()
                    Me.Close()
                End Try
            End If
        End If
    End Sub

End Class