﻿#pragma checksum "..\..\..\UserControllers\ScheduleUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3F50FC36B4739BA051A6806E48DCE832A0A63811320A83448A9CEEA979F0F431"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gu.Wpf.DataGrid2D;
using MrJobProject.Converters;
using MrJobProject.UserControllers;
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


namespace MrJobProject.UserControllers {
    
    
    /// <summary>
    /// ScheduleUC
    /// </summary>
    public partial class ScheduleUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\UserControllers\ScheduleUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid WorkersList;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\UserControllers\ScheduleUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ScheduleList;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\UserControllers\ScheduleUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ShiftList;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\UserControllers\ScheduleUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackDateBtn;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\UserControllers\ScheduleUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ForwardDateBtn;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\UserControllers\ScheduleUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\UserControllers\ScheduleUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListOfYears;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\UserControllers\ScheduleUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListOfMonths;
        
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
            System.Uri resourceLocater = new System.Uri("/MrJobProject;component/usercontrollers/scheduleuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControllers\ScheduleUC.xaml"
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
            
            #line 10 "..\..\..\UserControllers\ScheduleUC.xaml"
            ((MrJobProject.UserControllers.ScheduleUC)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.UserControl_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.WorkersList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.ScheduleList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.ShiftList = ((System.Windows.Controls.ListBox)(target));
            
            #line 86 "..\..\..\UserControllers\ScheduleUC.xaml"
            this.ShiftList.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ShiftList_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 91 "..\..\..\UserControllers\ScheduleUC.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteShift);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 93 "..\..\..\UserControllers\ScheduleUC.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddShiftDialog);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 95 "..\..\..\UserControllers\ScheduleUC.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.EditShiftDialog);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BackDateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\UserControllers\ScheduleUC.xaml"
            this.BackDateBtn.Click += new System.Windows.RoutedEventHandler(this.BackDateBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ForwardDateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\..\UserControllers\ScheduleUC.xaml"
            this.ForwardDateBtn.Click += new System.Windows.RoutedEventHandler(this.ForwardDateBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 151 "..\..\..\UserControllers\ScheduleUC.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ListOfYears = ((System.Windows.Controls.ComboBox)(target));
            
            #line 160 "..\..\..\UserControllers\ScheduleUC.xaml"
            this.ListOfYears.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListOfYears_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ListOfMonths = ((System.Windows.Controls.ComboBox)(target));
            
            #line 177 "..\..\..\UserControllers\ScheduleUC.xaml"
            this.ListOfMonths.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListOfMonths_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

