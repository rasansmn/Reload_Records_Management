<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReloads
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReloads))
        Me.DataGridRld = New System.Windows.Forms.DataGrid
        Me.btnToday = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cmbLookin = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnDeliver = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button
        CType(Me.DataGridRld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridRld
        '
        Me.DataGridRld.AlternatingBackColor = System.Drawing.Color.White
        Me.DataGridRld.BackColor = System.Drawing.Color.White
        Me.DataGridRld.BackgroundColor = System.Drawing.Color.Ivory
        Me.DataGridRld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGridRld.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridRld.CaptionForeColor = System.Drawing.Color.Lavender
        Me.DataGridRld.DataMember = ""
        Me.DataGridRld.FlatMode = True
        Me.DataGridRld.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridRld.ForeColor = System.Drawing.Color.Black
        Me.DataGridRld.GridLineColor = System.Drawing.Color.Wheat
        Me.DataGridRld.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridRld.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridRld.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGridRld.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridRld.Location = New System.Drawing.Point(12, 42)
        Me.DataGridRld.Name = "DataGridRld"
        Me.DataGridRld.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.DataGridRld.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGridRld.SelectionBackColor = System.Drawing.Color.Wheat
        Me.DataGridRld.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridRld.Size = New System.Drawing.Size(648, 315)
        Me.DataGridRld.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DataGridRld, "Select record by click on the left panel of the grid")
        '
        'btnToday
        '
        Me.btnToday.Location = New System.Drawing.Point(23, 13)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(75, 23)
        Me.btnToday.TabIndex = 1
        Me.btnToday.Text = "Today"
        Me.ToolTip1.SetToolTip(Me.btnToday, "Filter today")
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(104, 14)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.DateTimePicker1, "Date")
        '
        'cmbLookin
        '
        Me.cmbLookin.FormattingEnabled = True
        Me.cmbLookin.Items.AddRange(New Object() {"Reload ID", "Number", "Price", "Date", "Time", "Network", "Account Balance", "Status"})
        Me.cmbLookin.Location = New System.Drawing.Point(419, 15)
        Me.cmbLookin.Name = "cmbLookin"
        Me.cmbLookin.Size = New System.Drawing.Size(121, 21)
        Me.cmbLookin.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.cmbLookin, "Select look in field")
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(546, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(114, 20)
        Me.txtSearch.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtSearch, "Search text")
        '
        'btnDeliver
        '
        Me.btnDeliver.Enabled = False
        Me.btnDeliver.Location = New System.Drawing.Point(556, 366)
        Me.btnDeliver.Name = "btnDeliver"
        Me.btnDeliver.Size = New System.Drawing.Size(104, 23)
        Me.btnDeliver.TabIndex = 6
        Me.btnDeliver.Text = "Set As Delivered"
        Me.ToolTip1.SetToolTip(Me.btnDeliver, "Set as delivered")
        Me.btnDeliver.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Enabled = False
        Me.btnDel.ForeColor = System.Drawing.Color.Firebrick
        Me.btnDel.Location = New System.Drawing.Point(475, 366)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 7
        Me.btnDel.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.btnDel, "Delete")
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Look in:"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(394, 366)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print This"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmReloads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 402)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnDeliver)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbLookin)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnToday)
        Me.Controls.Add(Me.DataGridRld)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReloads"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reloads"
        CType(Me.DataGridRld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridRld As System.Windows.Forms.DataGrid
    Friend WithEvents btnToday As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbLookin As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnDeliver As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
