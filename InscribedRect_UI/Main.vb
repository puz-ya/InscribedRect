Module Main

	Sub Main()
		Dim operateMode As Integer = ProcItemForm.BeginSetupUnit()

		Select Case (operateMode)
			Case ProcItemForm.operateNormal
				System.Windows.Forms.Application.Run(New NormalForm)
            Case ProcItemForm.operateNonstop
                System.Windows.Forms.Application.Run(New NonstopForm)
        End Select

		ProcItemForm.EndSetupUnit()
	End Sub

End Module

