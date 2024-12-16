﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Shopping_Tutorial.Repository.Validation;

namespace Shopping_Tutorial.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yeu cau nhap ten San Pham")]
        public string Name { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yeu cau nhap Mo ta San Pham")]
        public string Description { get; set; }

        public string Slug {  get; set; }

        [Required( ErrorMessage = "Yeu cau nhap Gia San Pham")]
        [Range(0.01, double.MaxValue)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        [Required, Range(1,int.MaxValue, ErrorMessage = "Chon mot thuong hieu")]
        public int BrandId {  get; set; }

        [Required, Range(1,int.MaxValue, ErrorMessage = "Chon mot danh muc San Pham")]
        public int CategoryId {  get; set; }
        public CategoryModel Category { get; set; }
        public BrandModel Brand { get; set; }

        public string Image { get; set; }

        [NotMapped]
        [FileExtension]
        public IFormFile? ImageUpload { get; set; }
    }
}
