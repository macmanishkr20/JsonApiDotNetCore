using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApiDotNetCoreExample.Models
{
    public sealed class ArticleTag
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }

    public class IdentifiableArticleTag : Identifiable
    {
        public int ArticleId { get; set; }
        [HasOne]
        public Article Article { get; set; }

        public int TagId { get; set; }
        [HasOne]
        public Tag Tag { get; set; }

        public string SomeMetaData { get; set; }
    }
}
