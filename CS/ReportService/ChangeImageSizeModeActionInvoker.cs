using DevExpress.XtraReports.UI;
using CustomEditorSample;

namespace ReportService {
    public class ChangeImageSizeModeActionInvoker : DevExpress.XtraReports.Service.EditActionBaseInvoker {
        protected override void ControlInvoke(XRControl control, DevExpress.XtraReports.ServiceModel.DataContracts.EditActionBase editAction) {
            var action = editAction as ChangeImageSizeModeAction;
            var pictureBox = control as XRPictureBox;
            if(action == null || pictureBox == null)
                return;
            pictureBox.Sizing = action.ImageSizeMode;
        }
    }
}
