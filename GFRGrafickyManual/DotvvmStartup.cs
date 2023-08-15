using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;
using DotVVM.Framework.Routing;
using Microsoft.Extensions.DependencyInjection;
using DotVVM.Framework.Controls.Bootstrap4;
using System;

namespace GFRGrafickyManual
{
    public class DotvvmStartup : IDotvvmStartup, IDotvvmServiceConfigurator
    {
        // For more information about this class, visit https://dotvvm.com/docs/tutorials/basics-project-structure
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            config.AddBootstrap4Configuration(DotvvmBootstrapOptions.CreateDefaultSettings());

            ConfigureRoutes(config, applicationPath);
            ConfigureControls(config, applicationPath);
            ConfigureResources(config, applicationPath);
        }

        private void ConfigureRoutes(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.Add("Default", "", "Views/Textbox.dothtml");
            config.RouteTable.Add("Textbox", "Textbox", "Views/Textbox.dothtml");
            config.RouteTable.Add("Button", "Button", "Views/Button.dothtml");
            config.RouteTable.Add("RadioButton", "RadioButton", "Views/RadioButton.dothtml");
            config.RouteTable.Add("ComboBox", "ComboBox", "Views/ComboBox.dothtml");
            config.RouteTable.Add("TabControl", "TabControl", "Views/TabControl.dothtml");
            config.RouteTable.Add("Table", "Table", "Views/Table.dothtml");
            config.RouteTable.Add("Pagination", "Pagination", "Views/Pagination.dothtml");
            config.RouteTable.Add("DatePicker", "DatePicker", "Views/DatePicker.dothtml");
            config.RouteTable.AutoDiscoverRoutes(new DefaultRouteStrategy(config));    
        }

        private void ConfigureControls(DotvvmConfiguration config, string applicationPath)
        {
            // register code-only controls and markup controls
        }

        private void ConfigureResources(DotvvmConfiguration config, string applicationPath)
        {
            // register custom resources and adjust paths to the built-in resources
            
            // JQuery
            config.Resources.Register("jquery", new ScriptResource
            {
                Location = new UrlResourceLocation($"~/js/jquery.js")
            });

            config.Resources.Register("Script", new ScriptResource
            {
                Location = new UrlResourceLocation($"~/js/Script.js")
            });

            config.Resources.Register("Styles", new StylesheetResource()
            {
                Location = new UrlResourceLocation("~/css/style.css")
            });
        }

		public void ConfigureServices(IDotvvmServiceCollection options)
        {
            options.AddDefaultTempStorages("temp");
            options.AddBusinessPack();
            options.AddHotReload();
		}
    }
}
