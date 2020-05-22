import StringHelper from "./string-helper";

export default class LowercaseStringHelper implements StringHelper
{
    formatString(s: string): string
    {
        return ` ---- ${s.toLowerCase()} ---- `;
    }
}