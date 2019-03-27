using System;
using System.ComponentModel;
using System.Windows;

namespace MvvM_ViewModelLocatorDemo
{
    public static class ViewModelLocator
    {
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AutoWireViewModelProperty =
            DependencyProperty.RegisterAttached("AutoWireViewModel", typeof(bool), typeof(ViewModelLocator),
                new PropertyMetadata(false, AutoWireViewModelChanged));

        private static void AutoWireViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(DesignerProperties.GetIsInDesignMode(d)) return; // Let's dont disturb the designer.
            var viewTypeName = d.GetType().FullName;
            var viewModelTypeName = viewTypeName.Replace("Views", "ViewModels") + "Model";
            var viewModelType = Type.GetType(viewModelTypeName);
            var viewModelInstance = Activator.CreateInstance(viewModelType);
            ((FrameworkElement) d).DataContext = viewModelInstance;
        }

        public static bool GetAutoWireViewModel(DependencyObject obj)
        {
            return (bool) obj.GetValue(AutoWireViewModelProperty);
        }

        public static void SetAutoWireViewModel(DependencyObject obj, bool value)
        {
            obj.SetValue(AutoWireViewModelProperty, value);
        }
    }
}