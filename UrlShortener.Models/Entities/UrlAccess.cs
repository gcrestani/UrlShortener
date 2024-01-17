namespace UrlShortener.Models.Entities
{
  internal class UrlAccess : BaseEntity
  {
    public int UrlId { get; set; }
    public int DeviceTypeId { get; set; }
    public int CountryId { get; set; }

  }
}
