namespace AspNetCore.DependencyInjection.ServiceLifetime
{
    public class ScopedGuid : IScopedGuid
    {
        private readonly Guid Guid;

        public ScopedGuid()
        {
            Guid = Guid.NewGuid();
        }

        public string getGuid()
        {
            return Guid.ToString();
        }
    }
}
