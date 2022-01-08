﻿#region Imports

using Lunox.Views;
using Microsoft.Toolkit.Uwp.Helpers;
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

#endregion

namespace Lunox.Services
{
    #region FirstRunDisplayService

    /// <summary>
    /// 
    /// </summary>
    public static class FirstRunDisplayService
    {
        #region Variables

        /// <summary>
        /// 
        /// </summary>
        private static bool shown = false;

        #endregion

        #region Functions

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static async Task ShowIfAppropriateAsync()
        {
            await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync
            (
                CoreDispatcherPriority.Normal, async () =>
                {
                    if (SystemInformation.Instance.IsFirstRun && !shown)
                    {
                        shown = true;
                        FirstRunDialog dialog = new FirstRunDialog();
                        await dialog.ShowAsync();
                    }
                }
            );
        }

        #endregion
    }

    #endregion
}