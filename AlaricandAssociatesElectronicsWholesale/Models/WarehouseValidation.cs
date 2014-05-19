using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AlaricandAssociatesElectronicsWholesale.Models
{
    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {
        public List<Models.Product> AllProducts;
    }

    public class CategoryMetadata
    {
        [Required(ErrorMessage = "Name required")
        , Display(Name = "Category")]
        public string categoryName;

        [Display(Name = "Item Class")]
        public string ParentCategories;
    }

    [MetadataType(typeof(ImageMetadata))]
    public partial class Image
    {
    }

    public class ImageMetadata
    {
        [Required(ErrorMessage = "Name needed")
        , Display(Name = "Title")]
        public string imageName;

        [Display(Name = "Product Image")]
        public string imageURL;

        [Display(Name = "Description")]
        public string imageDescription;

        [Required(ErrorMessage = "Product needed")
        , Display(Name = "Product Shown")]
        public string ProductID;
    }

    [MetadataType(typeof(SupplierMetadata))]
    public partial class Supplier
    {
    }

    public class SupplierMetadata
    {
        [Required(ErrorMessage = "Supplier name required")
        , Display(Name = "Name")]
        public string supplierName;

        [Display(Name = "Description")]
        public string supplierDescription;

        [Required(ErrorMessage = "Image link needed")
        , Display(Name = "Image Link")]
        public string imageURL;

        [Required(ErrorMessage = "Location imperative")
        , Display(Name = "Location")]
        public string supplierLocation;
    }

    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
    }

    public class ProductMetadata
    {
        [Required(ErrorMessage = "Name needed")
        , Display(Name = "Name")]
        public string productName;

        [Required(ErrorMessage = "Blank price invalid")
        , Display(Name = "Price")]
        public decimal Price;

        [Required(ErrorMessage = "Stock quantity required")
        , Display(Name = "Number in Stock")]
        public int QtyInStock;

        [Display(Name = "Description")]
        public string productDescription;

        [Required(ErrorMessage = "Category needed")
        , Display(Name = "Category")]
        public string CategoryID;

        [Required(ErrorMessage = "Supplier required")
        , Display(Name = "Supplier")]
        public string SupplierID;
    }
}