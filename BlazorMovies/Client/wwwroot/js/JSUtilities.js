function Log(message) {
    console.log("Desde utilities:" + message)
}
/////Incocando un Metodo estatico de c# desde JS
function dotnetGetCounter() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        .then(result => {
            console.log("from JS calling c#" + result)
        });
}

////// Invocando un metoo de Instancia de c# desde JS
function dotnetIncrementCounter(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}