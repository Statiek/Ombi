﻿using Newtonsoft.Json;

namespace Ombi.Settings.Settings.Models
{
    public class CustomizationSettings : Settings
    {
        public string ApplicationName { get; set; }
        public string ApplicationUrl { get; set; }

        public void AddToUrl(string part)
        {
            if (string.IsNullOrEmpty(ApplicationUrl))
            {
                ApplicationUrl = part;
            }

            if (ApplicationUrl.EndsWith("/"))
            {
                ApplicationUrl.Remove(ApplicationUrl.Length - 1);
            }
            if (!part.StartsWith("/"))
            {
                part = "/" + part;
            }
            ApplicationUrl = ApplicationUrl + part;
        }
        public string Logo { get; set; }
    }
}