<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumbers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNumbers))
        Me.DataGridNum = New System.Windows.Forms.DataGrid
        Me.btnDel = New System.Windows.Forms.Button
        Me.cmbLookin = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnAll = New System.Windows.Forms.Button
        CType(Me.DataGridNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridNum
        '
        Me.DataGridNum.AlternatingBackColor = System.Drawing.Color.White
        Me.DataGridNum.BackColor = System.Drawing.Color.White
        Me.DataGridNum.BackgroundColor = System.Drawing.Color.Ivory
        Me.DataGridNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGridNum.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridNum.CaptionForeColor = System.Drawing.Color.Lavender
        Me.DataGridNum.DataMember = ""
        Me.DataGridNum.FlatMode = True
        Me.DataGridNum.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridNum.ForeColor = System.Drawing.Color.Black
        Me.DataGridNum.GridLineColor = System.Drawing.Color.Wheat
        Me.DataGridNum.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridNum.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridNum.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGridNum.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridNum.Location = New System.Drawing.Point(14, 39)
        Me.DataGridNum.Name = "DataGridNum"
        Me.DataGridNum.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.DataGridNum.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGridNum.SelectionBackColor = System.Drawing.Color.Wheat
        Me.DataGridNum.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridNum.Size = New System.Drawing.Size(418, 230)
        Me.DataGridNum.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DataGridNum, "Select record by click on the left panel of the grid")
        '
        'btnDel
        '
        Me.btnDel.Enabled = False
        Me.btnDel.ForeColor = System.Drawing.Color.Firebrick
        Me.btnDel.Location = New System.Drawing.Point(358, 275)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 1
        Me.btnDel.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.btnDel, "Delete")
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'cmbLookin
        '
        Me.cmbLookin.FormattingEnabled = True
        Me.cmbLookin.Items.AddRange(New Object() {"Number ID", "Number", "Terms", "Last Reload", "Network"})
        Me.cmbLookin.Location = New System.Drawing.Point(203, 13)
        Me.cmbLookin.Name = "cmbLookin"
        Me.cmbLookin.Size = New System.Drawing.Size(121, 21)
        Me.cmbLookin.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cmbLookin, "Select look in field")
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(330, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtSearch, "Search text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Look in:"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(277, 275)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print This"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(25, 11)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(75, 23)
        Me.btnAll.TabIndex = 6
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'frmNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 310)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbLookin)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.DataGridNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNumbers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Numbers"
        CType(Me.DataGridNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridNum As System.Windows.Forms.DataGrid
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents cmbLookin As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
End Class
