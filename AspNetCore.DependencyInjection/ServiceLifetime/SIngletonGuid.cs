namespace AspNetCore.DependencyInjection.ServiceLifetime
{
    public class SIngletonGuid : ISingletonGuid
    {
        private readonly Guid Guid;

        public SIngletonGuid()
        {
            Guid = Guid.NewGuid();
        }

        public string getGuid()
        {
            return Guid.ToString();
        }
    }
}
