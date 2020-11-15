﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TemplateforAspNetCore_0.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название услуги")]
        [Display(Name = "Название услуги(заголовок)")]
        public override string Title { get; set; } = "Информационная страница";

        [Display(Name = "Краткое описание услуги(заголовок)")]
        public override string Subtitle { get; set; }


        [Display(Name = "Полное описание услуги")]
        public override string Text { get; set; } = "Содержание заполняется администратором";
    }
}
