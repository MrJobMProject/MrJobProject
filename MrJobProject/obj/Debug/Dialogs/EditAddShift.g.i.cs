﻿#pragma checksum "..\..\..\Dialogs\EditAddShift.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10099C7DC1FEFE90EC6517D23806DFA295D06CDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MrJobProject.Dialogs;
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


namespace MrJobProject.Dialogs {
    
    
    /// <summary>
    /// EditAddShift
    /// </summary>
    public partial class EditAddShift : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Dialogs\EditAddShift.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameValue;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Dialogs\EditAddShift.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox timeFromHour;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Dialogs\EditAddShift.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox timeFromMin;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Dialogs\EditAddShift.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox timeToHour;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Dialogs\EditAddShift.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox timeToMin;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Dialogs\EditAddShift.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/MrJobProject;component/dialogs/editaddshift.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dialogs\EditAddShift.xaml"
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
            this.nameValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.timeFromHour = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\Dialogs\EditAddShift.xaml"
            this.timeFromHour.GotFocus += new System.Windows.RoutedEventHandler(this.TimeFromHour_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.timeFromMin = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Dialogs\EditAddShift.xaml"
            this.timeFromMin.GotFocus += new System.Windows.RoutedEventHandler(this.TimeFromMin_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.timeToHour = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Dialogs\EditAddShift.xaml"
            this.timeToHour.GotFocus += new System.Windows.RoutedEventHandler(this.TimeToHour_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.timeToMin = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\Dialogs\EditAddShift.xaml"
            this.timeToMin.GotFocus += new System.Windows.RoutedEventHandler(this.TimeToMin_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Dialogs\EditAddShift.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

