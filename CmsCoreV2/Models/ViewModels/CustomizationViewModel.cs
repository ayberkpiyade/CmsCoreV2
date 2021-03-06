﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CmsCoreV2.Models.ViewModels
{
    public class CustomizationViewModel
    {
        [Required]
        [StringLength(200)]
        [Display(Name = "Tema Adı")]
        public string ThemeName { get; set; }

        [Display(Name = "Sayfa Şablonları")]
        public string PageTemplates { get; set; }

        [Display(Name = "Bileşen Şablonları")]
        public string ComponentTemplates { get; set; }
        [StringLength(200)]
        public string Logo { get; set; }
        [StringLength(200)]
        [Display(Name = "Meta Başlık")]
        public string MetaTitle { get; set; }

        [Display(Name = "Meta Açıklama")]
        public string MetaDescription { get; set; }

        [Display(Name = "Anahtar Kelimeler")]
        public string MetaKeywords { get; set; }

        [Display(Name = "Resim Yolu")]
        public string ImageUrl { get; set; }
        [Display(Name = "Menü Konumları")]
        public string ManyLocations { get; set; }

        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreateDate { get; set; }


        [Display(Name = "Güncellenme Tarihi")]
        public DateTime UpdateDate { get; set; }
    }
}
