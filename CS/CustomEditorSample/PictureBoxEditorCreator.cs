using System.Windows.Controls;
using DevExpress.Xpf.ReportDesigner;

namespace CustomEditorSample {
    public class PictureBoxEditorCreator : IReportControlEditorCreator {
        public string Caption {
            get { return "XRPictureBox Editor"; }
        }

        public Control CreateEditor(ReportControlInfo controlInfo, EditorServices services, System.Collections.Generic.IDictionary<string, object> customProperties) {
            return new PictureBoxSizingEditor() { ViewModel = new PictureBoxSizingEditorViewModel(services, controlInfo, customProperties) };
        }
    }
}
