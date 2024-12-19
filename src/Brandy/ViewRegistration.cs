namespace Brandy;
// Idea taken from Prism on how it handles view registration into the defined container.
/// <summary>
/// Holds information about a view registration. Includes the type of registration, the view and view model types, and the name of the view.
/// </summary>
public class ViewRegistration
{
    public RegistrationType Type { get; init; }
    public required Type View { get; init; }
    public Type? ViewModel { get; init; }
    public string? Name { get; init; }
}

public enum RegistrationType
{
    /// <summary>
    /// Unknown registration type. We should never see this.
    /// </summary>
    Unknown,
    /// <summary>
    /// A page registration.
    /// </summary>
    Page,
    /// <summary>
    /// A popup registration.
    /// </summary>
    Popup,
    /// <summary>
    /// A bottom sheet registration.
    /// </summary>
    BottomSheet
}