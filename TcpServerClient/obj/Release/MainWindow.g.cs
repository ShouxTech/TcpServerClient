#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DECCA7FB7A83A78F045A85FFB31AA38F102EBDDFAC22ADDC6AB12E7F0E3CDAC5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TcpServerClient;


namespace TcpServerClient {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox portBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sendBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startServerBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox outputBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientPortBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientInputBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clientSendBtn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button connectClientBtn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientOutputBox;
        
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
            System.Uri resourceLocater = new System.Uri("/TcpServerClient;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 8 "..\..\MainWindow.xaml"
            ((TcpServerClient.MainWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.portBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\MainWindow.xaml"
            this.portBox.GotFocus += new System.Windows.RoutedEventHandler(this.portBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 26 "..\..\MainWindow.xaml"
            this.portBox.LostFocus += new System.Windows.RoutedEventHandler(this.portBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 26 "..\..\MainWindow.xaml"
            this.portBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.portBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.inputBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.inputBox.GotFocus += new System.Windows.RoutedEventHandler(this.inputBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 33 "..\..\MainWindow.xaml"
            this.inputBox.LostFocus += new System.Windows.RoutedEventHandler(this.inputBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sendBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.sendBtn.Click += new System.Windows.RoutedEventHandler(this.sendBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.startServerBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.startServerBtn.Click += new System.Windows.RoutedEventHandler(this.startServerBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.outputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.clientPortBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.clientPortBox.GotFocus += new System.Windows.RoutedEventHandler(this.clientPortBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 39 "..\..\MainWindow.xaml"
            this.clientPortBox.LostFocus += new System.Windows.RoutedEventHandler(this.clientPortBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.clientInputBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.clientInputBox.GotFocus += new System.Windows.RoutedEventHandler(this.clientInputBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 46 "..\..\MainWindow.xaml"
            this.clientInputBox.LostFocus += new System.Windows.RoutedEventHandler(this.clientInputBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.clientSendBtn = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.clientSendBtn.Click += new System.Windows.RoutedEventHandler(this.clientSendBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.connectClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\MainWindow.xaml"
            this.connectClientBtn.Click += new System.Windows.RoutedEventHandler(this.connectClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.clientOutputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

