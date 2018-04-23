using System;
using System.ComponentModel;
using DevExpress.Xpf.ReportDesigner;
using DevExpress.XtraPrinting;
using DevExpress.Xpf.Core;
using System.Linq.Expressions;
using DevExpress.Utils;
using System.Windows.Input;
using DevExpress.Xpf.Core.Commands;
using System.Collections.Generic;

namespace CustomEditorSample {
    public class PictureBoxSizingEditorViewModel : INotifyPropertyChanged {
        readonly EditorServices editorServices;
        ImageSizeMode sizeMode;
        readonly ICommand applyCommand;
        readonly string controlName;

        public static Array ImageSizeModes { get { return EnumExtensions.GetValues(typeof(ImageSizeMode)); } }

        public ImageSizeMode ImageSizeMode {
            get { return sizeMode; }
            set {
                if(sizeMode != value) {
                    sizeMode = value;
                    RaisePropertyChanged(() => sizeMode);
                }
            }
        }

        public ICommand ApplyCommand { get { return applyCommand; } }

        public PictureBoxSizingEditorViewModel(EditorServices editorServices, ReportControlInfo controlInfo, IDictionary<string, object> customProperties) {
            this.editorServices = editorServices;
            applyCommand = new DelegateCommand<object>(Apply);
            controlName = controlInfo.DesignName;
            const string customProperyName = "Sizing";
            ImageSizeMode = customProperties.ContainsKey(customProperyName) && customProperties[customProperyName] is ImageSizeMode ?
                (ImageSizeMode)customProperties[customProperyName] : DevExpress.XtraPrinting.ImageSizeMode.Normal;
        }

        void Apply(object parameter) {
            var changeService = editorServices.ChangeService;
            changeService.TriggerCustomAction(new ChangeImageSizeModeAction() { ControlName = controlName, ImageSizeMode = ImageSizeMode });
            changeService.CommitChanges();
        }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged<T>(Expression<Func<T>> property) {
            PropertyExtensions.RaisePropertyChanged(this, PropertyChanged, property);
        }
        #endregion
    }
}
