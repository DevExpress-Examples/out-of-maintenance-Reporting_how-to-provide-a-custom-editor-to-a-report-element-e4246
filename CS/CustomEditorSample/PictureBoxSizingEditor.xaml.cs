using System.Windows.Controls;

namespace CustomEditorSample {
    public partial class PictureBoxSizingEditor : UserControl {
        public PictureBoxSizingEditorViewModel ViewModel {
            get { return DataContext as PictureBoxSizingEditorViewModel; }
            set { DataContext = value; }
        }

        public PictureBoxSizingEditor() {
            InitializeComponent();
        }
    }
}
