using CustomEditorSample;
using DevExpress.DocumentServices.ServiceModel.DataContracts.Xpf.Designer;
using DevExpress.XtraReports.Service;
using DevExpress.XtraReports.UI;

namespace ReportService {
    public class ChangeImageSizeModeActionInvoker : EditActionBaseInvoker {
        protected override void ControlInvoke(XRControl control, EditActionBase editAction) {
            var action = editAction as ChangeImageSizeModeAction;
            var pictureBox = control as XRPictureBox;
            if(action == null || pictureBox == null)
                return;
            pictureBox.Sizing = action.ImageSizeMode;
        }
    }
}
