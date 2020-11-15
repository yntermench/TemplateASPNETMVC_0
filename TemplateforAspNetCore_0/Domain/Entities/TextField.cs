﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateforAspNetCore_0.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название страницы(заголовок)")]
        public override string Title { get; set; } = "Информационная страница";


        [Display(Name = "Содержание страницы(заголовок)")]
        public override string Text { get; set; } = "Содержание заполняется администратором";
    }
}
