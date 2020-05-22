import StringHelper from "./string-helper";
import LowercaseStringHelper from "./lowercase-string-helper";

// const helper = new LowercaseStringHelper();
// const helper: StringHelper = new LowercaseStringHelper();

document.addEventListener('DOMContentLoaded', () => {
    let element = document.createElement('p');

    const helper: StringHelper = new LowercaseStringHelper();

    element.textContent = helper.formatString("Hello TS");

    document.body.appendChild(element);
});