using System;
using System.Collections.Generic;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

using Jellyfin.Plugin.MediaOptimizer.Configuration;

namespace Jellyfin.Plugin.MediaOptimizer
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        public override string Name => "Media Optimizer";
        public override Guid Id => Guid.Parse("5ae0d264-9d62-4ab6-bff9-8dfbeaea6b6a");

        public override string Description => "Optimize Media for different devices";


        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }


        public static Plugin Instance { get; private set; }

        // Why do I need this again?
        public PluginConfiguration PluginConfiguration => Configuration;

        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {

                new PluginPageInfo
                {
                    Name = "mostatus",
                    EmbeddedResourcePath = GetType().Namespace + ".Web.mostatus.html",
                    EnableInMainMenu = true
                },

                new PluginPageInfo
                {
                    Name = "mostatusjs",
                    EmbeddedResourcePath = GetType().Namespace + ".Web.mostatus.js"
                },

                new PluginPageInfo
                {
                    Name = "mosettings",
                    EmbeddedResourcePath = GetType().Namespace + ".Web.mosettings.html"
                },

                new PluginPageInfo
                {
                    Name = "mosettingsjs",
                    EmbeddedResourcePath = GetType().Namespace + ".Web.mosettings.js"
                }

            };
        }
    }
}
