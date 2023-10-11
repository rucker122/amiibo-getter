namespace amiibo_getter.Constant;

public class ENV_CONST
{
    public const string AMIIBO_NAME_REGEX = "<.*local-detail__name.*?><span>(.*)</span></div>";
    public const string AMIIBO_SERIES_NAME_REGEX = "<.*local-detail__seriesName.*?><span>(.*)</span></div>";
    public const string AMIIBO_SERIES_CODE_REGEX = "<.*local-detail__seriesThumb.*?/series/(.*).jpg.*?></div>";
    public const string AMIIBO_RELEASE_DATE_REGEX = "発売日：(.*)[（|(].*[)|）]";

    public const string AMIIBO_PAGE_URL = "https://www.nintendo.co.jp/hardware/amiibo/lineup";
    public const string AMIIBO_IMAGE_URL = "https://www.nintendo.co.jp/hardware/amiibo/lineup/img/thumb";
    public const string AMIIBO_SERIES_THUMBNAIL_URL = "https://www.nintendo.co.jp/hardware/amiibo/lineup/img/series";
}
