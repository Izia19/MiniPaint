﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EEED2993697E61489D648BADECEBB9D9E62E23C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using minipaint;


namespace minipaint {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Szerokosc;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Wysokosc;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edycja_button;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Szerokosc_line;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Gumka_button;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Canvas;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/minipaint;V1.0.0.0;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 16 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.wybierz_figure);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.wybierz_figure);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 20 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.wybierz_figure);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 22 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.wybierz_figure);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 25 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.zmien_color);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Szerokosc = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\MainWindow.xaml"
            this.Szerokosc.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tylko_cyfra);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\MainWindow.xaml"
            this.Szerokosc.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.wpisana_wartosc);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Wysokosc = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\MainWindow.xaml"
            this.Wysokosc.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tylko_cyfra);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\MainWindow.xaml"
            this.Wysokosc.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.wpisana_wartosc);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 38 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.wyczysc_wysokosc_szerokosc);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Edycja_button = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\MainWindow.xaml"
            this.Edycja_button.Click += new System.Windows.RoutedEventHandler(this.edycja_true);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Szerokosc_line = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\MainWindow.xaml"
            this.Szerokosc_line.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tylko_cyfra);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Gumka_button = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\MainWindow.xaml"
            this.Gumka_button.Click += new System.Windows.RoutedEventHandler(this.gumka_true);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Canvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 46 "..\..\..\MainWindow.xaml"
            this.Canvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.rysuj);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\MainWindow.xaml"
            this.Canvas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lewy_przycisk_down);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\MainWindow.xaml"
            this.Canvas.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.lewy_przycisk_up);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\MainWindow.xaml"
            this.Canvas.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.prawy_przycisk_down);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\MainWindow.xaml"
            this.Canvas.MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.prawy_przycisk_up);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

