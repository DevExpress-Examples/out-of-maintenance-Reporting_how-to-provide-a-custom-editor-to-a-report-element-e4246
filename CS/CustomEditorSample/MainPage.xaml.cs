using System.Windows.Controls;
using DevExpress.Xpf.ReportDesigner;

namespace CustomEditorSample {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            designer.Model.CustomizeReportControlEditor += Model_CustomizeReportControlEditor;
        }

        void Model_CustomizeReportControlEditor(object sender, CustomizeReportControlEditorEventArgs e) {
            if(e.GetXRControlTypeName() != "DevExpress.XtraReports.UI.XRPictureBox")
                return;
            e.EditorCreators.Add(new PictureBoxEditorCreator());
        }
    }
}
