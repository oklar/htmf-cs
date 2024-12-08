namespace HtmfExample;

public class MicroWind
{
    public MicroWind(string className, string cssStyleOutput) { ClassName = className; CssStyleOutput = cssStyleOutput; }

    public string ClassName { get; }
    public string CssStyleOutput { get; }

    public override string ToString() => ClassName;

    // Should create .css file with preflight instead in wwwroot/
    public static string Preflight = "*,::after,::before{box-sizing:border-box;border-width:0;border-style:solid;border-color:#e5e7eb}::after,::before{--tw-content:''}:host,html{line-height:1.5;-webkit-text-size-adjust:100%;-moz-tab-size:4;tab-size:4;font-family:ui-sans-serif, system-ui, sans-serif, \"Apple Color Emoji\", \"Segoe UI Emoji\", \"Segoe UI Symbol\", \"Noto Color Emoji\";font-feature-settings:normal;font-variation-settings:normal;-webkit-tap-highlight-color:transparent}body{margin:0;line-height:inherit}hr{height:0;color:inherit;border-top-width:1px}abbr:where([title]){-webkit-text-decoration:underline dotted;text-decoration:underline dotted}h1,h2,h3,h4,h5,h6{font-size:inherit;font-weight:inherit}a{color:inherit;text-decoration:inherit}b,strong{font-weight:bolder}code,kbd,pre,samp{font-family:ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, \"Liberation Mono\", \"Courier New\", monospace;font-feature-settings:normal;font-variation-settings:normal;font-size:1em}small{font-size:80%}sub,sup{font-size:75%;line-height:0;position:relative;vertical-align:baseline}sub{bottom:-.25em}sup{top:-.5em}table{text-indent:0;border-color:inherit;border-collapse:collapse}button,input,optgroup,select,textarea{font-family:inherit;font-feature-settings:inherit;font-variation-settings:inherit;font-size:100%;font-weight:inherit;line-height:inherit;letter-spacing:inherit;color:inherit;margin:0;padding:0}button,select{text-transform:none}button,input:where([type=button]),input:where([type=reset]),input:where([type=submit]){-webkit-appearance:button;background-color:transparent;background-image:none}:-moz-focusring{outline:auto}:-moz-ui-invalid{box-shadow:none}progress{vertical-align:baseline}::-webkit-inner-spin-button,::-webkit-outer-spin-button{height:auto}[type=search]{-webkit-appearance:textfield;outline-offset:-2px}::-webkit-search-decoration{-webkit-appearance:none}::-webkit-file-upload-button{-webkit-appearance:button;font:inherit}summary{display:list-item}blockquote,dd,dl,figure,h1,h2,h3,h4,h5,h6,hr,p,pre{margin:0}fieldset{margin:0;padding:0}legend{padding:0}menu,ol,ul{list-style:none;margin:0;padding:0}dialog{padding:0}textarea{resize:vertical}input::placeholder,textarea::placeholder{opacity:1;color:#9ca3af}[role=button],button{cursor:pointer}:disabled{cursor:default}audio,canvas,embed,iframe,img,object,svg,video{display:block;vertical-align:middle}img,video{max-width:100%;height:auto}[hidden]{display:none}";

    // Amber
    public static string TextAmber50 { get; } = $".{nameof(TextAmber50)}{{color:{MWColors.Amber50};}}";
    public static string TextAmber100 { get; } = $".{nameof(TextAmber100)}{{color:{MWColors.Amber100};}}";
    public static string TextAmber200 { get; } = $".{nameof(TextAmber200)}{{color:{MWColors.Amber200};}}";
    public static string TextAmber300 { get; } = $".{nameof(TextAmber300)}{{color:{MWColors.Amber300};}}";
    public static string TextAmber400 { get; } = $".{nameof(TextAmber400)}{{color:{MWColors.Amber400};}}";
    public static string TextAmber500 { get; } = $".{nameof(TextAmber500)}{{color:{MWColors.Amber500};}}";
    public static string TextAmber600 { get; } = $".{nameof(TextAmber600)}{{color:{MWColors.Amber600};}}";
    public static string TextAmber700 { get; } = $".{nameof(TextAmber700)}{{color:{MWColors.Amber700};}}";
    public static string TextAmber800 { get; } = $".{nameof(TextAmber800)}{{color:{MWColors.Amber800};}}";
    public static string TextAmber900 { get; } = $".{nameof(TextAmber900)}{{color:{MWColors.Amber900};}}";

    // Black
    public static string TextBlack { get; } = $".{nameof(TextBlack)}{{color:{MWColors.Black};}}";

    // Blue
    public static string TextBlue50 { get; } = $".{nameof(TextBlue50)}{{color:{MWColors.Blue50};}}";
    public static string TextBlue100 { get; } = $".{nameof(TextBlue100)}{{color:{MWColors.Blue100};}}";
    public static string TextBlue200 { get; } = $".{nameof(TextBlue200)}{{color:{MWColors.Blue200};}}";
    public static string TextBlue300 { get; } = $".{nameof(TextBlue300)}{{color:{MWColors.Blue300};}}";
    public static string TextBlue400 { get; } = $".{nameof(TextBlue400)}{{color:{MWColors.Blue400};}}";
    public static string TextBlue500 { get; } = $".{nameof(TextBlue500)}{{color:{MWColors.Blue500};}}";
    public static string TextBlue600 { get; } = $".{nameof(TextBlue600)}{{color:{MWColors.Blue600};}}";
    public static string TextBlue700 { get; } = $".{nameof(TextBlue700)}{{color:{MWColors.Blue700};}}";
    public static string TextBlue800 { get; } = $".{nameof(TextBlue800)}{{color:{MWColors.Blue800};}}";
    public static string TextBlue900 { get; } = $".{nameof(TextBlue900)}{{color:{MWColors.Blue900};}}";

    // BlueGray
    public static string TextBlueGray50 { get; } = $".{nameof(TextBlueGray50)}{{color:{MWColors.BlueGray50};}}";
    public static string TextBlueGray100 { get; } = $".{nameof(TextBlueGray100)}{{color:{MWColors.BlueGray100};}}";
    public static string TextBlueGray200 { get; } = $".{nameof(TextBlueGray200)}{{color:{MWColors.BlueGray200};}}";
    public static string TextBlueGray300 { get; } = $".{nameof(TextBlueGray300)}{{color:{MWColors.BlueGray300};}}";
    public static string TextBlueGray400 { get; } = $".{nameof(TextBlueGray400)}{{color:{MWColors.BlueGray400};}}";
    public static string TextBlueGray500 { get; } = $".{nameof(TextBlueGray500)}{{color:{MWColors.BlueGray500};}}";
    public static string TextBlueGray600 { get; } = $".{nameof(TextBlueGray600)}{{color:{MWColors.BlueGray600};}}";
    public static string TextBlueGray700 { get; } = $".{nameof(TextBlueGray700)}{{color:{MWColors.BlueGray700};}}";
    public static string TextBlueGray800 { get; } = $".{nameof(TextBlueGray800)}{{color:{MWColors.BlueGray800};}}";
    public static string TextBlueGray900 { get; } = $".{nameof(TextBlueGray900)}{{color:{MWColors.BlueGray900};}}";

    // CoolGray
    public static string TextCoolGray50 { get; } = $".{nameof(TextCoolGray50)}{{color:{MWColors.CoolGray50};}}";
    public static string TextCoolGray100 { get; } = $".{nameof(TextCoolGray100)}{{color:{MWColors.CoolGray100};}}";
    public static string TextCoolGray200 { get; } = $".{nameof(TextCoolGray200)}{{color:{MWColors.CoolGray200};}}";
    public static string TextCoolGray300 { get; } = $".{nameof(TextCoolGray300)}{{color:{MWColors.CoolGray300};}}";
    public static string TextCoolGray400 { get; } = $".{nameof(TextCoolGray400)}{{color:{MWColors.CoolGray400};}}";
    public static string TextCoolGray500 { get; } = $".{nameof(TextCoolGray500)}{{color:{MWColors.CoolGray500};}}";
    public static string TextCoolGray600 { get; } = $".{nameof(TextCoolGray600)}{{color:{MWColors.CoolGray600};}}";
    public static string TextCoolGray700 { get; } = $".{nameof(TextCoolGray700)}{{color:{MWColors.CoolGray700};}}";
    public static string TextCoolGray800 { get; } = $".{nameof(TextCoolGray800)}{{color:{MWColors.CoolGray800};}}";
    public static string TextCoolGray900 { get; } = $".{nameof(TextCoolGray900)}{{color:{MWColors.CoolGray900};}}";

    // Cyan
    public static string TextCyan50 { get; } = $".{nameof(TextCyan50)}{{color:{MWColors.Cyan50};}}";
    public static string TextCyan100 { get; } = $".{nameof(TextCyan100)}{{color:{MWColors.Cyan100};}}";
    public static string TextCyan200 { get; } = $".{nameof(TextCyan200)}{{color:{MWColors.Cyan200};}}";
    public static string TextCyan300 { get; } = $".{nameof(TextCyan300)}{{color:{MWColors.Cyan300};}}";
    public static string TextCyan400 { get; } = $".{nameof(TextCyan400)}{{color:{MWColors.Cyan400};}}";
    public static string TextCyan500 { get; } = $".{nameof(TextCyan500)}{{color:{MWColors.Cyan500};}}";
    public static string TextCyan600 { get; } = $".{nameof(TextCyan600)}{{color:{MWColors.Cyan600};}}";
    public static string TextCyan700 { get; } = $".{nameof(TextCyan700)}{{color:{MWColors.Cyan700};}}";
    public static string TextCyan800 { get; } = $".{nameof(TextCyan800)}{{color:{MWColors.Cyan800};}}";
    public static string TextCyan900 { get; } = $".{nameof(TextCyan900)}{{color:{MWColors.Cyan900};}}";

    // Emerald
    public static string TextEmerald50 { get; } = $".{nameof(TextEmerald50)}{{color:{MWColors.Emerald50};}}";
    public static string TextEmerald100 { get; } = $".{nameof(TextEmerald100)}{{color:{MWColors.Emerald100};}}";
    public static string TextEmerald200 { get; } = $".{nameof(TextEmerald200)}{{color:{MWColors.Emerald200};}}";
    public static string TextEmerald300 { get; } = $".{nameof(TextEmerald300)}{{color:{MWColors.Emerald300};}}";
    public static string TextEmerald400 { get; } = $".{nameof(TextEmerald400)}{{color:{MWColors.Emerald400};}}";
    public static string TextEmerald500 { get; } = $".{nameof(TextEmerald500)}{{color:{MWColors.Emerald500};}}";
    public static string TextEmerald600 { get; } = $".{nameof(TextEmerald600)}{{color:{MWColors.Emerald600};}}";
    public static string TextEmerald700 { get; } = $".{nameof(TextEmerald700)}{{color:{MWColors.Emerald700};}}";
    public static string TextEmerald800 { get; } = $".{nameof(TextEmerald800)}{{color:{MWColors.Emerald800};}}";
    public static string TextEmerald900 { get; } = $".{nameof(TextEmerald900)}{{color:{MWColors.Emerald900};}}";

    // Fuchsia
    public static string TextFuchsia50 { get; } = $".{nameof(TextFuchsia50)}{{color:{MWColors.Fuchsia50};}}";
    public static string TextFuchsia100 { get; } = $".{nameof(TextFuchsia100)}{{color:{MWColors.Fuchsia100};}}";
    public static string TextFuchsia200 { get; } = $".{nameof(TextFuchsia200)}{{color:{MWColors.Fuchsia200};}}";
    public static string TextFuchsia300 { get; } = $".{nameof(TextFuchsia300)}{{color:{MWColors.Fuchsia300};}}";
    public static string TextFuchsia400 { get; } = $".{nameof(TextFuchsia400)}{{color:{MWColors.Fuchsia400};}}";
    public static string TextFuchsia500 { get; } = $".{nameof(TextFuchsia500)}{{color:{MWColors.Fuchsia500};}}";
    public static string TextFuchsia600 { get; } = $".{nameof(TextFuchsia600)}{{color:{MWColors.Fuchsia600};}}";
    public static string TextFuchsia700 { get; } = $".{nameof(TextFuchsia700)}{{color:{MWColors.Fuchsia700};}}";
    public static string TextFuchsia800 { get; } = $".{nameof(TextFuchsia800)}{{color:{MWColors.Fuchsia800};}}";
    public static string TextFuchsia900 { get; } = $".{nameof(TextFuchsia900)}{{color:{MWColors.Fuchsia900};}}";

    // Gray
    public static string TextGray50 { get; } = $".{nameof(TextGray50)}{{color:{MWColors.Gray50};}}";
    public static string TextGray100 { get; } = $".{nameof(TextGray100)}{{color:{MWColors.Gray100};}}";
    public static string TextGray200 { get; } = $".{nameof(TextGray200)}{{color:{MWColors.Gray200};}}";
    public static string TextGray300 { get; } = $".{nameof(TextGray300)}{{color:{MWColors.Gray300};}}";
    public static string TextGray400 { get; } = $".{nameof(TextGray400)}{{color:{MWColors.Gray400};}}";
    public static string TextGray500 { get; } = $".{nameof(TextGray500)}{{color:{MWColors.Gray500};}}";
    public static string TextGray600 { get; } = $".{nameof(TextGray600)}{{color:{MWColors.Gray600};}}";
    public static string TextGray700 { get; } = $".{nameof(TextGray700)}{{color:{MWColors.Gray700};}}";
    public static string TextGray800 { get; } = $".{nameof(TextGray800)}{{color:{MWColors.Gray800};}}";
    public static string TextGray900 { get; } = $".{nameof(TextGray900)}{{color:{MWColors.Gray900};}}";

    // Green
    public static string TextGreen50 { get; } = $".{nameof(TextGreen50)}{{color:{MWColors.Green50};}}";
    public static string TextGreen100 { get; } = $".{nameof(TextGreen100)}{{color:{MWColors.Green100};}}";
    public static string TextGreen200 { get; } = $".{nameof(TextGreen200)}{{color:{MWColors.Green200};}}";
    public static string TextGreen300 { get; } = $".{nameof(TextGreen300)}{{color:{MWColors.Green300};}}";
    public static string TextGreen400 { get; } = $".{nameof(TextGreen400)}{{color:{MWColors.Green400};}}";
    public static string TextGreen500 { get; } = $".{nameof(TextGreen500)}{{color:{MWColors.Green500};}}";
    public static string TextGreen600 { get; } = $".{nameof(TextGreen600)}{{color:{MWColors.Green600};}}";
    public static string TextGreen700 { get; } = $".{nameof(TextGreen700)}{{color:{MWColors.Green700};}}";
    public static string TextGreen800 { get; } = $".{nameof(TextGreen800)}{{color:{MWColors.Green800};}}";
    public static string TextGreen900 { get; } = $".{nameof(TextGreen900)}{{color:{MWColors.Green900};}}";

    // Indigo
    public static string TextIndigo50 { get; } = $".{nameof(TextIndigo50)}{{color:{MWColors.Indigo50};}}";
    public static string TextIndigo100 { get; } = $".{nameof(TextIndigo100)}{{color:{MWColors.Indigo100};}}";
    public static string TextIndigo200 { get; } = $".{nameof(TextIndigo200)}{{color:{MWColors.Indigo200};}}";
    public static string TextIndigo300 { get; } = $".{nameof(TextIndigo300)}{{color:{MWColors.Indigo300};}}";
    public static string TextIndigo400 { get; } = $".{nameof(TextIndigo400)}{{color:{MWColors.Indigo400};}}";
    public static string TextIndigo500 { get; } = $".{nameof(TextIndigo500)}{{color:{MWColors.Indigo500};}}";
    public static string TextIndigo600 { get; } = $".{nameof(TextIndigo600)}{{color:{MWColors.Indigo600};}}";
    public static string TextIndigo700 { get; } = $".{nameof(TextIndigo700)}{{color:{MWColors.Indigo700};}}";
    public static string TextIndigo800 { get; } = $".{nameof(TextIndigo800)}{{color:{MWColors.Indigo800};}}";
    public static string TextIndigo900 { get; } = $".{nameof(TextIndigo900)}{{color:{MWColors.Indigo900};}}";

    // LightBlue
    public static string TextLightBlue50 { get; } = $".{nameof(TextLightBlue50)}{{color:{MWColors.LightBlue50};}}";
    public static string TextLightBlue100 { get; } = $".{nameof(TextLightBlue100)}{{color:{MWColors.LightBlue100};}}";
    public static string TextLightBlue200 { get; } = $".{nameof(TextLightBlue200)}{{color:{MWColors.LightBlue200};}}";
    public static string TextLightBlue300 { get; } = $".{nameof(TextLightBlue300)}{{color:{MWColors.LightBlue300};}}";
    public static string TextLightBlue400 { get; } = $".{nameof(TextLightBlue400)}{{color:{MWColors.LightBlue400};}}";
    public static string TextLightBlue500 { get; } = $".{nameof(TextLightBlue500)}{{color:{MWColors.LightBlue500};}}";
    public static string TextLightBlue600 { get; } = $".{nameof(TextLightBlue600)}{{color:{MWColors.LightBlue600};}}";
    public static string TextLightBlue700 { get; } = $".{nameof(TextLightBlue700)}{{color:{MWColors.LightBlue700};}}";
    public static string TextLightBlue800 { get; } = $".{nameof(TextLightBlue800)}{{color:{MWColors.LightBlue800};}}";
    public static string TextLightBlue900 { get; } = $".{nameof(TextLightBlue900)}{{color:{MWColors.LightBlue900};}}";

    // Lime
    public static string TextLime50 { get; } = $".{nameof(TextLime50)}{{color:{MWColors.Lime50};}}";
    public static string TextLime100 { get; } = $".{nameof(TextLime100)}{{color:{MWColors.Lime100};}}";
    public static string TextLime200 { get; } = $".{nameof(TextLime200)}{{color:{MWColors.Lime200};}}";
    public static string TextLime300 { get; } = $".{nameof(TextLime300)}{{color:{MWColors.Lime300};}}";
    public static string TextLime400 { get; } = $".{nameof(TextLime400)}{{color:{MWColors.Lime400};}}";
    public static string TextLime500 { get; } = $".{nameof(TextLime500)}{{color:{MWColors.Lime500};}}";
    public static string TextLime600 { get; } = $".{nameof(TextLime600)}{{color:{MWColors.Lime600};}}";
    public static string TextLime700 { get; } = $".{nameof(TextLime700)}{{color:{MWColors.Lime700};}}";
    public static string TextLime800 { get; } = $".{nameof(TextLime800)}{{color:{MWColors.Lime800};}}";
    public static string TextLime900 { get; } = $".{nameof(TextLime900)}{{color:{MWColors.Lime900};}}";

    // Orange
    public static string TextOrange50 { get; } = $".{nameof(TextOrange50)}{{color:{MWColors.Orange50};}}";
    public static string TextOrange100 { get; } = $".{nameof(TextOrange100)}{{color:{MWColors.Orange100};}}";
    public static string TextOrange200 { get; } = $".{nameof(TextOrange200)}{{color:{MWColors.Orange200};}}";
    public static string TextOrange300 { get; } = $".{nameof(TextOrange300)}{{color:{MWColors.Orange300};}}";
    public static string TextOrange400 { get; } = $".{nameof(TextOrange400)}{{color:{MWColors.Orange400};}}";
    public static string TextOrange500 { get; } = $".{nameof(TextOrange500)}{{color:{MWColors.Orange500};}}";
    public static string TextOrange600 { get; } = $".{nameof(TextOrange600)}{{color:{MWColors.Orange600};}}";
    public static string TextOrange700 { get; } = $".{nameof(TextOrange700)}{{color:{MWColors.Orange700};}}";
    public static string TextOrange800 { get; } = $".{nameof(TextOrange800)}{{color:{MWColors.Orange800};}}";
    public static string TextOrange900 { get; } = $".{nameof(TextOrange900)}{{color:{MWColors.Orange900};}}";

    // Pink
    public static string TextPink50 { get; } = $".{nameof(TextPink50)}{{color:{MWColors.Pink50};}}";
    public static string TextPink100 { get; } = $".{nameof(TextPink100)}{{color:{MWColors.Pink100};}}";
    public static string TextPink200 { get; } = $".{nameof(TextPink200)}{{color:{MWColors.Pink200};}}";
    public static string TextPink300 { get; } = $".{nameof(TextPink300)}{{color:{MWColors.Pink300};}}";
    public static string TextPink400 { get; } = $".{nameof(TextPink400)}{{color:{MWColors.Pink400};}}";
    public static string TextPink500 { get; } = $".{nameof(TextPink500)}{{color:{MWColors.Pink500};}}";
    public static string TextPink600 { get; } = $".{nameof(TextPink600)}{{color:{MWColors.Pink600};}}";
    public static string TextPink700 { get; } = $".{nameof(TextPink700)}{{color:{MWColors.Pink700};}}";
    public static string TextPink800 { get; } = $".{nameof(TextPink800)}{{color:{MWColors.Pink800};}}";
    public static string TextPink900 { get; } = $".{nameof(TextPink900)}{{color:{MWColors.Pink900};}}";

    // Purple
    public static string TextPurple50 { get; } = $".{nameof(TextPurple50)}{{color:{MWColors.Purple50};}}";
    public static string TextPurple100 { get; } = $".{nameof(TextPurple100)}{{color:{MWColors.Purple100};}}";
    public static string TextPurple200 { get; } = $".{nameof(TextPurple200)}{{color:{MWColors.Purple200};}}";
    public static string TextPurple300 { get; } = $".{nameof(TextPurple300)}{{color:{MWColors.Purple300};}}";
    public static string TextPurple400 { get; } = $".{nameof(TextPurple400)}{{color:{MWColors.Purple400};}}";
    public static string TextPurple500 { get; } = $".{nameof(TextPurple500)}{{color:{MWColors.Purple500};}}";
    public static string TextPurple600 { get; } = $".{nameof(TextPurple600)}{{color:{MWColors.Purple600};}}";
    public static string TextPurple700 { get; } = $".{nameof(TextPurple700)}{{color:{MWColors.Purple700};}}";
    public static string TextPurple800 { get; } = $".{nameof(TextPurple800)}{{color:{MWColors.Purple800};}}";
    public static string TextPurple900 { get; } = $".{nameof(TextPurple900)}{{color:{MWColors.Purple900};}}";

    // Red
    public static string TextRed50 { get; } = $".{nameof(TextRed50)}{{color:{MWColors.Red50};}}";
    public static string TextRed100 { get; } = $".{nameof(TextRed100)}{{color:{MWColors.Red100};}}";
    public static string TextRed200 { get; } = $".{nameof(TextRed200)}{{color:{MWColors.Red200};}}";
    public static string TextRed300 { get; } = $".{nameof(TextRed300)}{{color:{MWColors.Red300};}}";
    public static string TextRed400 { get; } = $".{nameof(TextRed400)}{{color:{MWColors.Red400};}}";
    public static string TextRed500 { get; } = $".{nameof(TextRed500)}{{color:{MWColors.Red500};}}";
    public static string TextRed600 { get; } = $".{nameof(TextRed600)}{{color:{MWColors.Red600};}}";
    public static string TextRed700 { get; } = $".{nameof(TextRed700)}{{color:{MWColors.Red700};}}";
    public static string TextRed800 { get; } = $".{nameof(TextRed800)}{{color:{MWColors.Red800};}}";
    public static string TextRed900 { get; } = $".{nameof(TextRed900)}{{color:{MWColors.Red900};}}";

    // Rose
    public static string TextRose50 { get; } = $".{nameof(TextRose50)}{{color:{MWColors.Rose50};}}";
    public static string TextRose100 { get; } = $".{nameof(TextRose100)}{{color:{MWColors.Rose100};}}";
    public static string TextRose200 { get; } = $".{nameof(TextRose200)}{{color:{MWColors.Rose200};}}";
    public static string TextRose300 { get; } = $".{nameof(TextRose300)}{{color:{MWColors.Rose300};}}";
    public static string TextRose400 { get; } = $".{nameof(TextRose400)}{{color:{MWColors.Rose400};}}";
    public static string TextRose500 { get; } = $".{nameof(TextRose500)}{{color:{MWColors.Rose500};}}";
    public static string TextRose600 { get; } = $".{nameof(TextRose600)}{{color:{MWColors.Rose600};}}";
    public static string TextRose700 { get; } = $".{nameof(TextRose700)}{{color:{MWColors.Rose700};}}";
    public static string TextRose800 { get; } = $".{nameof(TextRose800)}{{color:{MWColors.Rose800};}}";
    public static string TextRose900 { get; } = $".{nameof(TextRose900)}{{color:{MWColors.Rose900};}}";

    // Sky
    public static string TextSky50 { get; } = $".{nameof(TextSky50)}{{color:{MWColors.Sky50};}}";
    public static string TextSky100 { get; } = $".{nameof(TextSky100)}{{color:{MWColors.Sky100};}}";
    public static string TextSky200 { get; } = $".{nameof(TextSky200)}{{color:{MWColors.Sky200};}}";
    public static string TextSky300 { get; } = $".{nameof(TextSky300)}{{color:{MWColors.Sky300};}}";
    public static string TextSky400 { get; } = $".{nameof(TextSky400)}{{color:{MWColors.Sky400};}}";
    public static string TextSky500 { get; } = $".{nameof(TextSky500)}{{color:{MWColors.Sky500};}}";
    public static string TextSky600 { get; } = $".{nameof(TextSky600)}{{color:{MWColors.Sky600};}}";
    public static string TextSky700 { get; } = $".{nameof(TextSky700)}{{color:{MWColors.Sky700};}}";
    public static string TextSky800 { get; } = $".{nameof(TextSky800)}{{color:{MWColors.Sky800};}}";
    public static string TextSky900 { get; } = $".{nameof(TextSky900)}{{color:{MWColors.Sky900};}}";

    // Teal
    public static string TextTeal50 { get; } = $".{nameof(TextTeal50)}{{color:{MWColors.Teal50};}}";
    public static string TextTeal100 { get; } = $".{nameof(TextTeal100)}{{color:{MWColors.Teal100};}}";
    public static string TextTeal200 { get; } = $".{nameof(TextTeal200)}{{color:{MWColors.Teal200};}}";
    public static string TextTeal300 { get; } = $".{nameof(TextTeal300)}{{color:{MWColors.Teal300};}}";
    public static string TextTeal400 { get; } = $".{nameof(TextTeal400)}{{color:{MWColors.Teal400};}}";
    public static string TextTeal500 { get; } = $".{nameof(TextTeal500)}{{color:{MWColors.Teal500};}}";
    public static string TextTeal600 { get; } = $".{nameof(TextTeal600)}{{color:{MWColors.Teal600};}}";
    public static string TextTeal700 { get; } = $".{nameof(TextTeal700)}{{color:{MWColors.Teal700};}}";
    public static string TextTeal800 { get; } = $".{nameof(TextTeal800)}{{color:{MWColors.Teal800};}}";
    public static string TextTeal900 { get; } = $".{nameof(TextTeal900)}{{color:{MWColors.Teal900};}}";

    // TrueGray
    public static string TextTrueGray50 { get; } = $".{nameof(TextTrueGray50)}{{color:{MWColors.TrueGray50};}}";
    public static string TextTrueGray100 { get; } = $".{nameof(TextTrueGray100)}{{color:{MWColors.TrueGray100};}}";
    public static string TextTrueGray200 { get; } = $".{nameof(TextTrueGray200)}{{color:{MWColors.TrueGray200};}}";
    public static string TextTrueGray300 { get; } = $".{nameof(TextTrueGray300)}{{color:{MWColors.TrueGray300};}}";
    public static string TextTrueGray400 { get; } = $".{nameof(TextTrueGray400)}{{color:{MWColors.TrueGray400};}}";
    public static string TextTrueGray500 { get; } = $".{nameof(TextTrueGray500)}{{color:{MWColors.TrueGray500};}}";
    public static string TextTrueGray600 { get; } = $".{nameof(TextTrueGray600)}{{color:{MWColors.TrueGray600};}}";
    public static string TextTrueGray700 { get; } = $".{nameof(TextTrueGray700)}{{color:{MWColors.TrueGray700};}}";
    public static string TextTrueGray800 { get; } = $".{nameof(TextTrueGray800)}{{color:{MWColors.TrueGray800};}}";
    public static string TextTrueGray900 { get; } = $".{nameof(TextTrueGray900)}{{color:{MWColors.TrueGray900};}}";

    // Violet
    public static string TextViolet50 { get; } = $".{nameof(TextViolet50)}{{color:{MWColors.Violet50};}}";
    public static string TextViolet100 { get; } = $".{nameof(TextViolet100)}{{color:{MWColors.Violet100};}}";
    public static string TextViolet200 { get; } = $".{nameof(TextViolet200)}{{color:{MWColors.Violet200};}}";
    public static string TextViolet300 { get; } = $".{nameof(TextViolet300)}{{color:{MWColors.Violet300};}}";
    public static string TextViolet400 { get; } = $".{nameof(TextViolet400)}{{color:{MWColors.Violet400};}}";
    public static string TextViolet500 { get; } = $".{nameof(TextViolet500)}{{color:{MWColors.Violet500};}}";
    public static string TextViolet600 { get; } = $".{nameof(TextViolet600)}{{color:{MWColors.Violet600};}}";
    public static string TextViolet700 { get; } = $".{nameof(TextViolet700)}{{color:{MWColors.Violet700};}}";
    public static string TextViolet800 { get; } = $".{nameof(TextViolet800)}{{color:{MWColors.Violet800};}}";
    public static string TextViolet900 { get; } = $".{nameof(TextViolet900)}{{color:{MWColors.Violet900};}}";

    // WarmGray
    public static string TextWarmGray50 { get; } = $".{nameof(TextWarmGray50)}{{color:{MWColors.WarmGray50};}}";
    public static string TextWarmGray100 { get; } = $".{nameof(TextWarmGray100)}{{color:{MWColors.WarmGray100};}}";
    public static string TextWarmGray200 { get; } = $".{nameof(TextWarmGray200)}{{color:{MWColors.WarmGray200};}}";
    public static string TextWarmGray300 { get; } = $".{nameof(TextWarmGray300)}{{color:{MWColors.WarmGray300};}}";
    public static string TextWarmGray400 { get; } = $".{nameof(TextWarmGray400)}{{color:{MWColors.WarmGray400};}}";
    public static string TextWarmGray500 { get; } = $".{nameof(TextWarmGray500)}{{color:{MWColors.WarmGray500};}}";
    public static string TextWarmGray600 { get; } = $".{nameof(TextWarmGray600)}{{color:{MWColors.WarmGray600};}}";
    public static string TextWarmGray700 { get; } = $".{nameof(TextWarmGray700)}{{color:{MWColors.WarmGray700};}}";
    public static string TextWarmGray800 { get; } = $".{nameof(TextWarmGray800)}{{color:{MWColors.WarmGray800};}}";
    public static string TextWarmGray900 { get; } = $".{nameof(TextWarmGray900)}{{color:{MWColors.WarmGray900};}}";

    // White
    public static string TextWhite { get; } = $".{nameof(TextWhite)}{{color:{MWColors.White};}}";

    // Yellow
    public static string TextYellow50 { get; } = $".{nameof(TextYellow50)}{{color:{MWColors.Yellow50};}}";
    public static string TextYellow100 { get; } = $".{nameof(TextYellow100)}{{color:{MWColors.Yellow100};}}";
    public static string TextYellow200 { get; } = $".{nameof(TextYellow200)}{{color:{MWColors.Yellow200};}}";
    public static string TextYellow300 { get; } = $".{nameof(TextYellow300)}{{color:{MWColors.Yellow300};}}";
    public static string TextYellow400 { get; } = $".{nameof(TextYellow400)}{{color:{MWColors.Yellow400};}}";
    public static string TextYellow500 { get; } = $".{nameof(TextYellow500)}{{color:{MWColors.Yellow500};}}";
    public static string TextYellow600 { get; } = $".{nameof(TextYellow600)}{{color:{MWColors.Yellow600};}}";
    public static string TextYellow700 { get; } = $".{nameof(TextYellow700)}{{color:{MWColors.Yellow700};}}";
    public static string TextYellow800 { get; } = $".{nameof(TextYellow800)}{{color:{MWColors.Yellow800};}}";
    public static string TextYellow900 { get; } = $".{nameof(TextYellow900)}{{color:{MWColors.Yellow900};}}";

    // Part 1: Layout

    public static string AspectRatioAuto { get; } = $".{nameof(AspectRatioAuto)}{{aspect-ratio:auto}}";
    public static string AspectRatioSquare { get; } = $".{nameof(AspectRatioSquare)}{{aspect-ratio:1/1}}";
    public static string AspectRatioVideo { get; } = $".{nameof(AspectRatioVideo)}{{aspect-ratio:16/9}}";

    public static string Container { get; } = $".{nameof(Container)}{{width:100%;}}";

    // Columns
    public static string Columns1 { get; } = $".{nameof(Columns1)}{{columns:1;}}";
    public static string Columns2 { get; } = $".{nameof(Columns2)}{{columns:2;}}";
    public static string Columns3 { get; } = $".{nameof(Columns3)}{{columns:3;}}";
    public static string Columns4 { get; } = $".{nameof(Columns4)}{{columns:4;}}";
    public static string Columns5 { get; } = $".{nameof(Columns5)}{{columns:5;}}";
    public static string Columns6 { get; } = $".{nameof(Columns6)}{{columns:6;}}";
    public static string Columns7 { get; } = $".{nameof(Columns7)}{{columns:7;}}";
    public static string Columns8 { get; } = $".{nameof(Columns8)}{{columns:8;}}";
    public static string Columns9 { get; } = $".{nameof(Columns9)}{{columns:9;}}";
    public static string Columns10 { get; } = $".{nameof(Columns10)}{{columns:10;}}";
    public static string Columns11 { get; } = $".{nameof(Columns11)}{{columns:11;}}";
    public static string Columns12 { get; } = $".{nameof(Columns12)}{{columns:12;}}";
    public static string ColumnsAuto { get; } = $".{nameof(ColumnsAuto)}{{columns:auto;}}";
    public static string Columns3Xs { get; } = $".{nameof(Columns3Xs)}{{columns:16rem;}}";
    public static string Columns2Xs { get; } = $".{nameof(Columns2Xs)}{{columns:18rem;}}";
    public static string ColumnsXs { get; } = $".{nameof(ColumnsXs)}{{columns:20rem;}}";
    public static string ColumnsSm { get; } = $".{nameof(ColumnsSm)}{{columns:24rem;}}";
    public static string ColumnsMd { get; } = $".{nameof(ColumnsMd)}{{columns:28rem;}}";
    public static string ColumnsLg { get; } = $".{nameof(ColumnsLg)}{{columns:32rem;}}";
    public static string ColumnsXl { get; } = $".{nameof(ColumnsXl)}{{columns:36rem;}}";
    public static string Columns2xl { get; } = $".{nameof(Columns2xl)}{{columns:42rem;}}";
    public static string Columns3xl { get; } = $".{nameof(Columns3xl)}{{columns:48rem;}}";
    public static string Columns4xl { get; } = $".{nameof(Columns4xl)}{{columns:56rem;}}";
    public static string Columns5xl { get; } = $".{nameof(Columns5xl)}{{columns:64rem;}}";
    public static string Columns6xl { get; } = $".{nameof(Columns6xl)}{{columns:72rem;}}";
    public static string Columns7xl { get; } = $".{nameof(Columns7xl)}{{columns:80rem;}}";

    // Break After
    public static string BreakAfterAuto { get; } = $".{nameof(BreakAfterAuto)}{{break-after:auto;}}";
    public static string BreakAfterAvoid { get; } = $".{nameof(BreakAfterAvoid)}{{break-after:avoid;}}";
    public static string BreakAfterAll { get; } = $".{nameof(BreakAfterAll)}{{break-after:all;}}";
    public static string BreakAfterAvoidPage { get; } = $".{nameof(BreakAfterAvoidPage)}{{break-after:avoid-page;}}";
    public static string BreakAfterPage { get; } = $".{nameof(BreakAfterPage)}{{break-after:page;}}";
    public static string BreakAfterLeft { get; } = $".{nameof(BreakAfterLeft)}{{break-after:left;}}";
    public static string BreakAfterRight { get; } = $".{nameof(BreakAfterRight)}{{break-after:right;}}";
    public static string BreakAfterColumn { get; } = $".{nameof(BreakAfterColumn)}{{break-after:column;}}";

    // Break Before
    public static string BreakBeforeAuto { get; } = $".{nameof(BreakBeforeAuto)}{{break-before:auto;}}";
    public static string BreakBeforeAvoid { get; } = $".{nameof(BreakBeforeAvoid)}{{break-before:avoid;}}";
    public static string BreakBeforeAll { get; } = $".{nameof(BreakBeforeAll)}{{break-before:all;}}";
    public static string BreakBeforeAvoidPage { get; }= $".{nameof(BreakBeforeAvoidPage)}{{break-before:avoid-page;}}";
    public static string BreakBeforePage { get; } = $".{nameof(BreakBeforePage)}{{break-before:page;}}";
    public static string BreakBeforeLeft { get; } = $".{nameof(BreakBeforeLeft)}{{break-before:left;}}";
    public static string BreakBeforeRight { get; } = $".{nameof(BreakBeforeRight)}{{break-before:right;}}";
    public static string BreakBeforeColumn { get; } = $".{nameof(BreakBeforeColumn)}{{break-before:column;}}";

    // Break Inside
    public static string BreakInsideAuto { get; } = $".{nameof(BreakInsideAuto)}{{break-inside:auto;}}";
    public static string BreakInsideAvoid { get; } = $".{nameof(BreakInsideAvoid)}{{break-inside:avoid;}}";
    public static string BreakInsideAvoidPage { get; } = $".{nameof(BreakInsideAvoidPage)}{{break-inside:avoid-page;}}";
    public static string BreakInsideAvoidColumn { get; } = $".{nameof(BreakInsideAvoidColumn)}{{break-inside:avoid-column;}}";

    // Box Decoration Break
    public static string DecorationBreakSlice { get; } = $".{nameof(DecorationBreakSlice)}{{box-decoration-break:slice;}}";
    public static string DecorationBreakClone { get; } = $".{nameof(DecorationBreakClone)}{{box-decoration-break:clone;}}";

    // Box Sizing
    public static string SizingBorderBox { get; } = $".{nameof(SizingBorderBox)}{{box-sizing:border-box;}}";
    public static string SizingContentBox { get; } = $".{nameof(SizingContentBox)}{{box-sizing:content-box;}}";

    // Display
    public static string Block { get; } = $".{nameof(Block)}{{display:block;}}";
    public static string Inline { get; } = $".{nameof(Inline)}{{display:inline;}}";
    public static string InlineBlock { get; } = $".{nameof(InlineBlock)}{{display:inline-block;}}";
    public static string Flex { get; } = $".{nameof(Flex)}{{display:flex;}}";
    public static string InlineFlex { get; } = $".{nameof(InlineFlex)}{{display:inline-flex;}}";
    public static string Table { get; } = $".{nameof(Table)}{{display:table;}}";
    public static string InlineTable { get; } = $".{nameof(InlineTable)}{{display:inline-table;}}";
    public static string TableCaption { get; } = $".{nameof(TableCaption)}{{display:table-caption;}}";
    public static string TableCell { get; } = $".{nameof(TableCell)}{{display:table-cell;}}";
    public static string TableColumn { get; } = $".{nameof(TableColumn)}{{display:table-column;}}";
    public static string TableColumnGroup { get; } = $".{nameof(TableColumnGroup)}{{display:table-column-group;}}";
    public static string TableFooterGroup { get; } = $".{nameof(TableFooterGroup)}{{display:table-footer-group;}}";
    public static string TableHeaderGroup { get; } = $".{nameof(TableHeaderGroup)}{{display:table-header-group;}}";
    public static string TableRowGroup { get; } = $".{nameof(TableRowGroup)}{{display:table-row-group;}}";
    public static string TableRow { get; } = $".{nameof(TableRow)}{{display:table-row;}}";
    public static string FlowRoot { get; } = $".{nameof(FlowRoot)}{{display:flow-root;}}";
    public static string Grid { get; } = $".{nameof(Grid)}{{display:grid;}}";
    public static string InlineGrid { get; } = $".{nameof(InlineGrid)}{{display:inline-grid;}}";
    public static string Contents { get; } = $".{nameof(Contents)}{{display:contents;}}";
    public static string ListItem { get; } = $".{nameof(ListItem)}{{display:list-item;}}";
    public static string Hidden { get; } = $".{nameof(Hidden)}{{display:none;}}";

    // Floats
    public static string FloatStart { get; } = $".{nameof(FloatStart)}{{float:inline-start;}}";
    public static string FloatEnd { get; } = $".{nameof(FloatEnd)}{{float:inline-end;}}";
    public static string FloatLeft { get; } = $".{nameof(FloatLeft)}{{float:left;}}";
    public static string FloatRight { get; } = $".{nameof(FloatRight)}{{float:right;}}";
    public static string FloatNone { get; } = $".{nameof(FloatNone)}{{float:none;}}";

    // Clear
    public static string ClearStart { get; } = $".{nameof(ClearStart)}{{clear:inline-start;}}";
    public static string ClearEnd { get; } = $".{nameof(ClearEnd)}{{clear:inline-end;}}";
    public static string ClearLeft { get; } = $".{nameof(ClearLeft)}{{clear:left;}}";
    public static string ClearRight { get; } = $".{nameof(ClearRight)}{{clear:right;}}";
    public static string ClearBoth { get; } = $".{nameof(ClearBoth)}{{clear:both;}}";
    public static string ClearNone { get; } = $".{nameof(ClearNone)}{{clear:none;}}";

    // Isolation
    public static string IsolationAuto { get; } = $".{nameof(IsolationAuto)}{{isolation:auto;}}";
    public static string Isolate { get; } = $".{nameof(Isolate)}{{isolation:isolate;}}";

    // Object Fit
    public static string ObjectFitFill { get; } = $".{nameof(ObjectFitFill)}{{object-fit:fill;}}";
    public static string ObjectFitContain { get; } = $".{nameof(ObjectFitContain)}{{object-fit:contain;}}";
    public static string ObjectFitCover { get; } = $".{nameof(ObjectFitCover)}{{object-fit:cover;}}";
    public static string ObjectFitNone { get; } = $".{nameof(ObjectFitNone)}{{object-fit:none;}}";
    public static string ObjectFitScaleDown { get; } = $".{nameof(ObjectFitScaleDown)}{{object-fit:scale-down;}}";

    // Object Position
    public static string ObjectPositionBottom { get; } = $".{nameof(ObjectPositionBottom)}{{object-position:bottom;}}";
    public static string ObjectPositionCenter { get; } = $".{nameof(ObjectPositionCenter)}{{object-position:center;}}";
    public static string ObjectPositionLeft { get; } = $".{nameof(ObjectPositionLeft)}{{object-position:left;}}";
    public static string ObjectPositionLeftBottom { get; } = $".{nameof(ObjectPositionLeftBottom)}{{object-position:left bottom;}}";
    public static string ObjectPositionLeftTop { get; } = $".{nameof(ObjectPositionLeftTop)}{{object-position:left top;}}";
    public static string ObjectPositionRight { get; } = $".{nameof(ObjectPositionRight)}{{object-position:right;}}";
    public static string ObjectPositionRightBottom { get; } = $".{nameof(ObjectPositionRightBottom)}{{object-position:right bottom;}}";
    public static string ObjectPositionRightTop { get; } = $".{nameof(ObjectPositionRightTop)}{{object-position:right top;}}";
    public static string ObjectPositionTop { get; } = $".{nameof(ObjectPositionTop)}{{object-position:top;}}";

    // Overflow
    public static string OverflowAuto { get; } = $".{nameof(OverflowAuto)}{{overflow:auto;}}";
    public static string OverflowHidden { get; } = $".{nameof(OverflowHidden)}{{overflow:hidden;}}";
    public static string OverflowClip { get; } = $".{nameof(OverflowClip)}{{overflow:clip;}}";
    public static string OverflowScroll { get; } = $".{nameof(OverflowScroll)}{{overflow:scroll;}}";
    public static string OverflowVisible { get; } = $".{nameof(OverflowVisible)}{{overflow:visible;}}";

    public static string OverflowXAuto { get; } = $".{nameof(OverflowXAuto)}{{overflow-x:auto;}}";
    public static string OverflowXHidden { get; } = $".{nameof(OverflowXHidden)}{{overflow-x:hidden;}}";
    public static string OverflowXClip { get; } = $".{nameof(OverflowXClip)}{{overflow-x:clip;}}";
    public static string OverflowXScroll { get; } = $".{nameof(OverflowXScroll)}{{overflow-x:scroll;}}";
    public static string OverflowXVisible { get; } = $".{nameof(OverflowXVisible)}{{overflow-x:visible;}}";

    public static string OverflowYAuto { get; } = $".{nameof(OverflowYAuto)}{{overflow-y:auto;}}";
    public static string OverflowYHidden { get; } = $".{nameof(OverflowYHidden)}{{overflow-y:hidden;}}";
    public static string OverflowYClip { get; } = $".{nameof(OverflowYClip)}{{overflow-y:clip;}}";
    public static string OverflowYScroll { get; } = $".{nameof(OverflowYScroll)}{{overflow-y:scroll;}}";
    public static string OverflowYVisible { get; } = $".{nameof(OverflowYVisible)}{{overflow-y:visible;}}";

    // Overscroll Behavior
    public static string OverscrollAuto { get; } = $".{nameof(OverscrollAuto)}{{overscroll-behavior:auto;}}";
    public static string OverscrollContain { get; } = $".{nameof(OverscrollContain)}{{overscroll-behavior:contain;}}";
    public static string OverscrollNone { get; } = $".{nameof(OverscrollNone)}{{overscroll-behavior:none;}}";

    public static string OverscrollXAuto { get; } = $".{nameof(OverscrollXAuto)}{{overscroll-behavior-x:auto;}}";
    public static string OverscrollXContain { get; } = $".{nameof(OverscrollXContain)}{{overscroll-behavior-x:contain;}}";
    public static string OverscrollXNone { get; } = $".{nameof(OverscrollXNone)}{{overscroll-behavior-x:none;}}";

    public static string OverscrollYAuto { get; } = $".{nameof(OverscrollYAuto)}{{overscroll-behavior-y:auto;}}";
    public static string OverscrollYContain { get; } = $".{nameof(OverscrollYContain)}{{overscroll-behavior-y:contain;}}";
    public static string OverscrollYNone { get; } = $".{nameof(OverscrollYNone)}{{overscroll-behavior-y:none;}}";

    // Position
    public static string PositionStatic { get; } = $".{nameof(PositionStatic)}{{position:static;}}";
    public static string PositionFixed { get; } = $".{nameof(PositionFixed)}{{position:fixed;}}";
    public static string PositionAbsolute { get; } = $".{nameof(PositionAbsolute)}{{position:absolute;}}";
    public static string PositionRelative { get; } = $".{nameof(PositionRelative)}{{position:relative;}}";
    public static string PositionSticky { get; } = $".{nameof(PositionSticky)}{{position:sticky;}}";


    // Top, Right, Bottom, Left
    public static string Top0 { get; } = $".{nameof(Top0)}{{top:0px;}}";
    public static string Right0 { get; } = $".{nameof(Right0)}{{right:0px;}}";
    public static string Bottom0 { get; } = $".{nameof(Bottom0)}{{bottom:0px;}}";
    public static string Left0 { get; } = $".{nameof(Left0)}{{left:0px;}}";
    public static string Start0 { get; } = $".{nameof(Start0)}{{inset-inline-start:0px;}}";
    public static string End0 { get; } = $".{nameof(End0)}{{inset-inline-end:0px;}}";
    public static string Inset0 { get; } = $".{nameof(Inset0)}{{inset:0px;}}";

    public static string Top1 { get; } = $".{nameof(Top1)}{{top:1px;}}";
    public static string Right1 { get; } = $".{nameof(Right1)}{{right:1px;}}";
    public static string Bottom1 { get; } = $".{nameof(Bottom1)}{{bottom:1px;}}";
    public static string Left1 { get; } = $".{nameof(Left1)}{{left:1px;}}";
    public static string Start1 { get; } = $".{nameof(Start1)}{{inset-inline-start:1px;}}";
    public static string End1 { get; } = $".{nameof(End1)}{{inset-inline-end:1px;}}";
    public static string Inset1 { get; } = $".{nameof(Inset1)}{{inset:1px;}}";

    public static string Top2 { get; } = $".{nameof(Top2)}{{top:2px;}}";
    public static string Right2 { get; } = $".{nameof(Right2)}{{right:2px;}}";
    public static string Bottom2 { get; } = $".{nameof(Bottom2)}{{bottom:2px;}}";
    public static string Left2 { get; } = $".{nameof(Left2)}{{left:2px;}}";
    public static string Start2 { get; } = $".{nameof(Start2)}{{inset-inline-start:2px;}}";
    public static string End2 { get; } = $".{nameof(End2)}{{inset-inline-end:2px;}}";
    public static string Inset2 { get; } = $".{nameof(Inset2)}{{inset:2px;}}";

    public static string Top4 { get; } = $".{nameof(Top4)}{{top:4px;}}";
    public static string Right4 { get; } = $".{nameof(Right4)}{{right:4px;}}";
    public static string Bottom4 { get; } = $".{nameof(Bottom4)}{{bottom:4px;}}";
    public static string Left4 { get; } = $".{nameof(Left4)}{{left:4px;}}";
    public static string Start4 { get; } = $".{nameof(Start4)}{{inset-inline-start:4px;}}";
    public static string End4 { get; } = $".{nameof(End4)}{{inset-inline-end:4px;}}";
    public static string Inset4 { get; } = $".{nameof(Inset4)}{{inset:4px;}}";

    public static string Top8 { get; } = $".{nameof(Top8)}{{top:8px;}}";
    public static string Right8 { get; } = $".{nameof(Right8)}{{right:8px;}}";
    public static string Bottom8 { get; } = $".{nameof(Bottom8)}{{bottom:8px;}}";
    public static string Left8 { get; } = $".{nameof(Left8)}{{left:8px;}}";
    public static string Start8 { get; } = $".{nameof(Start8)}{{inset-inline-start:8px;}}";
    public static string End8 { get; } = $".{nameof(End8)}{{inset-inline-end:8px;}}";
    public static string Inset8 { get; } = $".{nameof(Inset8)}{{inset:8px;}}";

    public static string Top16 { get; } = $".{nameof(Top16)}{{top:16px;}}";
    public static string Right16 { get; } = $".{nameof(Right16)}{{right:16px;}}";
    public static string Bottom16 { get; } = $".{nameof(Bottom16)}{{bottom:16px;}}";
    public static string Left16 { get; } = $".{nameof(Left16)}{{left:16px;}}";
    public static string Start16 { get; } = $".{nameof(Start16)}{{inset-inline-start:16px;}}";
    public static string End16 { get; } = $".{nameof(End16)}{{inset-inline-end:16px;}}";
    public static string Inset16 { get; } = $".{nameof(Inset16)}{{inset:16px;}}";

    public static string Top32 { get; } = $".{nameof(Top32)}{{top:32px;}}";
    public static string Right32 { get; } = $".{nameof(Right32)}{{right:32px;}}";
    public static string Bottom32 { get; } = $".{nameof(Bottom32)}{{bottom:32px;}}";
    public static string Left32 { get; } = $".{nameof(Left32)}{{left:32px;}}";
    public static string Start32 { get; } = $".{nameof(Start32)}{{inset-inline-start:32px;}}";
    public static string End32 { get; } = $".{nameof(End32)}{{inset-inline-end:32px;}}";
    public static string Inset32 { get; } = $".{nameof(Inset32)}{{inset:32px;}}";

    // Visibility
    public static string VisibilityVisible { get; } = $".{nameof(VisibilityVisible)}{{visibility:visible;}}";
    public static string VisibilityHidden { get; } = $".{nameof(VisibilityHidden)}{{visibility:hidden;}}";
    public static string VisibilityCollapse { get; } = $".{nameof(VisibilityCollapse)}{{visibility:collapse;}}";

    // Z Index
    public static string Z0 { get; } = $".{nameof(Z0)}{{z-index:0;}}";
    public static string Z10 { get; } = $".{nameof(Z10)}{{z-index:10;}}";
    public static string Z20 { get; } = $".{nameof(Z20)}{{z-index:20;}}";
    public static string Z30 { get; } = $".{nameof(Z30)}{{z-index:30;}}";
    public static string Z40 { get; } = $".{nameof(Z40)}{{z-index:40;}}";
    public static string Z50 { get; } = $".{nameof(Z50)}{{z-index:50;}}";

    // Part 2: Flexbox & Grid

    // Flex Direction
    public static string FlexRow { get; } = $".{nameof(FlexRow)}{{flex-direction:row;}}";
    public static string FlexRowReverse { get; } = $".{nameof(FlexRowReverse)}{{flex-direction:row-reverse;}}";
    public static string FlexCol { get; } = $".{nameof(FlexCol)}{{flex-direction:column;}}";
    public static string FlexColReverse { get; } = $".{nameof(FlexColReverse)}{{flex-direction:column-reverse;}}";

    // Flex Wrap
    public static string FlexWrap { get; } = $".{nameof(FlexWrap)}{{flex-wrap:wrap;}}";
    public static string FlexWrapReverse { get; } = $".{nameof(FlexWrapReverse)}{{flex-wrap:wrap-reverse;}}";
    public static string FlexNoWrap { get; } = $".{nameof(FlexNoWrap)}{{flex-wrap:nowrap;}}";

    // Flex
    public static string Flex1 { get; } = $".{nameof(Flex1)}{{flex:1 1 0%;}}";
    public static string FlexAuto { get; } = $".{nameof(FlexAuto)}{{flex:1 1 auto;}}";
    public static string FlexInitial { get; } = $".{nameof(FlexInitial)}{{flex:0 1 auto;}}";
    public static string FlexNone { get; } = $".{nameof(FlexNone)}{{flex:none;}}";

    // Flex Grow
    public static string FlexGrow { get; } = $".{nameof(FlexGrow)}{{flex-grow:1;}}";
    public static string FlexGrow0 { get; } = $".{nameof(FlexGrow0)}{{flex-grow:0;}}";

    // Flex Shrink
    public static string FlexShrink { get; } = $".{nameof(FlexShrink)}{{flex-shrink:1;}}";
    public static string FlexShrink0 { get; } = $".{nameof(FlexShrink0)}{{flex-shrink:0;}}";

    // Grid Cols
    public static string GridCols1 { get; } = $".{nameof(GridCols1)}{{grid-template-columns:repeat(1, minmax(0, 1fr));}}";
    public static string GridCols2 { get; } = $".{nameof(GridCols2)}{{grid-template-columns:repeat(2, minmax(0, 1fr));}}";
    public static string GridCols3 { get; } = $".{nameof(GridCols3)}{{grid-template-columns:repeat(3, minmax(0, 1fr));}}";
    public static string GridCols4 { get; } = $".{nameof(GridCols4)}{{grid-template-columns:repeat(4, minmax(0, 1fr));}}";
    public static string GridCols5 { get; } = $".{nameof(GridCols5)}{{grid-template-columns:repeat(5, minmax(0, 1fr));}}";
    public static string GridCols6 { get; } = $".{nameof(GridCols6)}{{grid-template-columns:repeat(6, minmax(0, 1fr));}}";
    public static string GridCols7 { get; } = $".{nameof(GridCols7)}{{grid-template-columns:repeat(7, minmax(0, 1fr));}}";
    public static string GridCols8 { get; } = $".{nameof(GridCols8)}{{grid-template-columns:repeat(8, minmax(0, 1fr));}}";
    public static string GridCols9 { get; } = $".{nameof(GridCols9)}{{grid-template-columns:repeat(9, minmax(0, 1fr));}}";
    public static string GridCols10 { get; } = $".{nameof(GridCols10)}{{grid-template-columns:repeat(10, minmax(0, 1fr));}}";
    public static string GridCols11 { get; } = $".{nameof(GridCols11)}{{grid-template-columns:repeat(11, minmax(0, 1fr));}}";
    public static string GridCols12 { get; } = $".{nameof(GridCols12)}{{grid-template-columns:repeat(12, minmax(0, 1fr));}}";
    public static string GridColsNone { get; } = $".{nameof(GridColsNone)}{{grid-template-columns:none;}}";
    public static string GridColsSubgrid { get; } = $".{nameof(GridColsSubgrid)}{{grid-template-columns:subgrid;}}";


    public static string ColAuto { get; } = $".{nameof(ColAuto)}{{grid-column:auto;}}";
    public static string ColSpan1 { get; } = $".{nameof(ColSpan1)}{{grid-column:span 1 / span 1;}}";
    public static string ColSpan2 { get; } = $".{nameof(ColSpan2)}{{grid-column:span 2 / span 2;}}";
    public static string ColSpan3 { get; } = $".{nameof(ColSpan3)}{{grid-column:span 3 / span 3;}}";
    public static string ColSpan4 { get; } = $".{nameof(ColSpan4)}{{grid-column:span 4 / span 4;}}";
    public static string ColSpan5 { get; } = $".{nameof(ColSpan5)}{{grid-column:span 5 / span 5;}}";
    public static string ColSpan6 { get; } = $".{nameof(ColSpan6)}{{grid-column:span 6 / span 6;}}";
    public static string ColSpan7 { get; } = $".{nameof(ColSpan7)}{{grid-column:span 7 / span 7;}}";
    public static string ColSpan8 { get; } = $".{nameof(ColSpan8)}{{grid-column:span 8 / span 8;}}";
    public static string ColSpan9 { get; } = $".{nameof(ColSpan9)}{{grid-column:span 9 / span 9;}}";
    public static string ColSpan10 { get; } = $".{nameof(ColSpan10)}{{grid-column:span 10 / span 10;}}";
    public static string ColSpan11 { get; } = $".{nameof(ColSpan11)}{{grid-column:span 11 / span 11;}}";
    public static string ColSpan12 { get; } = $".{nameof(ColSpan12)}{{grid-column:span 12 / span 12;}}";
    public static string ColSpanFull { get; } = $".{nameof(ColSpanFull)}{{grid-column:1 / -1;}}";


    public static string GridRows1 { get; } = $".{nameof(GridRows1)}{{grid-template-rows:repeat(1, minmax(0, 1fr));}}";
    public static string GridRows2 { get; } = $".{nameof(GridRows2)}{{grid-template-rows:repeat(2, minmax(0, 1fr));}}";
    public static string GridRows3 { get; } = $".{nameof(GridRows3)}{{grid-template-rows:repeat(3, minmax(0, 1fr));}}";
    public static string GridRows4 { get; } = $".{nameof(GridRows4)}{{grid-template-rows:repeat(4, minmax(0, 1fr));}}";
    public static string GridRows5 { get; } = $".{nameof(GridRows5)}{{grid-template-rows:repeat(5, minmax(0, 1fr));}}";
    public static string GridRows6 { get; } = $".{nameof(GridRows6)}{{grid-template-rows:repeat(6, minmax(0, 1fr));}}";
    public static string GridRows7 { get; } = $".{nameof(GridRows7)}{{grid-template-rows:repeat(7, minmax(0, 1fr));}}";
    public static string GridRows8 { get; } = $".{nameof(GridRows8)}{{grid-template-rows:repeat(8, minmax(0, 1fr));}}";
    public static string GridRows9 { get; } = $".{nameof(GridRows9)}{{grid-template-rows:repeat(9, minmax(0, 1fr));}}";
    public static string GridRows10 { get; } = $".{nameof(GridRows10)}{{grid-template-rows:repeat(10, minmax(0, 1fr));}}";
    public static string GridRows11 { get; } = $".{nameof(GridRows11)}{{grid-template-rows:repeat(11, minmax(0, 1fr));}}";
    public static string GridRows12 { get; } = $".{nameof(GridRows12)}{{grid-template-rows:repeat(12, minmax(0, 1fr));}}";
    public static string GridRowsNone { get; } = $".{nameof(GridRowsNone)}{{grid-template-rows:none;}}";
    public static string GridRowsSubgrid { get; } = $".{nameof(GridRowsSubgrid)}{{grid-template-rows:subgrid;}}";


    public static string RowAuto { get; } = $".{nameof(RowAuto)}{{grid-row:auto;}}";
    public static string RowSpan1 { get; } = $".{nameof(RowSpan1)}{{grid-row:span 1 / span 1;}}";
    public static string RowSpan2 { get; } = $".{nameof(RowSpan2)}{{grid-row:span 2 / span 2;}}";
    public static string RowSpan3 { get; } = $".{nameof(RowSpan3)}{{grid-row:span 3 / span 3;}}";
    public static string RowSpan4 { get; } = $".{nameof(RowSpan4)}{{grid-row:span 4 / span 4;}}";
    public static string RowSpan5 { get; } = $".{nameof(RowSpan5)}{{grid-row:span 5 / span 5;}}";
    public static string RowSpan6 { get; } = $".{nameof(RowSpan6)}{{grid-row:span 6 / span 6;}}";
    public static string RowSpan7 { get; } = $".{nameof(RowSpan7)}{{grid-row:span 7 / span 7;}}";
    public static string RowSpan8 { get; } = $".{nameof(RowSpan8)}{{grid-row:span 8 / span 8;}}";
    public static string RowSpan9 { get; } = $".{nameof(RowSpan9)}{{grid-row:span 9 / span 9;}}";
    public static string RowSpan10 { get; } = $".{nameof(RowSpan10)}{{grid-row:span 10 / span 10;}}";
    public static string RowSpan11 { get; } = $".{nameof(RowSpan11)}{{grid-row:span 11 / span 11;}}";
    public static string RowSpan12 { get; } = $".{nameof(RowSpan12)}{{grid-row:span 12 / span 12;}}";
    public static string RowSpanFull { get; } = $".{nameof(RowSpanFull)}{{grid-row:1 / -1;}}";

    public static string GridFlowRow { get; } = $".{nameof(GridFlowRow)}{{grid-auto-flow:row;}}";
    public static string GridFlowCol { get; } = $".{nameof(GridFlowCol)}{{grid-auto-flow:column;}}";
    public static string GridFlowDense { get; } = $".{nameof(GridFlowDense)}{{grid-auto-flow:dense;}}";
    public static string GridFlowRowDense { get; } = $".{nameof(GridFlowRowDense)}{{grid-auto-flow:row dense;}}";
    public static string GridFlowColDense { get; } = $".{nameof(GridFlowColDense)}{{grid-auto-flow:column dense;}}";

    public static string AutoColsAuto { get; } = $".{nameof(AutoColsAuto)}{{grid-auto-columns:auto;}}";
    public static string AutoColsMin { get; } = $".{nameof(AutoColsMin)}{{grid-auto-columns:min-content;}}";
    public static string AutoColsMax { get; } = $".{nameof(AutoColsMax)}{{grid-auto-columns:max-content;}}";
    public static string AutoColsFr { get; } = $".{nameof(AutoColsFr)}{{grid-auto-columns:minmax(0, 1fr);}}";

    public static string AutoRowsAuto { get; } = $".{nameof(AutoRowsAuto)}{{grid-auto-rows:auto;}}";
    public static string AutoRowsMin { get; } = $".{nameof(AutoRowsMin)}{{grid-auto-rows:min-content;}}";
    public static string AutoRowsMax { get; } = $".{nameof(AutoRowsMax)}{{grid-auto-rows:max-content;}}";
    public static string AutoRowsFr { get; } = $".{nameof(AutoRowsFr)}{{grid-auto-rows:minmax(0, 1fr);}}";

    public static string Gap0 { get; } = $".{nameof(Gap0)}{{gap:0px;}}";
    public static string GapPx { get; } = $".{nameof(GapPx)}{{gap:1px;}}";
    public static string Gap1 { get; } = $".{nameof(Gap1)}{{gap:0.25rem;}}";
    public static string Gap2 { get; } = $".{nameof(Gap2)}{{gap:0.5rem;}}";
    public static string Gap4 { get; } = $".{nameof(Gap4)}{{gap:1rem;}}";
    public static string Gap8 { get; } = $".{nameof(Gap8)}{{gap:2rem;}}";
    public static string Gap16 { get; } = $".{nameof(Gap16)}{{gap:4rem;}}";
    public static string Gap32 { get; } = $".{nameof(Gap32)}{{gap:8rem;}}";

    public static string JustifyNormal { get; } = $".{nameof(JustifyNormal)}{{justify-content:normal;}}";
    public static string JustifyStart { get; } = $".{nameof(JustifyStart)}{{justify-content:flex-start;}}";
    public static string JustifyEnd { get; } = $".{nameof(JustifyEnd)}{{justify-content:flex-end;}}";
    public static string JustifyCenter { get; } = $".{nameof(JustifyCenter)}{{justify-content:center;}}";
    public static string JustifyBetween { get; } = $".{nameof(JustifyBetween)}{{justify-content:space-between;}}";
    public static string JustifyAround { get; } = $".{nameof(JustifyAround)}{{justify-content:space-around;}}";
    public static string JustifyEvenly { get; } = $".{nameof(JustifyEvenly)}{{justify-content:space-evenly;}}";
    public static string JustifyStretch { get; } = $".{nameof(JustifyStretch)}{{justify-content:stretch;}}";

    public static string JustifyItemsStart { get; } = $".{nameof(JustifyItemsStart)}{{justify-items:start;}}";
    public static string JustifyItemsEnd { get; } = $".{nameof(JustifyItemsEnd)}{{justify-items:end;}}";
    public static string JustifyItemsCenter { get; } = $".{nameof(JustifyItemsCenter)}{{justify-items:center;}}";
    public static string JustifyItemsStretch { get; } = $".{nameof(JustifyItemsStretch)}{{justify-items:stretch;}}";

    public static string JustifySelfAuto { get; } = $".{nameof(JustifySelfAuto)}{{justify-self:auto;}}";
    public static string JustifySelfStart { get; } = $".{nameof(JustifySelfStart)}{{justify-self:start;}}";
    public static string JustifySelfEnd { get; } = $".{nameof(JustifySelfEnd)}{{justify-self:end;}}";
    public static string JustifySelfCenter { get; } = $".{nameof(JustifySelfCenter)}{{justify-self:center;}}";
    public static string JustifySelfStretch { get; } = $".{nameof(JustifySelfStretch)}{{justify-self:stretch;}}";

    public static string ContentNormal { get; } = $".{nameof(ContentNormal)}{{align-content:normal;}}";
    public static string ContentStart { get; } = $".{nameof(ContentStart)}{{align-content:flex-start;}}";
    public static string ContentEnd { get; } = $".{nameof(ContentEnd)}{{align-content:flex-end;}}";
    public static string ContentCenter { get; } = $".{nameof(ContentCenter)}{{align-content:center;}}";
    public static string ContentBetween { get; } = $".{nameof(ContentBetween)}{{align-content:space-between;}}";
    public static string ContentAround { get; } = $".{nameof(ContentAround)}{{align-content:space-around;}}";
    public static string ContentEvenly { get; } = $".{nameof(ContentEvenly)}{{align-content:space-evenly;}}";
    public static string ContentBaseline { get; } = $".{nameof(ContentBaseline)}{{align-content:baseline;}}";
    public static string ContentStretch { get; } = $".{nameof(ContentStretch)}{{align-content:stretch;}}";

    public static string ItemsStart { get; } = $".{nameof(ItemsStart)}{{align-items:flex-start;}}";
    public static string ItemsEnd { get; } = $".{nameof(ItemsEnd)}{{align-items:flex-end;}}";
    public static string ItemsCenter { get; } = $".{nameof(ItemsCenter)}{{align-items:center;}}";
    public static string ItemsBaseline { get; } = $".{nameof(ItemsBaseline)}{{align-items:baseline;}}";
    public static string ItemsStretch { get; } = $".{nameof(ItemsStretch)}{{align-items:stretch;}}";

    public static string SelfAuto { get; } = $".{nameof(SelfAuto)}{{align-self:auto;}}";
    public static string SelfStart { get; } = $".{nameof(SelfStart)}{{align-self:flex-start;}}";
    public static string SelfEnd { get; } = $".{nameof(SelfEnd)}{{align-self:flex-end;}}";
    public static string SelfCenter { get; } = $".{nameof(SelfCenter)}{{align-self:center;}}";
    public static string SelfBaseline { get; } = $".{nameof(SelfBaseline)}{{align-self:baseline;}}";
    public static string SelfStretch { get; } = $".{nameof(SelfStretch)}{{align-self:stretch;}}";

    public static string PlaceContentStart { get; } = $".{nameof(PlaceContentStart)}{{place-content:start;}}";
    public static string PlaceContentEnd { get; } = $".{nameof(PlaceContentEnd)}{{place-content:end;}}";
    public static string PlaceContentCenter { get; } = $".{nameof(PlaceContentCenter)}{{place-content:center;}}";
    public static string PlaceContentBetween { get; } = $".{nameof(PlaceContentBetween)}{{place-content:space-between;}}";
    public static string PlaceContentAround { get; } = $".{nameof(PlaceContentAround)}{{place-content:space-around;}}";
    public static string PlaceContentEvenly { get; } = $".{nameof(PlaceContentEvenly)}{{place-content:space-evenly;}}";
    public static string PlaceContentStretch { get; } = $".{nameof(PlaceContentStretch)}{{place-content:stretch;}}";

    public static string PlaceItemsStart { get; } = $".{nameof(PlaceItemsStart)}{{place-items:start;}}";
    public static string PlaceItemsEnd { get; } = $".{nameof(PlaceItemsEnd)}{{place-items:end;}}";
    public static string PlaceItemsCenter { get; } = $".{nameof(PlaceItemsCenter)}{{place-items:center;}}";
    public static string PlaceItemsStretch { get; } = $".{nameof(PlaceItemsStretch)}{{place-items:stretch;}}";

    public static string PlaceSelfAuto { get; } = $".{nameof(PlaceSelfAuto)}{{place-self:auto;}}";
    public static string PlaceSelfStart { get; } = $".{nameof(PlaceSelfStart)}{{place-self:start;}}";
    public static string PlaceSelfEnd { get; } = $".{nameof(PlaceSelfEnd)}{{place-self:end;}}";
    public static string PlaceSelfCenter { get; } = $".{nameof(PlaceSelfCenter)}{{place-self:center;}}";
    public static string PlaceSelfStretch { get; } = $".{nameof(PlaceSelfStretch)}{{place-self:stretch;}}";


    // Part 3: Spacing
    public static string P0 { get; } = $".{nameof(P0)}{{{MWSpace.Padding}:{MWSpace.S0};}}";
    public static string P1 { get; } = $".{nameof(P1)}{{{MWSpace.Padding}:{MWSpace.S1};}}";
    public static string P2 { get; } = $".{nameof(P2)}{{{MWSpace.Padding}:{MWSpace.S2};}}";
    public static string P4 { get; } = $".{nameof(P4)}{{{MWSpace.Padding}:{MWSpace.S4};}}";
    public static string P8 { get; } = $".{nameof(P8)}{{{MWSpace.Padding}:{MWSpace.S8};}}";
    public static string P16 { get; } = $".{nameof(P16)}{{{MWSpace.Padding}:{MWSpace.S16};}}";
    public static string P32 { get; } = $".{nameof(P32)}{{{MWSpace.Padding}:{MWSpace.S32};}}";
    public static string PPx { get; } = $".{nameof(PPx)}{{{MWSpace.Padding}:{MWSpace.SPx};}}";

    public static string PT0 { get; } = $".{nameof(PT0)}{{{MWSpace.PaddingTop}:{MWSpace.S0};}}";
    public static string PT1 { get; } = $".{nameof(PT1)}{{{MWSpace.PaddingTop}:{MWSpace.S1};}}";
    public static string PT2 { get; } = $".{nameof(PT2)}{{{MWSpace.PaddingTop}:{MWSpace.S2};}}";
    public static string PT4 { get; } = $".{nameof(PT4)}{{{MWSpace.PaddingTop}:{MWSpace.S4};}}";
    public static string PT8 { get; } = $".{nameof(PT8)}{{{MWSpace.PaddingTop}:{MWSpace.S8};}}";
    public static string PT16 { get; } = $".{nameof(PT16)}{{{MWSpace.PaddingTop}:{MWSpace.S16};}}";
    public static string PT32 { get; } = $".{nameof(PT32)}{{{MWSpace.PaddingTop}:{MWSpace.S32};}}";
    public static string PTPx { get; } = $".{nameof(PTPx)}{{{MWSpace.PaddingTop}:{MWSpace.SPx};}}";

    public static string PR0 { get; } = $".{nameof(PR0)}{{{MWSpace.PaddingRight}:{MWSpace.S0};}}";
    public static string PR1 { get; } = $".{nameof(PR1)}{{{MWSpace.PaddingRight}:{MWSpace.S1};}}";
    public static string PR2 { get; } = $".{nameof(PR2)}{{{MWSpace.PaddingRight}:{MWSpace.S2};}}";
    public static string PR4 { get; } = $".{nameof(PR4)}{{{MWSpace.PaddingRight}:{MWSpace.S4};}}";
    public static string PR8 { get; } = $".{nameof(PR8)}{{{MWSpace.PaddingRight}:{MWSpace.S8};}}";
    public static string PR16 { get; } = $".{nameof(PR16)}{{{MWSpace.PaddingRight}:{MWSpace.S16};}}";
    public static string PR32 { get; } = $".{nameof(PR32)}{{{MWSpace.PaddingRight}:{MWSpace.S32};}}";
    public static string PRPx { get; } = $".{nameof(PRPx)}{{{MWSpace.PaddingRight}:{MWSpace.SPx};}}";

    public static string PB0 { get; } = $".{nameof(PB0)}{{{MWSpace.PaddingBottom}:{MWSpace.S0};}}";
    public static string PB1 { get; } = $".{nameof(PB1)}{{{MWSpace.PaddingBottom}:{MWSpace.S1};}}";
    public static string PB2 { get; } = $".{nameof(PB2)}{{{MWSpace.PaddingBottom}:{MWSpace.S2};}}";
    public static string PB4 { get; } = $".{nameof(PB4)}{{{MWSpace.PaddingBottom}:{MWSpace.S4};}}";
    public static string PB8 { get; } = $".{nameof(PB8)}{{{MWSpace.PaddingBottom}:{MWSpace.S8};}}";
    public static string PB16 { get; } = $".{nameof(PB16)}{{{MWSpace.PaddingBottom}:{MWSpace.S16};}}";
    public static string PB32 { get; } = $".{nameof(PB32)}{{{MWSpace.PaddingBottom}:{MWSpace.S32};}}";
    public static string PBPx { get; } = $".{nameof(PBPx)}{{{MWSpace.PaddingBottom}:{MWSpace.SPx};}}";

    public static string PL0 { get; } = $".{nameof(PL0)}{{{MWSpace.PaddingLeft}:{MWSpace.S0};}}";
    public static string PL1 { get; } = $".{nameof(PL1)}{{{MWSpace.PaddingLeft}:{MWSpace.S1};}}";
    public static string PL2 { get; } = $".{nameof(PL2)}{{{MWSpace.PaddingLeft}:{MWSpace.S2};}}";
    public static string PL4 { get; } = $".{nameof(PL4)}{{{MWSpace.PaddingLeft}:{MWSpace.S4};}}";
    public static string PL8 { get; } = $".{nameof(PL8)}{{{MWSpace.PaddingLeft}:{MWSpace.S8};}}";
    public static string PL16 { get; } = $".{nameof(PL16)}{{{MWSpace.PaddingLeft}:{MWSpace.S16};}}";
    public static string PL32 { get; } = $".{nameof(PL32)}{{{MWSpace.PaddingLeft}:{MWSpace.S32};}}";
    public static string PLPx { get; } = $".{nameof(PLPx)}{{{MWSpace.PaddingLeft}:{MWSpace.SPx};}}";

    public static string PX0 { get; } = $".{nameof(PX0)}{{{MWSpace.PaddingLeft}:{MWSpace.S0};{MWSpace.PaddingRight}:{MWSpace.S0};}}";
    public static string PX1 { get; } = $".{nameof(PX1)}{{{MWSpace.PaddingLeft}:{MWSpace.S1};{MWSpace.PaddingRight}:{MWSpace.S1};}}";
    public static string PX2 { get; } = $".{nameof(PX2)}{{{MWSpace.PaddingLeft}:{MWSpace.S2};{MWSpace.PaddingRight}:{MWSpace.S2};}}";
    public static string PX4 { get; } = $".{nameof(PX4)}{{{MWSpace.PaddingLeft}:{MWSpace.S4};{MWSpace.PaddingRight}:{MWSpace.S4};}}";
    public static string PX8 { get; } = $".{nameof(PX8)}{{{MWSpace.PaddingLeft}:{MWSpace.S8};{MWSpace.PaddingRight}:{MWSpace.S8};}}";
    public static string PX16 { get; } = $".{nameof(PX16)}{{{MWSpace.PaddingLeft}:{MWSpace.S16};{MWSpace.PaddingRight}:{MWSpace.S16};}}";
    public static string PX32 { get; } = $".{nameof(PX32)}{{{MWSpace.PaddingLeft}:{MWSpace.S32};{MWSpace.PaddingRight}:{MWSpace.S32};}}";
    public static string PXPx { get; } = $".{nameof(PXPx)}{{{MWSpace.PaddingLeft}:{MWSpace.SPx};{MWSpace.PaddingRight}:{MWSpace.SPx};}}";

    public static string PY0 { get; } = $".{nameof(PY0)}{{{MWSpace.PaddingTop}:{MWSpace.S0};{MWSpace.PaddingBottom}:{MWSpace.S0};}}";
    public static string PY1 { get; } = $".{nameof(PY1)}{{{MWSpace.PaddingTop}:{MWSpace.S1};{MWSpace.PaddingBottom}:{MWSpace.S1};}}";
    public static string PY2 { get; } = $".{nameof(PY2)}{{{MWSpace.PaddingTop}:{MWSpace.S2};{MWSpace.PaddingBottom}:{MWSpace.S2};}}";
    public static string PY4 { get; } = $".{nameof(PY4)}{{{MWSpace.PaddingTop}:{MWSpace.S4};{MWSpace.PaddingBottom}:{MWSpace.S4};}}";
    public static string PY8 { get; } = $".{nameof(PY8)}{{{MWSpace.PaddingTop}:{MWSpace.S8};{MWSpace.PaddingBottom}:{MWSpace.S8};}}";
    public static string PY16 { get; } = $".{nameof(PY16)}{{{MWSpace.PaddingTop}:{MWSpace.S16};{MWSpace.PaddingBottom}:{MWSpace.S16};}}";
    public static string PY32 { get; } = $".{nameof(PY32)}{{{MWSpace.PaddingTop}:{MWSpace.S32};{MWSpace.PaddingBottom}:{MWSpace.S32};}}";
    public static string PYPx { get; } = $".{nameof(PYPx)}{{{MWSpace.PaddingTop}:{MWSpace.SPx};{MWSpace.PaddingBottom}:{MWSpace.SPx};}}";


    public static string M0 { get; } = $".{nameof(M0)}{{{MWSpace.Margin}:{MWSpace.S0};}}";
    public static string M1 { get; } = $".{nameof(M1)}{{{MWSpace.Margin}:{MWSpace.S1};}}";
    public static string M2 { get; } = $".{nameof(M2)}{{{MWSpace.Margin}:{MWSpace.S2};}}";
    public static string M4 { get; } = $".{nameof(M4)}{{{MWSpace.Margin}:{MWSpace.S4};}}";
    public static string M8 { get; } = $".{nameof(M8)}{{{MWSpace.Margin}:{MWSpace.S8};}}";
    public static string M16 { get; } = $".{nameof(M16)}{{{MWSpace.Margin}:{MWSpace.S16};}}";
    public static string M32 { get; } = $".{nameof(M32)}{{{MWSpace.Margin}:{MWSpace.S32};}}";
    public static string MPx { get; } = $".{nameof(MPx)}{{{MWSpace.Margin}:{MWSpace.SPx};}}";

    public static string MT0 { get; } = $".{nameof(MT0)}{{{MWSpace.MarginTop}:{MWSpace.S0};}}";
    public static string MT1 { get; } = $".{nameof(MT1)}{{{MWSpace.MarginTop}:{MWSpace.S1};}}";
    public static string MT2 { get; } = $".{nameof(MT2)}{{{MWSpace.MarginTop}:{MWSpace.S2};}}";
    public static string MT4 { get; } = $".{nameof(MT4)}{{{MWSpace.MarginTop}:{MWSpace.S4};}}";
    public static string MT8 { get; } = $".{nameof(MT8)}{{{MWSpace.MarginTop}:{MWSpace.S8};}}";
    public static string MT16 { get; } = $".{nameof(MT16)}{{{MWSpace.MarginTop}:{MWSpace.S16};}}";
    public static string MT32 { get; } = $".{nameof(MT32)}{{{MWSpace.MarginTop}:{MWSpace.S32};}}";
    public static string MTPx { get; } = $".{nameof(MTPx)}{{{MWSpace.MarginTop}:{MWSpace.SPx};}}";

    public static string MR0 { get; } = $".{nameof(MR0)}{{{MWSpace.MarginRight}:{MWSpace.S0};}}";
    public static string MR1 { get; } = $".{nameof(MR1)}{{{MWSpace.MarginRight}:{MWSpace.S1};}}";
    public static string MR2 { get; } = $".{nameof(MR2)}{{{MWSpace.MarginRight}:{MWSpace.S2};}}";
    public static string MR4 { get; } = $".{nameof(MR4)}{{{MWSpace.MarginRight}:{MWSpace.S4};}}";
    public static string MR8 { get; } = $".{nameof(MR8)}{{{MWSpace.MarginRight}:{MWSpace.S8};}}";
    public static string MR16 { get; } = $".{nameof(MR16)}{{{MWSpace.MarginRight}:{MWSpace.S16};}}";
    public static string MR32 { get; } = $".{nameof(MR32)}{{{MWSpace.MarginRight}:{MWSpace.S32};}}";
    public static string MRPx { get; } = $".{nameof(MRPx)}{{{MWSpace.MarginRight}:{MWSpace.SPx};}}";

    public static string MB0 { get; } = $".{nameof(MB0)}{{{MWSpace.MarginBottom}:{MWSpace.S0};}}";
    public static string MB1 { get; } = $".{nameof(MB1)}{{{MWSpace.MarginBottom}:{MWSpace.S1};}}";
    public static string MB2 { get; } = $".{nameof(MB2)}{{{MWSpace.MarginBottom}:{MWSpace.S2};}}";
    public static string MB4 { get; } = $".{nameof(MB4)}{{{MWSpace.MarginBottom}:{MWSpace.S4};}}";
    public static string MB8 { get; } = $".{nameof(MB8)}{{{MWSpace.MarginBottom}:{MWSpace.S8};}}";
    public static string MB16 { get; } = $".{nameof(MB16)}{{{MWSpace.MarginBottom}:{MWSpace.S16};}}";
    public static string MB32 { get; } = $".{nameof(MB32)}{{{MWSpace.MarginBottom}:{MWSpace.S32};}}";
    public static string MBPx { get; } = $".{nameof(MBPx)}{{{MWSpace.MarginBottom}:{MWSpace.SPx};}}";

    public static string ML0 { get; } = $".{nameof(ML0)}{{{MWSpace.MarginLeft}:{MWSpace.S0};}}";
    public static string ML1 { get; } = $".{nameof(ML1)}{{{MWSpace.MarginLeft}:{MWSpace.S1};}}";
    public static string ML2 { get; } = $".{nameof(ML2)}{{{MWSpace.MarginLeft}:{MWSpace.S2};}}";
    public static string ML4 { get; } = $".{nameof(ML4)}{{{MWSpace.MarginLeft}:{MWSpace.S4};}}";
    public static string ML8 { get; } = $".{nameof(ML8)}{{{MWSpace.MarginLeft}:{MWSpace.S8};}}";
    public static string ML16 { get; } = $".{nameof(ML16)}{{{MWSpace.MarginLeft}:{MWSpace.S16};}}";
    public static string ML32 { get; } = $".{nameof(ML32)}{{{MWSpace.MarginLeft}:{MWSpace.S32};}}";
    public static string MLPx { get; } = $".{nameof(MLPx)}{{{MWSpace.MarginLeft}:{MWSpace.SPx};}}";

    public static string MX0 { get; } = $".{nameof(MX0)}{{{MWSpace.MarginLeft}:{MWSpace.S0};{MWSpace.MarginRight}:{MWSpace.S0};}}";
    public static string MX1 { get; } = $".{nameof(MX1)}{{{MWSpace.MarginLeft}:{MWSpace.S1};{MWSpace.MarginRight}:{MWSpace.S1};}}";
    public static string MX2 { get; } = $".{nameof(MX2)}{{{MWSpace.MarginLeft}:{MWSpace.S2};{MWSpace.MarginRight}:{MWSpace.S2};}}";
    public static string MX4 { get; } = $".{nameof(MX4)}{{{MWSpace.MarginLeft}:{MWSpace.S4};{MWSpace.MarginRight}:{MWSpace.S4};}}";
    public static string MX8 { get; } = $".{nameof(MX8)}{{{MWSpace.MarginLeft}:{MWSpace.S8};{MWSpace.MarginRight}:{MWSpace.S8};}}";
    public static string MX16 { get; } = $".{nameof(MX16)}{{{MWSpace.MarginLeft}:{MWSpace.S16};{MWSpace.MarginRight}:{MWSpace.S16};}}";
    public static string MX32 { get; } = $".{nameof(MX32)}{{{MWSpace.MarginLeft}:{MWSpace.S32};{MWSpace.MarginRight}:{MWSpace.S32};}}";
    public static string MXPx { get; } = $".{nameof(MXPx)}{{{MWSpace.MarginLeft}:{MWSpace.SPx};{MWSpace.MarginRight}:{MWSpace.SPx};}}";

    public static string MY0 { get; } = $".{nameof(MY0)}{{{MWSpace.MarginTop}:{MWSpace.S0};{MWSpace.MarginBottom}:{MWSpace.S0};}}";
    public static string MY1 { get; } = $".{nameof(MY1)}{{{MWSpace.MarginTop}:{MWSpace.S1};{MWSpace.MarginBottom}:{MWSpace.S1};}}";
    public static string MY2 { get; } = $".{nameof(MY2)}{{{MWSpace.MarginTop}:{MWSpace.S2};{MWSpace.MarginBottom}:{MWSpace.S2};}}";
    public static string MY4 { get; } = $".{nameof(MY4)}{{{MWSpace.MarginTop}:{MWSpace.S4};{MWSpace.MarginBottom}:{MWSpace.S4};}}";
    public static string MY8 { get; } = $".{nameof(MY8)}{{{MWSpace.MarginTop}:{MWSpace.S8};{MWSpace.MarginBottom}:{MWSpace.S8};}}";
    public static string MY16 { get; } = $".{nameof(MY16)}{{{MWSpace.MarginTop}:{MWSpace.S16};{MWSpace.MarginBottom}:{MWSpace.S16};}}";
    public static string MY32 { get; } = $".{nameof(MY32)}{{{MWSpace.MarginTop}:{MWSpace.S32};{MWSpace.MarginBottom}:{MWSpace.S2};}}";
    public static string MYPx { get; } = $".{nameof(MYPx)}{{{MWSpace.MarginTop}:{MWSpace.SPx};{MWSpace.MarginBottom}:{MWSpace.SPx};}}";

    public static string W0 { get; } = $".{nameof(W0)}{{width:0px;}}";
    public static string WAuto { get; } = $".{nameof(WAuto)}{{width:auto;}}";
    public static string WPx { get; } = $".{nameof(WPx)}{{width:1px;}}";
    public static string WFull { get; } = $".{nameof(WFull)}{{width:100%;}}";
    public static string WScreen { get; } = $".{nameof(WScreen)}{{width:100vw;}}";
    public static string WMin { get; } = $".{nameof(WMin)}{{width:min-content;}}";
    public static string WMax { get; } = $".{nameof(WMax)}{{width:max-content;}}";
    public static string WFit { get; } = $".{nameof(WFit)}{{width:fit-content;}}";

    public static string MinW0 { get; } = $".{nameof(MinW0)}{{min-width:0px;}}";
    public static string MinWAuto { get; } = $".{nameof(MinWAuto)}{{min-width:auto;}}";
    public static string MinWPx { get; } = $".{nameof(MinWPx)}{{min-width:1px;}}";
    public static string MinWFull { get; } = $".{nameof(MinWFull)}{{min-width:100%;}}";
    public static string MinWScreen { get; } = $".{nameof(MinWScreen)}{{min-width:100vw;}}";
    public static string MinWMin { get; } = $".{nameof(MinWMin)}{{min-width:min-content;}}";
    public static string MinWMax { get; } = $".{nameof(MinWMax)}{{min-width:max-content;}}";
    public static string MinWFit { get; } = $".{nameof(MinWFit)}{{min-width:fit-content;}}";

    public static string MaxW0 { get; } = $".{nameof(MaxW0)}{{max-width:0px;}}";
    public static string MaxWAuto { get; } = $".{nameof(MaxWAuto)}{{max-width:auto;}}";
    public static string MaxWPx { get; } = $".{nameof(MaxWPx)}{{max-width:1px;}}";
    public static string MaxWFull { get; } = $".{nameof(MaxWFull)}{{max-width:100%;}}";
    public static string MaxWScreen { get; } = $".{nameof(MaxWScreen)}{{max-width:100vw;}}";
    public static string MaxWMin { get; } = $".{nameof(MaxWMin)}{{max-width:min-content;}}";
    public static string MaxWMax { get; } = $".{nameof(MaxWMax)}{{max-width:max-content;}}";
    public static string MaxWFit { get; } = $".{nameof(MaxWFit)}{{max-width:fit-content;}}";

    public static string H0 { get; } = $".{nameof(H0)}{{height:0px;}}";
    public static string HAuto { get; } = $".{nameof(HAuto)}{{height:auto;}}";
    public static string HPx { get; } = $".{nameof(HPx)}{{height:1px;}}";
    public static string HFull { get; } = $".{nameof(HFull)}{{height:100%;}}";
    public static string HScreen { get; } = $".{nameof(HScreen)}{{height:100vh;}}";
    public static string HMin { get; } = $".{nameof(HMin)}{{height:min-content;}}";
    public static string HMax { get; } = $".{nameof(HMax)}{{height:max-content;}}";
    public static string HFit { get; } = $".{nameof(HFit)}{{height:fit-content;}}";

    public static string MinH0 { get; } = $".{nameof(MinH0)}{{min-height:0px;}}";
    public static string MinHAuto { get; } = $".{nameof(MinHAuto)}{{min-height:auto;}}";
    public static string MinHPx { get; } = $".{nameof(MinHPx)}{{min-height:1px;}}";
    public static string MinHFull { get; } = $".{nameof(MinHFull)}{{min-height:100%;}}";
    public static string MinHScreen { get; } = $".{nameof(MinHScreen)}{{min-height:100vh;}}";
    public static string MinHMin { get; } = $".{nameof(MinHMin)}{{min-height:min-content;}}";
    public static string MinHMax { get; } = $".{nameof(MinHMax)}{{min-height:max-content;}}";
    public static string MinHFit { get; } = $".{nameof(MinHFit)}{{min-height:fit-content;}}";

    public static string MaxH0 { get; } = $".{nameof(MaxH0)}{{max-height:0px;}}";
    public static string MaxHAuto { get; } = $".{nameof(MaxHAuto)}{{max-height:auto;}}";
    public static string MaxHPx { get; } = $".{nameof(MaxHPx)}{{max-height:1px;}}";
    public static string MaxHFull { get; } = $".{nameof(MaxHFull)}{{max-height:100%;}}";
    public static string MaxHScreen { get; } = $".{nameof(MaxHScreen)}{{max-height:100vh;}}";
    public static string MaxHMin { get; } = $".{nameof(MaxHMin)}{{max-height:min-content;}}";
    public static string MaxHMax { get; } = $".{nameof(MaxHMax)}{{max-height:max-content;}}";
    public static string MaxHFit { get; } = $".{nameof(MaxHFit)}{{max-height:fit-content;}}";

    public static string Size0 { get; } = $".{nameof(Size0)}{{width:0px;height:0px;}}";
    public static string SizeAuto { get; } = $".{nameof(SizeAuto)}{{width:auto;height:auto;}}";
    public static string SizePx { get; } = $".{nameof(SizePx)}{{width:1px;height:1px;}}";
    public static string SizeFull { get; } = $".{nameof(SizeFull)}{{width:100%;height:100%;}}";
    public static string SizeMin { get; } = $".{nameof(SizeMin)}{{width:min-content;height:min-content;}}";
    public static string SizeMax { get; } = $".{nameof(SizeMax)}{{width:max-content;height:max-content;}}";
    public static string SizeFit { get; } = $".{nameof(SizeFit)}{{width:fit-content;height:fit-content;}}";

    public static string MinSize0 { get; } = $".{nameof(MinSize0)}{{min-width:0px;min-height:0px;}}";
    public static string MinSizeAuto { get; } = $".{nameof(MinSizeAuto)}{{min-width:auto;min-height:auto;}}";
    public static string MinSizePx { get; } = $".{nameof(MinSizePx)}{{min-width:1px;min-height:1px;}}";
    public static string MinSizeFull { get; } = $".{nameof(MinSizeFull)}{{min-width:100%;min-height:100%;}}";
    public static string MinSizeMin { get; } = $".{nameof(MinSizeMin)}{{min-width:min-content;min-height:min-content;}}";
    public static string MinSizeMax { get; } = $".{nameof(MinSizeMax)}{{min-width:max-content;min-height:max-content;}}";
    public static string MinSizeFit { get; } = $".{nameof(MinSizeFit)}{{min-width:fit-content;min-height:fit-content;}}";

    public static string MaxSize0 { get; } = $".{nameof(MaxSize0)}{{max-width:0px;max-height:0px;}}";
    public static string MaxSizeAuto { get; } = $".{nameof(MaxSizeAuto)}{{max-width:auto;max-height:auto;}}";
    public static string MaxSizePx { get; } = $".{nameof(MaxSizePx)}{{max-width:1px;max-height:1px;}}";
    public static string MaxSizeFull { get; } = $".{nameof(MaxSizeFull)}{{max-width:100%;max-height:100%;}}";
    public static string MaxSizeMin { get; } = $".{nameof(MaxSizeMin)}{{max-width:min-content;max-height:min-content;}}";
    public static string MaxSizeMax { get; } = $".{nameof(MaxSizeMax)}{{max-width:max-content;max-height:max-content;}}";
    public static string MaxSizeFit { get; } = $".{nameof(MaxSizeFit)}{{max-width:fit-content;max-height:fit-content;}}";

    // Part 4: Typography



}

public static class MWSpace
{
    public const string Padding = "padding";
    public const string PaddingTop = "padding-top";
    public const string PaddingRight = "padding-right";
    public const string PaddingBottom = "padding-bottom";
    public const string PaddingLeft = "padding-left";
    public const string Margin = "margin";
    public const string MarginTop = "margin-top";
    public const string MarginRight = "margin-right";
    public const string MarginBottom = "margin-bottom";
    public const string MarginLeft = "margin-left";
    public const string S0 = "0px";
    public const string S1 = "0.25rem";
    public const string S2 = "0.5rem";
    public const string S4 = "1rem";
    public const string S8 = "2rem";
    public const string S16 = "4rem";
    public const string S32 = "8rem";
    public const string SPx = "1px";
}

public static class MWColors
{
    // Amber
    public const string Amber50 = "#fffbeb";
    public const string Amber100 = "#fef3c7";
    public const string Amber200 = "#fde68a";
    public const string Amber300 = "#fcd34d";
    public const string Amber400 = "#fbbf24";
    public const string Amber500 = "#f59e0b";
    public const string Amber600 = "#d97706";
    public const string Amber700 = "#b45309";
    public const string Amber800 = "#92400e";
    public const string Amber900 = "#78350f";

    // Black
    public const string Black = "#000";

    // Blue
    public const string Blue50 = "#eff6ff";
    public const string Blue100 = "#dbeafe";
    public const string Blue200 = "#bfdbfe";
    public const string Blue300 = "#93c5fd";
    public const string Blue400 = "#60a5fa";
    public const string Blue500 = "#3b82f6";
    public const string Blue600 = "#2563eb";
    public const string Blue700 = "#1d4ed8";
    public const string Blue800 = "#1e40af";
    public const string Blue900 = "#1e3a8a";

    // BlueGray
    public const string BlueGray50 = "#f8fafc";
    public const string BlueGray100 = "#f1f5f9";
    public const string BlueGray200 = "#e2e8f0";
    public const string BlueGray300 = "#cbd5e1";
    public const string BlueGray400 = "#94a3b8";
    public const string BlueGray500 = "#64748b";
    public const string BlueGray600 = "#475569";
    public const string BlueGray700 = "#334155";
    public const string BlueGray800 = "#1e293b";
    public const string BlueGray900 = "#0f172a";

    // CoolGray
    public const string CoolGray50 = "#f9fafb";
    public const string CoolGray100 = "#f3f4f6";
    public const string CoolGray200 = "#e5e7eb";
    public const string CoolGray300 = "#d1d5db";
    public const string CoolGray400 = "#9ca3af";
    public const string CoolGray500 = "#6b7280";
    public const string CoolGray600 = "#4b5563";
    public const string CoolGray700 = "#374151";
    public const string CoolGray800 = "#1f2937";
    public const string CoolGray900 = "#111827";

    // Cyan
    public const string Cyan50 = "#ecfeff";
    public const string Cyan100 = "#cffafe";
    public const string Cyan200 = "#a5f3fc";
    public const string Cyan300 = "#67e8f9";
    public const string Cyan400 = "#22d3ee";
    public const string Cyan500 = "#06b6d4";
    public const string Cyan600 = "#0891b2";
    public const string Cyan700 = "#0e7490";
    public const string Cyan800 = "#155e75";
    public const string Cyan900 = "#164e63";

    // Emerald
    public const string Emerald50 = "#ecfdf5";
    public const string Emerald100 = "#d1fae5";
    public const string Emerald200 = "#a7f3d0";
    public const string Emerald300 = "#6ee7b7";
    public const string Emerald400 = "#34d399";
    public const string Emerald500 = "#10b981";
    public const string Emerald600 = "#059669";
    public const string Emerald700 = "#047857";
    public const string Emerald800 = "#065f46";
    public const string Emerald900 = "#064e3b";

    // Fuchsia
    public const string Fuchsia50 = "#fdf4ff";
    public const string Fuchsia100 = "#fae8ff";
    public const string Fuchsia200 = "#f5d0fe";
    public const string Fuchsia300 = "#f0abfc";
    public const string Fuchsia400 = "#e879f9";
    public const string Fuchsia500 = "#d946ef";
    public const string Fuchsia600 = "#c026d3";
    public const string Fuchsia700 = "#a21caf";
    public const string Fuchsia800 = "#86198f";
    public const string Fuchsia900 = "#701a75";

    // Gray
    public const string Gray50 = "#fafafa";
    public const string Gray100 = "#f4f4f5";
    public const string Gray200 = "#e4e4e7";
    public const string Gray300 = "#d4d4d8";
    public const string Gray400 = "#a1a1aa";
    public const string Gray500 = "#71717a";
    public const string Gray600 = "#52525b";
    public const string Gray700 = "#3f3f46";
    public const string Gray800 = "#27272a";
    public const string Gray900 = "#18181b";

    // Green
    public const string Green50 = "#f0fdf4";
    public const string Green100 = "#dcfce7";
    public const string Green200 = "#bbf7d0";
    public const string Green300 = "#86efac";
    public const string Green400 = "#4ade80";
    public const string Green500 = "#22c55e";
    public const string Green600 = "#16a34a";
    public const string Green700 = "#15803d";
    public const string Green800 = "#166534";
    public const string Green900 = "#1452d";

    // Indigo
    public const string Indigo50 = "#eef2ff";
    public const string Indigo100 = "#e0e7ff";
    public const string Indigo200 = "#c7d2fe";
    public const string Indigo300 = "#a5b4fc";
    public const string Indigo400 = "#818cf8";
    public const string Indigo500 = "#6366f1";
    public const string Indigo600 = "#4f46e5";
    public const string Indigo700 = "#4338ca";
    public const string Indigo800 = "#3730a3";
    public const string Indigo900 = "#312e81";

    // LightBlue
    public const string LightBlue50 = "#f0f9ff";
    public const string LightBlue100 = "#e0f2fe";
    public const string LightBlue200 = "#bae6fd";
    public const string LightBlue300 = "#7dd3fc";
    public const string LightBlue400 = "#38bdf8";
    public const string LightBlue500 = "#0ea5e9";
    public const string LightBlue600 = "#0284c7";
    public const string LightBlue700 = "#0369a1";
    public const string LightBlue800 = "#075985";
    public const string LightBlue900 = "#0c4a6e";

    // Lime
    public const string Lime50 = "#f7fee7";
    public const string Lime100 = "#ecfccb";
    public const string Lime200 = "#d9f99d";
    public const string Lime300 = "#bef264";
    public const string Lime400 = "#a3e635";
    public const string Lime500 = "#84cc16";
    public const string Lime600 = "#65a30d";
    public const string Lime700 = "#4d7c0f";
    public const string Lime800 = "#3f6212";
    public const string Lime900 = "#365314";

    // Orange
    public const string Orange50 = "#fff7ed";
    public const string Orange100 = "#ffedd5";
    public const string Orange200 = "#fed7aa";
    public const string Orange300 = "#fdba74";
    public const string Orange400 = "#fb923c";
    public const string Orange500 = "#f97316";
    public const string Orange600 = "#ea580c";
    public const string Orange700 = "#c2410c";
    public const string Orange800 = "#9a3412";
    public const string Orange900 = "#7c2d12";

    // Pink
    public const string Pink50 = "#fdf2f8";
    public const string Pink100 = "#fce7f3";
    public const string Pink200 = "#fbcfe8";
    public const string Pink300 = "#f9a8d4";
    public const string Pink400 = "#f472b6";
    public const string Pink500 = "#ec4899";
    public const string Pink600 = "#db2777";
    public const string Pink700 = "#be185d";
    public const string Pink800 = "#9d174d";
    public const string Pink900 = "#831843";

    // Purple
    public const string Purple50 = "#faf5ff";
    public const string Purple100 = "#f3e8ff";
    public const string Purple200 = "#e9d5ff";
    public const string Purple300 = "#d8b4fe";
    public const string Purple400 = "#c084fc";
    public const string Purple500 = "#a855f7";
    public const string Purple600 = "#9333ea";
    public const string Purple700 = "#7e22ce";
    public const string Purple800 = "#6b21a8";
    public const string Purple900 = "#581c87";

    // Red
    public const string Red50 = "#fef2f2";
    public const string Red100 = "#fee2e2";
    public const string Red200 = "#fecaca";
    public const string Red300 = "#fca5a5";
    public const string Red400 = "#f87171";
    public const string Red500 = "#ef4444";
    public const string Red600 = "#dc2626";
    public const string Red700 = "#b91c1c";
    public const string Red800 = "#991b1b";
    public const string Red900 = "#7f1d1d";

    // Rose
    public const string Rose50 = "#fff1f2";
    public const string Rose100 = "#ffe4e6";
    public const string Rose200 = "#fecdd3";
    public const string Rose300 = "#fda4af";
    public const string Rose400 = "#fb7185";
    public const string Rose500 = "#f43f5e";
    public const string Rose600 = "#e11d48";
    public const string Rose700 = "#be123c";
    public const string Rose800 = "#9f1239";
    public const string Rose900 = "#881337";

    // Sky
    public const string Sky50 = "#f0f9ff";
    public const string Sky100 = "#e0f2fe";
    public const string Sky200 = "#bae6fd";
    public const string Sky300 = "#7dd3fc";
    public const string Sky400 = "#38bdf8";
    public const string Sky500 = "#0ea5e9";
    public const string Sky600 = "#0284c7";
    public const string Sky700 = "#0369a1";
    public const string Sky800 = "#075985";
    public const string Sky900 = "#0c4a6e";

    // Teal
    public const string Teal50 = "#f0fdfa";
    public const string Teal100 = "#ccfbf1";
    public const string Teal200 = "#99f6e4";
    public const string Teal300 = "#5eead4";
    public const string Teal400 = "#2dd4bf";
    public const string Teal500 = "#14b8a6";
    public const string Teal600 = "#0d9488";
    public const string Teal700 = "#0f766e";
    public const string Teal800 = "#115e59";
    public const string Teal900 = "#134e4a";

    // TrueGray
    public const string TrueGray50 = "#fafafa";
    public const string TrueGray100 = "#f5f5f5";
    public const string TrueGray200 = "#e5e5e5";
    public const string TrueGray300 = "#d4d4d4";
    public const string TrueGray400 = "#a3a3a3";
    public const string TrueGray500 = "#737373";
    public const string TrueGray600 = "#525252";
    public const string TrueGray700 = "#404040";
    public const string TrueGray800 = "#262626";
    public const string TrueGray900 = "#171717";

    // Violet
    public const string Violet50 = "#f5f3ff";
    public const string Violet100 = "#ede9fe";
    public const string Violet200 = "#ddd6fe";
    public const string Violet300 = "#c4b5fd";
    public const string Violet400 = "#a78bfa";
    public const string Violet500 = "#8b5cf6";
    public const string Violet600 = "#7c3aed";
    public const string Violet700 = "#6d28d9";
    public const string Violet800 = "#5b21b6";
    public const string Violet900 = "#4c1d95";

    // WarmGray
    public const string WarmGray50 = "#fafaf9";
    public const string WarmGray100 = "#f5f5f4";
    public const string WarmGray200 = "#e7e5e4";
    public const string WarmGray300 = "#d6d3d1";
    public const string WarmGray400 = "#a8a29e";
    public const string WarmGray500 = "#78716c";
    public const string WarmGray600 = "#57534e";
    public const string WarmGray700 = "#44403c";
    public const string WarmGray800 = "#292524";
    public const string WarmGray900 = "#1c1917";

    // White
    public const string White = "#fff";

    // Yellow
    public const string Yellow50 = "#fefce8";
    public const string Yellow100 = "#fef9c3";
    public const string Yellow200 = "#fef08a";
    public const string Yellow300 = "#fde047";
    public const string Yellow400 = "#facc15";
    public const string Yellow500 = "#eab308";
    public const string Yellow600 = "#ca8a04";
    public const string Yellow700 = "#a16207";
    public const string Yellow800 = "#854d0e";
    public const string Yellow900 = "#713f12";
}