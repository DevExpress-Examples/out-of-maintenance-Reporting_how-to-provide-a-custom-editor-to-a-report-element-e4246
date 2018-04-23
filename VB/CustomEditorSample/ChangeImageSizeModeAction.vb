Imports Microsoft.VisualBasic
Imports System.Runtime.Serialization

Namespace CustomEditorSample
	<DataContract> _
	Public Class ChangeImageSizeModeAction
		Inherits DevExpress.XtraReports.ServiceModel.DataContracts.EditActionBase
		Private privateImageSizeMode As DevExpress.XtraPrinting.ImageSizeMode
		<DataMember> _
		Public Property ImageSizeMode() As DevExpress.XtraPrinting.ImageSizeMode
			Get
				Return privateImageSizeMode
			End Get
			Set(ByVal value As DevExpress.XtraPrinting.ImageSizeMode)
				privateImageSizeMode = value
			End Set
		End Property
	End Class
End Namespace
