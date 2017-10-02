Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click
        frmMain.MdiParent = Me
        frmMain.Show()
        frmMain.Activate()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
        frmReloads.MdiParent = Me
        frmReloads.Show()
        frmReloads.Activate()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.MdiParent = Me
        frmMain.Show()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        frmNumbers.MdiParent = Me
        frmNumbers.Show()
        frmNumbers.Activate()
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        frmNetworks.MdiParent = Me
        frmNetworks.Show()
        frmNetworks.Activate()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.MdiParent = Me
        AboutBox1.Show()
        AboutBox1.Activate()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        frmMain.MdiParent = Me
        frmMain.Show()
        frmMain.Activate()
    End Sub

    Private Sub NumbersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumbersToolStripMenuItem.Click
        frmReloads.MdiParent = Me
        frmReloads.Show()
        frmReloads.Activate()
    End Sub

    Private Sub NumbersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumbersToolStripMenuItem1.Click
        frmNumbers.MdiParent = Me
        frmNumbers.Show()
        frmNumbers.Activate()
    End Sub

    Private Sub NetworksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetworksToolStripMenuItem.Click
        frmNetworks.MdiParent = Me
        frmNetworks.Show()
        frmNetworks.Activate()
    End Sub

    Private Sub btnUpacc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddbalance.MdiParent = Me
        frmAddbalance.Show()
        frmAddbalance.Activate()
    End Sub

    Private Sub UpdateAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateAccountToolStripMenuItem.Click
        frmAddbalance.MdiParent = Me
        frmAddbalance.Show()
        frmAddbalance.Activate()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        frmAddbalance.MdiParent = Me
        frmAddbalance.Show()
        frmAddbalance.Activate()
    End Sub
End Class
