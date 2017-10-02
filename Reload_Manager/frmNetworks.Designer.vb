<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNetworks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNetworks))
        Me.btnDel = New System.Windows.Forms.Button
        Me.DataGridNet = New System.Windows.Forms.DataGrid
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button
        CType(Me.DataGridNet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDel
        '
        Me.btnDel.Enabled = False
        Me.btnDel.ForeColor = System.Drawing.Color.Firebrick
        Me.btnDel.Location = New System.Drawing.Point(250, 152)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(68, 24)
        Me.btnDel.TabIndex = 0
        Me.btnDel.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.btnDel, "Delete")
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'DataGridNet
        '
        Me.DataGridNet.AlternatingBackColor = System.Drawing.Color.White
        Me.DataGridNet.BackColor = System.Drawing.Color.White
        Me.DataGridNet.BackgroundColor = System.Drawing.Color.Ivory
        Me.DataGridNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGridNet.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridNet.CaptionForeColor = System.Drawing.Color.Lavender
        Me.DataGridNet.CaptionText = "Network Accounts"
        Me.DataGridNet.DataMember = ""
        Me.DataGridNet.FlatMode = True
        Me.DataGridNet.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridNet.ForeColor = System.Drawing.Color.Black
        Me.DataGridNet.GridLineColor = System.Drawing.Color.Wheat
        Me.DataGridNet.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridNet.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridNet.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGridNet.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridNet.Location = New System.Drawing.Point(12, 13)
        Me.DataGridNet.Name = "DataGridNet"
        Me.DataGridNet.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.DataGridNet.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGridNet.SelectionBackColor = System.Drawing.Color.Wheat
        Me.DataGridNet.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridNet.Size = New System.Drawing.Size(468, 133)
        Me.DataGridNet.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.DataGridNet, "Select record by click on the left panel of the grid")
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(324, 153)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "Update")
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(405, 153)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(169, 153)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "Print This"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmNetworks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 187)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridNet)
        Me.Controls.Add(Me.btnDel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNetworks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Network Accounts"
        CType(Me.DataGridNet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents DataGridNet As System.Windows.Forms.DataGrid
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
