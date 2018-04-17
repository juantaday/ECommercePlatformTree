namespace MultiColumnComboSuggestionBox.Models
{
    using System.ComponentModel.DataAnnotations;
    public class ListItemSuggestions
    {
         [Key]
        public int IndexItem { get; set; }
        public string  NameItem { get; set; }
    }
}
