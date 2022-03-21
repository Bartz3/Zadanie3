using System.ComponentModel.DataAnnotations;

namespace Zadanie3.Models
{
    public class User
    {
        [MaxLength(15),Required(ErrorMessage ="Pole nie może być puste!")
        ,Display(Name ="Imię")
        ,RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Podano niepoprawne dane!")]
        public string FirstName { get; set; }

        //[DataType(DataType.EmailAddress)]
        [EmailAddressAttribute, Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Wiek"), Range(1, 120, ErrorMessage = "Podano niepoprawne dane!")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Pole waga nie może być puste!"),Display(Name ="Waga")]  
        public double Weight { get; set; }

        [Required(ErrorMessage = "Pole wzrost nie może być puste"),Display(Name="Wzrost")]
        
        public double Height { get; set; }
        [Display (Name ="Płeć")]
        public string Gender { get; set; }
        [Display(Name ="Jednostka wzrostu")]
        public string HeightUnit { get; set; }
        public double Result { get; set; }
    }
}
