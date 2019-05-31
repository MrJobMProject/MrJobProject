﻿#pragma checksum "UserControllers\HolidayUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "15E7406F98D511940A94FD2B23A651A2B3206FEC06D1E556CE0406B00C5F6451"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// HolidayUC
    /// </summary>
    public partial class HolidayUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "UserControllers\HolidayUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox WorkersList;
        
        #line default
        #line hidden
        
        
        #line 69 "UserControllers\HolidayUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox HolidaysList;
        
        #line default
        #line hidden
        
        
        #line 88 "UserControllers\HolidayUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListOfMonths;
        
        #line default
        #line hidden
        
        
        #line 104 "UserControllers\HolidayUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListOfYears;
        
        #line default
        #line hidden
        
        
        #line 119 "UserControllers\HolidayUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListOfReasons;
        
        #line default
        #line hidden
        
        
        #line 135 "UserControllers\HolidayUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddHolidayButton;
        
        #line default
        #line hidden
        
        
        #line 145 "UserControllers\HolidayUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteHolidayButton;
        
        #line default
        #line hidden
        
        
        #line 156 "UserControllers\HolidayUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllButton;
        
        #line default
        #line hidden
        
        
        #line 166 "UserControllers\HolidayUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NoneButton;
        
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
            System.Uri resourceLocater = new System.Uri("/MrJobProject;component/usercontrollers/holidayuc.xaml", System.UriKind.Relative);
            
            #line 1 "UserControllers\HolidayUC.xaml"
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
            
            #line 10 "UserControllers\HolidayUC.xaml"
            ((MrJobProject.UserControllers.HolidayUC)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            
            #line 10 "UserControllers\HolidayUC.xaml"
            ((MrJobProject.UserControllers.HolidayUC)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.UserControl_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.WorkersList = ((System.Windows.Controls.ListBox)(target));
            
            #line 43 "UserControllers\HolidayUC.xaml"
            this.WorkersList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.WorkersList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HolidaysList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.ListOfMonths = ((System.Windows.Controls.ComboBox)(target));
            
            #line 91 "UserControllers\HolidayUC.xaml"
            this.ListOfMonths.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListOfMonths_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListOfYears = ((System.Windows.Controls.ComboBox)(target));
            
            #line 107 "UserControllers\HolidayUC.xaml"
            this.ListOfYears.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListOfYears_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ListOfReasons = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.AddHolidayButton = ((System.Windows.Controls.Button)(target));
            
            #line 139 "UserControllers\HolidayUC.xaml"
            this.AddHolidayButton.Click += new System.Windows.RoutedEventHandler(this.AddHolidayButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DeleteHolidayButton = ((System.Windows.Controls.Button)(target));
            
            #line 149 "UserControllers\HolidayUC.xaml"
            this.DeleteHolidayButton.Click += new System.Windows.RoutedEventHandler(this.DeleteHolidayButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AllButton = ((System.Windows.Controls.Button)(target));
            
            #line 160 "UserControllers\HolidayUC.xaml"
            this.AllButton.Click += new System.Windows.RoutedEventHandler(this.AllButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.NoneButton = ((System.Windows.Controls.Button)(target));
            
            #line 170 "UserControllers\HolidayUC.xaml"
            this.NoneButton.Click += new System.Windows.RoutedEventHandler(this.NoneButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
