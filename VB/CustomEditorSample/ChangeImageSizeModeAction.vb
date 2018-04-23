Imports Microsoft.VisualBasic
Imports System.Runtime.Serialization
Imports DevExpress.DocumentServices.ServiceModel.DataContracts.Xpf.Designer
Imports DevExpress.XtraPrinting

Namespace CustomEditorSample
	<DataContract> _
	Public Class ChangeImageSizeModeAction
		Inherits EditActionBase
		Private privateImageSizeMode As ImageSizeMode
		<DataMember> _
		Public Property ImageSizeMode() As ImageSizeMode
			Get
				Return privateImageSizeMode
			End Get
			Set(ByVal value As ImageSizeMode)
				privateImageSizeMode = value
			End Set
		End Property
	End Class
End Namespace
