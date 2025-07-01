using System.ComponentModel;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace AdPerus.Web.Layout;

public partial class MainLayout
{
    #region Services

    [Inject] 
    public NavigationManager NavigationManager { get; set; } = null!;

    #endregion

    #region Private Methods

    private string GetActiveClass(string path)
    {
        var currentUrl = NavigationManager.Uri;
        return currentUrl.Contains(path, StringComparison.OrdinalIgnoreCase) ? "active" : "";
    }

    private void LocationChanged(object? sender, LocationChangedEventArgs e)
    {
        StateHasChanged();
    }

    #endregion

    #region Overrides

    protected override Task OnInitializedAsync()
    {
        NavigationManager.LocationChanged += LocationChanged;
        return base.OnInitializedAsync();
    }

    #endregion

    #region Public Methods

    public void Dispose()
    {
        NavigationManager.LocationChanged -= LocationChanged;
    }

    #endregion
    
    
    
}