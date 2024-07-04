using System.ComponentModel.DataAnnotations;

/*/
 * 
 * In deze namespace bevinden zich de modellen die de data van de applicatie representeren.
 * 
 * Deze kun je uitbreiden met extra modellen die je nodig hebt voor je applicatie.
 * Voorkeur zou zijn om meerdere data classes / modellen in aparte bestanden te plaatsen, maar wel in deze namespace.
 * 
 */
namespace TodoList.Models
{
    public class TodoItem
    {        
        public int Id { get; set; }

        [Required]
        public string? Description { get; set; }

        public bool IsDone { get; set; }
    }
}
