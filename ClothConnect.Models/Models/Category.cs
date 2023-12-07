using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClothConnect.Models
{
    /// <summary>
    /// Represents a Category entity in the system.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the unique identifier for the Category.
        /// </summary>
        [Key] // Indicates that this property is the primary key in the database
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the Category. The name is required and its length must be 25 characters or less.
        /// </summary>
        [Required] // Indicates that this property is required
        [MaxLength(25)] // Sets the maximum length of the Name to 25 characters
        [DisplayName("Category Name")] // Sets a user-friendly display name for the property
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display order of the Category. The value must be between 1 and 200.
        /// </summary>
        [DisplayName("Display Order")] // Sets a user-friendly display name for the property
        [Range(1, 200)] // Sets the allowable range of values for the DisplayOrder from 1 to 200
        public int DisplayOrder { get; set; }
    }
}
