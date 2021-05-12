using MyCNameSpace.Infrastructure.Data;
using MyCNameSpace.Domain;
using MyCNameSpace.Test.Setup;

namespace MyCNameSpace.Test
{
    public static class Fixme
    {
        public static User ReloadUser<TEntryPoint>(AppWebApplicationFactory<TEntryPoint> factory, User user)
            where TEntryPoint : class
        {
            var applicationDatabaseContext = factory.GetRequiredService<ApplicationDatabaseContext>();
            applicationDatabaseContext.Entry(user).Reload();
            return user;
        }
    }
}
