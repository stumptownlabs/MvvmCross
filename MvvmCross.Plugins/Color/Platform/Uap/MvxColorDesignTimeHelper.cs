﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using MvvmCross.Base;
using MvvmCross.Base.UI;
using MvvmCross.Platform.Uap.Base.Platform;

namespace MvvmCross.Plugin.Color.Platform.Uap
{
    public class MvxColorDesignTimeHelper
        : MvxDesignTimeHelper
    {
        public MvxColorDesignTimeHelper()
        {
            if (!IsInDesignTool)
                return;

            if (Mvx.CanResolve<IMvxNativeColor>())
                return;

            var forceLoaded = new Plugin();
            forceLoaded.Load();
        }
    }
}
