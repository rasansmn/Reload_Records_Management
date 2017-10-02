Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class frmUpnet
    Dim editid As Integer
    Dim rmdb As New dbconnect

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Me.Close()
        Dim balstring As String
        balstring = txtRs.Text & "." & txtCts.Text
        If Trim(txtNetwork.Text) = "" Then
            MessageBox.Show("Please enter the network name", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPrefix.Text.Length <> 2 Then
            MessageBox.Show("Please enter an valid prefix. " & vbCrLf & "Ex: Dialog = 77", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtRs.Text = "" And txtCts.Text = "" Then
            MessageBox.Show("Please specify an update amount", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                rmdb.Open()
                Dim cmd As New SqlCommand("UPDATE RMDB_Network SET Network='" & txtNetwork.Text & "', Prefix='" & txtPrefix.Text & "', Balance='" & balstring & "', Last_Update='" & DateTime.Now & "' WHERE Network_Id=" & editid & "", rmdb.objcon)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Records updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Public Sub New(ByVal id As Integer)
        editid = id
        Dim bal As String = ""
        Dim balarray(2) As String
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Try
            rmdb.Open()
            Dim cmd As New SqlCommand("SELECT * FROM RMDB_Network WHERE Network_ID=" & editid & "", rmdb.objcon)
            Dim read As SqlDataReader = cmd.ExecuteReader()
            While read.Read = True
                txtNetwork.Text = read("Network").ToString
                txtPrefix.Text = read("Prefix").ToString
                bal = read("Balance").ToString
            End While
            read.Close()
            balarray = bal.Split(".")
            txtRs.Text = balarray(0)
            txtCts.Text = balarray(1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rmdb.Close()
        End Try
    End Sub
   
End Class
