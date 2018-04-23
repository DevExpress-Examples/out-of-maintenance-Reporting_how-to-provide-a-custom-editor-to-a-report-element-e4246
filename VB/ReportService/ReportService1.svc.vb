Imports System
Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.Xpf.Printing.Service
Imports DevExpress.XtraReports.Service
Imports DevExpress.XtraReports.UI

' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService1" 
' in code, svc and config file together.
<SilverlightFaultBehavior()>
Public Class ReportService1
    Inherits DevExpress.XtraReports.Service.ReportService
    Shared Sub New()
        EditActionInvokerFactory.RegisterInvoker(Of CustomEditorSample.ChangeImageSizeModeAction, ReportService.ChangeImageSizeModeActionInvoker)()
    End Sub

    Protected Overrides Sub FillCustomProperties(ByVal reportName As String, ByVal control As XRControl, ByVal properties As System.Collections.Generic.IDictionary(Of String, Object))
        Dim pictureBox = TryCast(control, XRPictureBox)
        If pictureBox Is Nothing Then
            Return
        End If
        properties("Sizing") = pictureBox.Sizing
    End Sub
End Class
