

Public Class NormalForm

    ''' <summary>
    ''' Simulation flag status (for debug)
    ''' </summary>
    Public Const SIMULATOR_FLAG As Integer = 0
    ''' <summary>
    ''' Simulation delay before we attach to process (ProcItem_UI or Fz-CoreRA) for Debug
    ''' </summary>
    Public Const SIMULATOR_THREAD_SLEEP As Integer = 5000
    ''' <summary>
    ''' CHECK_WHERE_WE_RUN == 2 in Release mode, other number in Sim
    ''' </summary>
    Public Const CHECK_WHERE_WE_RUN = 2

    'Return values for debugging functions
    Public res As Integer = -1
    Public ret As Integer = -1
    Public returnDblVal As Double = -1.0

    Private Sub NormalForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CheckIfSimulator()

        Me.imgMain.magnification = -1
        Me.imgMain.unitNo = Me.unitNo
        Me.tsbNormal.TabControl = Me.tcNormal
        Me.tcNormal.Update()

        GetSetControlsState()

    End Sub

    ''' <summary>
    ''' Check if we launch in Simulator Mode
    ''' </summary>
    Private Sub CheckIfSimulator()

        'Pause before attach & debug
        If SIMULATOR_FLAG = 1 Then

            Threading.Thread.Sleep(SIMULATOR_THREAD_SLEEP)

            'Timer1.Interval = SIMULATOR_THREAD_SLEEP * 10

            'Disable virtual keyboard
            'ret = SetSystemData("PanDA", "ScreenKeyboard", "2")

        End If

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Me.DialogResult = Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub tcNormal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcNormal.SelectedIndexChanged

        Dim index As Integer = Me.tcNormal.SelectedIndex

        If (index >= 0) Then
            Me.tcNormal.TabPages(index).Controls.Add(Me.btnOK)
            Me.tcNormal.TabPages(index).Controls.Add(Me.btnCancel)
            Me.tcNormal.TabPages(index).Controls.Add(Me.btnHelp)
            Me.tcNormal.TabPages(index).Controls.Add(Me.imgMain)
            Me.tcNormal.TabPages(index).Controls.Add(Me.ZoomMain)

            Me.tcNormal.TabPages(index).Controls.Add(Me.grpMouseCoordinates)
        End If

    End Sub

    '--- --- --- MOUSE

    ''' <summary>
    ''' Get coordinates (local and global) of Mouse pointer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub siwMainImageWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles imgMain.MouseMove

        UpdateMouseCoordGlobal()
        UpdateMouseCoordOnImageWindow()
        UpdateMouseCoordColorPick()

        'Force refresh works here
        lblSetupImageWindowXY.Refresh()
        lblSetupImageWindowRGB.Refresh()
        lblSetupImageWindowHSV.Refresh()
        lblSetupImageWindowPixelColor.Refresh()

    End Sub

    ''' <summary>
    ''' Get global cursor coordinates and update them in the label controls
    ''' </summary>
    Private Sub UpdateMouseCoordGlobal()

        'Get cursor coordinates
        Dim mouseCoord As Point

        'GetCursorPos(mouseCoord) 'Not working !

        Cursor = New Cursor(Cursor.Current.Handle)
        mouseCoord.X = Cursor.Position.X
        mouseCoord.Y = Cursor.Position.Y

        'lblMouseXY.Text = "" + CStr(mouseCoord.X) + ", " + CStr(mouseCoord.Y) + " px"

        'Cursor.Dispose()   '// Do NOT dispose Cursor resources

        'NO need to Update / Invalidate

    End Sub

    ''' <summary>
    ''' Get cursor coordinates related to FH ImageWindow and update them in the label controls
    ''' </summary>
    Private Sub UpdateMouseCoordOnImageWindow()

        Dim MousePos As Point = imgMain.PointToClient(MousePosition)
        Dim imgPoint As Point = imgMain.GetLawPoint(MousePos.X, MousePos.Y)

        lblSetupImageWindowXY.Text = "" + CStr(imgPoint.X) + ", " + CStr(imgPoint.Y) + " px"

    End Sub

    ''' <summary>
    ''' Converting RGB to HSV (0-359, 0-255, 0-255)
    ''' </summary>
    ''' <param name="color"></param>
    ''' <param name="hue"></param>
    ''' <param name="saturation"></param>
    ''' <param name="value"></param>
    Public Sub ColorToHSV(color As Color, ByRef hue As Double, ByRef saturation As Double, ByRef value As Double)

        Dim max As Integer = Math.Max(color.R, Math.Max(color.G, color.B))
        Dim min As Integer = Math.Min(color.R, Math.Min(color.G, color.B))

        hue = color.GetHue()

        If max = 0 Then
            saturation = 0
        Else
            saturation = (1D - (1D * min / max)) * 255D
        End If

        value = max

    End Sub

    ''' <summary>
    ''' Converting RGB to HSV (0-359, 0-100, 0-100)
    ''' </summary>
    ''' <param name="color"></param>
    ''' <param name="hue"></param>
    ''' <param name="saturation"></param>
    ''' <param name="value"></param>
    Public Sub ColorToHSV100(color As Color, ByRef hue As Double, ByRef saturation As Double, ByRef value As Double)

        Dim max As Integer = Math.Max(color.R, Math.Max(color.G, color.B))
        Dim min As Integer = Math.Min(color.R, Math.Min(color.G, color.B))

        hue = color.GetHue()

        If max = 0 Then
            saturation = 0
        Else
            saturation = (1D - (1D * min / max)) * 100D
        End If

        value = (max / 255D) * 100D

    End Sub

    ''' <summary>
    ''' Get color data under cursor coordinates related to FH ImageWindow and update them in the label controls
    ''' </summary>
    Private Sub UpdateMouseCoordColorPick()

        'For color pick, mouse position should be Global (from whole screen)
        Cursor = New Cursor(Cursor.Current.Handle)

        Dim myBmp As New Bitmap(1, 1)
        Dim graph As Graphics = Graphics.FromImage(myBmp)
        graph.CopyFromScreen(Cursor.Position.X, Cursor.Position.Y, 0, 0, myBmp.Size, CopyPixelOperation.SourceCopy)

        ''' NO IMAGE IN siwMainImageWindow.Image, RETURNS NULL
        ''' Graphics is useless for this
        'Dim siwImage As Image = siwMainImageWindow.Image
        'Dim graph As Graphics = siwMainImageWindow.Graphic()

        Dim mouseColor As Color = myBmp.GetPixel(0, 0)

        ' Default RGB
        lblSetupImageWindowRGB.Text = "(" + CStr(mouseColor.R) + ", " + CStr(mouseColor.G) + ", " + CStr(mouseColor.B) + ")"

        ' Second HSV
        'Microsoft API returns HSL color, NOT HSV (!)
        'lblSetupImageWindowHSV.Text = "(" + CStr(CInt(mouseColor.GetHue())) + ", " + CStr(CInt(mouseColor.GetSaturation())) + ", " + CStr(CInt(mouseColor.GetBrightness())) + ")"

        Dim Hue, Sat, Vue As Double
        ColorToHSV(mouseColor, Hue, Sat, Vue)
        lblSetupImageWindowHSV.Text = "(" + CStr(CInt(Hue)) + ", " + CStr(CInt(Sat)) + ", " + CStr(CInt(Vue)) + ")"
        lblSetupImageWindowPixelColor.BackColor = Color.FromArgb(mouseColor.R, mouseColor.G, mouseColor.B)

        'NO need to Update / Invalidate

        '// myBmp.Dispose() Do NOT dispose myBMP resources
        '// Cursor.Dispose() Do NOT dispose Cursor resources

    End Sub

    ''' <summary>
    ''' Add for each Form control MouseMoveHandler to update Cursor position
    ''' </summary>
    ''' <param name="c"></param>
    Private Sub AddMouseMoveHandler(c As Control)

        AddHandler c.MouseMove, AddressOf MouseMoveHandler

        If c.Controls.Count > 0 Then

            For Each ct As Control In c.Controls
                AddMouseMoveHandler(ct)
            Next

        End If

    End Sub

    Private Sub MouseMoveHandler(sender As Object, e As MouseEventArgs)

        UpdateMouseCoordGlobal()

    End Sub

    '--- --- ---

    Private Sub GetSetControlsState()

        '//TODO: Send positions of selected Scan Edge Pos unit in the Scene flow.
        SetUnitData(20, 2)
        SetUnitData(21, 3)
        SetUnitData(22, 4)
        SetUnitData(23, 5)

        '//TODO: Set mode to default, zero-based index
        Dim mode As Double
        GetUnitData(200, mode)
        cmb_mode.SelectedIndex = mode
        ShowHideModeGroups(mode)

        '//Set angle back to the slider from the unit on each onLoad
        Dim angle As Double
        GetUnitData(201, angle)
        sls_angle.Measurement = angle

        Dim mode01_angle_skip As Double
        GetUnitData(300, mode01_angle_skip)
        nmb_mode01_angle_skip.Value = mode01_angle_skip

        Dim mode02_angle_skip As Double
        GetUnitData(400, mode02_angle_skip)
        nmb_mode02_angle_skip.Value = mode02_angle_skip

        Dim mode02_scale_step As Double
        GetUnitData(401, mode02_scale_step)
        nmb_mode02_scale_step.Value = mode02_scale_step

        '//Slices
        GetSetSlicesControlsState()

    End Sub

    Private Sub GetSetSlicesControlsState()

        Dim sliceEnabled As Double
        GetUnitData(210, sliceEnabled)
        If sliceEnabled = 1 Then
            chbSlicesEnable.Checked = True
        Else
            chbSlicesEnable.Checked = False
        End If

        Dim sliceType As Double
        GetUnitData(211, sliceType)
        If sliceType >= 1 And sliceType <= 2 Then
            cmbSlicesType.SelectedIndex = CInt(sliceType - 1)
        Else
            cmbSlicesType.SelectedIndex = 0
        End If

        GetSetCmbSlicesType()

        Dim sliceRows As Double
        GetUnitData(212, sliceRows)
        nmbSlicesRows.Measurement = sliceRows

        Dim sliceCols As Double
        GetUnitData(213, sliceCols)
        nmbSlicesCols.Measurement = sliceCols

        Dim sliceHeight As Double
        GetUnitData(214, sliceHeight)
        nmbSlicesHeight.Measurement = sliceHeight

        Dim sliceWidth As Double
        GetUnitData(215, sliceWidth)
        nmbSlicesWidth.Measurement = sliceWidth

    End Sub


    Private Sub sls_angle_ValueChanged(sender As Object, e As EventArgs) Handles sls_angle.ValueChanged

        '// set max Angle into the UnitData
        SetUnitData(201, sls_angle.Measurement)

        '// change both controls MAX limit for different modes
        nmb_mode01_angle_skip.MaxValue = sls_angle.Measurement
        If nmb_mode01_angle_skip.Value > sls_angle.Measurement Then
            nmb_mode01_angle_skip.Value = sls_angle.Measurement
        End If

        nmb_mode02_angle_skip.MaxValue = sls_angle.Measurement
        If nmb_mode02_angle_skip.Value > sls_angle.Measurement Then
            nmb_mode02_angle_skip.Value = sls_angle.Measurement
        End If

    End Sub

    Private Sub cmb_mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mode.SelectedIndexChanged

        '//set current mode, zero-based
        SetUnitData(200, cmb_mode.SelectedIndex)

        ShowHideModeGroups(cmb_mode.SelectedIndex)

    End Sub

    Public Sub ShowHideModeGroups(mode As Integer)

        Select Case mode
            Case 0
                grp_mode01.Visible = True
                grp_mode02.Visible = False
            Case 1
                grp_mode01.Visible = False
                grp_mode02.Visible = True

                '//new location of GroupMode02
                Dim pGroup02 As Point
                pGroup02.X = grp_mode01.Location.X
                pGroup02.Y = grp_mode01.Location.Y
                grp_mode02.Location = pGroup02

            Case Else
                grp_mode01.Visible = True
                grp_mode02.Visible = False
        End Select

    End Sub

    Private Sub nmb_mode01_angle_skip_ValueChanged(sender As Object, e As EventArgs) Handles nmb_mode01_angle_skip.ValueChanged

        SetUnitData(300, nmb_mode01_angle_skip.Value)

    End Sub

    Private Sub nmb_mode02_angle_skip_ValueChanged(sender As Object, e As EventArgs) Handles nmb_mode02_angle_skip.ValueChanged

        SetUnitData(400, nmb_mode02_angle_skip.Value)

    End Sub

    Private Sub nmb_mode02_scale_step_ValueChanged(sender As Object, e As EventArgs) Handles nmb_mode02_scale_step.ValueChanged

        SetUnitData(401, nmb_mode02_scale_step.Value)

    End Sub

    Private Sub chbSlicesEnable_CheckedChanged(sender As Object, e As EventArgs) Handles chbSlicesEnable.CheckedChanged

        If chbSlicesEnable.Checked = True Then
            SetUnitData(210, 1)

            GrpSlicesState(True)

        Else
            SetUnitData(210, 0)

            GrpSlicesState(False)

        End If

    End Sub

    Private Sub GrpSlicesState(state As Boolean)

        cmbSlicesType.Enabled = state

        GetSetCmbSlicesType()


    End Sub

    Private Sub GetSetCmbSlicesType()

        If cmbSlicesType.Enabled = True And cmbSlicesType.SelectedIndex = 0 Then
            nmbSlicesRows.Enabled = True
            nmbSlicesCols.Enabled = True
            nmbSlicesHeight.Enabled = False
            nmbSlicesWidth.Enabled = False
        Else
            nmbSlicesRows.Enabled = False
            nmbSlicesCols.Enabled = False
        End If

        If cmbSlicesType.Enabled = True And cmbSlicesType.SelectedIndex = 1 Then
            nmbSlicesHeight.Enabled = True
            nmbSlicesWidth.Enabled = True
            nmbSlicesRows.Enabled = False
            nmbSlicesCols.Enabled = False
        Else
            nmbSlicesHeight.Enabled = False
            nmbSlicesWidth.Enabled = False
        End If

    End Sub

    Private Sub cmbSlicesType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSlicesType.SelectedIndexChanged

        '//SliceType starts with 1
        SetUnitData(211, cmbSlicesType.SelectedIndex + 1)

        GetSetCmbSlicesType()

    End Sub

    Private Sub nmbSlicesRows_ValueChanged(sender As Object, e As EventArgs) Handles nmbSlicesRows.ValueChanged

        SetUnitData(212, nmbSlicesRows.Measurement)

    End Sub

    Private Sub nmbSlicesCols_ValueChanged(sender As Object, e As EventArgs) Handles nmbSlicesCols.ValueChanged

        SetUnitData(213, nmbSlicesCols.Measurement)

    End Sub

    Private Sub nmbSlicesHeight_ValueChanged(sender As Object, e As EventArgs) Handles nmbSlicesHeight.ValueChanged

        SetUnitData(214, nmbSlicesHeight.Measurement)

    End Sub

    Private Sub nmbSlicesWidth_ValueChanged(sender As Object, e As EventArgs) Handles nmbSlicesWidth.ValueChanged

        SetUnitData(215, nmbSlicesWidth.Measurement)

    End Sub

    Private Sub btnMeasure_Click(sender As Object, e As EventArgs) Handles btnMeasure.Click

        SetUnitData(999, 7)

        '//Update controls because Slice values could change
        GetSetControlsState()

    End Sub



End Class

