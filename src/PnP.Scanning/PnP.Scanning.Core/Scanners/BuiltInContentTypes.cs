﻿namespace PnP.Scanning.Core.Scanners
{
    internal static class BuiltInContentTypes
    {
        internal static readonly string System = "0x";
        internal static readonly string Item = "0x01";
        internal static readonly string Document = "0x0101";
        internal static readonly string XMLDocument = "0x010101";
        internal static readonly string ODCDocument = "0x010100629D00608F814dd6AC8A86903AEE72AA";
        internal static readonly string UDCDocument = "0x010100B4CBD48E029A4ad8B62CB0E41868F2B0";
        internal static readonly string Picture = "0x010102";
        internal static readonly string UntypedDocument = "0x010104";
        internal static readonly string MasterPage = "0x010105";
        internal static readonly string WikiDocument = "0x010108";
        internal static readonly string DocumentWorkflowItem = "0x010107";
        internal static readonly string Event = "0x0102";
        internal static readonly string Issue = "0x0103";
        internal static readonly string Announcement = "0x0104";
        internal static readonly string Link = "0x0105";
        internal static readonly string Contact = "0x0106";
        internal static readonly string Message = "0x0107";
        internal static readonly string Discussion = "0x012002";
        internal static readonly string Task = "0x0108";
        internal static readonly string WorkflowTask = "0x010801";
        internal static readonly string AdminTask = "0x010802";
        internal static readonly string WorkflowHistory = "0x0109";
        internal static readonly string BlogPost = "0x0110";
        internal static readonly string BlogComment = "0x0111";
        internal static readonly string Folder = "0x0120";
        internal static readonly string RootOfList = "0x012001";
        internal static readonly string Person = "0x010A";
        internal static readonly string SharePointGroup = "0x010B";
        internal static readonly string DomainGroup = "0x010C";
        internal static readonly string BasicPage = "0x010109";
        internal static readonly string WebPartPage = "0x01010901";
        internal static readonly string LinkToDocument = "0x01010A";
        internal static readonly string FarEastContact = "0x0116";
        internal static readonly string DublinCoreName = "0x01010B";
        internal static readonly string HealthRuleDefinition = "0x01003A8AA7A4F53046158C5ABD98036A01D5";
        internal static readonly string HealthReport = "0x0100F95DB3A97E8046b58C6A54FB31F2BD46";
        internal static readonly string SummaryTask = "0x012004";
        internal static readonly string DocumentSet = "0x0120d5";
        internal static readonly string Schedule = "0x0102007dbdc1392eaf4ebbbf99e41d8922b264";
        internal static readonly string ResourceReservation = "0x0102004f51efdea49c49668ef9c6744c8cf87d";
        internal static readonly string ScheduleAndResourceReservation = "0x01020072bb2a38f0db49c3a96cf4fa85529956";
        internal static readonly string GbwCirculationCTName = "0x01000f389e14c9ce4ce486270b9d4713a5d6";
        internal static readonly string GbwOfficialNoticeCTName = "0x01007ce30dd1206047728bafd1c39a850120";
        internal static readonly string CallTracking = "0x0100807fbac5eb8a4653b8d24775195b5463";
        internal static readonly string Resource = "0x01004c9f4486fbf54864a7b0a33d02ad19b1";
        internal static readonly string ResourceGroup = "0x0100ca13f2f8d61541b180952dfb25e3e8e4";
        internal static readonly string Holiday = "0x01009be2ab5291bf4c1a986910bd278e4f18";
        internal static readonly string Timecard = "0x0100c30dda8edb2e434ea22d793d9ee42058";
        internal static readonly string WhatsNew = "0x0100a2ca87ff01b442ad93f37cd7dd0943eb";
        internal static readonly string Whereabouts = "0x0100fbeee6f0c500489b99cda6bb16c398f7";
        internal static readonly string IMEDictionaryItem = "0x010018f21907ed4e401cb4f14422abc65304";
        internal static readonly string XSLStyle = "0x010100734778F2B7DF462491FC91844AE431CF";
        internal static readonly string MasterPagePreview = "0x010106";
        internal static readonly string DisplayTemplateJS = "0x0101002039C03B61C64EC4A04F5361F3851068";

        // Hashset to contain the whole list of built in fields
        private static HashSet<string> builtInContentTypesHashSet;
        private static object builtInContentTypesHashSetSyncLock = new object();

        internal static bool Contains(string cid)
        {
            if (builtInContentTypesHashSet == null)
            {
                lock (builtInContentTypesHashSetSyncLock)
                {
                    if (builtInContentTypesHashSet == null)
                    {
                        builtInContentTypesHashSet = new HashSet<string>(
                            new string[] {
                                System,
                                Item,
                                Document,
                                XMLDocument,
                                ODCDocument,
                                UDCDocument,
                                Picture,
                                UntypedDocument,
                                MasterPage,
                                WikiDocument,
                                DocumentWorkflowItem,
                                Event,
                                Issue,
                                Announcement,
                                Link,
                                Contact,
                                Message,
                                Discussion,
                                Task,
                                WorkflowTask,
                                AdminTask,
                                WorkflowHistory,
                                BlogPost,
                                BlogComment,
                                Folder,
                                RootOfList,
                                Person,
                                SharePointGroup,
                                DomainGroup,
                                BasicPage,
                                WebPartPage,
                                LinkToDocument,
                                FarEastContact,
                                DublinCoreName,
                                HealthRuleDefinition,
                                HealthReport,
                                SummaryTask,
                                DocumentSet,
                                Schedule,
                                ResourceReservation,
                                ScheduleAndResourceReservation,
                                GbwCirculationCTName,
                                GbwOfficialNoticeCTName,
                                CallTracking,
                                Resource,
                                ResourceGroup,
                                Holiday,
                                Timecard,
                                WhatsNew,
                                Whereabouts,
                                IMEDictionaryItem,
                                XSLStyle,
                                MasterPagePreview,
                                DisplayTemplateJS,
                            });
                    } 
                }
            }

            if (builtInContentTypesHashSet != null)
            {
                return builtInContentTypesHashSet.Contains(cid);
            }
            else
            {
                return false;
            }
        }
    }
}
