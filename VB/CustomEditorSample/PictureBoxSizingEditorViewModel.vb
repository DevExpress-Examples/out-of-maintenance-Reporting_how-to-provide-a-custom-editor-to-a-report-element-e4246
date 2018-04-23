Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq.Expressions
Imports System.Windows.Input
Imports DevExpress.Utils
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.ReportDesigner
Imports DevExpress.XtraPrinting

Namespace CustomEditorSample
	Public Class PictureBoxSizingEditorViewModel
		Implements INotifyPropertyChanged
		Private ReadOnly editorServices As EditorServices
		Private sizeMode As ImageSizeMode
		Private ReadOnly applyCommand_Renamed As ICommand
		Private ReadOnly controlName As String

		Public Shared ReadOnly Property ImageSizeModes() As Array
			Get
				Return EnumExtensions.GetValues(GetType(ImageSizeMode))
			End Get
		End Property

		Public Property ImageSizeMode() As ImageSizeMode
			Get
				Return sizeMode
			End Get
			Set(ByVal value As ImageSizeMode)
                If Not sizeMode = value Then
                    sizeMode = value
                    RaisePropertyChanged(Function() sizeMode)
                End If
			End Set
		End Property

		Public ReadOnly Property ApplyCommand() As ICommand
			Get
				Return applyCommand_Renamed
			End Get
		End Property

		Public Sub New(ByVal editorServices As EditorServices, ByVal controlInfo As ReportControlInfo, ByVal customProperties As IDictionary(Of String, Object))
			Me.editorServices = editorServices
			applyCommand_Renamed = New DelegateCommand(Of Object)(AddressOf Apply)
			controlName = controlInfo.DesignName
			Const customProperyName As String = "Sizing"
			ImageSizeMode = If(customProperties.ContainsKey(customProperyName) AndAlso TypeOf customProperties(customProperyName) Is ImageSizeMode, CType(customProperties(customProperyName), ImageSizeMode), DevExpress.XtraPrinting.ImageSizeMode.Normal)
		End Sub

		Private Sub Apply(ByVal parameter As Object)
            Dim changeService As DevExpress.Xpf.ReportDesigner.Services.IChangeService = editorServices.ChangeService
			changeService.TriggerCustomAction(New ChangeImageSizeModeAction() With {.ControlName = controlName, .ImageSizeMode = ImageSizeMode})
			changeService.CommitChanges()
		End Sub
		#Region "INotifyPropertyChanged"
		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Private Sub RaisePropertyChanged(Of T)(ByVal [property] As Expression(Of Func(Of T)))
			PropertyExtensions.RaisePropertyChanged(Me, PropertyChangedEvent, [property])
		End Sub
		#End Region
	End Class
End Namespace
