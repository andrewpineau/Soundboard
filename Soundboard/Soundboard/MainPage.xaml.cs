using Soundboard.Models;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Soundboard
{
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Sound> sounds = new ObservableCollection<Sound>();
        private List<MenuItem> MenuItems = new List<MenuItem>();
        public MainPage()
        {
            this.InitializeComponent();
            SoundManager.GetAllSounds(sounds);
            MenuItems.Add(new MenuItem { IconFile = "/Assets/Icons/animals.png", Category = SoundCategory.Animals});
            MenuItems.Add(new MenuItem { IconFile = "/Assets/Icons/cartoon.png", Category = SoundCategory.Cartoons });
            MenuItems.Add(new MenuItem { IconFile = "/Assets/Icons/taunt.png", Category = SoundCategory.Taunts });
            MenuItems.Add(new MenuItem { IconFile = "/Assets/Icons/warning.png", Category = SoundCategory.Warnings });
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void SearchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
           
        }

        private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {

        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
