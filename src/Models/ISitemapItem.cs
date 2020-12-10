using Kentico.Kontent.Delivery.Abstractions;

namespace src.Models
{
    interface ISitemapItem
    {
        IContentItemSystemAttributes System { get; }
    }
}
