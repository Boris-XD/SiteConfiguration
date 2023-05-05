namespace SiteRecursives.Service.Sites
{
    public class SiteMap
    {
        public ICollection<SiteEntry> Entries { get; set; } = new List<SiteEntry>();
    }
}
