// Updated by XamlIntelliSenseFileGenerator 18.11.2021 12:39:50
#pragma checksum "..\..\SuplicePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "16C6E5440B1172122DAAF436B9C89D280C8FFAD12CC57E0C78AC684793BB76D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Project;
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


namespace Project
{


    /// <summary>
    /// SuplicePage
    /// </summary>
    public partial class SuplicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 16 "..\..\SuplicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid;

#line default
#line hidden


#line 26 "..\..\SuplicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addSup;

#line default
#line hidden


#line 29 "..\..\SuplicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditSup;

#line default
#line hidden


#line 32 "..\..\SuplicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelSup;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project;component/suplicepage.xaml", System.UriKind.Relative);

#line 1 "..\..\SuplicePage.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.DataGrid = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 2:
                    this.addSup = ((System.Windows.Controls.Button)(target));

#line 26 "..\..\SuplicePage.xaml"
                    this.addSup.Click += new System.Windows.RoutedEventHandler(this.addSup_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.EditSup = ((System.Windows.Controls.Button)(target));

#line 29 "..\..\SuplicePage.xaml"
                    this.EditSup.Click += new System.Windows.RoutedEventHandler(this.EditSup_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.DelSup = ((System.Windows.Controls.Button)(target));

#line 32 "..\..\SuplicePage.xaml"
                    this.DelSup.Click += new System.Windows.RoutedEventHandler(this.DelSup_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.RadioButton apartments;
        internal System.Windows.Controls.RadioButton houses;
        internal System.Windows.Controls.RadioButton lands;
    }
}
