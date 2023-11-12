using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Обработка_данных_о_фильмах
{
    [Table("Tags")]
    class TagTable
    {
        [Key]
        public string id;

        [Required]
        [StringLength(100)]
        public string text;
    }
}
