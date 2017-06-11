namespace SexyFishHorse.DataModel.DataAnnotations
{
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class PartialKeyAttribute : System.Attribute
    {
        public string PartialKey { get; private set; }

        public PartialKeyAttribute (string partialKey)
        {
            PartialKey = partialKey;
        }
    }
}
