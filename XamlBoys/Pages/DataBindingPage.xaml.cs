using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace XamlBoys.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DataBindingPage : Page
    {
        private List<Book> Books { get; } = new List<Book>()
        {
            new Book()
            {
                Author = "Sarah J. Maas",
                Title = "A Court of Thorns and Roses",
                CoverImage = "http://www.scifinow.co.uk/wp-content/uploads/2015/05/A-Court-of-Thorns-And-Roses.jpg"
            },
            new Book()
            {
                Author = "Sarah J. Maas",
                Title = "A Court of Mist and Fury",
                CoverImage = "https://thebookcorps.files.wordpress.com/2016/06/acomaf.jpg"
            },
            new Book()
            {
                Author = "Sarah J. Maas",
                Title = "A Court of Wings and Ruin",
                CoverImage = "http://cdn.amreading.com/wp-content/uploads/a-court-of-wings-and-ruin1.jpg"
            }
        };

        private ObservableCollection<Book> ObservableBooks { get; } = new ObservableCollection<Book>();

        public DataBindingPage()
        {
            this.InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (ObservableBooks.Count == Books.Count)
            {
                // No books to add!
                return;
            }

            var index = ObservableBooks.Count;
            var book = Books[index];

            ObservableBooks.Add(book);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ObservableBooks.Count == 0)
            {
                // No books to remove!
                return;
            }

            ObservableBooks.RemoveAt(ObservableBooks.Count - 1);
        }
    }
}
