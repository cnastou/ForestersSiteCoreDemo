// Group the error model in the application's namespace.
namespace ForestersSiteCoreDemo.Models;

// Provide diagnostic data to the shared error view.
public class ErrorViewModel
{
    // Store the identifier associated with the failed request.
    public string? RequestId { get; set; }

    // Indicate whether the request identifier should be displayed.
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
