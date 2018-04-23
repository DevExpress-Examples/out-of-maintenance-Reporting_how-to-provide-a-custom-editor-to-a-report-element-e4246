Imports Microsoft.VisualBasic
Imports System.Windows.Controls

Namespace CustomEditorSample
	Partial Public Class PictureBoxSizingEditor
		Inherits UserControl
		Public Property ViewModel() As PictureBoxSizingEditorViewModel
			Get
				Return TryCast(DataContext, PictureBoxSizingEditorViewModel)
			End Get
			Set(ByVal value As PictureBoxSizingEditorViewModel)
				DataContext = value
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
