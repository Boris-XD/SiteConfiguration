namespace SiteRecursives.Service.Sites
{
    public class SiteEntry
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public bool? IsActive { get; set; }

        public IEnumerable<SiteEntry>? Entries { get; set; } = null;
    }
}
