// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;

namespace src.Models
{
    public partial class Article
    {
        public const string Codename = "article";
        public const string ContentCodename = "content";
        public const string HeaderImageCodename = "header_image";
        public const string PublicationDateCodename = "publication_date";
        public const string SlugCodename = "slug";
        public const string SummaryCodename = "summary";
        public const string ThumbnailImageCodename = "thumbnail_image";
        public const string TitleCodename = "title";

        public string Content { get; set; }
        public IEnumerable<IAsset> HeaderImage { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
        public IContentItemSystemAttributes System { get; set; }
        public IEnumerable<IAsset> ThumbnailImage { get; set; }
        public string Title { get; set; }
    }
}