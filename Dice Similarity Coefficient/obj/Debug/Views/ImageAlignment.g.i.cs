﻿#pragma checksum "..\..\..\Views\ImageAlignment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2EF689C4CA41F65583A7F6777AD5A9258FDA4A372B91F3033089BFB2B372EDDD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Dice_Similarity_Coefficient.Views;
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


namespace Dice_Similarity_Coefficient.Views {
    
    
    /// <summary>
    /// ImageAlignment
    /// </summary>
    public partial class ImageAlignment : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Views\ImageAlignment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\ImageAlignment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\ImageAlignment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img2;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\ImageAlignment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save;
        
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
            System.Uri resourceLocater = new System.Uri("/Dice Similarity Coefficient;component/views/imagealignment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ImageAlignment.xaml"
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
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 21 "..\..\..\Views\ImageAlignment.xaml"
            this.canvas.SizeChanged += new System.Windows.SizeChangedEventHandler(this.canvas_SizeChanged);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\Views\ImageAlignment.xaml"
            this.canvas.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.canvas_PreviewMouseMove);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\Views\ImageAlignment.xaml"
            this.canvas.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.canvas_PreviewMouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.img1 = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.img2 = ((System.Windows.Controls.Image)(target));
            
            #line 29 "..\..\..\Views\ImageAlignment.xaml"
            this.img2.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.img2_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.save = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Views\ImageAlignment.xaml"
            this.save.Click += new System.Windows.RoutedEventHandler(this.save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

