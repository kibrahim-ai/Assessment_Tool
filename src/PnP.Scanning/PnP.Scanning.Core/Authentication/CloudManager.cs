﻿using PnP.Core.Services;

namespace PnP.Scanning.Core.Authentication
{
    internal static class CloudManager
    {
        internal static Microsoft365Environment GetEnvironmentFromUri(Uri url)
        {
            var dnsDomain = url.Authority.Substring(url.Authority.LastIndexOf('.') + 1);

            return dnsDomain switch
            {
                "com" => Microsoft365Environment.Production,
                "us" => Microsoft365Environment.USGovernment,
                "de" => Microsoft365Environment.Germany,
                "cn" => Microsoft365Environment.China,
                _ => Microsoft365Environment.Production,
            };
        }

        /// <summary>
        /// Returns the graph authority for the in use environment. See https://docs.microsoft.com/en-us/graph/deployments for details
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        internal static string GetMicrosoftGraphAuthority(Microsoft365Environment environment)
        {
            return environment switch
            {
                Microsoft365Environment.Production => "graph.microsoft.com",
                Microsoft365Environment.PreProduction => "graph.microsoft.com",
                Microsoft365Environment.USGovernment => "graph.microsoft.com",
                Microsoft365Environment.USGovernmentHigh => "graph.microsoft.us",
                Microsoft365Environment.USGovernmentDoD => "dod-graph.microsoft.us",
                Microsoft365Environment.Germany => "graph.microsoft.de",
                Microsoft365Environment.China => "microsoftgraph.chinacloudapi.cn",
                _ => "graph.microsoft.com"
            };
        }

        /// <summary>
        /// Returns the Azure AD login authority. See https://docs.microsoft.com/en-us/graph/deployments for details
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        internal static string GetAzureADLoginAuthority(Microsoft365Environment environment)
        {
            return environment switch
            {
                Microsoft365Environment.Production => "login.microsoftonline.com",
                Microsoft365Environment.PreProduction => "login.windows-ppe.net",
                Microsoft365Environment.USGovernment => "login.microsoftonline.us",
                Microsoft365Environment.USGovernmentHigh => "login.microsoftonline.us",
                Microsoft365Environment.USGovernmentDoD => "login.microsoftonline.us",
                Microsoft365Environment.Germany => "login.microsoftonline.de",
                Microsoft365Environment.China => "login.chinacloudapi.cn",
                _ => "login.microsoftonline.com"
            };
        }

    }
}
