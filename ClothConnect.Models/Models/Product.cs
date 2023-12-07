using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ClothConnect.Models.Models
{
    /// <summary>
    /// Represents a Product entity in the system.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the unique identifier for the Product.
        /// </summary>
        [Key] // Indicates this property is the primary key in the database
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the Product. This field is required.
        /// </summary>
        [Required] // Indicates that this property is required
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the Product.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the item code of the Product. This field is required.
        /// </summary>
        [Required] // Indicates that this property is required
        [Display(Name = "Item Code")] // Sets a user-friendly display name for the property
        public string ItemCode { get; set; }

        /// <summary>
        /// Gets or sets the seller of the Product. This field is required.
        /// </summary>
        [Required] // Indicates that this property is required
        public string Seller { get; set; }

        /// <summary>
        /// Gets or sets the list price of the Product. This field is required and must be between 1 and 1000.
        /// </summary>
        [Required] // Indicates that this property is required
        [Display(Name = "List Price")] // Sets a user-friendly display name for the property
        [Range(1, 1000)] // Sets the allowable range of values for the ListPrice from 1 to 1000
        public double ListPrice { get; set; }

        /// <summary>
        /// Gets or sets the price of the Product for quantities between 1 and 50. This field is required and must be between 1 and 1000.
        /// </summary>
        [Required] // Indicates that this property is required
        [Display(Name = "Price for 1-50")] // Sets a user-friendly display name for the property
        [Range(1, 1000)] // Sets the allowable range of values for the Price from 1 to 1000
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the price of the Product for quantities of 50 or more. This field is required and must be between 1 and 1000.
        /// </summary>
        [Required] // Indicates that this property is required
        [Display(Name = "Price for 50+")] // Sets a user-friendly display name for the property
        [Range(1, 1000)] // Sets the allowable range of values for the Price50 from 1 to 1000
        public double Price50 { get; set; }

        /// <summary>
        /// Gets or sets the price of the Product for quantities of 100 or more. This field is required and must be between 1 and 1000.
        /// </summary>
        [Required] // Indicates that this property is required
        [Display(Name = "Price for 100+")] // Sets a user-friendly display name for the property
        [Range(1, 1000)] // Sets the allowable range of values for the Price100 from 1 to 1000
        public double Price100 { get; set; }

        /// <summary>
        /// Gets or sets the CategoryId, which is the foreign key linking to the Category table.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Navigation property for the associated Category. It uses CategoryId as a foreign key.
        /// </summary>
        [ForeignKey("CategoryId")] // Specifies that this property is a foreign key
        public Category Category { get; set; }
    }
}
//RadhikaMunjal
