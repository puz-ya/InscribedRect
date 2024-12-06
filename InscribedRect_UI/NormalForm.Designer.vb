<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NormalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NormalForm))
        Me.tsbNormal = New FZ_CustomControl.TabSwitchButtons()
        Me.tabOutputParameter = New System.Windows.Forms.TabPage()
        Me.grpTotalJudge = New FZ_CustomControl.GroupPanel()
        Me.rdoUndo = New FZ_CustomControl.RadioButtonEx()
        Me.rdoDo = New FZ_CustomControl.RadioButtonEx()
        Me.coordinateSet = New FZ_CustomControl.CoordinateSetControl()
        Me.tcNormal = New System.Windows.Forms.TabControl()
        Me.tabRegion = New System.Windows.Forms.TabPage()
        Me.grpMouseCoordinates = New FZ_CustomControl.GroupPanel()
        Me.lblSetupImageWindowPixelColor = New FZ_CustomControl.LabelEx()
        Me.lblSetupImageWindowHSV = New FZ_CustomControl.LabelEx()
        Me.lblSetupImageDescriptHSV = New FZ_CustomControl.LabelEx()
        Me.lblSetupImageWindowRGB = New FZ_CustomControl.LabelEx()
        Me.lblSetupImageDescriptRGB = New FZ_CustomControl.LabelEx()
        Me.lblSetupImageWindowXY = New FZ_CustomControl.LabelEx()
        Me.lblSetupImageDescriptXY = New FZ_CustomControl.LabelEx()
        Me.btnHelp = New FZ_CustomControl.ImageButton()
        Me.btnCancel = New FZ_CustomControl.ImageButton()
        Me.btnOK = New FZ_CustomControl.ImageButton()
        Me.fscRegion = New FZ_CustomControl.FigureSetControl()
        Me.imgMain = New FZ_CustomControl.SetupImageWindow()
        Me.ZoomMain = New FZ_CustomControl.ZoomBrowser()
        Me.tabMeasure = New System.Windows.Forms.TabPage()
        Me.grpSlices = New FZ_CustomControl.GroupPanel()
        Me.lblSlicesWidth = New System.Windows.Forms.Label()
        Me.nmbSlicesWidth = New FZ_CustomControl.NumericBox()
        Me.lblSlicesHeight = New System.Windows.Forms.Label()
        Me.nmbSlicesHeight = New FZ_CustomControl.NumericBox()
        Me.lblSlicesCols = New System.Windows.Forms.Label()
        Me.nmbSlicesCols = New FZ_CustomControl.NumericBox()
        Me.chbSlicesEnable = New FZ_CustomControl.CheckBoxEx()
        Me.lblSlicesType = New System.Windows.Forms.Label()
        Me.cmbSlicesType = New FZ_CustomControl.ComboBoxEx()
        Me.lblSlicesRows = New System.Windows.Forms.Label()
        Me.nmbSlicesRows = New FZ_CustomControl.NumericBox()
        Me.grp_mode01 = New FZ_CustomControl.GroupPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nmb_mode01_angle_skip = New FZ_CustomControl.NumericBox()
        Me.grp_mode02 = New FZ_CustomControl.GroupPanel()
        Me.nmb_mode02_scale_step = New FZ_CustomControl.NumericBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nmb_mode02_angle_skip = New FZ_CustomControl.NumericBox()
        Me.btnMeasure = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_mode = New FZ_CustomControl.ComboBoxEx()
        Me.GroupPanel1 = New FZ_CustomControl.GroupPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_edge0 = New FZ_CustomControl.ComboBoxEx()
        Me.cmb_edge1 = New FZ_CustomControl.ComboBoxEx()
        Me.cmb_edge2 = New FZ_CustomControl.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_edge3 = New FZ_CustomControl.ComboBoxEx()
        Me.sls_angle = New FZ_CustomControl.SliderSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.colorSet = New FZ_CustomControl.ColorSetControl()
        Me.cbColorSpecification = New FZ_CustomControl.CheckBoxEx()
        Me.LabelEx3 = New FZ_CustomControl.LabelEx()
        Me.rdoColorIN = New FZ_CustomControl.RadioButtonEx()
        Me.rdoColorOUT = New FZ_CustomControl.RadioButtonEx()
        Me.stdsetReference = New FZ_CustomControl.StandardSet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tabOutputParameter.SuspendLayout()
        Me.grpTotalJudge.SuspendLayout()
        Me.tcNormal.SuspendLayout()
        Me.tabRegion.SuspendLayout()
        Me.grpMouseCoordinates.SuspendLayout()
        Me.tabMeasure.SuspendLayout()
        Me.grpSlices.SuspendLayout()
        Me.grp_mode01.SuspendLayout()
        Me.grp_mode02.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbNormal
        '
        Me.tsbNormal.ButtonImageDisabled = CType(resources.GetObject("tsbNormal.ButtonImageDisabled"), System.Drawing.Image)
        Me.tsbNormal.ButtonImageOFF = CType(resources.GetObject("tsbNormal.ButtonImageOFF"), System.Drawing.Image)
        Me.tsbNormal.ButtonImageON = CType(resources.GetObject("tsbNormal.ButtonImageON"), System.Drawing.Image)
        Me.tsbNormal.Location = New System.Drawing.Point(0, 0)
        Me.tsbNormal.Name = "tsbNormal"
        Me.tsbNormal.Size = New System.Drawing.Size(1024, 40)
        Me.tsbNormal.TabControl = Nothing
        Me.tsbNormal.TabIndex = 0
        '
        'tabOutputParameter
        '
        Me.tabOutputParameter.BackColor = System.Drawing.SystemColors.Control
        Me.tabOutputParameter.Controls.Add(Me.grpTotalJudge)
        Me.tabOutputParameter.Controls.Add(Me.coordinateSet)
        Me.tabOutputParameter.Location = New System.Drawing.Point(4, 23)
        Me.tabOutputParameter.Name = "tabOutputParameter"
        Me.tabOutputParameter.Size = New System.Drawing.Size(1016, 701)
        Me.tabOutputParameter.TabIndex = 5
        Me.tabOutputParameter.Text = "Output parameter"
        '
        'grpTotalJudge
        '
        Me.grpTotalJudge.Controls.Add(Me.rdoUndo)
        Me.grpTotalJudge.Controls.Add(Me.rdoDo)
        Me.grpTotalJudge.FrameColor = System.Drawing.Color.RoyalBlue
        Me.grpTotalJudge.FrameWidth = 2
        Me.grpTotalJudge.Location = New System.Drawing.Point(12, 159)
        Me.grpTotalJudge.Name = "grpTotalJudge"
        Me.grpTotalJudge.Size = New System.Drawing.Size(341, 74)
        Me.grpTotalJudge.TabIndex = 0
        Me.grpTotalJudge.TextIdent = ""
        Me.grpTotalJudge.TitleColor = System.Drawing.Color.Black
        Me.grpTotalJudge.TitleFont = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.grpTotalJudge.TitleText = "Reflect to overall judgement"
        Me.grpTotalJudge.TransparentBackground = False
        '
        'rdoUndo
        '
        Me.rdoUndo.DataIdent = "overallJudge"
        Me.rdoUndo.DataType = FZ_CustomControl.DATATYPE.UnitData
        Me.rdoUndo.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.rdoUndo.Location = New System.Drawing.Point(199, 34)
        Me.rdoUndo.Name = "rdoUndo"
        Me.rdoUndo.RefreshWindow = Nothing
        Me.rdoUndo.Size = New System.Drawing.Size(71, 18)
        Me.rdoUndo.TabIndex = 21
        Me.rdoUndo.Text = "OFF"
        Me.rdoUndo.TextIdent = ""
        Me.rdoUndo.TransparentBackground = True
        Me.rdoUndo.UnitNo = -1
        Me.rdoUndo.Value = 1
        '
        'rdoDo
        '
        Me.rdoDo.Checked = True
        Me.rdoDo.DataIdent = "overallJudge"
        Me.rdoDo.DataType = FZ_CustomControl.DATATYPE.UnitData
        Me.rdoDo.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.rdoDo.Location = New System.Drawing.Point(15, 34)
        Me.rdoDo.Name = "rdoDo"
        Me.rdoDo.RefreshWindow = Nothing
        Me.rdoDo.Size = New System.Drawing.Size(52, 18)
        Me.rdoDo.TabIndex = 20
        Me.rdoDo.TabStop = True
        Me.rdoDo.Text = "ON"
        Me.rdoDo.TextIdent = ""
        Me.rdoDo.TransparentBackground = True
        Me.rdoDo.UnitNo = -1
        Me.rdoDo.Value = 0
        '
        'coordinateSet
        '
        Me.coordinateSet.BackColor = System.Drawing.SystemColors.Control
        Me.coordinateSet.CalibrationMode = 0
        Me.coordinateSet.CalibrationModeSupport = False
        Me.coordinateSet.CoordinateData = 0
        Me.coordinateSet.DataIdent = ""
        Me.coordinateSet.DataIdentCalibrationMode = "calibration"
        Me.coordinateSet.DataIdentPositionMode = "outputCoordinate"
        Me.coordinateSet.DataType = FZ_CustomControl.DATATYPE.UnitData
        Me.coordinateSet.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.coordinateSet.Location = New System.Drawing.Point(12, 8)
        Me.coordinateSet.Name = "coordinateSet"
        Me.coordinateSet.RefreshWindow = Nothing
        Me.coordinateSet.ScrollMode = 0
        Me.coordinateSet.ScrollModeSupport = False
        Me.coordinateSet.Size = New System.Drawing.Size(341, 145)
        Me.coordinateSet.StopChangeEvent = True
        Me.coordinateSet.TabIndex = 16
        Me.coordinateSet.TextIdent = ""
        Me.coordinateSet.TransparentBackground = True
        Me.coordinateSet.UnitNo = -1
        '
        'tcNormal
        '
        Me.tcNormal.Controls.Add(Me.tabRegion)
        Me.tcNormal.Controls.Add(Me.tabMeasure)
        Me.tcNormal.Controls.Add(Me.tabOutputParameter)
        Me.tcNormal.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.tcNormal.Location = New System.Drawing.Point(0, 16)
        Me.tcNormal.Name = "tcNormal"
        Me.tcNormal.SelectedIndex = 0
        Me.tcNormal.Size = New System.Drawing.Size(1024, 728)
        Me.tcNormal.TabIndex = 1
        '
        'tabRegion
        '
        Me.tabRegion.BackColor = System.Drawing.SystemColors.Control
        Me.tabRegion.Controls.Add(Me.Label13)
        Me.tabRegion.Controls.Add(Me.Label10)
        Me.tabRegion.Controls.Add(Me.grpMouseCoordinates)
        Me.tabRegion.Controls.Add(Me.btnHelp)
        Me.tabRegion.Controls.Add(Me.btnCancel)
        Me.tabRegion.Controls.Add(Me.btnOK)
        Me.tabRegion.Controls.Add(Me.fscRegion)
        Me.tabRegion.Controls.Add(Me.imgMain)
        Me.tabRegion.Controls.Add(Me.ZoomMain)
        Me.tabRegion.Location = New System.Drawing.Point(4, 23)
        Me.tabRegion.Name = "tabRegion"
        Me.tabRegion.Size = New System.Drawing.Size(1016, 701)
        Me.tabRegion.TabIndex = 6
        Me.tabRegion.Text = "Region"
        '
        'grpMouseCoordinates
        '
        Me.grpMouseCoordinates.Controls.Add(Me.lblSetupImageWindowPixelColor)
        Me.grpMouseCoordinates.Controls.Add(Me.lblSetupImageWindowHSV)
        Me.grpMouseCoordinates.Controls.Add(Me.lblSetupImageDescriptHSV)
        Me.grpMouseCoordinates.Controls.Add(Me.lblSetupImageWindowRGB)
        Me.grpMouseCoordinates.Controls.Add(Me.lblSetupImageDescriptRGB)
        Me.grpMouseCoordinates.Controls.Add(Me.lblSetupImageWindowXY)
        Me.grpMouseCoordinates.Controls.Add(Me.lblSetupImageDescriptXY)
        Me.grpMouseCoordinates.FrameColor = System.Drawing.Color.RoyalBlue
        Me.grpMouseCoordinates.FrameWidth = 2
        Me.grpMouseCoordinates.Location = New System.Drawing.Point(366, 629)
        Me.grpMouseCoordinates.Name = "grpMouseCoordinates"
        Me.grpMouseCoordinates.Size = New System.Drawing.Size(290, 45)
        Me.grpMouseCoordinates.TabIndex = 66
        Me.grpMouseCoordinates.TextIdent = ""
        Me.grpMouseCoordinates.TitleColor = System.Drawing.Color.Black
        Me.grpMouseCoordinates.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grpMouseCoordinates.TitleText = "Coordinates"
        Me.grpMouseCoordinates.TransparentBackground = False
        '
        'lblSetupImageWindowPixelColor
        '
        Me.lblSetupImageWindowPixelColor.BackColor = System.Drawing.SystemColors.Control
        Me.lblSetupImageWindowPixelColor.DataIdent = ""
        Me.lblSetupImageWindowPixelColor.DataType = FZ_CustomControl.DATATYPE.None
        Me.lblSetupImageWindowPixelColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblSetupImageWindowPixelColor.Location = New System.Drawing.Point(151, 14)
        Me.lblSetupImageWindowPixelColor.Name = "lblSetupImageWindowPixelColor"
        Me.lblSetupImageWindowPixelColor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblSetupImageWindowPixelColor.RefreshWindow = Nothing
        Me.lblSetupImageWindowPixelColor.Size = New System.Drawing.Size(24, 24)
        Me.lblSetupImageWindowPixelColor.StopChangeEvent = True
        Me.lblSetupImageWindowPixelColor.TabIndex = 39
        Me.lblSetupImageWindowPixelColor.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSetupImageWindowPixelColor.TextIdent = ""
        Me.lblSetupImageWindowPixelColor.TransparentBackground = False
        Me.lblSetupImageWindowPixelColor.UnitNo = -1
        '
        'lblSetupImageWindowHSV
        '
        Me.lblSetupImageWindowHSV.BackColor = System.Drawing.SystemColors.Control
        Me.lblSetupImageWindowHSV.DataIdent = ""
        Me.lblSetupImageWindowHSV.DataType = FZ_CustomControl.DATATYPE.None
        Me.lblSetupImageWindowHSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblSetupImageWindowHSV.Location = New System.Drawing.Point(210, 26)
        Me.lblSetupImageWindowHSV.Name = "lblSetupImageWindowHSV"
        Me.lblSetupImageWindowHSV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblSetupImageWindowHSV.RefreshWindow = Nothing
        Me.lblSetupImageWindowHSV.Size = New System.Drawing.Size(77, 16)
        Me.lblSetupImageWindowHSV.StopChangeEvent = True
        Me.lblSetupImageWindowHSV.TabIndex = 38
        Me.lblSetupImageWindowHSV.Text = "(359,255,255) "
        Me.lblSetupImageWindowHSV.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSetupImageWindowHSV.TextIdent = ""
        Me.lblSetupImageWindowHSV.TransparentBackground = True
        Me.lblSetupImageWindowHSV.UnitNo = -1
        '
        'lblSetupImageDescriptHSV
        '
        Me.lblSetupImageDescriptHSV.BackColor = System.Drawing.SystemColors.Control
        Me.lblSetupImageDescriptHSV.DataIdent = ""
        Me.lblSetupImageDescriptHSV.DataType = FZ_CustomControl.DATATYPE.None
        Me.lblSetupImageDescriptHSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblSetupImageDescriptHSV.Location = New System.Drawing.Point(179, 26)
        Me.lblSetupImageDescriptHSV.Name = "lblSetupImageDescriptHSV"
        Me.lblSetupImageDescriptHSV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblSetupImageDescriptHSV.RefreshWindow = Nothing
        Me.lblSetupImageDescriptHSV.Size = New System.Drawing.Size(34, 16)
        Me.lblSetupImageDescriptHSV.StopChangeEvent = True
        Me.lblSetupImageDescriptHSV.TabIndex = 37
        Me.lblSetupImageDescriptHSV.Text = "HSV: "
        Me.lblSetupImageDescriptHSV.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSetupImageDescriptHSV.TextIdent = ""
        Me.lblSetupImageDescriptHSV.TransparentBackground = True
        Me.lblSetupImageDescriptHSV.UnitNo = -1
        '
        'lblSetupImageWindowRGB
        '
        Me.lblSetupImageWindowRGB.BackColor = System.Drawing.SystemColors.Control
        Me.lblSetupImageWindowRGB.DataIdent = ""
        Me.lblSetupImageWindowRGB.DataType = FZ_CustomControl.DATATYPE.None
        Me.lblSetupImageWindowRGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblSetupImageWindowRGB.Location = New System.Drawing.Point(210, 13)
        Me.lblSetupImageWindowRGB.Name = "lblSetupImageWindowRGB"
        Me.lblSetupImageWindowRGB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblSetupImageWindowRGB.RefreshWindow = Nothing
        Me.lblSetupImageWindowRGB.Size = New System.Drawing.Size(77, 16)
        Me.lblSetupImageWindowRGB.StopChangeEvent = True
        Me.lblSetupImageWindowRGB.TabIndex = 36
        Me.lblSetupImageWindowRGB.Text = "(255,255,255) "
        Me.lblSetupImageWindowRGB.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSetupImageWindowRGB.TextIdent = ""
        Me.lblSetupImageWindowRGB.TransparentBackground = True
        Me.lblSetupImageWindowRGB.UnitNo = -1
        '
        'lblSetupImageDescriptRGB
        '
        Me.lblSetupImageDescriptRGB.BackColor = System.Drawing.SystemColors.Control
        Me.lblSetupImageDescriptRGB.DataIdent = ""
        Me.lblSetupImageDescriptRGB.DataType = FZ_CustomControl.DATATYPE.None
        Me.lblSetupImageDescriptRGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblSetupImageDescriptRGB.Location = New System.Drawing.Point(179, 13)
        Me.lblSetupImageDescriptRGB.Name = "lblSetupImageDescriptRGB"
        Me.lblSetupImageDescriptRGB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblSetupImageDescriptRGB.RefreshWindow = Nothing
        Me.lblSetupImageDescriptRGB.Size = New System.Drawing.Size(34, 16)
        Me.lblSetupImageDescriptRGB.StopChangeEvent = True
        Me.lblSetupImageDescriptRGB.TabIndex = 35
        Me.lblSetupImageDescriptRGB.Text = "RGB: "
        Me.lblSetupImageDescriptRGB.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSetupImageDescriptRGB.TextIdent = ""
        Me.lblSetupImageDescriptRGB.TransparentBackground = True
        Me.lblSetupImageDescriptRGB.UnitNo = -1
        '
        'lblSetupImageWindowXY
        '
        Me.lblSetupImageWindowXY.BackColor = System.Drawing.SystemColors.Control
        Me.lblSetupImageWindowXY.DataIdent = ""
        Me.lblSetupImageWindowXY.DataType = FZ_CustomControl.DATATYPE.None
        Me.lblSetupImageWindowXY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblSetupImageWindowXY.Location = New System.Drawing.Point(76, 23)
        Me.lblSetupImageWindowXY.Name = "lblSetupImageWindowXY"
        Me.lblSetupImageWindowXY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblSetupImageWindowXY.RefreshWindow = Nothing
        Me.lblSetupImageWindowXY.Size = New System.Drawing.Size(80, 16)
        Me.lblSetupImageWindowXY.StopChangeEvent = True
        Me.lblSetupImageWindowXY.TabIndex = 33
        Me.lblSetupImageWindowXY.Text = "0, 0 px"
        Me.lblSetupImageWindowXY.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSetupImageWindowXY.TextIdent = ""
        Me.lblSetupImageWindowXY.TransparentBackground = True
        Me.lblSetupImageWindowXY.UnitNo = -1
        '
        'lblSetupImageDescriptXY
        '
        Me.lblSetupImageDescriptXY.BackColor = System.Drawing.SystemColors.Control
        Me.lblSetupImageDescriptXY.DataIdent = ""
        Me.lblSetupImageDescriptXY.DataType = FZ_CustomControl.DATATYPE.None
        Me.lblSetupImageDescriptXY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblSetupImageDescriptXY.Location = New System.Drawing.Point(13, 22)
        Me.lblSetupImageDescriptXY.Name = "lblSetupImageDescriptXY"
        Me.lblSetupImageDescriptXY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblSetupImageDescriptXY.RefreshWindow = Nothing
        Me.lblSetupImageDescriptXY.Size = New System.Drawing.Size(70, 16)
        Me.lblSetupImageDescriptXY.StopChangeEvent = True
        Me.lblSetupImageDescriptXY.TabIndex = 29
        Me.lblSetupImageDescriptXY.Text = "Image XY: "
        Me.lblSetupImageDescriptXY.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSetupImageDescriptXY.TextIdent = ""
        Me.lblSetupImageDescriptXY.TransparentBackground = True
        Me.lblSetupImageDescriptXY.UnitNo = -1
        '
        'btnHelp
        '
        Me.btnHelp.BorderColor = System.Drawing.Color.Empty
        Me.btnHelp.ButtonStyle = FZ_CustomControl.ButtonStyle.Push
        Me.btnHelp.DataIdent = ""
        Me.btnHelp.DataType = FZ_CustomControl.DATATYPE.None
        Me.btnHelp.DropDownMenu = Nothing
        Me.btnHelp.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.btnHelp.Icon = Nothing
        Me.btnHelp.IconDisabled = Nothing
        Me.btnHelp.ImageDisabled = CType(resources.GetObject("btnHelp.ImageDisabled"), System.Drawing.Image)
        Me.btnHelp.ImageEnabledOFF = CType(resources.GetObject("btnHelp.ImageEnabledOFF"), System.Drawing.Image)
        Me.btnHelp.ImageEnabledON = CType(resources.GetObject("btnHelp.ImageEnabledON"), System.Drawing.Image)
        Me.btnHelp.Location = New System.Drawing.Point(8, 652)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.RefreshWindow = Nothing
        Me.btnHelp.Size = New System.Drawing.Size(80, 40)
        Me.btnHelp.StopChangeEvent = True
        Me.btnHelp.TabIndex = 24
        Me.btnHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHelp.TextIdent = ""
        Me.btnHelp.TransparentBackground = False
        Me.btnHelp.UnitNo = -1
        '
        'btnCancel
        '
        Me.btnCancel.BorderColor = System.Drawing.Color.Empty
        Me.btnCancel.ButtonStyle = FZ_CustomControl.ButtonStyle.Push
        Me.btnCancel.DataIdent = ""
        Me.btnCancel.DataType = FZ_CustomControl.DATATYPE.None
        Me.btnCancel.DropDownMenu = Nothing
        Me.btnCancel.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.btnCancel.Icon = Nothing
        Me.btnCancel.IconDisabled = Nothing
        Me.btnCancel.ImageDisabled = CType(resources.GetObject("btnCancel.ImageDisabled"), System.Drawing.Image)
        Me.btnCancel.ImageEnabledOFF = CType(resources.GetObject("btnCancel.ImageEnabledOFF"), System.Drawing.Image)
        Me.btnCancel.ImageEnabledON = CType(resources.GetObject("btnCancel.ImageEnabledON"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(292, 652)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RefreshWindow = Nothing
        Me.btnCancel.Size = New System.Drawing.Size(80, 40)
        Me.btnCancel.StopChangeEvent = True
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.TextIdent = ""
        Me.btnCancel.TransparentBackground = False
        Me.btnCancel.UnitNo = -1
        '
        'btnOK
        '
        Me.btnOK.BorderColor = System.Drawing.Color.Empty
        Me.btnOK.ButtonStyle = FZ_CustomControl.ButtonStyle.Push
        Me.btnOK.DataIdent = ""
        Me.btnOK.DataType = FZ_CustomControl.DATATYPE.None
        Me.btnOK.DropDownMenu = Nothing
        Me.btnOK.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.btnOK.Icon = Nothing
        Me.btnOK.IconDisabled = Nothing
        Me.btnOK.ImageDisabled = CType(resources.GetObject("btnOK.ImageDisabled"), System.Drawing.Image)
        Me.btnOK.ImageEnabledOFF = CType(resources.GetObject("btnOK.ImageEnabledOFF"), System.Drawing.Image)
        Me.btnOK.ImageEnabledON = CType(resources.GetObject("btnOK.ImageEnabledON"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(206, 652)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.RefreshWindow = Nothing
        Me.btnOK.Size = New System.Drawing.Size(80, 40)
        Me.btnOK.StopChangeEvent = True
        Me.btnOK.TabIndex = 22
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOK.TextIdent = ""
        Me.btnOK.TransparentBackground = False
        Me.btnOK.UnitNo = -1
        '
        'fscRegion
        '
        Me.fscRegion.CautionMessage = "Please register the figure."
        Me.fscRegion.CautionMessageFont = New System.Drawing.Font("MS Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.fscRegion.CircleMode = 0
        Me.fscRegion.DataIdent = ""
        Me.fscRegion.DataIdentNum_Figure = -1
        Me.fscRegion.DataType = FZ_CustomControl.DATATYPE.None
        Me.fscRegion.DeleteDisable = False
        Me.fscRegion.Enabled = False
        Me.fscRegion.ExclusionMode = True
        Me.fscRegion.FigureKind = 0
        Me.fscRegion.FigureMax = 100
        Me.fscRegion.ImageWindow = Me.imgMain
        Me.fscRegion.LineArrowMode = False
        Me.fscRegion.Location = New System.Drawing.Point(8, 7)
        Me.fscRegion.Name = "fscRegion"
        Me.fscRegion.NotOnlyFigureEnabled = False
        Me.fscRegion.OrNotEnabled = True
        Me.fscRegion.RefreshWindow = Nothing
        Me.fscRegion.SelectedIndex = -1
        Me.fscRegion.Size = New System.Drawing.Size(320, 420)
        Me.fscRegion.StopChangeEvent = True
        Me.fscRegion.TabIndex = 21
        Me.fscRegion.Text = "FigureSetControl1"
        Me.fscRegion.TextIdent = ""
        Me.fscRegion.TransparentBackground = True
        Me.fscRegion.UnitNo = -1
        '
        'imgMain
        '
        Me.imgMain.BackColor = System.Drawing.Color.Black
        Me.imgMain.DrawColor = System.Drawing.Color.Green
        Me.imgMain.DrawWidth = 2
        Me.imgMain.FrameColor = System.Drawing.Color.LightBlue
        Me.imgMain.FrameVisible = False
        Me.imgMain.FrameWidth = CType(2UI, UInteger)
        Me.imgMain.Image = Nothing
        Me.imgMain.ImageGraphic = Nothing
        Me.imgMain.Location = New System.Drawing.Point(366, 7)
        Me.imgMain.magnification = 1.0R
        Me.imgMain.Name = "imgMain"
        Me.imgMain.origin = New System.Drawing.Point(0, 0)
        Me.imgMain.Size = New System.Drawing.Size(640, 480)
        Me.imgMain.subNo = 0
        Me.imgMain.TabIndex = 19
        Me.imgMain.throughDisp = False
        Me.imgMain.TransparentBackground = True
        Me.imgMain.unitNo = -1
        Me.imgMain.ZoomPosX = 0
        Me.imgMain.ZoomPosY = 0
        Me.imgMain.ZoomRate = 100.0R
        '
        'ZoomMain
        '
        Me.ZoomMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ZoomMain.DataIdent = ""
        Me.ZoomMain.DataType = FZ_CustomControl.DATATYPE.None
        Me.ZoomMain.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.ZoomMain.ImageWindow = Me.imgMain
        Me.ZoomMain.Location = New System.Drawing.Point(366, 493)
        Me.ZoomMain.Name = "ZoomMain"
        Me.ZoomMain.RefreshWindow = Me.imgMain
        Me.ZoomMain.Size = New System.Drawing.Size(290, 130)
        Me.ZoomMain.StopChangeEvent = True
        Me.ZoomMain.TabIndex = 20
        Me.ZoomMain.TextIdent = ""
        Me.ZoomMain.TransparentBackground = True
        Me.ZoomMain.UnitNo = -1
        '
        'tabMeasure
        '
        Me.tabMeasure.BackColor = System.Drawing.SystemColors.Control
        Me.tabMeasure.Controls.Add(Me.Label14)
        Me.tabMeasure.Controls.Add(Me.Label12)
        Me.tabMeasure.Controls.Add(Me.grpSlices)
        Me.tabMeasure.Controls.Add(Me.grp_mode01)
        Me.tabMeasure.Controls.Add(Me.grp_mode02)
        Me.tabMeasure.Controls.Add(Me.btnMeasure)
        Me.tabMeasure.Controls.Add(Me.Label6)
        Me.tabMeasure.Controls.Add(Me.cmb_mode)
        Me.tabMeasure.Controls.Add(Me.GroupPanel1)
        Me.tabMeasure.Controls.Add(Me.sls_angle)
        Me.tabMeasure.Controls.Add(Me.Label7)
        Me.tabMeasure.Location = New System.Drawing.Point(4, 23)
        Me.tabMeasure.Name = "tabMeasure"
        Me.tabMeasure.Size = New System.Drawing.Size(1016, 701)
        Me.tabMeasure.TabIndex = 0
        Me.tabMeasure.Text = "Measurement"
        '
        'grpSlices
        '
        Me.grpSlices.Controls.Add(Me.lblSlicesWidth)
        Me.grpSlices.Controls.Add(Me.nmbSlicesWidth)
        Me.grpSlices.Controls.Add(Me.lblSlicesHeight)
        Me.grpSlices.Controls.Add(Me.nmbSlicesHeight)
        Me.grpSlices.Controls.Add(Me.lblSlicesCols)
        Me.grpSlices.Controls.Add(Me.nmbSlicesCols)
        Me.grpSlices.Controls.Add(Me.chbSlicesEnable)
        Me.grpSlices.Controls.Add(Me.lblSlicesType)
        Me.grpSlices.Controls.Add(Me.cmbSlicesType)
        Me.grpSlices.Controls.Add(Me.lblSlicesRows)
        Me.grpSlices.Controls.Add(Me.nmbSlicesRows)
        Me.grpSlices.FrameColor = System.Drawing.Color.RoyalBlue
        Me.grpSlices.FrameWidth = 2
        Me.grpSlices.Location = New System.Drawing.Point(22, 298)
        Me.grpSlices.Name = "grpSlices"
        Me.grpSlices.Size = New System.Drawing.Size(323, 194)
        Me.grpSlices.TabIndex = 43
        Me.grpSlices.TextIdent = ""
        Me.grpSlices.TitleColor = System.Drawing.Color.Black
        Me.grpSlices.TitleFont = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.grpSlices.TitleText = "Slices"
        Me.grpSlices.TransparentBackground = False
        '
        'lblSlicesWidth
        '
        Me.lblSlicesWidth.AutoSize = True
        Me.lblSlicesWidth.Location = New System.Drawing.Point(40, 162)
        Me.lblSlicesWidth.Name = "lblSlicesWidth"
        Me.lblSlicesWidth.Size = New System.Drawing.Size(49, 14)
        Me.lblSlicesWidth.TabIndex = 50
        Me.lblSlicesWidth.Text = "Width:"
        '
        'nmbSlicesWidth
        '
        Me.nmbSlicesWidth.BackColor = System.Drawing.Color.White
        Me.nmbSlicesWidth.DataIdent = ""
        Me.nmbSlicesWidth.DataType = FZ_CustomControl.DATATYPE.None
        Me.nmbSlicesWidth.DecimalDigits = 0
        Me.nmbSlicesWidth.Enabled = False
        Me.nmbSlicesWidth.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.nmbSlicesWidth.ForeColor = System.Drawing.Color.Black
        Me.nmbSlicesWidth.Location = New System.Drawing.Point(183, 156)
        Me.nmbSlicesWidth.MaxValue = 32767.0R
        Me.nmbSlicesWidth.Measurement = 5.0R
        Me.nmbSlicesWidth.MinValue = 5.0R
        Me.nmbSlicesWidth.Name = "nmbSlicesWidth"
        Me.nmbSlicesWidth.RefreshWindow = Nothing
        Me.nmbSlicesWidth.Size = New System.Drawing.Size(120, 20)
        Me.nmbSlicesWidth.StopChangeEvent = True
        Me.nmbSlicesWidth.TabIndex = 49
        Me.nmbSlicesWidth.Text = "NumericBox3"
        Me.nmbSlicesWidth.TextIdent = ""
        Me.nmbSlicesWidth.TransparentBackground = False
        Me.nmbSlicesWidth.UnitNo = -1
        Me.nmbSlicesWidth.Value = 5.0R
        '
        'lblSlicesHeight
        '
        Me.lblSlicesHeight.AutoSize = True
        Me.lblSlicesHeight.Location = New System.Drawing.Point(40, 136)
        Me.lblSlicesHeight.Name = "lblSlicesHeight"
        Me.lblSlicesHeight.Size = New System.Drawing.Size(56, 14)
        Me.lblSlicesHeight.TabIndex = 48
        Me.lblSlicesHeight.Text = "Height:"
        '
        'nmbSlicesHeight
        '
        Me.nmbSlicesHeight.BackColor = System.Drawing.Color.White
        Me.nmbSlicesHeight.DataIdent = ""
        Me.nmbSlicesHeight.DataType = FZ_CustomControl.DATATYPE.None
        Me.nmbSlicesHeight.DecimalDigits = 0
        Me.nmbSlicesHeight.Enabled = False
        Me.nmbSlicesHeight.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.nmbSlicesHeight.ForeColor = System.Drawing.Color.Black
        Me.nmbSlicesHeight.Location = New System.Drawing.Point(183, 130)
        Me.nmbSlicesHeight.MaxValue = 32767.0R
        Me.nmbSlicesHeight.Measurement = 5.0R
        Me.nmbSlicesHeight.MinValue = 5.0R
        Me.nmbSlicesHeight.Name = "nmbSlicesHeight"
        Me.nmbSlicesHeight.RefreshWindow = Nothing
        Me.nmbSlicesHeight.Size = New System.Drawing.Size(120, 20)
        Me.nmbSlicesHeight.StopChangeEvent = True
        Me.nmbSlicesHeight.TabIndex = 47
        Me.nmbSlicesHeight.Text = "NumericBox1"
        Me.nmbSlicesHeight.TextIdent = ""
        Me.nmbSlicesHeight.TransparentBackground = False
        Me.nmbSlicesHeight.UnitNo = -1
        Me.nmbSlicesHeight.Value = 5.0R
        '
        'lblSlicesCols
        '
        Me.lblSlicesCols.AutoSize = True
        Me.lblSlicesCols.Location = New System.Drawing.Point(40, 110)
        Me.lblSlicesCols.Name = "lblSlicesCols"
        Me.lblSlicesCols.Size = New System.Drawing.Size(63, 14)
        Me.lblSlicesCols.TabIndex = 46
        Me.lblSlicesCols.Text = "Columns:"
        '
        'nmbSlicesCols
        '
        Me.nmbSlicesCols.BackColor = System.Drawing.Color.White
        Me.nmbSlicesCols.DataIdent = ""
        Me.nmbSlicesCols.DataType = FZ_CustomControl.DATATYPE.None
        Me.nmbSlicesCols.DecimalDigits = 0
        Me.nmbSlicesCols.Enabled = False
        Me.nmbSlicesCols.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.nmbSlicesCols.ForeColor = System.Drawing.Color.Black
        Me.nmbSlicesCols.Location = New System.Drawing.Point(183, 104)
        Me.nmbSlicesCols.MaxValue = 1024.0R
        Me.nmbSlicesCols.Measurement = 1.0R
        Me.nmbSlicesCols.MinValue = 1.0R
        Me.nmbSlicesCols.Name = "nmbSlicesCols"
        Me.nmbSlicesCols.RefreshWindow = Nothing
        Me.nmbSlicesCols.Size = New System.Drawing.Size(120, 20)
        Me.nmbSlicesCols.StopChangeEvent = True
        Me.nmbSlicesCols.TabIndex = 45
        Me.nmbSlicesCols.Text = "NumericBox1"
        Me.nmbSlicesCols.TextIdent = ""
        Me.nmbSlicesCols.TransparentBackground = False
        Me.nmbSlicesCols.UnitNo = -1
        Me.nmbSlicesCols.Value = 1.0R
        '
        'chbSlicesEnable
        '
        Me.chbSlicesEnable.AutoSize = True
        Me.chbSlicesEnable.DataIdent = ""
        Me.chbSlicesEnable.DataType = FZ_CustomControl.DATATYPE.None
        Me.chbSlicesEnable.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.chbSlicesEnable.Location = New System.Drawing.Point(14, 30)
        Me.chbSlicesEnable.Name = "chbSlicesEnable"
        Me.chbSlicesEnable.RefreshWindow = Nothing
        Me.chbSlicesEnable.Size = New System.Drawing.Size(68, 18)
        Me.chbSlicesEnable.TabIndex = 44
        Me.chbSlicesEnable.Text = "Enable"
        Me.chbSlicesEnable.TextIdent = ""
        Me.chbSlicesEnable.UnitNo = -1
        Me.chbSlicesEnable.UseVisualStyleBackColor = True
        Me.chbSlicesEnable.ValueOff = 0
        Me.chbSlicesEnable.ValueOn = 1
        '
        'lblSlicesType
        '
        Me.lblSlicesType.Location = New System.Drawing.Point(40, 54)
        Me.lblSlicesType.Name = "lblSlicesType"
        Me.lblSlicesType.Size = New System.Drawing.Size(42, 18)
        Me.lblSlicesType.TabIndex = 42
        Me.lblSlicesType.Text = "Type:"
        '
        'cmbSlicesType
        '
        Me.cmbSlicesType.DataIdent = ""
        Me.cmbSlicesType.DataType = FZ_CustomControl.DATATYPE.None
        Me.cmbSlicesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSlicesType.Enabled = False
        Me.cmbSlicesType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSlicesType.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.cmbSlicesType.FormattingEnabled = True
        Me.cmbSlicesType.Items.AddRange(New Object() {"Cols and rows", "Width and height"})
        Me.cmbSlicesType.Location = New System.Drawing.Point(100, 51)
        Me.cmbSlicesType.Name = "cmbSlicesType"
        Me.cmbSlicesType.RefreshWindow = Nothing
        Me.cmbSlicesType.Size = New System.Drawing.Size(203, 21)
        Me.cmbSlicesType.TabIndex = 43
        Me.cmbSlicesType.UnitNo = -1
        '
        'lblSlicesRows
        '
        Me.lblSlicesRows.AutoSize = True
        Me.lblSlicesRows.Location = New System.Drawing.Point(40, 84)
        Me.lblSlicesRows.Name = "lblSlicesRows"
        Me.lblSlicesRows.Size = New System.Drawing.Size(42, 14)
        Me.lblSlicesRows.TabIndex = 39
        Me.lblSlicesRows.Text = "Rows:"
        '
        'nmbSlicesRows
        '
        Me.nmbSlicesRows.BackColor = System.Drawing.Color.White
        Me.nmbSlicesRows.DataIdent = ""
        Me.nmbSlicesRows.DataType = FZ_CustomControl.DATATYPE.None
        Me.nmbSlicesRows.DecimalDigits = 0
        Me.nmbSlicesRows.Enabled = False
        Me.nmbSlicesRows.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.nmbSlicesRows.ForeColor = System.Drawing.Color.Black
        Me.nmbSlicesRows.Location = New System.Drawing.Point(183, 78)
        Me.nmbSlicesRows.MaxValue = 1024.0R
        Me.nmbSlicesRows.Measurement = 1.0R
        Me.nmbSlicesRows.MinValue = 1.0R
        Me.nmbSlicesRows.Name = "nmbSlicesRows"
        Me.nmbSlicesRows.RefreshWindow = Nothing
        Me.nmbSlicesRows.Size = New System.Drawing.Size(120, 20)
        Me.nmbSlicesRows.StopChangeEvent = True
        Me.nmbSlicesRows.TabIndex = 38
        Me.nmbSlicesRows.Text = "NumericBox1"
        Me.nmbSlicesRows.TextIdent = ""
        Me.nmbSlicesRows.TransparentBackground = False
        Me.nmbSlicesRows.UnitNo = -1
        Me.nmbSlicesRows.Value = 1.0R
        '
        'grp_mode01
        '
        Me.grp_mode01.Controls.Add(Me.Label11)
        Me.grp_mode01.Controls.Add(Me.nmb_mode01_angle_skip)
        Me.grp_mode01.FrameColor = System.Drawing.Color.RoyalBlue
        Me.grp_mode01.FrameWidth = 2
        Me.grp_mode01.Location = New System.Drawing.Point(22, 190)
        Me.grp_mode01.Name = "grp_mode01"
        Me.grp_mode01.Size = New System.Drawing.Size(323, 65)
        Me.grp_mode01.TabIndex = 42
        Me.grp_mode01.TextIdent = ""
        Me.grp_mode01.TitleColor = System.Drawing.Color.Black
        Me.grp_mode01.TitleFont = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.grp_mode01.TitleText = "Mode01"
        Me.grp_mode01.TransparentBackground = False
        Me.grp_mode01.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 14)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Angle skip:"
        '
        'nmb_mode01_angle_skip
        '
        Me.nmb_mode01_angle_skip.BackColor = System.Drawing.Color.White
        Me.nmb_mode01_angle_skip.DataIdent = ""
        Me.nmb_mode01_angle_skip.DataType = FZ_CustomControl.DATATYPE.None
        Me.nmb_mode01_angle_skip.DecimalDigits = 0
        Me.nmb_mode01_angle_skip.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.nmb_mode01_angle_skip.ForeColor = System.Drawing.Color.Black
        Me.nmb_mode01_angle_skip.Location = New System.Drawing.Point(183, 26)
        Me.nmb_mode01_angle_skip.MaxValue = 90.0R
        Me.nmb_mode01_angle_skip.Measurement = 0R
        Me.nmb_mode01_angle_skip.MinValue = 0R
        Me.nmb_mode01_angle_skip.Name = "nmb_mode01_angle_skip"
        Me.nmb_mode01_angle_skip.RefreshWindow = Nothing
        Me.nmb_mode01_angle_skip.Size = New System.Drawing.Size(120, 20)
        Me.nmb_mode01_angle_skip.StopChangeEvent = True
        Me.nmb_mode01_angle_skip.TabIndex = 38
        Me.nmb_mode01_angle_skip.Text = "NumericBox1"
        Me.nmb_mode01_angle_skip.TextIdent = ""
        Me.nmb_mode01_angle_skip.TransparentBackground = False
        Me.nmb_mode01_angle_skip.UnitNo = -1
        Me.nmb_mode01_angle_skip.Value = 0R
        '
        'grp_mode02
        '
        Me.grp_mode02.Controls.Add(Me.nmb_mode02_scale_step)
        Me.grp_mode02.Controls.Add(Me.Label9)
        Me.grp_mode02.Controls.Add(Me.Label8)
        Me.grp_mode02.Controls.Add(Me.nmb_mode02_angle_skip)
        Me.grp_mode02.FrameColor = System.Drawing.Color.RoyalBlue
        Me.grp_mode02.FrameWidth = 2
        Me.grp_mode02.Location = New System.Drawing.Point(351, 190)
        Me.grp_mode02.Name = "grp_mode02"
        Me.grp_mode02.Size = New System.Drawing.Size(323, 100)
        Me.grp_mode02.TabIndex = 39
        Me.grp_mode02.TextIdent = ""
        Me.grp_mode02.TitleColor = System.Drawing.Color.Black
        Me.grp_mode02.TitleFont = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.grp_mode02.TitleText = "Mode02"
        Me.grp_mode02.TransparentBackground = False
        Me.grp_mode02.Visible = False
        '
        'nmb_mode02_scale_step
        '
        Me.nmb_mode02_scale_step.BackColor = System.Drawing.Color.White
        Me.nmb_mode02_scale_step.DataIdent = ""
        Me.nmb_mode02_scale_step.DataType = FZ_CustomControl.DATATYPE.None
        Me.nmb_mode02_scale_step.DecimalDigits = 2
        Me.nmb_mode02_scale_step.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.nmb_mode02_scale_step.ForeColor = System.Drawing.Color.Black
        Me.nmb_mode02_scale_step.Location = New System.Drawing.Point(183, 54)
        Me.nmb_mode02_scale_step.MaxValue = 0.99R
        Me.nmb_mode02_scale_step.Measurement = 0.05R
        Me.nmb_mode02_scale_step.MinValue = 0.01R
        Me.nmb_mode02_scale_step.Name = "nmb_mode02_scale_step"
        Me.nmb_mode02_scale_step.RefreshWindow = Nothing
        Me.nmb_mode02_scale_step.Size = New System.Drawing.Size(120, 20)
        Me.nmb_mode02_scale_step.StopChangeEvent = True
        Me.nmb_mode02_scale_step.TabIndex = 41
        Me.nmb_mode02_scale_step.Text = "NumericBox1"
        Me.nmb_mode02_scale_step.TextIdent = ""
        Me.nmb_mode02_scale_step.TransparentBackground = False
        Me.nmb_mode02_scale_step.UnitNo = -1
        Me.nmb_mode02_scale_step.Value = 0.05R
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 14)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Scale step [0.01; 0.99]:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 14)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Angle skip:"
        '
        'nmb_mode02_angle_skip
        '
        Me.nmb_mode02_angle_skip.BackColor = System.Drawing.Color.White
        Me.nmb_mode02_angle_skip.DataIdent = ""
        Me.nmb_mode02_angle_skip.DataType = FZ_CustomControl.DATATYPE.None
        Me.nmb_mode02_angle_skip.DecimalDigits = 0
        Me.nmb_mode02_angle_skip.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.nmb_mode02_angle_skip.ForeColor = System.Drawing.Color.Black
        Me.nmb_mode02_angle_skip.Location = New System.Drawing.Point(183, 26)
        Me.nmb_mode02_angle_skip.MaxValue = 90.0R
        Me.nmb_mode02_angle_skip.Measurement = 0R
        Me.nmb_mode02_angle_skip.MinValue = 0R
        Me.nmb_mode02_angle_skip.Name = "nmb_mode02_angle_skip"
        Me.nmb_mode02_angle_skip.RefreshWindow = Nothing
        Me.nmb_mode02_angle_skip.Size = New System.Drawing.Size(120, 20)
        Me.nmb_mode02_angle_skip.StopChangeEvent = True
        Me.nmb_mode02_angle_skip.TabIndex = 38
        Me.nmb_mode02_angle_skip.Text = "NumericBox1"
        Me.nmb_mode02_angle_skip.TextIdent = ""
        Me.nmb_mode02_angle_skip.TransparentBackground = False
        Me.nmb_mode02_angle_skip.UnitNo = -1
        Me.nmb_mode02_angle_skip.Value = 0R
        '
        'btnMeasure
        '
        Me.btnMeasure.Enabled = False
        Me.btnMeasure.Location = New System.Drawing.Point(77, 510)
        Me.btnMeasure.Name = "btnMeasure"
        Me.btnMeasure.Size = New System.Drawing.Size(203, 30)
        Me.btnMeasure.TabIndex = 31
        Me.btnMeasure.Text = "ReMeasure"
        Me.btnMeasure.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 14)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Mode:"
        '
        'cmb_mode
        '
        Me.cmb_mode.DataIdent = ""
        Me.cmb_mode.DataType = FZ_CustomControl.DATATYPE.None
        Me.cmb_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_mode.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.cmb_mode.FormattingEnabled = True
        Me.cmb_mode.Items.AddRange(New Object() {"Mode01: Non Convex Poly", "Mode02: Scale and Rotate Rect"})
        Me.cmb_mode.Location = New System.Drawing.Point(122, 28)
        Me.cmb_mode.Name = "cmb_mode"
        Me.cmb_mode.RefreshWindow = Nothing
        Me.cmb_mode.Size = New System.Drawing.Size(203, 21)
        Me.cmb_mode.TabIndex = 33
        Me.cmb_mode.UnitNo = -1
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.cmb_edge0)
        Me.GroupPanel1.Controls.Add(Me.cmb_edge1)
        Me.GroupPanel1.Controls.Add(Me.cmb_edge2)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.cmb_edge3)
        Me.GroupPanel1.FrameColor = System.Drawing.Color.RoyalBlue
        Me.GroupPanel1.FrameWidth = 2
        Me.GroupPanel1.Location = New System.Drawing.Point(679, 499)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(327, 154)
        Me.GroupPanel1.TabIndex = 37
        Me.GroupPanel1.TextIdent = ""
        Me.GroupPanel1.TitleColor = System.Drawing.Color.Black
        Me.GroupPanel1.TitleFont = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.GroupPanel1.TitleText = "HIDDEN"
        Me.GroupPanel1.TransparentBackground = False
        Me.GroupPanel1.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(76, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 14)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "HIDDEN Select Scan Edge Position units:"
        '
        'cmb_edge0
        '
        Me.cmb_edge0.DataIdent = ""
        Me.cmb_edge0.DataType = FZ_CustomControl.DATATYPE.None
        Me.cmb_edge0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_edge0.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.cmb_edge0.FormattingEnabled = True
        Me.cmb_edge0.Location = New System.Drawing.Point(97, 28)
        Me.cmb_edge0.Name = "cmb_edge0"
        Me.cmb_edge0.RefreshWindow = Nothing
        Me.cmb_edge0.Size = New System.Drawing.Size(203, 21)
        Me.cmb_edge0.TabIndex = 23
        Me.cmb_edge0.UnitNo = -1
        '
        'cmb_edge1
        '
        Me.cmb_edge1.DataIdent = ""
        Me.cmb_edge1.DataType = FZ_CustomControl.DATATYPE.None
        Me.cmb_edge1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_edge1.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.cmb_edge1.FormattingEnabled = True
        Me.cmb_edge1.Location = New System.Drawing.Point(97, 55)
        Me.cmb_edge1.Name = "cmb_edge1"
        Me.cmb_edge1.RefreshWindow = Nothing
        Me.cmb_edge1.Size = New System.Drawing.Size(203, 21)
        Me.cmb_edge1.TabIndex = 26
        Me.cmb_edge1.UnitNo = -1
        '
        'cmb_edge2
        '
        Me.cmb_edge2.DataIdent = ""
        Me.cmb_edge2.DataType = FZ_CustomControl.DATATYPE.None
        Me.cmb_edge2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_edge2.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.cmb_edge2.FormattingEnabled = True
        Me.cmb_edge2.Location = New System.Drawing.Point(97, 82)
        Me.cmb_edge2.Name = "cmb_edge2"
        Me.cmb_edge2.RefreshWindow = Nothing
        Me.cmb_edge2.Size = New System.Drawing.Size(203, 21)
        Me.cmb_edge2.TabIndex = 25
        Me.cmb_edge2.UnitNo = -1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 14)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Label4"
        '
        'cmb_edge3
        '
        Me.cmb_edge3.DataIdent = ""
        Me.cmb_edge3.DataType = FZ_CustomControl.DATATYPE.None
        Me.cmb_edge3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_edge3.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.cmb_edge3.FormattingEnabled = True
        Me.cmb_edge3.Location = New System.Drawing.Point(97, 109)
        Me.cmb_edge3.Name = "cmb_edge3"
        Me.cmb_edge3.RefreshWindow = Nothing
        Me.cmb_edge3.Size = New System.Drawing.Size(203, 21)
        Me.cmb_edge3.TabIndex = 24
        Me.cmb_edge3.UnitNo = -1
        '
        'sls_angle
        '
        Me.sls_angle.DataIdent = ""
        Me.sls_angle.DataType = FZ_CustomControl.DATATYPE.None
        Me.sls_angle.DecimalDigits = 0
        Me.sls_angle.Interval = 100
        Me.sls_angle.LargeChange = 10.0R
        Me.sls_angle.Location = New System.Drawing.Point(22, 58)
        Me.sls_angle.MaxValue = 90.0R
        Me.sls_angle.Measurement = 0R
        Me.sls_angle.MinValue = 0R
        Me.sls_angle.Name = "sls_angle"
        Me.sls_angle.PushMargin = 500
        Me.sls_angle.RefreshWindow = Nothing
        Me.sls_angle.Size = New System.Drawing.Size(303, 55)
        Me.sls_angle.SliderStyle = FZ_CustomControl.ARRAYSTYLE.Vertical
        Me.sls_angle.SmallChange = 1.0R
        Me.sls_angle.StopChangeEvent = True
        Me.sls_angle.TabIndex = 36
        Me.sls_angle.TabStop = False
        Me.sls_angle.Text = "SliderSet1"
        Me.sls_angle.TextIdent = ""
        Me.sls_angle.TickFrequency = 10.0R
        Me.sls_angle.TickStyle = System.Windows.Forms.TickStyle.BottomRight
        Me.sls_angle.Title = "Max angle (+/-) [0; 90]:"
        Me.sls_angle.TrackBarOnly = False
        Me.sls_angle.TransparentBackground = True
        Me.sls_angle.UnitNo = -1
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(19, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(320, 30)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "It takes ~1 sec (!) for 640x480 px image and 5 degree (no skip angles)!"
        '
        'colorSet
        '
        Me.colorSet.B = 0
        Me.colorSet.BackColor = System.Drawing.SystemColors.Control
        Me.colorSet.ColorRangeSupport = True
        Me.colorSet.CompactMode = False
        Me.colorSet.DataIdent = ""
        Me.colorSet.DataIdent_B = ""
        Me.colorSet.DataIdent_G = ""
        Me.colorSet.DataIdent_GB = ""
        Me.colorSet.DataIdent_GG = ""
        Me.colorSet.DataIdent_GR = ""
        Me.colorSet.DataIdent_R = ""
        Me.colorSet.DataType = FZ_CustomControl.DATATYPE.UnitData
        Me.colorSet.G = 0
        Me.colorSet.GB = 0
        Me.colorSet.GG = 0
        Me.colorSet.GR = 0
        Me.colorSet.ImageWindow = Nothing
        Me.colorSet.Location = New System.Drawing.Point(35, 43)
        Me.colorSet.Name = "colorSet"
        Me.colorSet.R = 0
        Me.colorSet.RefreshWindow = Nothing
        Me.colorSet.Size = New System.Drawing.Size(225, 299)
        Me.colorSet.StopChangeEvent = True
        Me.colorSet.TabIndex = 0
        Me.colorSet.TextIdent = ""
        Me.colorSet.TransparentBackground = True
        Me.colorSet.UnitNo = -1
        '
        'cbColorSpecification
        '
        Me.cbColorSpecification.DataIdent = ""
        Me.cbColorSpecification.DataType = FZ_CustomControl.DATATYPE.UnitData
        Me.cbColorSpecification.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.cbColorSpecification.Location = New System.Drawing.Point(15, 16)
        Me.cbColorSpecification.Name = "cbColorSpecification"
        Me.cbColorSpecification.RefreshWindow = Nothing
        Me.cbColorSpecification.Size = New System.Drawing.Size(189, 21)
        Me.cbColorSpecification.TabIndex = 1
        Me.cbColorSpecification.Text = "Edge color specification     "
        Me.cbColorSpecification.TextIdent = ""
        Me.cbColorSpecification.UnitNo = -1
        Me.cbColorSpecification.ValueOff = 0
        Me.cbColorSpecification.ValueOn = 1
        '
        'LabelEx3
        '
        Me.LabelEx3.DataIdent = ""
        Me.LabelEx3.DataType = FZ_CustomControl.DATATYPE.None
        Me.LabelEx3.Font = New System.Drawing.Font("MS Gothic", 10.0!)
        Me.LabelEx3.Location = New System.Drawing.Point(30, 437)
        Me.LabelEx3.Name = "LabelEx3"
        Me.LabelEx3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LabelEx3.RefreshWindow = Nothing
        Me.LabelEx3.Size = New System.Drawing.Size(200, 17)
        Me.LabelEx3.StopChangeEvent = True
        Me.LabelEx3.TabIndex = 2
        Me.LabelEx3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LabelEx3.TextIdent = ""
        Me.LabelEx3.TransparentBackground = True
        Me.LabelEx3.UnitNo = -1
        '
        'rdoColorIN
        '
        Me.rdoColorIN.Checked = True
        Me.rdoColorIN.DataIdent = ""
        Me.rdoColorIN.DataType = FZ_CustomControl.DATATYPE.UnitData
        Me.rdoColorIN.Location = New System.Drawing.Point(35, 469)
        Me.rdoColorIN.Name = "rdoColorIN"
        Me.rdoColorIN.RefreshWindow = Nothing
        Me.rdoColorIN.Size = New System.Drawing.Size(78, 21)
        Me.rdoColorIN.TabIndex = 3
        Me.rdoColorIN.TabStop = True
        Me.rdoColorIN.Text = "Color IN "
        Me.rdoColorIN.TextIdent = ""
        Me.rdoColorIN.TransparentBackground = True
        Me.rdoColorIN.UnitNo = -1
        Me.rdoColorIN.Value = 0
        '
        'rdoColorOUT
        '
        Me.rdoColorOUT.DataIdent = ""
        Me.rdoColorOUT.DataType = FZ_CustomControl.DATATYPE.UnitData
        Me.rdoColorOUT.Location = New System.Drawing.Point(148, 469)
        Me.rdoColorOUT.Name = "rdoColorOUT"
        Me.rdoColorOUT.RefreshWindow = Nothing
        Me.rdoColorOUT.Size = New System.Drawing.Size(92, 21)
        Me.rdoColorOUT.TabIndex = 4
        Me.rdoColorOUT.Text = "Color OUT"
        Me.rdoColorOUT.TextIdent = ""
        Me.rdoColorOUT.TransparentBackground = True
        Me.rdoColorOUT.UnitNo = -1
        Me.rdoColorOUT.Value = 1
        '
        'stdsetReference
        '
        Me.stdsetReference.BackColor = System.Drawing.SystemColors.Control
        Me.stdsetReference.DataIdent = ""
        Me.stdsetReference.DataIdentPosX = ""
        Me.stdsetReference.DataIdentPosY = ""
        Me.stdsetReference.DataType = FZ_CustomControl.DATATYPE.UnitData
        Me.stdsetReference.DecimalDigits = 0
        Me.stdsetReference.ImageWindow = Nothing
        Me.stdsetReference.Interval = 100
        Me.stdsetReference.Location = New System.Drawing.Point(13, 41)
        Me.stdsetReference.MaxX = 9999.0R
        Me.stdsetReference.MaxY = 9999.0R
        Me.stdsetReference.MinX = 0R
        Me.stdsetReference.MinY = 0R
        Me.stdsetReference.Name = "stdsetReference"
        Me.stdsetReference.Position = New System.Drawing.Point(0, 0)
        Me.stdsetReference.PositionX = 0R
        Me.stdsetReference.PositionY = 0R
        Me.stdsetReference.PushChange = 1.0R
        Me.stdsetReference.PushMargin = 500
        Me.stdsetReference.RefreshWindow = Nothing
        Me.stdsetReference.Size = New System.Drawing.Size(283, 90)
        Me.stdsetReference.StopChangeEvent = True
        Me.stdsetReference.TabIndex = 0
        Me.stdsetReference.TextIdent = ""
        Me.stdsetReference.TransparentBackground = True
        Me.stdsetReference.UnitNo = -1
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("MS Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(19, 623)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(320, 30)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "TODO: Region figure in process..."
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("MS Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(19, 623)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(320, 30)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "TODO: Remeasure and Display graphics"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("MS Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(19, 588)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(320, 30)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Unit SAMPLE"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("MS Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(19, 588)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(320, 30)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Unit SAMPLE"
        '
        'NormalForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1022, 743)
        Me.ControlBox = False
        Me.Controls.Add(Me.tcNormal)
        Me.Controls.Add(Me.tsbNormal)
        Me.Name = "NormalForm"
        Me.tabOutputParameter.ResumeLayout(False)
        Me.grpTotalJudge.ResumeLayout(False)
        Me.tcNormal.ResumeLayout(False)
        Me.tabRegion.ResumeLayout(False)
        Me.grpMouseCoordinates.ResumeLayout(False)
        Me.tabMeasure.ResumeLayout(False)
        Me.tabMeasure.PerformLayout()
        Me.grpSlices.ResumeLayout(False)
        Me.grpSlices.PerformLayout()
        Me.grp_mode01.ResumeLayout(False)
        Me.grp_mode01.PerformLayout()
        Me.grp_mode02.ResumeLayout(False)
        Me.grp_mode02.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tsbNormal As FZ_CustomControl.TabSwitchButtons
    Friend WithEvents tabOutputParameter As TabPage
    Friend WithEvents grpTotalJudge As FZ_CustomControl.GroupPanel
    Friend WithEvents rdoUndo As FZ_CustomControl.RadioButtonEx
    Friend WithEvents rdoDo As FZ_CustomControl.RadioButtonEx
    Friend WithEvents coordinateSet As FZ_CustomControl.CoordinateSetControl
    Friend WithEvents tcNormal As TabControl
    Friend WithEvents tabMeasure As TabPage
    Friend WithEvents colorSet As FZ_CustomControl.ColorSetControl
    Friend WithEvents cbColorSpecification As FZ_CustomControl.CheckBoxEx
    Friend WithEvents LabelEx3 As FZ_CustomControl.LabelEx
    Friend WithEvents rdoColorIN As FZ_CustomControl.RadioButtonEx
    Friend WithEvents rdoColorOUT As FZ_CustomControl.RadioButtonEx
    Friend WithEvents stdsetReference As FZ_CustomControl.StandardSet
    Friend WithEvents cmb_edge3 As FZ_CustomControl.ComboBoxEx
    Friend WithEvents cmb_edge0 As FZ_CustomControl.ComboBoxEx
    Friend WithEvents cmb_edge1 As FZ_CustomControl.ComboBoxEx
    Friend WithEvents cmb_edge2 As FZ_CustomControl.ComboBoxEx
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMeasure As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents sls_angle As FZ_CustomControl.SliderSet
    Friend WithEvents GroupPanel1 As FZ_CustomControl.GroupPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_mode As FZ_CustomControl.ComboBoxEx
    Friend WithEvents grp_mode02 As FZ_CustomControl.GroupPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents nmb_mode02_angle_skip As FZ_CustomControl.NumericBox
    Friend WithEvents nmb_mode02_scale_step As FZ_CustomControl.NumericBox
    Friend WithEvents Label9 As Label
    Friend WithEvents grp_mode01 As FZ_CustomControl.GroupPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents nmb_mode01_angle_skip As FZ_CustomControl.NumericBox
    Friend WithEvents grpSlices As FZ_CustomControl.GroupPanel
    Friend WithEvents chbSlicesEnable As FZ_CustomControl.CheckBoxEx
    Friend WithEvents lblSlicesType As Label
    Friend WithEvents cmbSlicesType As FZ_CustomControl.ComboBoxEx
    Friend WithEvents lblSlicesRows As Label
    Friend WithEvents nmbSlicesRows As FZ_CustomControl.NumericBox
    Friend WithEvents lblSlicesWidth As Label
    Friend WithEvents nmbSlicesWidth As FZ_CustomControl.NumericBox
    Friend WithEvents lblSlicesHeight As Label
    Friend WithEvents nmbSlicesHeight As FZ_CustomControl.NumericBox
    Friend WithEvents lblSlicesCols As Label
    Friend WithEvents nmbSlicesCols As FZ_CustomControl.NumericBox
    Friend WithEvents tabRegion As TabPage
    Friend WithEvents fscRegion As FZ_CustomControl.FigureSetControl
    Friend WithEvents imgMain As FZ_CustomControl.SetupImageWindow
    Friend WithEvents ZoomMain As FZ_CustomControl.ZoomBrowser
    Friend WithEvents btnHelp As FZ_CustomControl.ImageButton
    Friend WithEvents btnCancel As FZ_CustomControl.ImageButton
    Friend WithEvents btnOK As FZ_CustomControl.ImageButton
    Friend WithEvents grpMouseCoordinates As FZ_CustomControl.GroupPanel
    Friend WithEvents lblSetupImageWindowPixelColor As FZ_CustomControl.LabelEx
    Friend WithEvents lblSetupImageWindowHSV As FZ_CustomControl.LabelEx
    Friend WithEvents lblSetupImageDescriptHSV As FZ_CustomControl.LabelEx
    Friend WithEvents lblSetupImageWindowRGB As FZ_CustomControl.LabelEx
    Friend WithEvents lblSetupImageDescriptRGB As FZ_CustomControl.LabelEx
    Friend WithEvents lblSetupImageWindowXY As FZ_CustomControl.LabelEx
    Friend WithEvents lblSetupImageDescriptXY As FZ_CustomControl.LabelEx
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class

