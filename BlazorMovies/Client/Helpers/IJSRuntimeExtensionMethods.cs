using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime jscommand, string message)
        {
            await jscommand.InvokeVoidAsync("Log","Por confirmamr desde JS");
            return await jscommand.InvokeAsync<bool>("confirm", message);
        }
        public static async ValueTask JSLog(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("Log", message);
        }
    }
}
