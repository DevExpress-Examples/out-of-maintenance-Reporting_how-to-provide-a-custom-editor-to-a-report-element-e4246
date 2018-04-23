Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
Imports CustomEditorSample

Namespace ReportService
	Public Class ChangeImageSizeModeActionInvoker
		Inherits DevExpress.XtraReports.Service.EditActionBaseInvoker
		Protected Overrides Sub ControlInvoke(ByVal control As XRControl, ByVal editAction As DevExpress.XtraReports.ServiceModel.DataContracts.EditActionBase)
			Dim action = TryCast(editAction, ChangeImageSizeModeAction)
			Dim pictureBox = TryCast(control, XRPictureBox)
			If action Is Nothing OrElse pictureBox Is Nothing Then
				Return
			End If
			pictureBox.Sizing = action.ImageSizeMode
		End Sub
	End Class
End Namespace
