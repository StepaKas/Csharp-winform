using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KonzolaCore.Database
{
    [Table("Worker")]
    public class Worker     : INotifyPropertyChanged
    {
        [Required]
        public decimal Id { get; set; }

        [Required]
        private string name;
        [Required]
        private string surname;
        [Display(Name = "Jméno")]
        [Required(ErrorMessage = "Chybí jméno")]

        public string Name { 
            get
            {
                return name;
            } 
            
            set 
            { 
                name = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Worker.name)));
            } 
        
        }

        [Display(Name = "Příjmení")]
        [Required(ErrorMessage = "Zadej Příjmení")]
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Worker.surname)));
            }

        }
        [Required(ErrorMessage = "Zadej heslo")]
        [PasswordPropertyText]
        [Display(Name = "Heslo")]
        public string My_password { get; set; }
        public DateTime? Last_Visit { get; set; } = DateTime.Now;

        [Required(ErrorMessage ="Zadej datum narození")]
        [Display(Name = "Datum narození")]
        public DateTime? Date_of_Birth { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Zadej pozici")]

        [Display(Name = "Pozice")]

        public string Position { get; set; }
        [Required(ErrorMessage = "Role")]

        [Display(Name = "Role")]

        public string Role { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        [Required(ErrorMessage = "Zadej email")]
        [EmailAddress(ErrorMessage ="Tohle není email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} \nName: {Name} \nSurname: {Surname}\n";
        }

    }
}
