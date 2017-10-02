<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtRs = New System.Windows.Forms.TextBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkDelivered = New System.Windows.Forms.CheckBox
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataGridRld = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridAcc = New System.Windows.Forms.DataGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCts = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.rdo100 = New System.Windows.Forms.RadioButton
        Me.rdo50 = New System.Windows.Forms.RadioButton
        Me.cmbNumber = New System.Windows.Forms.ComboBox
        Me.DatePicker = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnDeliver = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridRld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRs
        '
        Me.txtRs.Location = New System.Drawing.Point(87, 64)
        Me.txtRs.Name = "txtRs"
        Me.txtRs.Size = New System.Drawing.Size(112, 20)
        Me.txtRs.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtRs, "Ruppees")
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(258, 189)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.btnSubmit, "Add")
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Price:"
        '
        'chkDelivered
        '
        Me.chkDelivered.AutoSize = True
        Me.chkDelivered.Location = New System.Drawing.Point(64, 118)
        Me.chkDelivered.Name = "chkDelivered"
        Me.chkDelivered.Size = New System.Drawing.Size(71, 17)
        Me.chkDelivered.TabIndex = 5
        Me.chkDelivered.Text = "Delivered"
        Me.ToolTip1.SetToolTip(Me.chkDelivered, "Reload delivery status")
        Me.chkDelivered.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(254, 91)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(68, 20)
        Me.txtTime.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtTime, "Time(click to edit)")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Time:"
        '
        'DataGridRld
        '
        Me.DataGridRld.AlternatingBackColor = System.Drawing.Color.White
        Me.DataGridRld.BackColor = System.Drawing.Color.White
        Me.DataGridRld.BackgroundColor = System.Drawing.Color.Ivory
        Me.DataGridRld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGridRld.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridRld.CaptionForeColor = System.Drawing.Color.Lavender
        Me.DataGridRld.CaptionText = "All Reloads"
        Me.DataGridRld.DataMember = ""
        Me.DataGridRld.FlatMode = True
        Me.DataGridRld.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridRld.ForeColor = System.Drawing.Color.Black
        Me.DataGridRld.GridLineColor = System.Drawing.Color.Wheat
        Me.DataGridRld.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridRld.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridRld.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGridRld.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridRld.Location = New System.Drawing.Point(14, 21)
        Me.DataGridRld.Name = "DataGridRld"
        Me.DataGridRld.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.DataGridRld.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGridRld.SelectionBackColor = System.Drawing.Color.Wheat
        Me.DataGridRld.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridRld.Size = New System.Drawing.Size(655, 216)
        Me.DataGridRld.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.DataGridRld, "Select record by click on the left panel of the grid")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.DataGridAcc)
        Me.GroupBox1.Location = New System.Drawing.Point(358, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 163)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Balance"
        '
        'DataGridAcc
        '
        Me.DataGridAcc.AlternatingBackColor = System.Drawing.Color.White
        Me.DataGridAcc.BackColor = System.Drawing.Color.White
        Me.DataGridAcc.BackgroundColor = System.Drawing.Color.Ivory
        Me.DataGridAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGridAcc.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridAcc.CaptionForeColor = System.Drawing.Color.Lavender
        Me.DataGridAcc.CaptionText = "Account Balance"
        Me.DataGridAcc.DataMember = ""
        Me.DataGridAcc.FlatMode = True
        Me.DataGridAcc.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridAcc.ForeColor = System.Drawing.Color.Black
        Me.DataGridAcc.GridLineColor = System.Drawing.Color.Wheat
        Me.DataGridAcc.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridAcc.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridAcc.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGridAcc.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridAcc.Location = New System.Drawing.Point(13, 21)
        Me.DataGridAcc.Name = "DataGridAcc"
        Me.DataGridAcc.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.DataGridAcc.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGridAcc.SelectionBackColor = System.Drawing.Color.Wheat
        Me.DataGridAcc.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridAcc.Size = New System.Drawing.Size(311, 129)
        Me.DataGridAcc.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.DataGridAcc, "Networks")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.txtCts)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rdo100)
        Me.GroupBox2.Controls.Add(Me.rdo50)
        Me.GroupBox2.Controls.Add(Me.cmbNumber)
        Me.GroupBox2.Controls.Add(Me.DatePicker)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtRs)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtTime)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkDelivered)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 163)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Reload"
        '
        'txtCts
        '
        Me.txtCts.Location = New System.Drawing.Point(231, 64)
        Me.txtCts.Name = "txtCts"
        Me.txtCts.Size = New System.Drawing.Size(91, 20)
        Me.txtCts.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.txtCts, "Cents")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cts."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Rs."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Or"
        '
        'rdo100
        '
        Me.rdo100.AutoSize = True
        Me.rdo100.Location = New System.Drawing.Point(120, 45)
        Me.rdo100.Name = "rdo100"
        Me.rdo100.Size = New System.Drawing.Size(58, 17)
        Me.rdo100.TabIndex = 12
        Me.rdo100.TabStop = True
        Me.rdo100.Text = "100.00"
        Me.ToolTip1.SetToolTip(Me.rdo100, "100")
        Me.rdo100.UseVisualStyleBackColor = True
        '
        'rdo50
        '
        Me.rdo50.AutoSize = True
        Me.rdo50.Checked = True
        Me.rdo50.Location = New System.Drawing.Point(64, 45)
        Me.rdo50.Name = "rdo50"
        Me.rdo50.Size = New System.Drawing.Size(52, 17)
        Me.rdo50.TabIndex = 11
        Me.rdo50.TabStop = True
        Me.rdo50.Text = "50.00"
        Me.ToolTip1.SetToolTip(Me.rdo50, "50")
        Me.rdo50.UseVisualStyleBackColor = True
        '
        'cmbNumber
        '
        Me.cmbNumber.FormattingEnabled = True
        Me.cmbNumber.Location = New System.Drawing.Point(64, 20)
        Me.cmbNumber.MaxLength = 9
        Me.cmbNumber.Name = "cmbNumber"
        Me.cmbNumber.Size = New System.Drawing.Size(258, 21)
        Me.cmbNumber.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.cmbNumber, "Phone number in 9 charactors")
        '
        'DatePicker
        '
        Me.DatePicker.Location = New System.Drawing.Point(64, 91)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(184, 20)
        Me.DatePicker.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.DatePicker, "Date")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(577, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Networks..."
        Me.ToolTip1.SetToolTip(Me.Button1, "Networks window")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.DataGridRld)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 213)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(682, 251)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "All Reloads"
        '
        'btnDeliver
        '
        Me.btnDeliver.Enabled = False
        Me.btnDeliver.Location = New System.Drawing.Point(588, 478)
        Me.btnDeliver.Name = "btnDeliver"
        Me.btnDeliver.Size = New System.Drawing.Size(94, 23)
        Me.btnDeliver.TabIndex = 14
        Me.btnDeliver.Text = "Set As Delivered"
        Me.ToolTip1.SetToolTip(Me.btnDeliver, "Set as delivered")
        Me.btnDeliver.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(707, 513)
        Me.Controls.Add(Me.btnDeliver)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSubmit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Reload"
        CType(Me.DataGridRld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridAcc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRs As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkDelivered As System.Windows.Forms.CheckBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridRld As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridAcc As System.Windows.Forms.DataGrid
    Friend WithEvents cmbNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdo100 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo50 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCts As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeliver As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
