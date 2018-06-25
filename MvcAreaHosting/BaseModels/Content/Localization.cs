using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAreaHosting.BaseModels.Content
{
    //TODO: https://saimana.com/list-of-country-locale-code/
    //TODO: https://www.science.co.il/language/Locale-codes.php

    [Table("Culture", Schema = "Localization")]
    public class Culture
    {
        [Key]
        public string CultureCode { get; set; }

        public string LanguageAndCountryName { get; set; }

        public string LanguageCode { get; set; }

        public int LCID { get; set; }

        public int Codepage { get; set; }

        [ForeignKey("LanguageCode")]
        public Language Language { get; set; }
    }

    [Table("Language", Schema = "Localization")]
    public class Language
    {
        [Key]
        public string LanguageCode { get; set; }

        public string LanguageName { get; set; }
    }

    [Table("Label", Schema = "Localization")]
    public class Label
    {
        [Key]
        public int LabelID { get; set; }

        [ForeignKey("Language")]
        public string LanguageCode { get; set; }

        public string Content { get; set; }

        public Language Language { get; set; }
    }

    public abstract class TextArticle
    {

    }
}

