﻿#pragma checksum "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "33FCDAFA1987760FA15ED51043FC60BA595B71075D9003634905013D262FC70C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using TurismoReal.Vistas.VistasAdmin;


namespace TurismoReal.Vistas.VistasAdmin {
    
    
    /// <summary>
    /// Departamentos
    /// </summary>
    public partial class Departamentos : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 225 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridDepartamento;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Contenido;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbBuscar;
        
        #line default
        #line hidden
        
        
        #line 312 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBuscar;
        
        #line default
        #line hidden
        
        
        #line 328 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCrearDepto;
        
        #line default
        #line hidden
        
        
        #line 342 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridDatos;
        
        #line default
        #line hidden
        
        
        #line 422 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameDepartamentos;
        
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
            System.Uri resourceLocater = new System.Uri("/TurismoReal;component/vistas/vistasadmin/departamentos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
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
            this.GridDepartamento = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Contenido = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.tbBuscar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtnBuscar = ((System.Windows.Controls.Button)(target));
            
            #line 313 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
            this.BtnBuscar.Click += new System.Windows.RoutedEventHandler(this.Ver);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnCrearDepto = ((System.Windows.Controls.Button)(target));
            
            #line 330 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
            this.BtnCrearDepto.Click += new System.Windows.RoutedEventHandler(this.BtnAgregarDepto_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GridDatos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.FrameDepartamentos = ((System.Windows.Controls.Frame)(target));
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
            case 7:
            
            #line 383 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Consultar);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 394 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Actualizar);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 405 "..\..\..\..\Vistas\VistasAdmin\Departamentos.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Eliminar);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

