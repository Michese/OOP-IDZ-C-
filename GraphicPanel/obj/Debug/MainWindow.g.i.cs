﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FF758CDF139348044FFD4CB29FF2D5714AB004B6D5A0B14AC842AFE248E43922"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GraphicPanel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GraphicPanel {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderdrawPanel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas drawPanel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Line Arrow_type_1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Line Arrow_type_2;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Line Arrow_type_3;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTextBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mainAttributeTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GraphicPanel;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.borderdrawPanel = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.drawPanel = ((System.Windows.Controls.Canvas)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.drawPanel.MouseMove += new System.Windows.Input.MouseEventHandler(this.drawPanel_MouseMove);
            
            #line default
            #line hidden
            
            #line 23 "..\..\MainWindow.xaml"
            this.drawPanel.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.drawPanel_MouseUp);
            
            #line default
            #line hidden
            
            #line 23 "..\..\MainWindow.xaml"
            this.drawPanel.Drop += new System.Windows.DragEventHandler(this.drawPanel_Drop);
            
            #line default
            #line hidden
            
            #line 23 "..\..\MainWindow.xaml"
            this.drawPanel.DragEnter += new System.Windows.DragEventHandler(this.drawPanel_DragEnter);
            
            #line default
            #line hidden
            
            #line 23 "..\..\MainWindow.xaml"
            this.drawPanel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.drawPanel_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 29 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.arrow_canvas_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Arrow_type_1 = ((System.Windows.Shapes.Line)(target));
            return;
            case 5:
            
            #line 36 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.arrow_canvas_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Arrow_type_2 = ((System.Windows.Shapes.Line)(target));
            return;
            case 7:
            
            #line 43 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.arrow_canvas_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Arrow_type_3 = ((System.Windows.Shapes.Line)(target));
            return;
            case 9:
            
            #line 52 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 55 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.StackPanel_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.nameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.mainAttributeTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.mainAttributeTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.mainTextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 63 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 64 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_on);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 65 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_off);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

