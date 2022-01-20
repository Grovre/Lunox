﻿using Lunox.Library.Helper;
using Windows.UI.Xaml.Controls;

// Boş Sayfa öğe şablonu https://go.microsoft.com/fwlink/?LinkId=234238 adresinde açıklanmaktadır

namespace Lunox.Core.Views
{
    /// <summary>
    /// Kendi başına kullanılabilecek ya da bir Çerçeve içine gezinebilecek boş bir sayfa.
    /// </summary>
    public sealed partial class TestPage : Page
    {
        /// <summary>
        /// 
        /// </summary>
        public TestPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            string Text = string.Empty;

            //await Windows.System.UserProfile.UserProfilePersonalizationSettings.Current.TrySetWallpaperImageAsync(null);
            //Windows.System.Profile.AnalyticsInfo.

            Text = Windows.System.UserProfile.GlobalizationPreferences.HomeGeographicRegion;

            Dialog.SendDialog(Text);
        }
    }
}