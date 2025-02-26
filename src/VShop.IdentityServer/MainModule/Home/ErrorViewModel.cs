using Duende.IdentityServer.Models;

namespace IdentityServerHost.Quickstart.UI
{
    public class ErrorViewModel

    {
        public ErrorViewModel()
        {

        }

        public ErrorViewModel(string error)
        {
            error = new ErrorMessage {error = error};
        }

        public ErrorMessage Error { get; set; }
    }
}