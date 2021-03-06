﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TargetInfoEvent.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2020 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   TargetInfoEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;

    using Sharlayan.Core;

    public class TargetInfoEvent : EventArgs {
        public TargetInfoEvent(object sender, TargetInfo targetInfo) {
            this.Sender = sender;
            this.TargetInfo = targetInfo;
        }

        public object Sender { get; set; }

        public TargetInfo TargetInfo { get; set; }
    }
}