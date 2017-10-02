Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class frmAddnetwork
    Dim rmdb As New dbconnect
    Dim balstring As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        balstring = TxtRs.Text & "." & txtCts.Text
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Me.Close()
        If Trim(txtNetwork.Text) = "" Then
            MessageBox.Show("Please enter the network name", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPrefix.Text.Length <> 2 Or IsNumeric(txtPrefix.Text) = False Then
            MessageBox.Show("Please enter an valid prefix. " & vbCrLf & "Ex: Dialog = 77", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtRs.Text = "" And txtCts.Text = "" Then
            MessageBox.Show("Please specify an update amount", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                rmdb.Open()
                Dim count, newnetid As Integer
                Dim cmdcount As New SqlCommand("SELECT COUNT (*) FROM RMDB_Network", rmdb.objcon)
                count = cmdcount.ExecuteScalar
                If count > 0 Then
                    Dim cmd As New SqlCommand("SELECT max(Network_ID) FROM RMDB_Network", rmdb.objcon)
                    newnetid = cmd.ExecuteScalar
                End If
                newnetid += 1
                Dim cmdin As New SqlCommand("INSERT INTO RMDB_Network VALUES (" & newnetid & ",'" & txtNetwork.Text & "'," & txtPrefix.Text & ",'" & balstring & "','" & Now.Date & "')", rmdb.objcon)
                cmdin.ExecuteNonQuery()
                MessageBox.Show("Record added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rmdb.Close()
                frmNetworks.Close()
                frmNetworks.Show()
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmAddnetwork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNetwork.Select()
    End Sub
End Class
