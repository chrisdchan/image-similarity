﻿#pragma checksum "..\..\..\Views\DiceCoefficient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E774961F6711CB8A181BCCC11F59260158AC52A57A6B2A006CBBB4D9A90EC632"
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
    /// DiceCoefficient
    /// </summary>
    public partial class DiceCoefficient : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Views\DiceCoefficient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\DiceCoefficient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\DiceCoefficient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img2;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\DiceCoefficient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock cortext;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\DiceCoefficient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider zslider;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\DiceCoefficient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock zsliderTxt;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Views\DiceCoefficient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text1;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Views\DiceCoefficient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider alphaSlider;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Views\DiceCoefficient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock alphaTxt;
        
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
            System.Uri resourceLocater = new System.Uri("/Dice Similarity Coefficient;component/views/dicecoefficient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\DiceCoefficient.xaml"
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
            
            #line 27 "..\..\..\Views\DiceCoefficient.xaml"
            this.canvas.SizeChanged += new System.Windows.SizeChangedEventHandler(this.canvas_SizeChanged);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\Views\DiceCoefficient.xaml"
            this.canvas.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.canvas_PreviewMouseMove);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\Views\DiceCoefficient.xaml"
            this.canvas.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.canvas_PreviewMouseUp);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\Views\DiceCoefficient.xaml"
            this.canvas.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.canvas_PreviewMouseWheel);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\Views\DiceCoefficient.xaml"
            this.canvas.PreviewMouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.canvas_PreviewMouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.img1 = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.img2 = ((System.Windows.Controls.Image)(target));
            
            #line 38 "..\..\..\Views\DiceCoefficient.xaml"
            this.img2.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.img2_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cortext = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.zslider = ((System.Windows.Controls.Slider)(target));
            
            #line 51 "..\..\..\Views\DiceCoefficient.xaml"
            this.zslider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.zslider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.zsliderTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 67 "..\..\..\Views\DiceCoefficient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.calculate);
            
            #line default
            #line hidden
            return;
            case 8:
            this.text1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 79 "..\..\..\Views\DiceCoefficient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.autoCenter);
            
            #line default
            #line hidden
            return;
            case 10:
            this.alphaSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 90 "..\..\..\Views\DiceCoefficient.xaml"
            this.alphaSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.alpha_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.alphaTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
