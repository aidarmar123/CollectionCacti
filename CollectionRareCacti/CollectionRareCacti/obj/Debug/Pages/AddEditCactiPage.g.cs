﻿#pragma checksum "..\..\..\Pages\AddEditCactiPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7FFED966C3DD0006386BB5E09AF70E245C70AE491EC1EE44014292973DC4F47C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CollectionRareCacti.Pages;
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


namespace CollectionRareCacti.Pages {
    
    
    /// <summary>
    /// AddEditCactiPage
    /// </summary>
    public partial class AddEditCactiPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\AddEditCactiPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbCountry;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\AddEditCactiPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SpInstarction;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\AddEditCactiPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAddInstaction;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\AddEditCactiPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BSave;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\AddEditCactiPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BBack;
        
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
            System.Uri resourceLocater = new System.Uri("/CollectionRareCacti;component/pages/addeditcactipage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddEditCactiPage.xaml"
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
            this.CbCountry = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.SpInstarction = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.BAddInstaction = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Pages\AddEditCactiPage.xaml"
            this.BAddInstaction.Click += new System.Windows.RoutedEventHandler(this.BAddInstaction_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BSave = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pages\AddEditCactiPage.xaml"
            this.BSave.Click += new System.Windows.RoutedEventHandler(this.BSave_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BBack = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Pages\AddEditCactiPage.xaml"
            this.BBack.Click += new System.Windows.RoutedEventHandler(this.BBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

