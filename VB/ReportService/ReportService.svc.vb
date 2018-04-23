Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.XtraReports.Service
Imports CustomEditorSample
Imports DevExpress.XtraReports.UI

Namespace ReportService
	<SilverlightFaultBehavior> _
	Public Class ReportService
		Inherits DevExpress.XtraReports.Service.ReportService
		Shared Sub New()
			EditActionInvokerFactory.RegisterInvoker(Of ChangeImageSizeModeAction, ChangeImageSizeModeActionInvoker)()
		End Sub

		Protected Overrides Sub FillCustomProperties(ByVal reportName As String, ByVal control As XRControl, ByVal properties As System.Collections.Generic.IDictionary(Of String, Object))
			Dim pictureBox = TryCast(control, XRPictureBox)
			If pictureBox Is Nothing Then
				Return
			End If
			properties("Sizing") = pictureBox.Sizing
		End Sub
	End Class
End Namespace
