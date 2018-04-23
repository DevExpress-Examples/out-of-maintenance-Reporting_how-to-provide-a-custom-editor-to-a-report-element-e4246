Imports Microsoft.VisualBasic
Imports System
Imports CustomEditorSample
Imports DevExpress.DocumentServices.ServiceModel.DataContracts.Xpf.Designer
Imports DevExpress.XtraReports.Service
Imports DevExpress.XtraReports.UI

Namespace ReportService
	Public Class ChangeImageSizeModeActionInvoker
		Inherits EditActionBaseInvoker
		Protected Overrides Sub ControlInvoke(ByVal control As XRControl, ByVal editAction As EditActionBase)
			Dim action = TryCast(editAction, ChangeImageSizeModeAction)
			Dim pictureBox = TryCast(control, XRPictureBox)
			If action Is Nothing OrElse pictureBox Is Nothing Then
				Return
			End If
			pictureBox.Sizing = action.ImageSizeMode
		End Sub
	End Class
End Namespace
