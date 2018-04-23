using System.Runtime.Serialization;

namespace CustomEditorSample {
    [DataContract]
    public class ChangeImageSizeModeAction : DevExpress.XtraReports.ServiceModel.DataContracts.EditActionBase {
        [DataMember]
        public DevExpress.XtraPrinting.ImageSizeMode ImageSizeMode { get; set; }
    }
}
