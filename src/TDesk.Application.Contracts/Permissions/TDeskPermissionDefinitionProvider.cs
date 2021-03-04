using TDesk.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TDesk.Permissions
{
    public class TDeskPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TDeskPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(TDeskPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TDeskResource>(name);
        }
    }
}
