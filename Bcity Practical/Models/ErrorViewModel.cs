namespace Bcity_Practical.Models
{
    public class ErrorViewModel
    {
        // Stores the request ID for debugging purposes
        public string? RequestId { get; set; }

        // Indicates whether the RequestId should be shown
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
