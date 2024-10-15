using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RoomInspectionApplication
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private RoomInspectionModel _model;

        public MainPage()
        {
            this.InitializeComponent();
        }


        private void MainNavigation_Loaded(object sender, RoutedEventArgs e)
        {
            EnableMainNavigation(false); 
            ContentFrame.Navigate(typeof(StartPage));
        }


        private void EnableMainNavigation(bool enable)
        {
            MainNavigation.IsPaneVisible = enable;
            MainNavigation.IsPaneToggleButtonVisible = enable;
            MainNavigation.IsPaneOpen = enable;
        }

        private void ContentFrame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.SourcePageType != typeof(StartPage) && e.Parameter is RoomInspectionModel model && _model == null)
            {
                _model = model;
                EnableMainNavigation(true);
                MainNavigation.PaneDisplayMode = NavigationViewPaneDisplayMode.Left;
            }

            if (_model != null)
            {
                MainNavigation.MenuItems.Clear();
                foreach (RoomName value in Enum.GetValues(typeof(RoomName)))
                {
                    var description = value.GetDescription();
                    if (description != null)
                    {
                        NavigationViewItemHeader header = new NavigationViewItemHeader
                        {
                            Content = description.Description
                        };
                        MainNavigation.MenuItems.Add(header);

                        NavigationViewItem inspection = new NavigationViewItem()
                        {
                            Content = "Inspektion"
                        };
                        MainNavigation.MenuItems.Add(inspection);

                        NavigationViewItem rapport = new NavigationViewItem()
                        {
                            Content = "Sammanställning"
                        };
                        MainNavigation.MenuItems.Add(rapport);

                        MainNavigation.MenuItems.Add(new NavigationViewItemSeparator());
                    }
                    
                }
            }
        }


        
    }
}
