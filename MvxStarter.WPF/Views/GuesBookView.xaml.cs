using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MvvmCross.ViewModels;
using MvxStarter.Core.ViewModels;

namespace MvxStarter.WPF.Views
{
    /// <summary>
    /// Logika interakcji dla klasy GuesBookView.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(GuestBookViewModel))]
    public partial class GuesBookView : MvxWpfView
    {
        public GuesBookView()
        {
            InitializeComponent();
        }
    }
}
