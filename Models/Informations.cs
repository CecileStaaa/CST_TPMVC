using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Informations
    {
        /* Informations personnelles */
        [Required(ErrorMessage = "Le nom est obligatoire")]
        [Display(Name = "Nom")]
        public string? Nom {  get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire")]
        [Display(Name = "Prénom")]
        public string? Prénom { get; set; }

        [Required(ErrorMessage = "Veuillez sélectionner un genre")]
        [Display(Name = "Genre")]
        public string? Genre { get; set; }

        [Required(ErrorMessage = "L'adresse est obligatoire")]
        [Display(Name = "Adresse")]
        public string? Adresse { get; set; }

        
        [Required(ErrorMessage = "Le code postal est obligatoire")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Le code postal doit contenir exactement 5 chiffres")]
        [Display(Name = "Code postal")]
        public string? CodePostal { get; set; }

        [Required(ErrorMessage = "La ville est obligatoire")]
        [Display(Name = "Ville")]
        public string? Ville { get; set; }

        [Required(ErrorMessage = "L'adresse courriel est obligatoire")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)\.([\w]+)$", ErrorMessage = "Le format de l'adresse courriel doit être example@mail.fr")]
        [Display(Name = "Adresse courriel")]
        public string? Courriel { get; set; }

        /* Informations sur la formation suivie */
        [Required(ErrorMessage = "La date de début de formation est obligatoire")]
        [Range(typeof(DateTime), "01-01-1900", "31-12-2020", ErrorMessage = "La date doit être inférieure au 01-01-2021")]
        [Display(Name = "Date de début de la formation")]
        [DataType(DataType.Date)]
        public DateTime? DateDebut { get; set; }

        [Required(ErrorMessage = "Veuillez sélectionner une formation suivie")]
        [Display(Name = "Type de formation")]
        public string? TypeFormation { get; set; }

        /* Avis sur la formation */
        [Display(Name = "Formation Cobol")]
        public string? Cobol {  get; set; }

        [Display(Name = "Formation C#")]
        public string? CSharp { get; set; }

    }

}
