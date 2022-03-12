using CurselessModUtility.Controllers;
using CurselessModUtility.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurselessModUtility
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CurseForgeAPIController.Instance.Init();

            ((INotifyCollectionChanged)listView.Items).CollectionChanged += ListView_CollectionChanged;
        }

        private void ListView_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action != NotifyCollectionChangedAction.Add) return;

            // API request to get mod info
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.V && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                var url = Clipboard.GetText();

                if (!Uri.IsWellFormedUriString(url, UriKind.Absolute)) return;

                AddItemByURL(url);
            }
        }

        private void AddItemByURL(string url)
        {
            var item = new ModListItem(url);

            if (listView.Items.Contains(item)) return;

            listView.Items.Add(item);
        }

        private async Task Test()
        {
            var response = await CurseForgeAPIController.Instance.Request("/v1/minecraft/version");

            Console.WriteLine(response);
            Console.WriteLine(response.Content);

        }

        private async void testButton_Click(object sender, RoutedEventArgs e)
        {
            await Test();
        }
    }
}
