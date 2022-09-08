using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QFE.DAL
{
    [Table("quran")]
    public class quran
    {
        [Key]

        [Column("idx")]
        public int idx { get; set; }

        [Column("ayah_id")]
        public int ayah_id { get; set; }

        [Column("surah_id")]
        public int? surah_id { get; set; }

        [Column("ayah_location")]
        public string ayah_location { get; set; }

        [Column("Arabic")]
        public string Arabic { get; set; }

        [Column("Albanian")]
        public string Albanian { get; set; }

        [Column("Azerbaijani")]
        public string Azerbaijani { get; set; }

        [Column("Bangali")]
        public string Bangali { get; set; }

        [Column("Bosnian")]
        public string Bosnian { get; set; }

        [Column("Bulgarian")]
        public string Bulgarian { get; set; }

        [Column("Chinese")]
        public string Chinese { get; set; }

        [Column("Czech")]
        public string Czech { get; set; }

        [Column("Divehi")]
        public string Divehi { get; set; }

        [Column("Dutch")]
        public string Dutch { get; set; }

        [Column("English")]
        public string English { get; set; }

        [Column("German")]
        public string German { get; set; }

        [Column("Hausa")]
        public string Hausa { get; set; }

        [Column("Hindi")]
        public string Hindi { get; set; }

        [Column("Indonesian")]
        public string Indonesian { get; set; }

        [Column("Italian")]
        public string Italian { get; set; }

        [Column("Japanese")]
        public string Japanese { get; set; }

        [Column("Korean")]
        public string Korean { get; set; }

        [Column("Kurdish")]
        public string Kurdish { get; set; }

        [Column("Malay")]
        public string Malay { get; set; }

        [Column("Malayalam")]
        public string Malayalam { get; set; }

        [Column("Norwegian")]
        public string Norwegian { get; set; }

        [Column("Persian")]
        public string Persian { get; set; }

        [Column("Polish")]
        public string Polish { get; set; }

        [Column("Portuguese")]
        public string Portuguese { get; set; }

        [Column("Romanian")]
        public string Romanian { get; set; }

        [Column("Russian")]
        public string Russian { get; set; }

        [Column("Sindhi")]
        public string Sindhi { get; set; }

        [Column("Somali")]
        public string Somali { get; set; }

        [Column("Spanish")]
        public string Spanish { get; set; }

        [Column("Swahili")]
        public string Swahili { get; set; }

        [Column("Swedish")]
        public string Swedish { get; set; }

        [Column("Tajik")]
        public string Tajik { get; set; }

        [Column("Tamil")]
        public string Tamil { get; set; }

        [Column("Tatar")]
        public string Tatar { get; set; }

        [Column("Thai")]
        public string Thai { get; set; }

        [Column("Turkish")]
        public string Turkish { get; set; }

        [Column("Urdu")]
        public string Urdu { get; set; }

        [Column("Uzbek")]
        public string Uzbek { get; set; }
    }
}
