// FFXIVAPP.Plugin.Sample
// LogPublisher.cs

#region Usings

using System;
using FFXIVAPP.Common.Chat;
using FFXIVAPP.Common.Utilities;
using NLog;

#endregion

namespace Sample.Plugin.Utilities
{
    public static class LogPublisher
    {
        public static void Process(ChatEntry chatEntry)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Logging.Log(LogManager.GetCurrentClassLogger(), "", ex);
            }
        }
    }
}
