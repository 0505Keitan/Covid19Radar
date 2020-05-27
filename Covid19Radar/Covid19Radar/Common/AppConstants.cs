﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Radar.Common
{
    public class AppConstants
    {
        public static readonly string AppCenterTokensAndroid = "APPCENTER_ANDROID";
        public static readonly string AppCenterTokensIOS = "APPCENTER_IOS";

        public static readonly string ApiUserSecretKeyPrefix = "Bearer";
        public static readonly string AppName = "COVID-19RADAR";
        public static readonly string AppVersion = "Ver 1.0.0";
        public static readonly string AppStoreUrl = "https://www.apple.com/jp/ios/app-store/";
        public static readonly string GooglePlayUrl = "https://play.google.com/store";

        public static readonly string ApiBaseUrl = "***REMOVED***/api";
//        public static readonly string ApiSecret = "API_SECRET";
        public static readonly string ApiSecret = "***REMOVED***";

        public static readonly int NumberOfGroup = 86400;

        public static readonly string SqliteFilename = "local.db3";

        public static readonly string LicenseUrl = "https://covid19radar.z11.web.core.windows.net/license.html";

        // Android Safetynet API Key
        public static readonly string safetyNetApiKey = "YOUR-KEY-HERE";
    }
}
