using System.Formats.Asn1;

namespace UrlShortener.Models.Entities
{
  internal class Url : BaseEntity
  {
    public string ShortUrl { get; set; }
    public string OriginalUrl { get; set; }

    public List<TagClass> Tags { get; set; }
  }
}
