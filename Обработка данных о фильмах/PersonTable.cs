using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Обработка_данных_о_фильмах
{
    [Table("Persons")]
    class PersonTable
    {
        [Key]
        public string person_id;

        [Required]
        [StringLength(50)]
        public string name;

        // строка с id-шниками, разделитель ; (без пробелов)
        [Required]
        [DefaultValue("")]
        public string actor_movies_id;
        [Required]
        [DefaultValue("")]
        public string director_movies_id;
    }
}
