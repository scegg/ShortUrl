﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecretNest.ShortUrl
{
    public class Setting
    {
        public UrlSetting Default;
        public string ManageKey;
        public string ReloadKey;
        public Dictionary<string, UrlSetting> Records;
    }

    public class UrlSetting
    {
        public string Url;
        public bool IsPermanent;
    }
}