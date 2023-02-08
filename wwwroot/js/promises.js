function setElementById(id, text) {
    document.getElementById(id).innerText = text;
    // window.location.assign(window.location.origin + "/myPages/steps.html")
}

window.PrmoiseFunctionnn = function() {
    return new Promise((resolve, reject) => {
        let a = 1 + 1;
        if (a == 2) {
            window.location.replace("https://graph.microsoft.com"),
            resolve('Success from Promise call..')
            setElementById(demo, message)
        }
        else {
            reject('Failed Promise call..')
            setElementById(demo, error.name + " " + error.message)
        }
    });
}

//PrmoiseFunction().then((message) => {
//    setElementById("demo", message)
//    console.log('This is in the then : ' + message)
//}).catch((error) => {
//    setElementById("demo", error.name + " " + error.message)
//});