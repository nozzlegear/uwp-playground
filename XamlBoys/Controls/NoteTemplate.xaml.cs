using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XamlBoys.Models;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace XamlBoys.Controls
{
    public sealed partial class NoteTemplate : UserControl
    {
        private Note Note { get { return this.DataContext as Note; } }
        
        public NoteTemplate()
        {
            this.InitializeComponent();

            this.DataContextChanged += (s, e) => Bindings.Update();
        }
    }
}
