﻿#pragma checksum "..\..\CustomerDeposit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "80662271622E4EF1A44A9330376F20D4B7DDCDD16A055B87424B48849CE19EDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IZBankingATM;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace IZBankingATM {
    
    
    /// <summary>
    /// CustomerDeposit
    /// </summary>
    public partial class CustomerDeposit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\CustomerDeposit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CustomerDeposit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DepositInput;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CustomerDeposit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DepositButton;
        
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
            System.Uri resourceLocater = new System.Uri("/IZBankingATM;component/customerdeposit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustomerDeposit.xaml"
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
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\CustomerDeposit.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.SaldoBackButton);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DepositInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\CustomerDeposit.xaml"
            this.DepositInput.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DepositInput_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 21 "..\..\CustomerDeposit.xaml"
            this.DepositInput.AddHandler(System.Windows.DataObject.PastingEvent, new System.Windows.DataObjectPastingEventHandler(this.DepositInput_DataObjectPasting));
            
            #line default
            #line hidden
            return;
            case 3:
            this.DepositButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\CustomerDeposit.xaml"
            this.DepositButton.Click += new System.Windows.RoutedEventHandler(this.DepositButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

