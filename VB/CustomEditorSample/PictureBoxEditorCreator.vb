Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.ReportDesigner

Namespace CustomEditorSample
	Public Class PictureBoxEditorCreator
        Implements IReportControlEditorCreator
        Public ReadOnly Property Caption() As String Implements IReportControlEditorCreator.Caption
            Get
                Return "XRPictureBox Editor"
            End Get
        End Property

        Public Function CreateEditor(ByVal controlInfo As ReportControlInfo, ByVal services As EditorServices, ByVal customProperties As System.Collections.Generic.IDictionary(Of String, Object)) As Control Implements IReportControlEditorCreator.CreateEditor
            Return New PictureBoxSizingEditor() With {.ViewModel = New PictureBoxSizingEditorViewModel(services, controlInfo, customProperties)}
        End Function
	End Class
End Namespace
