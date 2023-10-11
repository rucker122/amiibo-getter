using amiibo_getter.Constant;
using amiibo_getter.Models;
using System.Text;
using System.Text.RegularExpressions;

namespace amiibo_getter;
public class DataHelper
{
    // Get web content from Url
    public static async Task<string> GetHtml(string url)
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);
        HttpContent content = response.Content;
        return await content.ReadAsStringAsync();
    }

    public static AmiiboData HtmlToAmiiboData(string html)
    {
        return new()
        {
            //Indo = idno,
            Name = GetHtmlElement(html, ENV_CONST.AMIIBO_NAME_REGEX),
            Series = new (){
                Code = GetHtmlElement(html, ENV_CONST.AMIIBO_SERIES_CODE_REGEX),
                Name = GetHtmlElement(html, ENV_CONST.AMIIBO_SERIES_NAME_REGEX)
            },
            ReleaseDate = GetHtmlElement(html, ENV_CONST.AMIIBO_RELEASE_DATE_REGEX)
        };
    }

    public static string getNextIdno(string idno = "", bool skip = false) 
    {
        if (string.IsNullOrEmpty(idno)) return "aaaa";

        byte[] asciiBytes = IdnoToAsciiArray(idno);
        for (int idx = asciiBytes.Length - 1; idx >= 0; idx--)
        {
            if (!IsLegitAscii(asciiBytes))
                throw new Exception("Exception occured when getting next Idno");

            if (++asciiBytes[idx] > 122 || skip)
            {
                if (skip) skip = !skip;
                asciiBytes[idx] = 97;
                continue;
            }
            break;
        }
        return AsciiArrayToIdno(asciiBytes);
    }

    public static bool IsLegitIdno(string idno) {
        return IsLegitAscii(IdnoToAsciiArray(idno));
    }

    public static bool IsLegitAscii(byte[] asciiBytes) {
    return !asciiBytes.Any(x => x < 97 || x > 122);
}

    public static byte[] IdnoToAsciiArray(string idno) {
        return Encoding.ASCII.GetBytes(idno);
    }

    public static string AsciiArrayToIdno(byte[] asciiBytes) {
        return Encoding.ASCII.GetString(asciiBytes);
    }

    public static string GetHtmlElement(string html, string reg)
    {
        Regex r = new Regex(reg);
        Match m = r.Match(html);
        return m.Groups.Values.LastOrDefault()?.ToString() ?? "";
    }
}
