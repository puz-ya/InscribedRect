Public Class NonstopForm

	Private Sub NonstopForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Me.tsbNonstop.TabControl = Me.tcNonstop
	End Sub

	Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

		Me.DialogResult = Windows.Forms.DialogResult.OK

		Me.Close()
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

		Me.DialogResult = Windows.Forms.DialogResult.Cancel

		Me.Close()
	End Sub

	Private Sub tcNonstop_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcNonstop.SelectedIndexChanged

		Dim index As Integer = Me.tcNonstop.SelectedIndex

		If (index >= 0) Then
			Me.tcNonstop.TabPages(index).Controls.Add(Me.btnOK)
			Me.tcNonstop.TabPages(index).Controls.Add(Me.btnCancel)
		End If
	End Sub

End Class

