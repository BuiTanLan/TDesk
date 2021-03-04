using Volo.Abp.Settings;

namespace TDesk.Settings
{
    public class TDeskSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TDeskSettings.MySetting1));
        }
    }
}
