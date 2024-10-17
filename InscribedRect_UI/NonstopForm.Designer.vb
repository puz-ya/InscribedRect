<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NonstopForm
	Inherits ProcItemForm.ProcItemForm

	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	Private components As System.ComponentModel.IContainer

	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NonstopForm))
		Me.btnOK = New FZ_CustomControl.ImageButton
		Me.btnCancel = New FZ_CustomControl.ImageButton
		Me.tsbNonstop = New FZ_CustomControl.TabSwitchButtons
		Me.tcNonstop = New System.Windows.Forms.TabControl
		Me.tabMenu1 = New System.Windows.Forms.TabPage
		Me.GroupPanel1 = New FZ_CustomControl.GroupPanel
		Me.tcNonstop.SuspendLayout()
		Me.tabMenu1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnOK
		'
		Me.btnOK.BorderColor = System.Drawing.Color.Empty
		Me.btnOK.ButtonStyle = FZ_CustomControl.ButtonStyle.Push
		Me.btnOK.DropDownMenu = Nothing
		Me.btnOK.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!, System.Drawing.FontStyle.Regular)
		Me.btnOK.Icon = Nothing
		Me.btnOK.IconDisabled = Nothing
		Me.btnOK.ImageDisabled = CType(resources.GetObject("btnOK.ImageDisabled"), System.Drawing.Image)
		Me.btnOK.ImageEnabledOFF = CType(resources.GetObject("btnOK.ImageEnabledOFF"), System.Drawing.Image)
		Me.btnOK.ImageEnabledON = CType(resources.GetObject("btnOK.ImageEnabledON"), System.Drawing.Image)
		Me.btnOK.Location = New System.Drawing.Point(223, 491)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(80, 40)
		Me.btnOK.TabIndex = 0
		Me.btnOK.Text = "OK"
		Me.btnOK.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnOK.TransparentBackground = False
		'
		'btnCancel
		'
		Me.btnCancel.BorderColor = System.Drawing.Color.Empty
		Me.btnCancel.ButtonStyle = FZ_CustomControl.ButtonStyle.Push
		Me.btnCancel.DropDownMenu = Nothing
		Me.btnCancel.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!, System.Drawing.FontStyle.Regular)
		Me.btnCancel.Icon = Nothing
		Me.btnCancel.IconDisabled = Nothing
		Me.btnCancel.ImageDisabled = CType(resources.GetObject("btnCancel.ImageDisabled"), System.Drawing.Image)
		Me.btnCancel.ImageEnabledOFF = CType(resources.GetObject("btnCancel.ImageEnabledOFF"), System.Drawing.Image)
		Me.btnCancel.ImageEnabledON = CType(resources.GetObject("btnCancel.ImageEnabledON"), System.Drawing.Image)
		Me.btnCancel.Location = New System.Drawing.Point(309, 491)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(80, 40)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnCancel.TransparentBackground = False
		'
		'tsbNonstop
		'
		Me.tsbNonstop.ButtonImageDisabled = CType(resources.GetObject("tsbNonstop.ButtonImageDisabled"), System.Drawing.Image)
		Me.tsbNonstop.ButtonImageOFF = CType(resources.GetObject("tsbNonstop.ButtonImageOFF"), System.Drawing.Image)
		Me.tsbNonstop.ButtonImageON = CType(resources.GetObject("tsbNonstop.ButtonImageON"), System.Drawing.Image)
		Me.tsbNonstop.ButtonWidth = 120
		Me.tsbNonstop.Location = New System.Drawing.Point(0, 0)
		Me.tsbNonstop.Name = "tsbNonstop"
		Me.tsbNonstop.Size = New System.Drawing.Size(400, 40)
		Me.tsbNonstop.TabControl = Nothing
		Me.tsbNonstop.TabIndex = 2
		'
		'tcNonstop
		'
		Me.tcNonstop.Controls.Add(Me.tabMenu1)
		Me.tcNonstop.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!, System.Drawing.FontStyle.Regular)
		Me.tcNonstop.Location = New System.Drawing.Point(0, 16)
		Me.tcNonstop.Name = "tcNonstop"
		Me.tcNonstop.SelectedIndex = 0
		Me.tcNonstop.Size = New System.Drawing.Size(400, 560)
		Me.tcNonstop.TabIndex = 3
		'
		'tabMenu1
		'
		Me.tabMenu1.Controls.Add(Me.GroupPanel1)
		Me.tabMenu1.Controls.Add(Me.btnOK)
		Me.tabMenu1.Controls.Add(Me.btnCancel)
		Me.tabMenu1.Location = New System.Drawing.Point(4, 22)
		Me.tabMenu1.Name = "tabMenu1"
		Me.tabMenu1.Size = New System.Drawing.Size(392, 534)
		Me.tabMenu1.Text = "Menu1"
		'
		'GroupPanel1
		'
		Me.GroupPanel1.FrameColor = System.Drawing.Color.RoyalBlue
		Me.GroupPanel1.FrameWidth = 2
		Me.GroupPanel1.Location = New System.Drawing.Point(3, 8)
		Me.GroupPanel1.Name = "GroupPanel1"
		Me.GroupPanel1.Size = New System.Drawing.Size(386, 250)
		Me.GroupPanel1.TitleColor = System.Drawing.Color.Black
		Me.GroupPanel1.TitleFont = New System.Drawing.Font("ＭＳ ゴシック", 10.0!, System.Drawing.FontStyle.Regular)
		Me.GroupPanel1.TitleText = ""
		Me.GroupPanel1.TransparentBackground = False
		'
		'NonstopForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(398, 575)
		Me.ControlBox = False
		Me.Controls.Add(Me.tcNonstop)
		Me.Controls.Add(Me.tsbNonstop)
		Me.Location = New System.Drawing.Point(312, 84)
		Me.Name = "NonstopForm"
		Me.tcNonstop.ResumeLayout(False)
		Me.tabMenu1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnOK As FZ_CustomControl.ImageButton
	Friend WithEvents btnCancel As FZ_CustomControl.ImageButton
	Friend WithEvents tsbNonstop As FZ_CustomControl.TabSwitchButtons
	Friend WithEvents tcNonstop As System.Windows.Forms.TabControl
	Friend WithEvents tabMenu1 As System.Windows.Forms.TabPage
	Friend WithEvents GroupPanel1 As FZ_CustomControl.GroupPanel

End Class

