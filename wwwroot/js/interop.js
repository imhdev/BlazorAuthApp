function createAlert() {
    alert("Hey! this is an alert!!");
}

function createPrompt(question) {
    return prompt(question);
}

function setElementByIddd(id, text) {
    document.getElementById(id).innerText = text;
    window.location.assign(window.location.origin + "/myPages/steps.html")
}

function focusOnElement(element) {
    element.focus();
}

