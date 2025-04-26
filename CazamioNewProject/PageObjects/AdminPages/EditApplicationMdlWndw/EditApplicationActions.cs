using CazamioNewProject.Objects;

namespace CazamioNewProject.PageObjects.AdminPages.EditApplicationMdlWndw
{
    public partial class EditApplicationMdlWndw
    {
        Application application = Application.Generate();
        AgentBroker agentBroker = AgentBroker.Generate();
        TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
    }
}
