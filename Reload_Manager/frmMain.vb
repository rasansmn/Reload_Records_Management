Imports System.Data.SqlClient
Public Class frmMain
    Dim rmdb As New dbconnect
    Dim selectedrldid As Integer
    Dim selectedrldstat As String

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim newrldid, numberid, networkid, terms As Integer
        Dim price, balance, newbalance As Double
        Dim delivered As String
        If chkDelivered.Checked = True Then
            delivered = "Delivered"
        Else
            delivered = "Pending"
        End If
        If rdo50.Enabled = True And rdo50.Checked = True Then
            price = 50
        ElseIf rdo100.Enabled = True And rdo100.Checked = True Then
            price = 100
        Else
            Dim strAmount As String = txtRs.Text + "." + txtCts.Text
            price = Val(strAmount)
        End If
        'validating inputs
        If cmbNumber.Text.Length <> 9 Or IsNumeric(cmbNumber.Text) = False Then
            MessageBox.Show("Enter an valid number which contain 9 numbers", "Add Reload", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf price = 0 Then
            MessageBox.Show("Please specify a reload amount", "Add Reload", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'validate success
            Dim strPrefix As String = cmbNumber.Text.Substring(0, 2)
            Try
                rmdb.Open()
                Dim cmd1 As New SqlCommand("SELECT Balance from RMDB_Network WHERE Prefix = '" & strPrefix & "'", rmdb.objcon)
                balance = cmd1.ExecuteScalar
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rmdb.Close()
            End Try

            If balance = 0 Then ' validating the network
                MessageBox.Show("Unknown network service", "Add Reload", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else 'validate success
                Try
                    rmdb.Open()
                    'generate new reload ID
                    Dim rldcount As Integer
                    Dim cmdcount As New SqlCommand("SELECT COUNT (*) from RMDB_Reload", rmdb.objcon)
                    rldcount = cmdcount.ExecuteScalar
                    If rldcount > 0 Then
                        Dim cmd1 As New SqlCommand("SELECT max(Reload_ID) from RMDB_Reload", rmdb.objcon)
                        newrldid = cmd1.ExecuteScalar
                    End If
                    newrldid += 1
                    'find the number infomation in the DB
                    Dim cmd3 As New SqlCommand("SELECT * from RMDB_Number WHERE Number = '" + cmbNumber.Text + "'", rmdb.objcon)
                    Dim read As SqlDataReader = cmd3.ExecuteReader
                    While read.Read = True
                        numberid = read("Number_ID")
                        networkid = read("Network_ID")
                        terms = read("Terms")
                    End While
                    read.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    rmdb.Close()
                End Try
                newbalance = balance - price
                Dim result As DialogResult = MessageBox.Show("You are going to add a new reload" & vbCrLf & vbCrLf & "Number: " & cmbNumber.Text & vbCrLf & "Price: " & price & vbCrLf & "Current Balance: " & balance & vbCrLf & "New Balance: " & newbalance & vbCrLf & "Status: " & delivered & vbCrLf & vbCrLf & "Is above details are correct?", "Add Reload", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    Try
                        rmdb.Open()
                        If numberid < 1 Then 'not existing number, then add it
                            Dim numcount As Integer
                            Dim cmdcount2 As New SqlCommand("SELECT COUNT (*) from RMDB_Number", rmdb.objcon)
                            numcount = cmdcount2.ExecuteScalar
                            If numcount > 0 Then
                                Dim cmdx As New SqlCommand("SELECT max(Number_ID) from RMDB_Number", rmdb.objcon)
                                numberid = cmdx.ExecuteScalar
                            End If
                            numberid += 1
                            Dim cmdnet As New SqlCommand("SELECT Network_ID from RMDB_Network WHERE Prefix = '" & strPrefix & "'", rmdb.objcon)
                            networkid = cmdnet.ExecuteScalar
                            Dim cmdinnum As New SqlCommand("INSERT INTO RMDB_Number VALUES (" & numberid & "," & cmbNumber.Text & ", 1 ,'" & DatePicker.Value & "'," & networkid & ")", rmdb.objcon)
                            cmdinnum.ExecuteNonQuery()
                        Else 'number is exist, just update it
                            Dim cmdup As New SqlCommand("UPDATE RMDB_Number SET Terms = '" & terms + 1 & "', Last_Reload ='" & DatePicker.Value & "' WHERE Number_ID ='" & numberid & "'", rmdb.objcon)
                            cmdup.ExecuteNonQuery()
                        End If
                        'updating reload, network tables
                        Dim cmdin As New SqlCommand("INSERT INTO RMDB_Reload VALUES (" & newrldid & "," & price & ",'" & txtTime.Text & "','" & DatePicker.Value.Date & "','" & newbalance & "','" & delivered & "'," & numberid & "," & networkid & ")", rmdb.objcon)
                        cmdin.ExecuteNonQuery()
                        Dim cmdup2 As New SqlCommand("UPDATE RMDB_Network SET Balance = '" & newbalance & "' WHERE Network_ID ='" & networkid & "'", rmdb.objcon)
                        cmdup2.ExecuteNonQuery()
                        MessageBox.Show("Records updated successfully", "Add Reload", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        rmdb.Close()
                        initializeform()
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtTime.Text = Microsoft.VisualBasic.TimeOfDay
    End Sub

    Private Sub txtDate_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Timer1.Enabled = False
    End Sub

    Private Sub txtTime_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTime.MouseClick
        Timer1.Enabled = False
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        initializeform()
    End Sub

    Private Sub txtRs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRs.TextChanged
        If txtRs.Text.Length = 0 And txtCts.Text.Length = 0 Then
            rdo100.Enabled = True
            rdo50.Enabled = True
        Else
            rdo100.Enabled = False
            rdo50.Enabled = False
        End If
    End Sub

    Private Sub txtCts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCts.TextChanged
        If txtCts.Text.Length = 0 And txtRs.Text.Length = 0 Then
            rdo100.Enabled = True
            rdo50.Enabled = True
        Else
            rdo100.Enabled = False
            rdo50.Enabled = False
        End If
    
    End Sub

    Sub showaccounts()
        Try
            rmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter("SELECT Network, Balance, Last_Update FROM RMDB_Network", rmdb.objcon)
            Dim countadapt As New SqlClient.SqlDataAdapter("SELECT Network, Balance, Last_Update FROM RMDB_Network", rmdb.objcon)
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "Account")
            countadapt.Fill(dset, "Count")
            Dim count As Integer = dset.Tables("Count").Rows.Count
            DataGridAcc.SetDataBinding(dset, "Account")
            DataGridAcc.DataSource = dset
            DataGridAcc.DataMember = "account"
            DataGridAcc.CaptionText = "Numbers (" & count.ToString & " records)"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rmdb.Close()
        End Try
    End Sub

    Sub showreloads()
        Try
            rmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter("SELECT R.Reload_ID, N.Number, R.Price, R.Date, R.Time, X.Network, R.Account_Balance, R.Status FROM RMDB_Reload R, RMDB_Number N, RMDB_Network X WHERE R.Number_ID=N.Number_ID AND R.Network_ID=X.Network_ID ORDER BY R.Reload_ID DESC", rmdb.objcon)
            Dim countadapt As New SqlClient.SqlDataAdapter("SELECT R.Reload_ID, N.Number, R.Price, R.Date, R.Time, X.Network, R.Account_Balance, R.Status FROM RMDB_Reload R, RMDB_Number N, RMDB_Network X WHERE R.Number_ID=N.Number_ID AND R.Network_ID=X.Network_ID ORDER BY R.Reload_ID DESC", rmdb.objcon)
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "Reload")
            countadapt.Fill(dset, "Count")
            Dim count As Integer = dset.Tables("Count").Rows.Count
            DataGridRld.SetDataBinding(dset, "Reload")
            DataGridRld.DataSource = dset
            DataGridRld.DataMember = "Reload"
            DataGridRld.CaptionText = "Numbers (" & count.ToString & " records)"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rmdb.Close()
        End Try
    End Sub

    Sub initializeform()
        cmbNumber.Text = ""
        txtCts.Clear()
        txtRs.Clear()
        rdo100.Enabled = True
        rdo50.Enabled = True
        cmbNumber.Select()
        showaccounts()
        showreloads()
        Try
            rmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter("SET ROWCOUNT 10 SELECT * FROM RMDB_Number ORDER BY Last_Reload DESC", rmdb.objcon)
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "Number")
            cmbNumber.DataSource = dset.Tables("Number")
            cmbNumber.DisplayMember = "Number"
            cmbNumber.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rmdb.Close()
        End Try
    End Sub

    Private Sub DataGridRld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridRld.Click
        Try
            Dim rown As Integer = DataGridRld.CurrentRowIndex
            selectedrldid = DataGridRld.Item(rown, 0)
            selectedrldstat = DataGridRld.Item(rown, 7)
            btnDeliver.Enabled = True
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
            showreloads()
            btnDeliver.Enabled = False
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmNetworks.MdiParent = MDIParent1
        frmNetworks.Show()
        frmNetworks.Activate()
    End Sub
End Class
