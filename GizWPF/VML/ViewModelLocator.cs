using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GizWPF.VML
{
    public class ViewModelLocator
    {
        /* Using a DependencyProperty as the backing store for AutoHookedUpViewModel.
       This enables animation, styling, binding, etc...*/
        public static readonly DependencyProperty AutoHookedUpViewModelProperty =
         DependencyProperty.RegisterAttached("AutoHookedUpViewModel",
         typeof(bool), typeof(ViewModelLocator), new PropertyMetadata(false,
        AutoHookedUpViewModelChanged));

        public static bool GetAutoHookedUpViewModel(DependencyObject obj)
        {
            return (bool)obj.GetValue(AutoHookedUpViewModelProperty);
        }

        public static void SetAutoHookedUpViewModel(DependencyObject obj, bool value)
        {
            obj.SetValue(AutoHookedUpViewModelProperty, value);
        }
       

        
         //TODO Anas: Manipulate this to hook differnet views for presnte,edit,delete or add 
        
        private static void AutoHookedUpViewModelChanged(DependencyObject d,
    DependencyPropertyChangedEventArgs e)
        {
            if (DesignerProperties.GetIsInDesignMode(d)) return;
            var viewType = d.GetType();
            string str = viewType.FullName;
            str = str.Replace(".View.", ".ViewModel.");
            var viewTypeName = str;
            var viewModelTypeName = viewTypeName + "Model";
            var viewModelType = Type.GetType(viewModelTypeName);
            var viewModel = Activator.CreateInstance(viewModelType);
            ((FrameworkElement)d).DataContext = viewModel;
        }
    }
}
