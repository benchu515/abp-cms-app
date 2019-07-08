using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CMS_Assignment.Localization
{
    public static class CMS_AssignmentLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CMS_AssignmentConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CMS_AssignmentLocalizationConfigurer).GetAssembly(),
                        "CMS_Assignment.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
