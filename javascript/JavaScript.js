function focusNextInput(event, currentElement) {
    if (event.key === "Enter") {
        event.preventDefault();
        var formElements = document.forms[0].elements;
        for (var i = 0; i < formElements.length; i++) {
            if (formElements[i] === currentElement) {
                if (i + 1 < formElements.length) {
                    formElements[i + 1].focus();
                }
                break;
            }
        }
    }
}