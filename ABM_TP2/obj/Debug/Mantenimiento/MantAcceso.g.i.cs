﻿#pragma checksum "..\..\..\Mantenimiento\MantAcceso.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "754C33FDE287CD6676B8CFDDF38919E60A4946497AF1B4CF5B6AB46D09AF4C48"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ABM_TP2.Mantenimiento;
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


namespace ABM_TP2.Mantenimiento {
    
    
    /// <summary>
    /// MantAcceso
    /// </summary>
    public partial class MantAcceso : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Mantenimiento\MantAcceso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbEmpleado;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Mantenimiento\MantAcceso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHoraEntrada;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Mantenimiento\MantAcceso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHoraSalida;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Mantenimiento\MantAcceso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCodAcceso;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Mantenimiento\MantAcceso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgAcceso;
        
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
            System.Uri resourceLocater = new System.Uri("/ABM_TP2;component/mantenimiento/mantacceso.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Mantenimiento\MantAcceso.xaml"
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
            
            #line 10 "..\..\..\Mantenimiento\MantAcceso.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 11 "..\..\..\Mantenimiento\MantAcceso.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 12 "..\..\..\Mantenimiento\MantAcceso.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbEmpleado = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.txtHoraEntrada = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtHoraSalida = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtCodAcceso = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.dtgAcceso = ((System.Windows.Controls.DataGrid)(target));
            
            #line 20 "..\..\..\Mantenimiento\MantAcceso.xaml"
            this.dtgAcceso.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

