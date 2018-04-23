using DevExpress.Data.Utils.ServiceModel;
using DevExpress.XtraReports.Service;
using CustomEditorSample;
using DevExpress.XtraReports.UI;

namespace ReportService {
    [SilverlightFaultBehavior]
    public class ReportService : DevExpress.XtraReports.Service.ReportService {
        static ReportService() {
            EditActionInvokerFactory.RegisterInvoker<ChangeImageSizeModeAction, ChangeImageSizeModeActionInvoker>();
        }

        protected override void FillCustomProperties(string reportName, XRControl control, System.Collections.Generic.IDictionary<string, object> properties) {
            var pictureBox = control as XRPictureBox;
            if(pictureBox == null)
                return;
            properties["Sizing"] = pictureBox.Sizing;
        }
    }
}
