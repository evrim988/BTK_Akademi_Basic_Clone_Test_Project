using System.ComponentModel.DataAnnotations;

namespace BTKAkademiTest.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email Alanı Boş Geçilemez")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "İsim Kısmı Boş Geçilemez")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Soyisim Kısmı Boş Geçilemez")]
        public string? SurName { get; set; }
        public string? FullName => $"{Name} {SurName?.ToUpper()}";
        public int? Age { get; set; }
        [Required(ErrorMessage = "Kurs Seçme Kısmı Boş Geçilemez")]
        public string? SelectedCourse { get; set; }
        public DateTime RegistiredDate {  get; set; }

        public Candidate()
        {
            RegistiredDate = DateTime.Now;
        }
    }
}
