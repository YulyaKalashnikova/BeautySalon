﻿#pragma checksum "..\..\WorkOfEmployeePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FD551539784A57852B3D261F513F6BE6BD8C79F1ED40696738C09B47F4F642E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BeautySalon;
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


namespace BeautySalon {
    
    
    /// <summary>
    /// WorkOfEmployeePage
    /// </summary>
    public partial class WorkOfEmployeePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\WorkOfEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbRole;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\WorkOfEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PersonData;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\WorkOfEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid DataOfMaster;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\WorkOfEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProcedureOfMasterList;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\WorkOfEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbProcedure;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\WorkOfEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddInTable;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\WorkOfEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbPosition;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\WorkOfEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddOrEditEmployee;
        
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
            System.Uri resourceLocater = new System.Uri("/BeautySalon;component/workofemployeepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WorkOfEmployeePage.xaml"
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
            this.CmbRole = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\WorkOfEmployeePage.xaml"
            this.CmbRole.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbRole_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PersonData = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.DataOfMaster = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.ProcedureOfMasterList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.CmbProcedure = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.BtnAddInTable = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\WorkOfEmployeePage.xaml"
            this.BtnAddInTable.Click += new System.Windows.RoutedEventHandler(this.BtnAddInTable_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CmbPosition = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.BtnAddOrEditEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\WorkOfEmployeePage.xaml"
            this.BtnAddOrEditEmployee.Click += new System.Windows.RoutedEventHandler(this.BtnAddOrEditEmployee_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 60 "..\..\WorkOfEmployeePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDeleteProcedure_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

