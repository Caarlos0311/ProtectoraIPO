﻿#pragma checksum "..\..\win_Preferencias.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ED85470B0670C15BC34A78018E8215F2D02D0FEEDA5EB47F29448C2BA4D48F6E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ProtectoraIPO;
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


namespace ProtectoraIPO {
    
    
    /// <summary>
    /// win_Preferencias
    /// </summary>
    public partial class win_Preferencias : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\win_Preferencias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_preferencias;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\win_Preferencias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProtectoraIPO.SML_switch sml_tBotones;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\win_Preferencias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProtectoraIPO.SML_switch sml_tFuente;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\win_Preferencias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProtectoraIPO.ToggleButton tbtn_tema;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\win_Preferencias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProtectoraIPO.ToggleButton tbtn_gifs;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\win_Preferencias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProtectoraIPO.ToggleButton tbtn_sonidos;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\win_Preferencias.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_aplicar;
        
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
            System.Uri resourceLocater = new System.Uri("/ProtectoraIPO;component/win_preferencias.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\win_Preferencias.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 9 "..\..\win_Preferencias.xaml"
            ((ProtectoraIPO.win_Preferencias)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid_preferencias = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.sml_tBotones = ((ProtectoraIPO.SML_switch)(target));
            return;
            case 4:
            this.sml_tFuente = ((ProtectoraIPO.SML_switch)(target));
            return;
            case 5:
            this.tbtn_tema = ((ProtectoraIPO.ToggleButton)(target));
            return;
            case 6:
            this.tbtn_gifs = ((ProtectoraIPO.ToggleButton)(target));
            return;
            case 7:
            this.tbtn_sonidos = ((ProtectoraIPO.ToggleButton)(target));
            return;
            case 8:
            this.btn_aplicar = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\win_Preferencias.xaml"
            this.btn_aplicar.Click += new System.Windows.RoutedEventHandler(this.btn_aplicar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

