﻿using Sitecore.AspNetCore.SDK.LayoutService.Client.Response.Model.Fields;
using Sitecore.AspNetCore.SDK.RenderingEngine.Binding.Attributes;

namespace Sitecore.AspNetCore.Starter.Models;

public class Promo : BaseModel
{
    public const string VARIANT_WITH_TEXT = "WithText";

    [SitecoreComponentField]
    public ImageField? PromoIcon { get; set; }

    [SitecoreComponentField]
    public RichTextField? PromoText { get; set; }

    [SitecoreComponentField]
    public HyperLinkField? PromoLink { get; set; }
}
