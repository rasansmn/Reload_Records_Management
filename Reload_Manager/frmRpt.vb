Public Class frmRpt
    Dim rmdb As New dbconnect

    Public Sub New(ByVal showquery As String, ByVal table As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Try
            Dim dadapt As New SqlClient.SqlDataAdapter(showquery, rmdb.objcon)
            Dim dset As New DS

            If table = "Reload" Then
                dadapt.Fill(dset, "tblReload")
                Dim crys As New rptRld
                crys.SetDataSource(dset)
                CrystalReportViewer1.ReportSource = crys
            ElseIf table = "Number" Then
                dadapt.Fill(dset, "tblNumber")
                Dim crys As New rptNum
                crys.SetDataSource(dset)
                CrystalReportViewer1.ReportSource = crys
            Else
                dadapt.Fill(dset, "tblNetwork")
                Dim crys As New rptNet
                crys.SetDataSource(dset)
                CrystalReportViewer1.ReportSource = crys
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class