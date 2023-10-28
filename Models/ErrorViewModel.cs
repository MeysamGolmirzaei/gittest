namespace git.Models;

public class ErrorViewModel
{
    public string? rid { get; set; }
    public string Name { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
