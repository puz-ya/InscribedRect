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
        End If

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
End Class

