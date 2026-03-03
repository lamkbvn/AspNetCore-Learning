namespace AspNetCore.DependencyInjection.ServiceLifetime
{
    public class TransientGuid : ITransientGuid
    {
        private readonly Guid Guid;

        public TransientGuid()
        {
            Guid = Guid.NewGuid();
        }

        public string getGuid()
        {
            return Guid.ToString();
        }
    }
}
