<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUberSubwayOrBus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboTransportationMethod = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCommuteCostDisplay = New System.Windows.Forms.Label()
        Me.lblValidinputs = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTransportationMethod
        '
        Me.cboTransportationMethod.FormattingEnabled = True
        Me.cboTransportationMethod.Items.AddRange(New Object() {"Uber", "Subway", "Bus"})
        Me.cboTransportationMethod.Location = New System.Drawing.Point(450, 190)
        Me.cboTransportationMethod.Name = "cboTransportationMethod"
        Me.cboTransportationMethod.Size = New System.Drawing.Size(156, 28)
        Me.cboTransportationMethod.TabIndex = 0
        Me.cboTransportationMethod.Text = "Type of Transport"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(368, 62)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(317, 34)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Uber, Subway, or Bus"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblInstructions.Location = New System.Drawing.Point(369, 114)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(319, 57)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "To calculate yearly commute cost select " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mode of transportation, and enter the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "requested information. Then click Calculate."
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Goldenrod
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculate.Location = New System.Drawing.Point(478, 315)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 49)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Goldenrod
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 36)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 32)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblCommuteCostDisplay
        '
        Me.lblCommuteCostDisplay.AutoSize = True
        Me.lblCommuteCostDisplay.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCommuteCostDisplay.Location = New System.Drawing.Point(316, 368)
        Me.lblCommuteCostDisplay.Name = "lblCommuteCostDisplay"
        Me.lblCommuteCostDisplay.Size = New System.Drawing.Size(410, 24)
        Me.lblCommuteCostDisplay.TabIndex = 5
        Me.lblCommuteCostDisplay.Text = "Your yearly commute cost is, $XXXX.XX"
        Me.lblCommuteCostDisplay.Visible = False
        '
        'lblValidinputs
        '
        Me.lblValidinputs.AutoSize = True
        Me.lblValidinputs.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblValidinputs.Location = New System.Drawing.Point(345, 263)
        Me.lblValidinputs.Name = "lblValidinputs"
        Me.lblValidinputs.Size = New System.Drawing.Size(367, 36)
        Me.lblValidinputs.TabIndex = 6
        Me.lblValidinputs.Text = "Acceptable range for Price Per Day: $1 - $59.99" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Acceptable range for Days In a M" &
    "onth: 1 - 30"
        '
        'frmUberSubwayOrBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.BackgroundImage = Global.UberSubwayOrBusProgram.My.Resources.Resources.crop3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 449)
        Me.Controls.Add(Me.lblValidinputs)
        Me.Controls.Add(Me.lblCommuteCostDisplay)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cboTransportationMethod)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUberSubwayOrBus"
        Me.Text = "Uber, Subway, or Bus"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboTransportationMethod As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCommuteCostDisplay As Label
    Friend WithEvents lblValidinputs As Label
End Class
