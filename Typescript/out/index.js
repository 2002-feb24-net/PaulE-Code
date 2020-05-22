"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const lowercase_string_helper_1 = __importDefault(require("./lowercase-string-helper"));
// const helper = new LowercaseStringHelper();
// const helper: StringHelper = new LowercaseStringHelper();
document.addEventListener('DOMContentLoaded', () => {
    let element = document.createElement('p');
    const helper = new lowercase_string_helper_1.default();
    element.textContent = helper.formatString("Hello TS");
    document.body.appendChild(element);
});
