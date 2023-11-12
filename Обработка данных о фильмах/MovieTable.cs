using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обработка_данных_о_фильмах
{
    [Table("Movies")]
    class MovieTable
    {
        [Key]
        public string id;

        [Required]
        public string name;

        public string rating;
        
        // в строке может быть несколько элементов, разделитель ; (без пробелов)
        public string tags;
        public string actors;
        public  string directors;
    }
}
