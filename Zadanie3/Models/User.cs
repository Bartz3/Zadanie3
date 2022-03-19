using System.ComponentModel.DataAnnotations;

namespace Zadanie3.Models
{
    public class User
    {
        [MaxLength(15),Required(ErrorMessage ="Podano niepoprawne dane!")
        ,Display(Name ="Imię")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string FirstName { get; set; }

        //[DataType(DataType.EmailAddress)]
        [EmailAddressAttribute, Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Wiek"), Range(1, 120, ErrorMessage = "Podano niepoprawne dane!")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Pole jest obowiązkowe!"),Display(Name ="Waga")]
        public double Weight { get; set; }
        [Required(ErrorMessage = "Pole jest obowiązkowe!"),Display(Name="Wzrost")]
        public double Height { get; set; }
        [Display (Name ="Płeć")]
        public string Gender { get; set; }
        public string HeightUnit { get; set; }
        public double Result { get; set; }
    }
}
