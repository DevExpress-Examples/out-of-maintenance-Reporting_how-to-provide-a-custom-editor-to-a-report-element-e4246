Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.ReportDesigner

Namespace CustomEditorSample
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			AddHandler designer.Model.CustomizeReportControlEditor, AddressOf Model_CustomizeReportControlEditor
		End Sub

		Private Sub Model_CustomizeReportControlEditor(ByVal sender As Object, ByVal e As CustomizeReportControlEditorEventArgs)
			If e.GetXRControlTypeName() <> "DevExpress.XtraReports.UI.XRPictureBox" Then
				Return
			End If
			e.EditorCreators.Add(New PictureBoxEditorCreator())
		End Sub
	End Class
End Namespace
