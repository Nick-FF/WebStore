using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.ViewModels
{
    /// <summary>Модель-представления товара</summary>
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        /// <summary>Идентификатор</summary>
        public int Id { get; set; }

        /// <summary>Название</summary>
        [Required, Display(Name = "Название" )]
        public string Name { get; set; }

        /// <summary>Порядковый номер</summary>
        [Required, Display(Name = "Порядок")]
        public int Order { get; set; }

        /// <summary>Ссылка на изображение</summary>
        [Required, Display(Name = "Изображение")]
        public string ImageUrl { get; set; }

        /// <summary>Цена</summary>
        [Required, Display(Name = "Цена")]
        public decimal Price { get; set; }

        /// <summary>Бренд</summary>
        [Display(Name = "Бренд")]
        public string Brand { get; set; }
        [Display(Name = "Категория")]
        public string Section { get; set; }
        [Required]
        public int SectionId { get; set; } 
        public SelectList Sections { get; set; }
        public SelectList Brands { get; set; } 
    }
}
