using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace AdPerus.Web.Components;

public partial class NavMenuItem : ComponentBase
{
    #region Properties

    [Parameter, EditorRequired]
    public string Route { get; set; } = string.Empty;

    [Parameter, EditorRequired]
    public string Title { get; set; } = string.Empty;
    
    [Parameter, EditorRequired]
    public string DefaultIconPath { get; set; } = string.Empty;

    [Parameter, EditorRequired]
    public string DarkIconPath { get; set; } = string.Empty;

    private string DivClass => IsActive ? "bg-zinc-300 text-black" : "hover:bg-gray-600 ";
    private string DefaultIconClass => IsActive ? "hidden" : "inline";
    private string BlackIconClass => IsActive ? "inline" : "hidden";

    #endregion
    
    
    #region Services

    [Inject] 
    public NavigationManager NavigationManager { get; set; } = null!;

    #endregion

    #region Private Methods
    
    private bool IsActive => NavigationManager.Uri.Contains(Route, StringComparison.OrdinalIgnoreCase);

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