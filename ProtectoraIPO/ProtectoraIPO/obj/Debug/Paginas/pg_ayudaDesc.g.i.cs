﻿#pragma checksum "..\..\..\Paginas\pg_ayudaDesc.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1FD20AEA89342C2A7DE24FF643CF24A89E7F3353EC2275054C3CEDA0AA331A89"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ProtectoraIPO.Paginas;
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


namespace ProtectoraIPO.Paginas {
    
    
    /// <summary>
    /// pg_ayudaDesc
    /// </summary>
    public partial class pg_ayudaDesc : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Paginas\pg_ayudaDesc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_titulo;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Paginas\pg_ayudaDesc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_atrasDesc;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Paginas\pg_ayudaDesc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_foto;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Paginas\pg_ayudaDesc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox gb_pasos;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Paginas\pg_ayudaDesc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sp_pasos;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Paginas\pg_ayudaDesc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RB_0;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Paginas\pg_ayudaDesc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_descripcion;
        
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
            System.Uri resourceLocater = new System.Uri("/ProtectoraIPO;component/paginas/pg_ayudadesc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Paginas\pg_ayudaDesc.xaml"
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
            this.lbl_titulo = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btn_atrasDesc = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Paginas\pg_ayudaDesc.xaml"
            this.btn_atrasDesc.Click += new System.Windows.RoutedEventHandler(this.btn_atrasDesc_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.img_foto = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.gb_pasos = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 5:
            this.sp_pasos = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.RB_0 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 27 "..\..\..\Paginas\pg_ayudaDesc.xaml"
            this.RB_0.Click += new System.Windows.RoutedEventHandler(this.RB_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txt_descripcion = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
