// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPlugin.cs" company="SyndicatedLife">
//   Copyright� 2007 - 2020 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   IPlugin.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface {
    using System;
    using System.Collections.Generic;
    using Avalonia.Controls;

    // TODO: Needed? [InheritedExport(typeof(IPlugin)),]
    public interface IPlugin {
        string Copyright { get; }

        string Description { get; }

        string FriendlyName { get; }

        string Icon { get; }

        Dictionary<string, string> Locale { get; set; }

        string Name { get; }

        string Notice { get; }

        FFXIVAPP.Common.WPF.MessageBoxResult PopupResult { get; set; }

        Exception Trace { get; }

        string Version { get; }

        TabItem CreateTab();

        void Dispose(bool isUpdating = false);

        void Initialize(IPluginHost pluginHost);
    }
}