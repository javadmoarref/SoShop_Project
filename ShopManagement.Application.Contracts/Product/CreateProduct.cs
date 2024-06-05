﻿using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace ShopManagement.Application.Contracts.Product;

public class CreateProduct
{
    [Required(ErrorMessage = ValidationMessage.IsRequired)]
    public string Name { get;  set; }

    [Required(ErrorMessage = ValidationMessage.IsRequired)]
    public string Code { get;  set; }

    [Required(ErrorMessage = ValidationMessage.IsRequired)]
    [MaxLength(500,ErrorMessage = ValidationMessage.MaxIsRequired)]
    public string ShortDescription { get;  set; }

    [MaxLength(500, ErrorMessage = ValidationMessage.MaxIsRequired)]
    public string Description { get;  set; }
    public string Picture { get;  set; }
    public string PictureAlt { get;  set; }
    public string PictureTitle { get;  set; }
    [Required(ErrorMessage = ValidationMessage.IsRequired)]
    public string Slug { get;  set; }

    [Required(ErrorMessage = ValidationMessage.IsRequired)]
    public string Keywords { get;  set; }

    [Required(ErrorMessage = ValidationMessage.IsRequired)]
    public string MetaDescription { get;  set; }

    [Range(1,100000,ErrorMessage = ValidationMessage.IsRequired)]
    public long CategoryId { get;  set; }
    public string BackgroundColor { get;  set; }
}