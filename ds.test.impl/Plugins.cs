using System;
using System.Linq;

namespace ds.test.impl
{
    // CS0714: реализация интерфейсов статическими классами невозможна.
    /// <summary>
    /// Класс фабрики плагинов
    /// </summary>
    public class Plugins : PluginFactory
    {
        public int PluginsCount => GetPlugins.Count();

        public string[] GetPluginNames => GetPlugins
                .Select(t => ((IPlugin)Activator.CreateInstance(t)).PluginName).ToArray();

        private System.Collections.Generic.IEnumerable<Type> GetPlugins =>
            AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsClass && !t.IsAbstract
                &&
                (t.Namespace == "ds.test.impl.Ops" ||
                t.Namespace == "ds.test.impl.Ops.geometry")
                && t.GetProperty("PluginName") != null);

        /// <summary>
        /// Находит плагин по имени. Пример обращения:
        /// <code>
        /// PluginFactory pluginFactory = new Plugins();<br/>
        /// IPlugin p = pluginFactory.GetPlugin("PluginName");
        /// </code>
        /// </summary>
        public IPlugin GetPlugin(string pluginName)
        {
            Type type = GetPlugins
                .FirstOrDefault(
                t => ((IPlugin)Activator.CreateInstance(t)).PluginName == pluginName
                );
            return (IPlugin)Activator.CreateInstance(type);
        }
    }
}
