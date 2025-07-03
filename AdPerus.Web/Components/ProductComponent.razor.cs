using Microsoft.AspNetCore.Components;

namespace AdPerus.Web.Components;

public partial class ProductComponent : ComponentBase
{

    #region Parameters

    [Parameter]
    public string ProductTitle { get; set; } = string.Empty;

    [Parameter]
    public string ProductImage { get; set; } = string.Empty;
    
    [Parameter]
    public decimal ProductPrice { get; set; }

    #endregion


}