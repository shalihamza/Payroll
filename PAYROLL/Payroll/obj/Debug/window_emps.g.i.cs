﻿#pragma checksum "..\..\window_emps.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "09D815215DC408ADFB67CA363EDB85E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Payroll;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Payroll {
    
    
    /// <summary>
    /// window_emps
    /// </summary>
    public partial class window_emps : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\window_emps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_emps;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\window_emps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_open;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\window_emps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_closed;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\window_emps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_emps_no;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\window_emps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_emps_area;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\window_emps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_emps_name;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\window_emps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_records;
        
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
            System.Uri resourceLocater = new System.Uri("/Payroll;component/window_emps.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\window_emps.xaml"
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
            this.grid_emps = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.radio_open = ((System.Windows.Controls.RadioButton)(target));
            
            #line 101 "..\..\window_emps.xaml"
            this.radio_open.Checked += new System.Windows.RoutedEventHandler(this.management_action);
            
            #line default
            #line hidden
            return;
            case 3:
            this.radio_closed = ((System.Windows.Controls.RadioButton)(target));
            
            #line 102 "..\..\window_emps.xaml"
            this.radio_closed.Checked += new System.Windows.RoutedEventHandler(this.management_action);
            
            #line default
            #line hidden
            return;
            case 4:
            this.search_emps_no = ((System.Windows.Controls.TextBox)(target));
            
            #line 104 "..\..\window_emps.xaml"
            this.search_emps_no.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.management_action);
            
            #line default
            #line hidden
            return;
            case 5:
            this.search_emps_area = ((System.Windows.Controls.TextBox)(target));
            
            #line 106 "..\..\window_emps.xaml"
            this.search_emps_area.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.management_action);
            
            #line default
            #line hidden
            return;
            case 6:
            this.search_emps_name = ((System.Windows.Controls.TextBox)(target));
            
            #line 107 "..\..\window_emps.xaml"
            this.search_emps_name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.management_action);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lbl_records = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

