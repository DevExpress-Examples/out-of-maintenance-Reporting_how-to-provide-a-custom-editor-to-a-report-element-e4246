using System.Runtime.Serialization;
using DevExpress.DocumentServices.ServiceModel.DataContracts.Xpf.Designer;
using DevExpress.XtraPrinting;

namespace CustomEditorSample {
    [DataContract]
    public class ChangeImageSizeModeAction : EditActionBase {
        [DataMember]
        public ImageSizeMode ImageSizeMode { get; set; }
    }
}
