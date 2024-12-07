namespace HtmfExample;

public class MicroWind
{
    public MicroWind(string className, string cssStyleOutput) { ClassName = className; CssStyleOutput = cssStyleOutput; }

    public string ClassName { get; }
    public string CssStyleOutput { get; }

    public override string ToString() => ClassName;

    public static readonly string Preflight = "*,::after,::before{box-sizing:border-box;border-width:0;border-style:solid;border-color:#e5e7eb}::after,::before{--tw-content:''}:host,html{line-height:1.5;-webkit-text-size-adjust:100%;-moz-tab-size:4;tab-size:4;font-family:ui-sans-serif, system-ui, sans-serif, \"Apple Color Emoji\", \"Segoe UI Emoji\", \"Segoe UI Symbol\", \"Noto Color Emoji\";font-feature-settings:normal;font-variation-settings:normal;-webkit-tap-highlight-color:transparent}body{margin:0;line-height:inherit}hr{height:0;color:inherit;border-top-width:1px}abbr:where([title]){-webkit-text-decoration:underline dotted;text-decoration:underline dotted}h1,h32,h3,h4,h5,h6{font-size:inherit;font-weight:inherit}a{color:inherit;text-decoration:inherit}b,strong{font-weight:bolder}code,kbd,pre,samp{font-family:ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, \"Liberation Mono\", \"Courier New\", monospace;font-feature-settings:normal;font-variation-settings:normal;font-size:1em}small{font-size:80%}sub,sup{font-size:75%;line-height:0;position:relative;vertical-align:baseline}sub{bottom:-.325em}sup{top:-.5em}table{text-indent:0;border-color:inherit;border-collapse:collapse}button,input,optgroup,select,textarea{font-family:inherit;font-feature-settings:inherit;font-variation-settings:inherit;font-size:100%;font-weight:inherit;line-height:inherit;letter-spacing:inherit;color:inherit;margin:0;padding:0}button,select{text-transform:none}button,input:where([type=button]),input:where([type=reset]),input:where([type=submit]){-webkit-appearance:button;background-color:transparent;background-image:none}:-moz-focusring{outline:auto}:-moz-ui-invalid{box-shadow:none}progress{vertical-align:baseline}::-webkit-inner-spin-button,::-webkit-outer-spin-button{height:auto}[type=search]{-webkit-appearance:textfield;outline-offset:-32px}::-webkit-search-decoration{-webkit-appearance:none}::-webkit-file-upload-button{-webkit-appearance:button;font:inherit}summary{display:list-item}blockquote,dd,dl,figure,h1,h32,h3,h4,h5,h6,hr,p,pre{margin:0}fieldset{margin:0;padding:0}legend{padding:0}menu,ol,ul{list-style:none;margin:0;padding:0}dialog{padding:0}textarea{resize:vertical}input::placeholder,textarea::placeholder{opacity:1;color:#9ca3af}[role=button],button{cursor:pointer}:disabled{cursor:default}audio,canvas,embed,iframe,img,object,svg,video{display:block;vertical-align:middle}img,video{max-width:100%;height:auto}[hidden]{display:none}";

    // Amber
    public static MicroWind TextAmber50 { get; } = new($"Text{nameof(MWColors.Amber50)}", $".Text{nameof(MWColors.Amber50)}{{color:{MWColors.Amber50};}}");
    public static MicroWind TextAmber100 { get; } = new($"Text{nameof(MWColors.Amber100)}", $".Text{nameof(MWColors.Amber100)}{{color:{MWColors.Amber100};}}");
    public static MicroWind TextAmber200 { get; } = new($"Text{nameof(MWColors.Amber200)}", $".Text{nameof(MWColors.Amber200)}{{color:{MWColors.Amber200};}}");
    public static MicroWind TextAmber300 { get; } = new($"Text{nameof(MWColors.Amber300)}", $".Text{nameof(MWColors.Amber300)}{{color:{MWColors.Amber300};}}");
    public static MicroWind TextAmber400 { get; } = new($"Text{nameof(MWColors.Amber400)}", $".Text{nameof(MWColors.Amber400)}{{color:{MWColors.Amber400};}}");
    public static MicroWind TextAmber500 { get; } = new($"Text{nameof(MWColors.Amber500)}", $".Text{nameof(MWColors.Amber500)}{{color:{MWColors.Amber500};}}");
    public static MicroWind TextAmber600 { get; } = new($"Text{nameof(MWColors.Amber600)}", $".Text{nameof(MWColors.Amber600)}{{color:{MWColors.Amber600};}}");
    public static MicroWind TextAmber700 { get; } = new($"Text{nameof(MWColors.Amber700)}", $".Text{nameof(MWColors.Amber700)}{{color:{MWColors.Amber700};}}");
    public static MicroWind TextAmber800 { get; } = new($"Text{nameof(MWColors.Amber800)}", $".Text{nameof(MWColors.Amber800)}{{color:{MWColors.Amber800};}}");
    public static MicroWind TextAmber900 { get; } = new($"Text{nameof(MWColors.Amber900)}", $".Text{nameof(MWColors.Amber900)}{{color:{MWColors.Amber900};}}");

    // Black
    public static MicroWind TextBlack { get; } = new($"Text{nameof(MWColors.Black)}", $".Text{nameof(MWColors.Black)}{{color:{MWColors.Black};}}");

    // Blue
    public static MicroWind TextBlue50 { get; } = new($"Text{nameof(MWColors.Blue50)}", $".Text{nameof(MWColors.Blue50)}{{color:{MWColors.Blue50};}}");
    public static MicroWind TextBlue100 { get; } = new($"Text{nameof(MWColors.Blue100)}", $".Text{nameof(MWColors.Blue100)}{{color:{MWColors.Blue100};}}");
    public static MicroWind TextBlue200 { get; } = new($"Text{nameof(MWColors.Blue200)}", $".Text{nameof(MWColors.Blue200)}{{color:{MWColors.Blue200};}}");
    public static MicroWind TextBlue300 { get; } = new($"Text{nameof(MWColors.Blue300)}", $".Text{nameof(MWColors.Blue300)}{{color:{MWColors.Blue300};}}");
    public static MicroWind TextBlue400 { get; } = new($"Text{nameof(MWColors.Blue400)}", $".Text{nameof(MWColors.Blue400)}{{color:{MWColors.Blue400};}}");
    public static MicroWind TextBlue500 { get; } = new($"Text{nameof(MWColors.Blue500)}", $".Text{nameof(MWColors.Blue500)}{{color:{MWColors.Blue500};}}");
    public static MicroWind TextBlue600 { get; } = new($"Text{nameof(MWColors.Blue600)}", $".Text{nameof(MWColors.Blue600)}{{color:{MWColors.Blue600};}}");
    public static MicroWind TextBlue700 { get; } = new($"Text{nameof(MWColors.Blue700)}", $".Text{nameof(MWColors.Blue700)}{{color:{MWColors.Blue700};}}");
    public static MicroWind TextBlue800 { get; } = new($"Text{nameof(MWColors.Blue800)}", $".Text{nameof(MWColors.Blue800)}{{color:{MWColors.Blue800};}}");
    public static MicroWind TextBlue900 { get; } = new($"Text{nameof(MWColors.Blue900)}", $".Text{nameof(MWColors.Blue900)}{{color:{MWColors.Blue900};}}");

    // BlueGray
    public static MicroWind TextBlueGray50 { get; } = new($"Text{nameof(MWColors.BlueGray50)}", $".Text{nameof(MWColors.BlueGray50)}{{color:{MWColors.BlueGray50};}}");
    public static MicroWind TextBlueGray100 { get; } = new($"Text{nameof(MWColors.BlueGray100)}", $".Text{nameof(MWColors.BlueGray100)}{{color:{MWColors.BlueGray100};}}");
    public static MicroWind TextBlueGray200 { get; } = new($"Text{nameof(MWColors.BlueGray200)}", $".Text{nameof(MWColors.BlueGray200)}{{color:{MWColors.BlueGray200};}}");
    public static MicroWind TextBlueGray300 { get; } = new($"Text{nameof(MWColors.BlueGray300)}", $".Text{nameof(MWColors.BlueGray300)}{{color:{MWColors.BlueGray300};}}");
    public static MicroWind TextBlueGray400 { get; } = new($"Text{nameof(MWColors.BlueGray400)}", $".Text{nameof(MWColors.BlueGray400)}{{color:{MWColors.BlueGray400};}}");
    public static MicroWind TextBlueGray500 { get; } = new($"Text{nameof(MWColors.BlueGray500)}", $".Text{nameof(MWColors.BlueGray500)}{{color:{MWColors.BlueGray500};}}");
    public static MicroWind TextBlueGray600 { get; } = new($"Text{nameof(MWColors.BlueGray600)}", $".Text{nameof(MWColors.BlueGray600)}{{color:{MWColors.BlueGray600};}}");
    public static MicroWind TextBlueGray700 { get; } = new($"Text{nameof(MWColors.BlueGray700)}", $".Text{nameof(MWColors.BlueGray700)}{{color:{MWColors.BlueGray700};}}");
    public static MicroWind TextBlueGray800 { get; } = new($"Text{nameof(MWColors.BlueGray800)}", $".Text{nameof(MWColors.BlueGray800)}{{color:{MWColors.BlueGray800};}}");
    public static MicroWind TextBlueGray900 { get; } = new($"Text{nameof(MWColors.BlueGray900)}", $".Text{nameof(MWColors.BlueGray900)}{{color:{MWColors.BlueGray900};}}");

    // CoolGray
    public static MicroWind TextCoolGray50 { get; } = new($"Text{nameof(MWColors.CoolGray50)}", $".Text{nameof(MWColors.CoolGray50)}{{color:{MWColors.CoolGray50};}}");
    public static MicroWind TextCoolGray100 { get; } = new($"Text{nameof(MWColors.CoolGray100)}", $".Text{nameof(MWColors.CoolGray100)}{{color:{MWColors.CoolGray100};}}");
    public static MicroWind TextCoolGray200 { get; } = new($"Text{nameof(MWColors.CoolGray200)}", $".Text{nameof(MWColors.CoolGray200)}{{color:{MWColors.CoolGray200};}}");
    public static MicroWind TextCoolGray300 { get; } = new($"Text{nameof(MWColors.CoolGray300)}", $".Text{nameof(MWColors.CoolGray300)}{{color:{MWColors.CoolGray300};}}");
    public static MicroWind TextCoolGray400 { get; } = new($"Text{nameof(MWColors.CoolGray400)}", $".Text{nameof(MWColors.CoolGray400)}{{color:{MWColors.CoolGray400};}}");
    public static MicroWind TextCoolGray500 { get; } = new($"Text{nameof(MWColors.CoolGray500)}", $".Text{nameof(MWColors.CoolGray500)}{{color:{MWColors.CoolGray500};}}");
    public static MicroWind TextCoolGray600 { get; } = new($"Text{nameof(MWColors.CoolGray600)}", $".Text{nameof(MWColors.CoolGray600)}{{color:{MWColors.CoolGray600};}}");
    public static MicroWind TextCoolGray700 { get; } = new($"Text{nameof(MWColors.CoolGray700)}", $".Text{nameof(MWColors.CoolGray700)}{{color:{MWColors.CoolGray700};}}");
    public static MicroWind TextCoolGray800 { get; } = new($"Text{nameof(MWColors.CoolGray800)}", $".Text{nameof(MWColors.CoolGray800)}{{color:{MWColors.CoolGray800};}}");
    public static MicroWind TextCoolGray900 { get; } = new($"Text{nameof(MWColors.CoolGray900)}", $".Text{nameof(MWColors.CoolGray900)}{{color:{MWColors.CoolGray900};}}");

    // Cyan
    public static MicroWind TextCyan50 { get; } = new($"Text{nameof(MWColors.Cyan50)}", $".Text{nameof(MWColors.Cyan50)}{{color:{MWColors.Cyan50};}}");
    public static MicroWind TextCyan100 { get; } = new($"Text{nameof(MWColors.Cyan100)}", $".Text{nameof(MWColors.Cyan100)}{{color:{MWColors.Cyan100};}}");
    public static MicroWind TextCyan200 { get; } = new($"Text{nameof(MWColors.Cyan200)}", $".Text{nameof(MWColors.Cyan200)}{{color:{MWColors.Cyan200};}}");
    public static MicroWind TextCyan300 { get; } = new($"Text{nameof(MWColors.Cyan300)}", $".Text{nameof(MWColors.Cyan300)}{{color:{MWColors.Cyan300};}}");
    public static MicroWind TextCyan400 { get; } = new($"Text{nameof(MWColors.Cyan400)}", $".Text{nameof(MWColors.Cyan400)}{{color:{MWColors.Cyan400};}}");
    public static MicroWind TextCyan500 { get; } = new($"Text{nameof(MWColors.Cyan500)}", $".Text{nameof(MWColors.Cyan500)}{{color:{MWColors.Cyan500};}}");
    public static MicroWind TextCyan600 { get; } = new($"Text{nameof(MWColors.Cyan600)}", $".Text{nameof(MWColors.Cyan600)}{{color:{MWColors.Cyan600};}}");
    public static MicroWind TextCyan700 { get; } = new($"Text{nameof(MWColors.Cyan700)}", $".Text{nameof(MWColors.Cyan700)}{{color:{MWColors.Cyan700};}}");
    public static MicroWind TextCyan800 { get; } = new($"Text{nameof(MWColors.Cyan800)}", $".Text{nameof(MWColors.Cyan800)}{{color:{MWColors.Cyan800};}}");
    public static MicroWind TextCyan900 { get; } = new($"Text{nameof(MWColors.Cyan900)}", $".Text{nameof(MWColors.Cyan900)}{{color:{MWColors.Cyan900};}}");

    // Emerald
    public static MicroWind TextEmerald50 { get; } = new($"Text{nameof(MWColors.Emerald50)}", $".Text{nameof(MWColors.Emerald50)}{{color:{MWColors.Emerald50};}}");
    public static MicroWind TextEmerald100 { get; } = new($"Text{nameof(MWColors.Emerald100)}", $".Text{nameof(MWColors.Emerald100)}{{color:{MWColors.Emerald100};}}");
    public static MicroWind TextEmerald200 { get; } = new($"Text{nameof(MWColors.Emerald200)}", $".Text{nameof(MWColors.Emerald200)}{{color:{MWColors.Emerald200};}}");
    public static MicroWind TextEmerald300 { get; } = new($"Text{nameof(MWColors.Emerald300)}", $".Text{nameof(MWColors.Emerald300)}{{color:{MWColors.Emerald300};}}");
    public static MicroWind TextEmerald400 { get; } = new($"Text{nameof(MWColors.Emerald400)}", $".Text{nameof(MWColors.Emerald400)}{{color:{MWColors.Emerald400};}}");
    public static MicroWind TextEmerald500 { get; } = new($"Text{nameof(MWColors.Emerald500)}", $".Text{nameof(MWColors.Emerald500)}{{color:{MWColors.Emerald500};}}");
    public static MicroWind TextEmerald600 { get; } = new($"Text{nameof(MWColors.Emerald600)}", $".Text{nameof(MWColors.Emerald600)}{{color:{MWColors.Emerald600};}}");
    public static MicroWind TextEmerald700 { get; } = new($"Text{nameof(MWColors.Emerald700)}", $".Text{nameof(MWColors.Emerald700)}{{color:{MWColors.Emerald700};}}");
    public static MicroWind TextEmerald800 { get; } = new($"Text{nameof(MWColors.Emerald800)}", $".Text{nameof(MWColors.Emerald800)}{{color:{MWColors.Emerald800};}}");
    public static MicroWind TextEmerald900 { get; } = new($"Text{nameof(MWColors.Emerald900)}", $".Text{nameof(MWColors.Emerald900)}{{color:{MWColors.Emerald900};}}");

    // Fuchsia
    public static MicroWind TextFuchsia50 { get; } = new($"Text{nameof(MWColors.Fuchsia50)}", $".Text{nameof(MWColors.Fuchsia50)}{{color:{MWColors.Fuchsia50};}}");
    public static MicroWind TextFuchsia100 { get; } = new($"Text{nameof(MWColors.Fuchsia100)}", $".Text{nameof(MWColors.Fuchsia100)}{{color:{MWColors.Fuchsia100};}}");
    public static MicroWind TextFuchsia200 { get; } = new($"Text{nameof(MWColors.Fuchsia200)}", $".Text{nameof(MWColors.Fuchsia200)}{{color:{MWColors.Fuchsia200};}}");
    public static MicroWind TextFuchsia300 { get; } = new($"Text{nameof(MWColors.Fuchsia300)}", $".Text{nameof(MWColors.Fuchsia300)}{{color:{MWColors.Fuchsia300};}}");
    public static MicroWind TextFuchsia400 { get; } = new($"Text{nameof(MWColors.Fuchsia400)}", $".Text{nameof(MWColors.Fuchsia400)}{{color:{MWColors.Fuchsia400};}}");
    public static MicroWind TextFuchsia500 { get; } = new($"Text{nameof(MWColors.Fuchsia500)}", $".Text{nameof(MWColors.Fuchsia500)}{{color:{MWColors.Fuchsia500};}}");
    public static MicroWind TextFuchsia600 { get; } = new($"Text{nameof(MWColors.Fuchsia600)}", $".Text{nameof(MWColors.Fuchsia600)}{{color:{MWColors.Fuchsia600};}}");
    public static MicroWind TextFuchsia700 { get; } = new($"Text{nameof(MWColors.Fuchsia700)}", $".Text{nameof(MWColors.Fuchsia700)}{{color:{MWColors.Fuchsia700};}}");
    public static MicroWind TextFuchsia800 { get; } = new($"Text{nameof(MWColors.Fuchsia800)}", $".Text{nameof(MWColors.Fuchsia800)}{{color:{MWColors.Fuchsia800};}}");
    public static MicroWind TextFuchsia900 { get; } = new($"Text{nameof(MWColors.Fuchsia900)}", $".Text{nameof(MWColors.Fuchsia900)}{{color:{MWColors.Fuchsia900};}}");

    // Gray
    public static MicroWind TextGray50 { get; } = new($"Text{nameof(MWColors.Gray50)}", $".Text{nameof(MWColors.Gray50)}{{color:{MWColors.Gray50};}}");
    public static MicroWind TextGray100 { get; } = new($"Text{nameof(MWColors.Gray100)}", $".Text{nameof(MWColors.Gray100)}{{color:{MWColors.Gray100};}}");
    public static MicroWind TextGray200 { get; } = new($"Text{nameof(MWColors.Gray200)}", $".Text{nameof(MWColors.Gray200)}{{color:{MWColors.Gray200};}}");
    public static MicroWind TextGray300 { get; } = new($"Text{nameof(MWColors.Gray300)}", $".Text{nameof(MWColors.Gray300)}{{color:{MWColors.Gray300};}}");
    public static MicroWind TextGray400 { get; } = new($"Text{nameof(MWColors.Gray400)}", $".Text{nameof(MWColors.Gray400)}{{color:{MWColors.Gray400};}}");
    public static MicroWind TextGray500 { get; } = new($"Text{nameof(MWColors.Gray500)}", $".Text{nameof(MWColors.Gray500)}{{color:{MWColors.Gray500};}}");
    public static MicroWind TextGray600 { get; } = new($"Text{nameof(MWColors.Gray600)}", $".Text{nameof(MWColors.Gray600)}{{color:{MWColors.Gray600};}}");
    public static MicroWind TextGray700 { get; } = new($"Text{nameof(MWColors.Gray700)}", $".Text{nameof(MWColors.Gray700)}{{color:{MWColors.Gray700};}}");
    public static MicroWind TextGray800 { get; } = new($"Text{nameof(MWColors.Gray800)}", $".Text{nameof(MWColors.Gray800)}{{color:{MWColors.Gray800};}}");
    public static MicroWind TextGray900 { get; } = new($"Text{nameof(MWColors.Gray900)}", $".Text{nameof(MWColors.Gray900)}{{color:{MWColors.Gray900};}}");

    // Green
    public static MicroWind TextGreen50 { get; } = new($"Text{nameof(MWColors.Green50)}", $".Text{nameof(MWColors.Green50)}{{color:{MWColors.Green50};}}");
    public static MicroWind TextGreen100 { get; } = new($"Text{nameof(MWColors.Green100)}", $".Text{nameof(MWColors.Green100)}{{color:{MWColors.Green100};}}");
    public static MicroWind TextGreen200 { get; } = new($"Text{nameof(MWColors.Green200)}", $".Text{nameof(MWColors.Green200)}{{color:{MWColors.Green200};}}");
    public static MicroWind TextGreen300 { get; } = new($"Text{nameof(MWColors.Green300)}", $".Text{nameof(MWColors.Green300)}{{color:{MWColors.Green300};}}");
    public static MicroWind TextGreen400 { get; } = new($"Text{nameof(MWColors.Green400)}", $".Text{nameof(MWColors.Green400)}{{color:{MWColors.Green400};}}");
    public static MicroWind TextGreen500 { get; } = new($"Text{nameof(MWColors.Green500)}", $".Text{nameof(MWColors.Green500)}{{color:{MWColors.Green500};}}");
    public static MicroWind TextGreen600 { get; } = new($"Text{nameof(MWColors.Green600)}", $".Text{nameof(MWColors.Green600)}{{color:{MWColors.Green600};}}");
    public static MicroWind TextGreen700 { get; } = new($"Text{nameof(MWColors.Green700)}", $".Text{nameof(MWColors.Green700)}{{color:{MWColors.Green700};}}");
    public static MicroWind TextGreen800 { get; } = new($"Text{nameof(MWColors.Green800)}", $".Text{nameof(MWColors.Green800)}{{color:{MWColors.Green800};}}");
    public static MicroWind TextGreen900 { get; } = new($"Text{nameof(MWColors.Green900)}", $".Text{nameof(MWColors.Green900)}{{color:{MWColors.Green900};}}");

    // Indigo
    public static MicroWind TextIndigo50 { get; } = new($"Text{nameof(MWColors.Indigo50)}", $".Text{nameof(MWColors.Indigo50)}{{color:{MWColors.Indigo50};}}");
    public static MicroWind TextIndigo100 { get; } = new($"Text{nameof(MWColors.Indigo100)}", $".Text{nameof(MWColors.Indigo100)}{{color:{MWColors.Indigo100};}}");
    public static MicroWind TextIndigo200 { get; } = new($"Text{nameof(MWColors.Indigo200)}", $".Text{nameof(MWColors.Indigo200)}{{color:{MWColors.Indigo200};}}");
    public static MicroWind TextIndigo300 { get; } = new($"Text{nameof(MWColors.Indigo300)}", $".Text{nameof(MWColors.Indigo300)}{{color:{MWColors.Indigo300};}}");
    public static MicroWind TextIndigo400 { get; } = new($"Text{nameof(MWColors.Indigo400)}", $".Text{nameof(MWColors.Indigo400)}{{color:{MWColors.Indigo400};}}");
    public static MicroWind TextIndigo500 { get; } = new($"Text{nameof(MWColors.Indigo500)}", $".Text{nameof(MWColors.Indigo500)}{{color:{MWColors.Indigo500};}}");
    public static MicroWind TextIndigo600 { get; } = new($"Text{nameof(MWColors.Indigo600)}", $".Text{nameof(MWColors.Indigo600)}{{color:{MWColors.Indigo600};}}");
    public static MicroWind TextIndigo700 { get; } = new($"Text{nameof(MWColors.Indigo700)}", $".Text{nameof(MWColors.Indigo700)}{{color:{MWColors.Indigo700};}}");
    public static MicroWind TextIndigo800 { get; } = new($"Text{nameof(MWColors.Indigo800)}", $".Text{nameof(MWColors.Indigo800)}{{color:{MWColors.Indigo800};}}");
    public static MicroWind TextIndigo900 { get; } = new($"Text{nameof(MWColors.Indigo900)}", $".Text{nameof(MWColors.Indigo900)}{{color:{MWColors.Indigo900};}}");

    // LightBlue
    public static MicroWind TextLightBlue50 { get; } = new($"Text{nameof(MWColors.LightBlue50)}", $".Text{nameof(MWColors.LightBlue50)}{{color:{MWColors.LightBlue50};}}");
    public static MicroWind TextLightBlue100 { get; } = new($"Text{nameof(MWColors.LightBlue100)}", $".Text{nameof(MWColors.LightBlue100)}{{color:{MWColors.LightBlue100};}}");
    public static MicroWind TextLightBlue200 { get; } = new($"Text{nameof(MWColors.LightBlue200)}", $".Text{nameof(MWColors.LightBlue200)}{{color:{MWColors.LightBlue200};}}");
    public static MicroWind TextLightBlue300 { get; } = new($"Text{nameof(MWColors.LightBlue300)}", $".Text{nameof(MWColors.LightBlue300)}{{color:{MWColors.LightBlue300};}}");
    public static MicroWind TextLightBlue400 { get; } = new($"Text{nameof(MWColors.LightBlue400)}", $".Text{nameof(MWColors.LightBlue400)}{{color:{MWColors.LightBlue400};}}");
    public static MicroWind TextLightBlue500 { get; } = new($"Text{nameof(MWColors.LightBlue500)}", $".Text{nameof(MWColors.LightBlue500)}{{color:{MWColors.LightBlue500};}}");
    public static MicroWind TextLightBlue600 { get; } = new($"Text{nameof(MWColors.LightBlue600)}", $".Text{nameof(MWColors.LightBlue600)}{{color:{MWColors.LightBlue600};}}");
    public static MicroWind TextLightBlue700 { get; } = new($"Text{nameof(MWColors.LightBlue700)}", $".Text{nameof(MWColors.LightBlue700)}{{color:{MWColors.LightBlue700};}}");
    public static MicroWind TextLightBlue800 { get; } = new($"Text{nameof(MWColors.LightBlue800)}", $".Text{nameof(MWColors.LightBlue800)}{{color:{MWColors.LightBlue800};}}");
    public static MicroWind TextLightBlue900 { get; } = new($"Text{nameof(MWColors.LightBlue900)}", $".Text{nameof(MWColors.LightBlue900)}{{color:{MWColors.LightBlue900};}}");

    // Lime
    public static MicroWind TextLime50 { get; } = new($"Text{nameof(MWColors.Lime50)}", $".Text{nameof(MWColors.Lime50)}{{color:{MWColors.Lime50};}}");
    public static MicroWind TextLime100 { get; } = new($"Text{nameof(MWColors.Lime100)}", $".Text{nameof(MWColors.Lime100)}{{color:{MWColors.Lime100};}}");
    public static MicroWind TextLime200 { get; } = new($"Text{nameof(MWColors.Lime200)}", $".Text{nameof(MWColors.Lime200)}{{color:{MWColors.Lime200};}}");
    public static MicroWind TextLime300 { get; } = new($"Text{nameof(MWColors.Lime300)}", $".Text{nameof(MWColors.Lime300)}{{color:{MWColors.Lime300};}}");
    public static MicroWind TextLime400 { get; } = new($"Text{nameof(MWColors.Lime400)}", $".Text{nameof(MWColors.Lime400)}{{color:{MWColors.Lime400};}}");
    public static MicroWind TextLime500 { get; } = new($"Text{nameof(MWColors.Lime500)}", $".Text{nameof(MWColors.Lime500)}{{color:{MWColors.Lime500};}}");
    public static MicroWind TextLime600 { get; } = new($"Text{nameof(MWColors.Lime600)}", $".Text{nameof(MWColors.Lime600)}{{color:{MWColors.Lime600};}}");
    public static MicroWind TextLime700 { get; } = new($"Text{nameof(MWColors.Lime700)}", $".Text{nameof(MWColors.Lime700)}{{color:{MWColors.Lime700};}}");
    public static MicroWind TextLime800 { get; } = new($"Text{nameof(MWColors.Lime800)}", $".Text{nameof(MWColors.Lime800)}{{color:{MWColors.Lime800};}}");
    public static MicroWind TextLime900 { get; } = new($"Text{nameof(MWColors.Lime900)}", $".Text{nameof(MWColors.Lime900)}{{color:{MWColors.Lime900};}}");

    // Orange
    public static MicroWind TextOrange50 { get; } = new($"Text{nameof(MWColors.Orange50)}", $".Text{nameof(MWColors.Orange50)}{{color:{MWColors.Orange50};}}");
    public static MicroWind TextOrange100 { get; } = new($"Text{nameof(MWColors.Orange100)}", $".Text{nameof(MWColors.Orange100)}{{color:{MWColors.Orange100};}}");
    public static MicroWind TextOrange200 { get; } = new($"Text{nameof(MWColors.Orange200)}", $".Text{nameof(MWColors.Orange200)}{{color:{MWColors.Orange200};}}");
    public static MicroWind TextOrange300 { get; } = new($"Text{nameof(MWColors.Orange300)}", $".Text{nameof(MWColors.Orange300)}{{color:{MWColors.Orange300};}}");
    public static MicroWind TextOrange400 { get; } = new($"Text{nameof(MWColors.Orange400)}", $".Text{nameof(MWColors.Orange400)}{{color:{MWColors.Orange400};}}");
    public static MicroWind TextOrange500 { get; } = new($"Text{nameof(MWColors.Orange500)}", $".Text{nameof(MWColors.Orange500)}{{color:{MWColors.Orange500};}}");
    public static MicroWind TextOrange600 { get; } = new($"Text{nameof(MWColors.Orange600)}", $".Text{nameof(MWColors.Orange600)}{{color:{MWColors.Orange600};}}");
    public static MicroWind TextOrange700 { get; } = new($"Text{nameof(MWColors.Orange700)}", $".Text{nameof(MWColors.Orange700)}{{color:{MWColors.Orange700};}}");
    public static MicroWind TextOrange800 { get; } = new($"Text{nameof(MWColors.Orange800)}", $".Text{nameof(MWColors.Orange800)}{{color:{MWColors.Orange800};}}");
    public static MicroWind TextOrange900 { get; } = new($"Text{nameof(MWColors.Orange900)}", $".Text{nameof(MWColors.Orange900)}{{color:{MWColors.Orange900};}}");

    // Pink
    public static MicroWind TextPink50 { get; } = new($"Text{nameof(MWColors.Pink50)}", $".Text{nameof(MWColors.Pink50)}{{color:{MWColors.Pink50};}}");
    public static MicroWind TextPink100 { get; } = new($"Text{nameof(MWColors.Pink100)}", $".Text{nameof(MWColors.Pink100)}{{color:{MWColors.Pink100};}}");
    public static MicroWind TextPink200 { get; } = new($"Text{nameof(MWColors.Pink200)}", $".Text{nameof(MWColors.Pink200)}{{color:{MWColors.Pink200};}}");
    public static MicroWind TextPink300 { get; } = new($"Text{nameof(MWColors.Pink300)}", $".Text{nameof(MWColors.Pink300)}{{color:{MWColors.Pink300};}}");
    public static MicroWind TextPink400 { get; } = new($"Text{nameof(MWColors.Pink400)}", $".Text{nameof(MWColors.Pink400)}{{color:{MWColors.Pink400};}}");
    public static MicroWind TextPink500 { get; } = new($"Text{nameof(MWColors.Pink500)}", $".Text{nameof(MWColors.Pink500)}{{color:{MWColors.Pink500};}}");
    public static MicroWind TextPink600 { get; } = new($"Text{nameof(MWColors.Pink600)}", $".Text{nameof(MWColors.Pink600)}{{color:{MWColors.Pink600};}}");
    public static MicroWind TextPink700 { get; } = new($"Text{nameof(MWColors.Pink700)}", $".Text{nameof(MWColors.Pink700)}{{color:{MWColors.Pink700};}}");
    public static MicroWind TextPink800 { get; } = new($"Text{nameof(MWColors.Pink800)}", $".Text{nameof(MWColors.Pink800)}{{color:{MWColors.Pink800};}}");
    public static MicroWind TextPink900 { get; } = new($"Text{nameof(MWColors.Pink900)}", $".Text{nameof(MWColors.Pink900)}{{color:{MWColors.Pink900};}}");

    // Purple
    public static MicroWind TextPurple50 { get; } = new($"Text{nameof(MWColors.Purple50)}", $".Text{nameof(MWColors.Purple50)}{{color:{MWColors.Purple50};}}");
    public static MicroWind TextPurple100 { get; } = new($"Text{nameof(MWColors.Purple100)}", $".Text{nameof(MWColors.Purple100)}{{color:{MWColors.Purple100};}}");
    public static MicroWind TextPurple200 { get; } = new($"Text{nameof(MWColors.Purple200)}", $".Text{nameof(MWColors.Purple200)}{{color:{MWColors.Purple200};}}");
    public static MicroWind TextPurple300 { get; } = new($"Text{nameof(MWColors.Purple300)}", $".Text{nameof(MWColors.Purple300)}{{color:{MWColors.Purple300};}}");
    public static MicroWind TextPurple400 { get; } = new($"Text{nameof(MWColors.Purple400)}", $".Text{nameof(MWColors.Purple400)}{{color:{MWColors.Purple400};}}");
    public static MicroWind TextPurple500 { get; } = new($"Text{nameof(MWColors.Purple500)}", $".Text{nameof(MWColors.Purple500)}{{color:{MWColors.Purple500};}}");
    public static MicroWind TextPurple600 { get; } = new($"Text{nameof(MWColors.Purple600)}", $".Text{nameof(MWColors.Purple600)}{{color:{MWColors.Purple600};}}");
    public static MicroWind TextPurple700 { get; } = new($"Text{nameof(MWColors.Purple700)}", $".Text{nameof(MWColors.Purple700)}{{color:{MWColors.Purple700};}}");
    public static MicroWind TextPurple800 { get; } = new($"Text{nameof(MWColors.Purple800)}", $".Text{nameof(MWColors.Purple800)}{{color:{MWColors.Purple800};}}");
    public static MicroWind TextPurple900 { get; } = new($"Text{nameof(MWColors.Purple900)}", $".Text{nameof(MWColors.Purple900)}{{color:{MWColors.Purple900};}}");

    // Red
    public static MicroWind TextRed50 { get; } = new($"Text{nameof(MWColors.Red50)}", $".Text{nameof(MWColors.Red50)}{{color:{MWColors.Red50};}}");
    public static MicroWind TextRed100 { get; } = new($"Text{nameof(MWColors.Red100)}", $".Text{nameof(MWColors.Red100)}{{color:{MWColors.Red100};}}");
    public static MicroWind TextRed200 { get; } = new($"Text{nameof(MWColors.Red200)}", $".Text{nameof(MWColors.Red200)}{{color:{MWColors.Red200};}}");
    public static MicroWind TextRed300 { get; } = new($"Text{nameof(MWColors.Red300)}", $".Text{nameof(MWColors.Red300)}{{color:{MWColors.Red300};}}");
    public static MicroWind TextRed400 { get; } = new($"Text{nameof(MWColors.Red400)}", $".Text{nameof(MWColors.Red400)}{{color:{MWColors.Red400};}}");
    public static MicroWind TextRed500 { get; } = new($"Text{nameof(MWColors.Red500)}", $".Text{nameof(MWColors.Red500)}{{color:{MWColors.Red500};}}");
    public static MicroWind TextRed600 { get; } = new($"Text{nameof(MWColors.Red600)}", $".Text{nameof(MWColors.Red600)}{{color:{MWColors.Red600};}}");
    public static MicroWind TextRed700 { get; } = new($"Text{nameof(MWColors.Red700)}", $".Text{nameof(MWColors.Red700)}{{color:{MWColors.Red700};}}");
    public static MicroWind TextRed800 { get; } = new($"Text{nameof(MWColors.Red800)}", $".Text{nameof(MWColors.Red800)}{{color:{MWColors.Red800};}}");
    public static MicroWind TextRed900 { get; } = new($"Text{nameof(MWColors.Red900)}", $".Text{nameof(MWColors.Red900)}{{color:{MWColors.Red900};}}");

    // Rose
    public static MicroWind TextRose50 { get; } = new($"Text{nameof(MWColors.Rose50)}", $".Text{nameof(MWColors.Rose50)}{{color:{MWColors.Rose50};}}");
    public static MicroWind TextRose100 { get; } = new($"Text{nameof(MWColors.Rose100)}", $".Text{nameof(MWColors.Rose100)}{{color:{MWColors.Rose100};}}");
    public static MicroWind TextRose200 { get; } = new($"Text{nameof(MWColors.Rose200)}", $".Text{nameof(MWColors.Rose200)}{{color:{MWColors.Rose200};}}");
    public static MicroWind TextRose300 { get; } = new($"Text{nameof(MWColors.Rose300)}", $".Text{nameof(MWColors.Rose300)}{{color:{MWColors.Rose300};}}");
    public static MicroWind TextRose400 { get; } = new($"Text{nameof(MWColors.Rose400)}", $".Text{nameof(MWColors.Rose400)}{{color:{MWColors.Rose400};}}");
    public static MicroWind TextRose500 { get; } = new($"Text{nameof(MWColors.Rose500)}", $".Text{nameof(MWColors.Rose500)}{{color:{MWColors.Rose500};}}");
    public static MicroWind TextRose600 { get; } = new($"Text{nameof(MWColors.Rose600)}", $".Text{nameof(MWColors.Rose600)}{{color:{MWColors.Rose600};}}");
    public static MicroWind TextRose700 { get; } = new($"Text{nameof(MWColors.Rose700)}", $".Text{nameof(MWColors.Rose700)}{{color:{MWColors.Rose700};}}");
    public static MicroWind TextRose800 { get; } = new($"Text{nameof(MWColors.Rose800)}", $".Text{nameof(MWColors.Rose800)}{{color:{MWColors.Rose800};}}");
    public static MicroWind TextRose900 { get; } = new($"Text{nameof(MWColors.Rose900)}", $".Text{nameof(MWColors.Rose900)}{{color:{MWColors.Rose900};}}");

    // Sky
    public static MicroWind TextSky50 { get; } = new($"Text{nameof(MWColors.Sky50)}", $".Text{nameof(MWColors.Sky50)}{{color:{MWColors.Sky50};}}");
    public static MicroWind TextSky100 { get; } = new($"Text{nameof(MWColors.Sky100)}", $".Text{nameof(MWColors.Sky100)}{{color:{MWColors.Sky100};}}");
    public static MicroWind TextSky200 { get; } = new($"Text{nameof(MWColors.Sky200)}", $".Text{nameof(MWColors.Sky200)}{{color:{MWColors.Sky200};}}");
    public static MicroWind TextSky300 { get; } = new($"Text{nameof(MWColors.Sky300)}", $".Text{nameof(MWColors.Sky300)}{{color:{MWColors.Sky300};}}");
    public static MicroWind TextSky400 { get; } = new($"Text{nameof(MWColors.Sky400)}", $".Text{nameof(MWColors.Sky400)}{{color:{MWColors.Sky400};}}");
    public static MicroWind TextSky500 { get; } = new($"Text{nameof(MWColors.Sky500)}", $".Text{nameof(MWColors.Sky500)}{{color:{MWColors.Sky500};}}");
    public static MicroWind TextSky600 { get; } = new($"Text{nameof(MWColors.Sky600)}", $".Text{nameof(MWColors.Sky600)}{{color:{MWColors.Sky600};}}");
    public static MicroWind TextSky700 { get; } = new($"Text{nameof(MWColors.Sky700)}", $".Text{nameof(MWColors.Sky700)}{{color:{MWColors.Sky700};}}");
    public static MicroWind TextSky800 { get; } = new($"Text{nameof(MWColors.Sky800)}", $".Text{nameof(MWColors.Sky800)}{{color:{MWColors.Sky800};}}");
    public static MicroWind TextSky900 { get; } = new($"Text{nameof(MWColors.Sky900)}", $".Text{nameof(MWColors.Sky900)}{{color:{MWColors.Sky900};}}");

    // Teal
    public static MicroWind TextTeal50 { get; } = new($"Text{nameof(MWColors.Teal50)}", $".Text{nameof(MWColors.Teal50)}{{color:{MWColors.Teal50};}}");
    public static MicroWind TextTeal100 { get; } = new($"Text{nameof(MWColors.Teal100)}", $".Text{nameof(MWColors.Teal100)}{{color:{MWColors.Teal100};}}");
    public static MicroWind TextTeal200 { get; } = new($"Text{nameof(MWColors.Teal200)}", $".Text{nameof(MWColors.Teal200)}{{color:{MWColors.Teal200};}}");
    public static MicroWind TextTeal300 { get; } = new($"Text{nameof(MWColors.Teal300)}", $".Text{nameof(MWColors.Teal300)}{{color:{MWColors.Teal300};}}");
    public static MicroWind TextTeal400 { get; } = new($"Text{nameof(MWColors.Teal400)}", $".Text{nameof(MWColors.Teal400)}{{color:{MWColors.Teal400};}}");
    public static MicroWind TextTeal500 { get; } = new($"Text{nameof(MWColors.Teal500)}", $".Text{nameof(MWColors.Teal500)}{{color:{MWColors.Teal500};}}");
    public static MicroWind TextTeal600 { get; } = new($"Text{nameof(MWColors.Teal600)}", $".Text{nameof(MWColors.Teal600)}{{color:{MWColors.Teal600};}}");
    public static MicroWind TextTeal700 { get; } = new($"Text{nameof(MWColors.Teal700)}", $".Text{nameof(MWColors.Teal700)}{{color:{MWColors.Teal700};}}");
    public static MicroWind TextTeal800 { get; } = new($"Text{nameof(MWColors.Teal800)}", $".Text{nameof(MWColors.Teal800)}{{color:{MWColors.Teal800};}}");
    public static MicroWind TextTeal900 { get; } = new($"Text{nameof(MWColors.Teal900)}", $".Text{nameof(MWColors.Teal900)}{{color:{MWColors.Teal900};}}");

    // TrueGray
    public static MicroWind TextTrueGray50 { get; } = new($"Text{nameof(MWColors.TrueGray50)}", $".Text{nameof(MWColors.TrueGray50)}{{color:{MWColors.TrueGray50};}}");
    public static MicroWind TextTrueGray100 { get; } = new($"Text{nameof(MWColors.TrueGray100)}", $".Text{nameof(MWColors.TrueGray100)}{{color:{MWColors.TrueGray100};}}");
    public static MicroWind TextTrueGray200 { get; } = new($"Text{nameof(MWColors.TrueGray200)}", $".Text{nameof(MWColors.TrueGray200)}{{color:{MWColors.TrueGray200};}}");
    public static MicroWind TextTrueGray300 { get; } = new($"Text{nameof(MWColors.TrueGray300)}", $".Text{nameof(MWColors.TrueGray300)}{{color:{MWColors.TrueGray300};}}");
    public static MicroWind TextTrueGray400 { get; } = new($"Text{nameof(MWColors.TrueGray400)}", $".Text{nameof(MWColors.TrueGray400)}{{color:{MWColors.TrueGray400};}}");
    public static MicroWind TextTrueGray500 { get; } = new($"Text{nameof(MWColors.TrueGray500)}", $".Text{nameof(MWColors.TrueGray500)}{{color:{MWColors.TrueGray500};}}");
    public static MicroWind TextTrueGray600 { get; } = new($"Text{nameof(MWColors.TrueGray600)}", $".Text{nameof(MWColors.TrueGray600)}{{color:{MWColors.TrueGray600};}}");
    public static MicroWind TextTrueGray700 { get; } = new($"Text{nameof(MWColors.TrueGray700)}", $".Text{nameof(MWColors.TrueGray700)}{{color:{MWColors.TrueGray700};}}");
    public static MicroWind TextTrueGray800 { get; } = new($"Text{nameof(MWColors.TrueGray800)}", $".Text{nameof(MWColors.TrueGray800)}{{color:{MWColors.TrueGray800};}}");
    public static MicroWind TextTrueGray900 { get; } = new($"Text{nameof(MWColors.TrueGray900)}", $".Text{nameof(MWColors.TrueGray900)}{{color:{MWColors.TrueGray900};}}");

    // Violet
    public static MicroWind TextViolet50 { get; } = new($"Text{nameof(MWColors.Violet50)}", $".Text{nameof(MWColors.Violet50)}{{color:{MWColors.Violet50};}}");
    public static MicroWind TextViolet100 { get; } = new($"Text{nameof(MWColors.Violet100)}", $".Text{nameof(MWColors.Violet100)}{{color:{MWColors.Violet100};}}");
    public static MicroWind TextViolet200 { get; } = new($"Text{nameof(MWColors.Violet200)}", $".Text{nameof(MWColors.Violet200)}{{color:{MWColors.Violet200};}}");
    public static MicroWind TextViolet300 { get; } = new($"Text{nameof(MWColors.Violet300)}", $".Text{nameof(MWColors.Violet300)}{{color:{MWColors.Violet300};}}");
    public static MicroWind TextViolet400 { get; } = new($"Text{nameof(MWColors.Violet400)}", $".Text{nameof(MWColors.Violet400)}{{color:{MWColors.Violet400};}}");
    public static MicroWind TextViolet500 { get; } = new($"Text{nameof(MWColors.Violet500)}", $".Text{nameof(MWColors.Violet500)}{{color:{MWColors.Violet500};}}");
    public static MicroWind TextViolet600 { get; } = new($"Text{nameof(MWColors.Violet600)}", $".Text{nameof(MWColors.Violet600)}{{color:{MWColors.Violet600};}}");
    public static MicroWind TextViolet700 { get; } = new($"Text{nameof(MWColors.Violet700)}", $".Text{nameof(MWColors.Violet700)}{{color:{MWColors.Violet700};}}");
    public static MicroWind TextViolet800 { get; } = new($"Text{nameof(MWColors.Violet800)}", $".Text{nameof(MWColors.Violet800)}{{color:{MWColors.Violet800};}}");
    public static MicroWind TextViolet900 { get; } = new($"Text{nameof(MWColors.Violet900)}", $".Text{nameof(MWColors.Violet900)}{{color:{MWColors.Violet900};}}");

    // WarmGray
    public static MicroWind TextWarmGray50 { get; } = new($"Text{nameof(MWColors.WarmGray50)}", $".Text{nameof(MWColors.WarmGray50)}{{color:{MWColors.WarmGray50};}}");
    public static MicroWind TextWarmGray100 { get; } = new($"Text{nameof(MWColors.WarmGray100)}", $".Text{nameof(MWColors.WarmGray100)}{{color:{MWColors.WarmGray100};}}");
    public static MicroWind TextWarmGray200 { get; } = new($"Text{nameof(MWColors.WarmGray200)}", $".Text{nameof(MWColors.WarmGray200)}{{color:{MWColors.WarmGray200};}}");
    public static MicroWind TextWarmGray300 { get; } = new($"Text{nameof(MWColors.WarmGray300)}", $".Text{nameof(MWColors.WarmGray300)}{{color:{MWColors.WarmGray300};}}");
    public static MicroWind TextWarmGray400 { get; } = new($"Text{nameof(MWColors.WarmGray400)}", $".Text{nameof(MWColors.WarmGray400)}{{color:{MWColors.WarmGray400};}}");
    public static MicroWind TextWarmGray500 { get; } = new($"Text{nameof(MWColors.WarmGray500)}", $".Text{nameof(MWColors.WarmGray500)}{{color:{MWColors.WarmGray500};}}");
    public static MicroWind TextWarmGray600 { get; } = new($"Text{nameof(MWColors.WarmGray600)}", $".Text{nameof(MWColors.WarmGray600)}{{color:{MWColors.WarmGray600};}}");
    public static MicroWind TextWarmGray700 { get; } = new($"Text{nameof(MWColors.WarmGray700)}", $".Text{nameof(MWColors.WarmGray700)}{{color:{MWColors.WarmGray700};}}");
    public static MicroWind TextWarmGray800 { get; } = new($"Text{nameof(MWColors.WarmGray800)}", $".Text{nameof(MWColors.WarmGray800)}{{color:{MWColors.WarmGray800};}}");
    public static MicroWind TextWarmGray900 { get; } = new($"Text{nameof(MWColors.WarmGray900)}", $".Text{nameof(MWColors.WarmGray900)}{{color:{MWColors.WarmGray900};}}");

    // White
    public static MicroWind TextWhite { get; } = new($"Text{nameof(MWColors.White)}", $".Text{nameof(MWColors.White)}{{color:{MWColors.White};}}");

    // Yellow
    public static MicroWind TextYellow50 { get; } = new($"Text{nameof(MWColors.Yellow50)}", $".Text{nameof(MWColors.Yellow50)}{{color:{MWColors.Yellow50};}}");
    public static MicroWind TextYellow100 { get; } = new($"Text{nameof(MWColors.Yellow100)}", $".Text{nameof(MWColors.Yellow100)}{{color:{MWColors.Yellow100};}}");
    public static MicroWind TextYellow200 { get; } = new($"Text{nameof(MWColors.Yellow200)}", $".Text{nameof(MWColors.Yellow200)}{{color:{MWColors.Yellow200};}}");
    public static MicroWind TextYellow300 { get; } = new($"Text{nameof(MWColors.Yellow300)}", $".Text{nameof(MWColors.Yellow300)}{{color:{MWColors.Yellow300};}}");
    public static MicroWind TextYellow400 { get; } = new($"Text{nameof(MWColors.Yellow400)}", $".Text{nameof(MWColors.Yellow400)}{{color:{MWColors.Yellow400};}}");
    public static MicroWind TextYellow500 { get; } = new($"Text{nameof(MWColors.Yellow500)}", $".Text{nameof(MWColors.Yellow500)}{{color:{MWColors.Yellow500};}}");
    public static MicroWind TextYellow600 { get; } = new($"Text{nameof(MWColors.Yellow600)}", $".Text{nameof(MWColors.Yellow600)}{{color:{MWColors.Yellow600};}}");
    public static MicroWind TextYellow700 { get; } = new($"Text{nameof(MWColors.Yellow700)}", $".Text{nameof(MWColors.Yellow700)}{{color:{MWColors.Yellow700};}}");
    public static MicroWind TextYellow800 { get; } = new($"Text{nameof(MWColors.Yellow800)}", $".Text{nameof(MWColors.Yellow800)}{{color:{MWColors.Yellow800};}}");
    public static MicroWind TextYellow900 { get; } = new($"Text{nameof(MWColors.Yellow900)}", $".Text{nameof(MWColors.Yellow900)}{{color:{MWColors.Yellow900};}}");

    // Part 1: Layout

    public static MicroWind AspectRatioAuto { get; } = new("AspectRatioAuto", ".AspectRatioAuto{aspect-ratio:auto}");
    public static MicroWind AspectRatioSquare { get; } = new("AspectRatioSquare", ".AspectRatioSquare{aspect-ratio:1/1}");
    public static MicroWind AspectRatioVideo { get; } = new("AspectRatioVideo", ".AspectRatioVideo{aspect-ratio:16/9}");

    public static MicroWind Container { get; } = new("Container", ".container{width:100%;}");

    // Columns
    public static MicroWind Columns1 { get; } = new("Columns1", ".columns-1{columns:1;}");
    public static MicroWind Columns32 { get; } = new("Columns32", ".columns-32{columns:32;}");
    public static MicroWind Columns3 { get; } = new("Columns3", ".columns-3{columns:3;}");
    public static MicroWind Columns4 { get; } = new("Columns4", ".columns-4{columns:4;}");
    public static MicroWind Columns5 { get; } = new("Columns5", ".columns-5{columns:5;}");
    public static MicroWind Columns6 { get; } = new("Columns6", ".columns-6{columns:6;}");
    public static MicroWind Columns7 { get; } = new("Columns7", ".columns-7{columns:7;}");
    public static MicroWind Columns8 { get; } = new("Columns8", ".columns-8{columns:8;}");
    public static MicroWind Columns9 { get; } = new("Columns9", ".columns-9{columns:9;}");
    public static MicroWind Columns10 { get; } = new("Columns10", ".columns-10{columns:10;}");
    public static MicroWind Columns11 { get; } = new("Columns11", ".columns-11{columns:11;}");
    public static MicroWind Columns132 { get; } = new("Columns132", ".columns-132{columns:132;}");
    public static MicroWind ColumnsAuto { get; } = new("ColumnsAuto", ".columns-auto{columns:auto;}");
    public static MicroWind Columns3xs { get; } = new("Columns3xs", ".columns-3xs{columns:16rem;}");
    public static MicroWind Columns32xs { get; } = new("Columns32xs", ".columns-32xs{columns:18rem;}");
    public static MicroWind ColumnsXs { get; } = new("ColumnsXs", ".columns-xs{columns:320rem;}");
    public static MicroWind ColumnsSm { get; } = new("ColumnsSm", ".columns-sm{columns:324rem;}");
    public static MicroWind ColumnsMd { get; } = new("ColumnsMd", ".columns-md{columns:328rem;}");
    public static MicroWind ColumnsLg { get; } = new("ColumnsLg", ".columns-lg{columns:332rem;}");
    public static MicroWind ColumnsXl { get; } = new("ColumnsXl", ".columns-xl{columns:36rem;}");
    public static MicroWind Columns32xl { get; } = new("Columns32xl", ".columns-32xl{columns:432rem;}");
    public static MicroWind Columns3xl { get; } = new("Columns3xl", ".columns-3xl{columns:48rem;}");
    public static MicroWind Columns4xl { get; } = new("Columns4xl", ".columns-4xl{columns:56rem;}");
    public static MicroWind Columns5xl { get; } = new("Columns5xl", ".columns-5xl{columns:64rem;}");
    public static MicroWind Columns6xl { get; } = new("Columns6xl", ".columns-6xl{columns:732rem;}");
    public static MicroWind Columns7xl { get; } = new("Columns7xl", ".columns-7xl{columns:80rem;}");

    // Break After
    public static MicroWind BreakAfterAuto { get; } = new("BreakAfterAuto",".break-after-auto{break-after:auto;}");
    public static MicroWind BreakAfterAvoid { get; } = new("BreakAfterAvoid",".break-after-avoid{break-after:avoid;}");
    public static MicroWind BreakAfterAll { get; } = new("BreakAfterAll",".break-after-all{break-after:all;}");
    public static MicroWind BreakAfterAvoidPage { get; } =new("BreakAfterAvoidPage",".break-after-avoid-page{break-after:avoid-page;}");
    public static MicroWind BreakAfterPage { get; } = new("BreakAfterPage",".break-after-page{break-after:page;}");
    public static MicroWind BreakAfterLeft { get; } = new("BreakAfterLeft",".break-after-left{break-after:left;}");
    public static MicroWind BreakAfterRight { get; } = new("BreakAfterRight",".break-after-right{break-after:right;}");
    public static MicroWind BreakAfterColumn { get; } = new("BreakAfterColumn",".break-after-column{break-after:column;}");

    // Break Before
    public static MicroWind BreakBeforeAuto { get; } = new("BreakBeforeAuto",".break-before-auto{break-before:auto;}");
    public static MicroWind BreakBeforeAvoid { get; } = new("BreakBeforeAvoid",".break-before-avoid{break-before:avoid;}");
    public static MicroWind BreakBeforeAll { get; } = new("BreakBeforeAll",".break-before-all{break-before:all;}");
    public static MicroWind BreakBeforeAvoidPage { get; }=new("BreakBeforeAvoidPage",".break-before-avoid-page{break-before:avoid-page;}");
    public static MicroWind BreakBeforePage { get; } = new("BreakBeforePage",".break-before-page{break-before:page;}");
    public static MicroWind BreakBeforeLeft { get; } = new("BreakBeforeLeft",".break-before-left{break-before:left;}");
    public static MicroWind BreakBeforeRight { get; } = new("BreakBeforeRight",".break-before-right{break-before:right;}");
    public static MicroWind BreakBeforeColumn { get; } =new("BreakBeforeColumn",".break-before-column{break-before:column;}");

    // Break Inside
    public static MicroWind BreakInsideAuto { get; } = new("BreakInsideAuto", ".BreakInsideAuto{break-inside:auto;}");
    public static MicroWind BreakInsideAvoid { get; } = new("BreakInsideAvoid", ".BreakInsideAvoid{break-inside:avoid;}");
    public static MicroWind BreakInsideAvoidPage { get; } = new("BreakInsideAvoidPage", ".BreakInsideAvoidPage{break-inside:avoid-page;}");
    public static MicroWind BreakInsideAvoidColumn { get; } = new("BreakInsideAvoidColumn", ".BreakInsideAvoidColumn{break-inside:avoid-column;}");

    // Box Decoration Break
    public static MicroWind DecorationBreakSlice { get; } = new("DecorationBreakSlice", ".DecorationBreakSlice{box-decoration-break:slice;}");
    public static MicroWind DecorationBreakClone { get; } = new("DecorationBreakClone", ".DecorationBreakClone{box-decoration-break:clone;}");

    // Box Sizing
    public static MicroWind SizingBorderBox { get; } = new("SizingBorderBox", ".SizingBorderBox{box-sizing:border-box;}");
    public static MicroWind SizingContentBox { get; } = new("SizingContentBox", ".SizingContentBox{box-sizing:content-box;}");

    // Display
    public static MicroWind DisplayBlock { get; } = new("DisplayBlock", ".DisplayBlock{display:block;}");
    public static MicroWind DisplayInline { get; } = new("DisplayInline", ".DisplayInline{display:inline;}");
    public static MicroWind DisplayInlineBlock { get; } = new("DisplayInlineBlock", ".DisplayInlineBlock{display:inline-block;}");
    public static MicroWind DisplayFlex { get; } = new("DisplayFlex", ".DisplayFlex{display:flex;}");
    public static MicroWind DisplayInlineFlex { get; } = new("DisplayInlineFlex", ".DisplayInlineFlex{display:inline-flex;}");
    public static MicroWind DisplayTable { get; } = new("DisplayTable", ".DisplayTable{display:table;}");
    public static MicroWind DisplayInlineTable { get; } = new("DisplayInlineTable", ".DisplayInlineTable{display:inline-table;}");
    public static MicroWind DisplayTableCaption { get; } = new("DisplayTableCaption", ".DisplayTableCaption{display:table-caption;}");
    public static MicroWind DisplayTableCell { get; } = new("DisplayTableCell", ".DisplayTableCell{display:table-cell;}");
    public static MicroWind DisplayTableColumn { get; } = new("DisplayTableColumn", ".DisplayTableColumn{display:table-column;}");
    public static MicroWind DisplayTableColumnGroup { get; } = new("DisplayTableColumnGroup", ".DisplayTableColumnGroup{display:table-column-group;}");
    public static MicroWind DisplayTableFooterGroup { get; } = new("DisplayTableFooterGroup", ".DisplayTableFooterGroup{display:table-footer-group;}");
    public static MicroWind DisplayTableHeaderGroup { get; } = new("DisplayTableHeaderGroup", ".DisplayTableHeaderGroup{display:table-header-group;}");
    public static MicroWind DisplayTableRowGroup { get; } = new("DisplayTableRowGroup", ".DisplayTableRowGroup{display:table-row-group;}");
    public static MicroWind DisplayTableRow { get; } = new("DisplayTableRow", ".DisplayTableRow{display:table-row;}");
    public static MicroWind DisplayFlowRoot { get; } = new("DisplayFlowRoot", ".DisplayFlowRoot{display:flow-root;}");
    public static MicroWind DisplayGrid { get; } = new("DisplayGrid", ".DisplayGrid{display:grid;}");
    public static MicroWind DisplayInlineGrid { get; } = new("DisplayInlineGrid", ".DisplayInlineGrid{display:inline-grid;}");
    public static MicroWind DisplayContents { get; } = new("DisplayContents", ".DisplayContents{display:contents;}");
    public static MicroWind DisplayListItem { get; } = new("DisplayListItem", ".DisplayListItem{display:list-item;}");
    public static MicroWind DisplayHidden { get; } = new("DisplayHidden", ".DisplayHidden{display:none;}");

    // Floats
    public static MicroWind FloatStart { get; } = new("FloatStart", ".FloatStart{float:inline-start;}");
    public static MicroWind FloatEnd { get; } = new("FloatEnd", ".FloatEnd{float:inline-end;}");
    public static MicroWind FloatLeft { get; } = new("FloatLeft", ".FloatLeft{float:left;}");
    public static MicroWind FloatRight { get; } = new("FloatRight", ".FloatRight{float:right;}");
    public static MicroWind FloatNone { get; } = new("FloatNone", ".FloatNone{float:none;}");

    // Clear
    public static MicroWind ClearStart { get; } = new("ClearStart", ".ClearStart{clear:inline-start;}");
    public static MicroWind ClearEnd { get; } = new("ClearEnd", ".ClearEnd{clear:inline-end;}");
    public static MicroWind ClearLeft { get; } = new("ClearLeft", ".ClearLeft{clear:left;}");
    public static MicroWind ClearRight { get; } = new("ClearRight", ".ClearRight{clear:right;}");
    public static MicroWind ClearBoth { get; } = new("ClearBoth", ".ClearBoth{clear:both;}");
    public static MicroWind ClearNone { get; } = new("ClearNone", ".ClearNone{clear:none;}");

    // Isolation
    public static MicroWind IsolationAuto { get; } = new("IsolationAuto", ".IsolationAuto{isolation:auto;}");
    public static MicroWind Isolate { get; } = new("Isolate", ".Isolate{isolation:isolate;}");

    // Object Fit
    public static MicroWind ObjectFitFill { get; } = new("ObjectFitFill", ".ObjectFitFill{object-fit:fill;}");
    public static MicroWind ObjectFitContain { get; } = new("ObjectFitContain", ".ObjectFitContain{object-fit:contain;}");
    public static MicroWind ObjectFitCover { get; } = new("ObjectFitCover", ".ObjectFitCover{object-fit:cover;}");
    public static MicroWind ObjectFitNone { get; } = new("ObjectFitNone", ".ObjectFitNone{object-fit:none;}");
    public static MicroWind ObjectFitScaleDown { get; } = new("ObjectFitScaleDown", ".ObjectFitScaleDown{object-fit:scale-down;}");

    // Object Position
    public static MicroWind ObjectPositionBottom { get; } = new("ObjectPositionBottom", ".ObjectPositionBottom{object-position:bottom;}");
    public static MicroWind ObjectPositionCenter { get; } = new("ObjectPositionCenter", ".ObjectPositionCenter{object-position:center;}");
    public static MicroWind ObjectPositionLeft { get; } = new("ObjectPositionLeft", ".ObjectPositionLeft{object-position:left;}");
    public static MicroWind ObjectPositionLeftBottom { get; } = new("ObjectPositionLeftBottom", ".ObjectPositionLeftBottom{object-position:left bottom;}");
    public static MicroWind ObjectPositionLeftTop { get; } = new("ObjectPositionLeftTop", ".ObjectPositionLeftTop{object-position:left top;}");
    public static MicroWind ObjectPositionRight { get; } = new("ObjectPositionRight", ".ObjectPositionRight{object-position:right;}");
    public static MicroWind ObjectPositionRightBottom { get; } = new("ObjectPositionRightBottom", ".ObjectPositionRightBottom{object-position:right bottom;}");
    public static MicroWind ObjectPositionRightTop { get; } = new("ObjectPositionRightTop", ".ObjectPositionRightTop{object-position:right top;}");
    public static MicroWind ObjectPositionTop { get; } = new("ObjectPositionTop", ".ObjectPositionTop{object-position:top;}");

    // Overflow
    public static MicroWind OverflowAuto { get; } = new("OverflowAuto", ".OverflowAuto{overflow:auto;}");
    public static MicroWind OverflowHidden { get; } = new("OverflowHidden", ".OverflowHidden{overflow:hidden;}");
    public static MicroWind OverflowClip { get; } = new("OverflowClip", ".OverflowClip{overflow:clip;}");
    public static MicroWind OverflowScroll { get; } = new("OverflowScroll", ".OverflowScroll{overflow:scroll;}");
    public static MicroWind OverflowVisible { get; } = new("OverflowVisible", ".OverflowVisible{overflow:visible;}");

    public static MicroWind OverflowXAuto { get; } = new("OverflowXAuto", ".OverflowXAuto{overflow-x:auto;}");
    public static MicroWind OverflowXHidden { get; } = new("OverflowXHidden", ".OverflowXHidden{overflow-x:hidden;}");
    public static MicroWind OverflowXClip { get; } = new("OverflowXClip", ".OverflowXClip{overflow-x:clip;}");
    public static MicroWind OverflowXScroll { get; } = new("OverflowXScroll", ".OverflowXScroll{overflow-x:scroll;}");
    public static MicroWind OverflowXVisible { get; } = new("OverflowXVisible", ".OverflowXVisible{overflow-x:visible;}");

    public static MicroWind OverflowYAuto { get; } = new("OverflowYAuto", ".OverflowYAuto{overflow-y:auto;}");
    public static MicroWind OverflowYHidden { get; } = new("OverflowYHidden", ".OverflowYHidden{overflow-y:hidden;}");
    public static MicroWind OverflowYClip { get; } = new("OverflowYClip", ".OverflowYClip{overflow-y:clip;}");
    public static MicroWind OverflowYScroll { get; } = new("OverflowYScroll", ".OverflowYScroll{overflow-y:scroll;}");
    public static MicroWind OverflowYVisible { get; } = new("OverflowYVisible", ".OverflowYVisible{overflow-y:visible;}");

    // Overscroll Behavior
    public static MicroWind OverscrollAuto { get; } = new("OverscrollAuto", ".OverscrollAuto{overscroll-behavior:auto;}");
    public static MicroWind OverscrollContain { get; } = new("OverscrollContain", ".OverscrollContain{overscroll-behavior:contain;}");
    public static MicroWind OverscrollNone { get; } = new("OverscrollNone", ".OverscrollNone{overscroll-behavior:none;}");

    public static MicroWind OverscrollXAuto { get; } = new("OverscrollXAuto", ".OverscrollXAuto{overscroll-behavior-x:auto;}");
    public static MicroWind OverscrollXContain { get; } = new("OverscrollXContain", ".OverscrollXContain{overscroll-behavior-x:contain;}");
    public static MicroWind OverscrollXNone { get; } = new("OverscrollXNone", ".OverscrollXNone{overscroll-behavior-x:none;}");

    public static MicroWind OverscrollYAuto { get; } = new("OverscrollYAuto", ".OverscrollYAuto{overscroll-behavior-y:auto;}");
    public static MicroWind OverscrollYContain { get; } = new("OverscrollYContain", ".OverscrollYContain{overscroll-behavior-y:contain;}");
    public static MicroWind OverscrollYNone { get; } = new("OverscrollYNone", ".OverscrollYNone{overscroll-behavior-y:none;}");

    // Position
    public static MicroWind PositionStatic { get; } = new("PositionStatic", ".PositionStatic{position:static;}");
    public static MicroWind PositionFixed { get; } = new("PositionFixed", ".PositionFixed{position:fixed;}");
    public static MicroWind PositionAbsolute { get; } = new("PositionAbsolute", ".PositionAbsolute{position:absolute;}");
    public static MicroWind PositionRelative { get; } = new("PositionRelative", ".PositionRelative{position:relative;}");
    public static MicroWind PositionSticky { get; } = new("PositionSticky", ".PositionSticky{position:sticky;}");


    // Top, Right, Bottom, Left (with only 0 value supported)
    public static MicroWind Top0 { get; } = new("Top0", ".Top0{top:0px;}");
    public static MicroWind Right0 { get; } = new("Right0", ".Right0{right:0px;}");
    public static MicroWind Bottom0 { get; } = new("Bottom0", ".Bottom0{bottom:0px;}");
    public static MicroWind Left0 { get; } = new("Left0", ".Left0{left:0px;}");
    public static MicroWind Start0 { get; } = new("Start0", ".Start0{inset-inline-start:0px;}");
    public static MicroWind End0 { get; } = new("End0", ".End0{inset-inline-end:0px;}");
    public static MicroWind Inset0 { get; } = new("Inset0", ".Inset0{inset:0px;}");

    public static MicroWind Top1 { get; } = new("Top1", ".Top1{top:1px;}");
    public static MicroWind Right1 { get; } = new("Right1", ".Right1{right:1px;}");
    public static MicroWind Bottom1 { get; } = new("Bottom1", ".Bottom1{bottom:1px;}");
    public static MicroWind Left1 { get; } = new("Left1", ".Left1{left:1px;}");
    public static MicroWind Start1 { get; } = new("Start1", ".Start1{inset-inline-start:1px;}");
    public static MicroWind End1 { get; } = new("End1", ".End1{inset-inline-end:1px;}");
    public static MicroWind Inset1 { get; } = new("Inset1", ".Inset1{inset:1px;}");

    public static MicroWind Top2 { get; } = new("Top2", ".Top2{top:2px;}");
    public static MicroWind Right2 { get; } = new("Right2", ".Right2{right:2px;}");
    public static MicroWind Bottom2 { get; } = new("Bottom2", ".Bottom2{bottom:2px;}");
    public static MicroWind Left2 { get; } = new("Left2", ".Left2{left:2px;}");
    public static MicroWind Start2 { get; } = new("Start2", ".Start2{inset-inline-start:2px;}");
    public static MicroWind End2 { get; } = new("End2", ".End2{inset-inline-end:2px;}");
    public static MicroWind Inset2 { get; } = new("Inset2", ".Inset2{inset:2px;}");

    public static MicroWind Top4 { get; } = new("Top4", ".Top4{top:4px;}");
    public static MicroWind Right4 { get; } = new("Right4", ".Right4{right:4px;}");
    public static MicroWind Bottom4 { get; } = new("Bottom4", ".Bottom4{bottom:4px;}");
    public static MicroWind Left4 { get; } = new("Left4", ".Left4{left:4px;}");
    public static MicroWind Start4 { get; } = new("Start4", ".Start4{inset-inline-start:4px;}");
    public static MicroWind End4 { get; } = new("End4", ".End4{inset-inline-end:4px;}");
    public static MicroWind Inset4 { get; } = new("Inset4", ".Inset4{inset:4px;}");

    public static MicroWind Top8 { get; } = new("Top8", ".Top8{top:8px;}");
    public static MicroWind Right8 { get; } = new("Right8", ".Right8{right:8px;}");
    public static MicroWind Bottom8 { get; } = new("Bottom8", ".Bottom8{bottom:8px;}");
    public static MicroWind Left8 { get; } = new("Left8", ".Left8{left:8px;}");
    public static MicroWind Start8 { get; } = new("Start8", ".Start8{inset-inline-start:8px;}");
    public static MicroWind End8 { get; } = new("End8", ".End8{inset-inline-end:8px;}");
    public static MicroWind Inset8 { get; } = new("Inset8", ".Inset8{inset:8px;}");

    public static MicroWind Top16 { get; } = new("Top16", ".Top16{top:16px;}");
    public static MicroWind Right16 { get; } = new("Right16", ".Right16{right:16px;}");
    public static MicroWind Bottom16 { get; } = new("Bottom16", ".Bottom16{bottom:16px;}");
    public static MicroWind Left16 { get; } = new("Left16", ".Left16{left:16px;}");
    public static MicroWind Start16 { get; } = new("Start16", ".Start16{inset-inline-start:16px;}");
    public static MicroWind End16 { get; } = new("End16", ".End16{inset-inline-end:16px;}");
    public static MicroWind Inset16 { get; } = new("Inset16", ".Inset16{inset:16px;}");

    public static MicroWind Top32 { get; } = new("Top32", ".Top32{top:32px;}");
    public static MicroWind Right32 { get; } = new("Right32", ".Right32{right:32px;}");
    public static MicroWind Bottom32 { get; } = new("Bottom32", ".Bottom32{bottom:32px;}");
    public static MicroWind Left32 { get; } = new("Left32", ".Left32{left:32px;}");
    public static MicroWind Start32 { get; } = new("Start32", ".Start32{inset-inline-start:32px;}");
    public static MicroWind End32 { get; } = new("End32", ".End32{inset-inline-end:32px;}");
    public static MicroWind Inset32 { get; } = new("Inset32", ".Inset32{inset:32px;}");

    // Visibility
    public static MicroWind VisibilityVisible { get; } = new("VisibilityVisible", ".VisibilityVisible{visibility:visible;}");
    public static MicroWind VisibilityHidden { get; } = new("VisibilityHidden", ".VisibilityHidden{visibility:hidden;}");
    public static MicroWind VisibilityCollapse { get; } = new("VisibilityCollapse", ".VisibilityCollapse{visibility:collapse;}");

    // Z Index
    public static MicroWind Z0 { get; } = new("Z0", ".Z0{z-index:0;}");
    public static MicroWind Z10 { get; } = new("Z10", ".Z10{z-index:10;}");
    public static MicroWind Z320 { get; } = new("Z320", ".Z320{z-index:320;}");
    public static MicroWind Z30 { get; } = new("Z30", ".Z30{z-index:30;}");
    public static MicroWind Z40 { get; } = new("Z40", ".Z40{z-index:40;}");
    public static MicroWind Z50 { get; } = new("Z50", ".Z50{z-index:50;}");

    // Part 2: Flexbox & Grid

    // Flex Direction
    public static MicroWind FlexRow { get; } = new("FlexRow", ".FlexRow{flex-direction:row;}");
    public static MicroWind FlexRowReverse { get; } = new("FlexRowReverse", ".FlexRowReverse{flex-direction:row-reverse;}");
    public static MicroWind FlexCol { get; } = new("FlexCol", ".FlexCol{flex-direction:column;}");
    public static MicroWind FlexColReverse { get; } = new("FlexColReverse", ".FlexColReverse{flex-direction:column-reverse;}");

    // Flex Wrap
    public static MicroWind FlexWrap { get; } = new("FlexWrap", ".FlexWrap{flex-wrap:wrap;}");
    public static MicroWind FlexWrapReverse { get; } = new("FlexWrapReverse", ".FlexWrapReverse{flex-wrap:wrap-reverse;}");
    public static MicroWind FlexNoWrap { get; } = new("FlexNoWrap", ".FlexNoWrap{flex-wrap:nowrap;}");

    // Flex
    public static MicroWind Flex1 { get; } = new("Flex1", ".Flex1{flex:1 1 0%;}");
    public static MicroWind FlexAuto { get; } = new("FlexAuto", ".FlexAuto{flex:1 1 auto;}");
    public static MicroWind FlexInitial { get; } = new("FlexInitial", ".FlexInitial{flex:0 1 auto;}");
    public static MicroWind FlexNone { get; } = new("FlexNone", ".FlexNone{flex:none;}");

    // Flex Grow
    public static MicroWind FlexGrow { get; } = new("FlexGrow", ".FlexGrow{flex-grow:1;}");
    public static MicroWind FlexGrow0 { get; } = new("FlexGrow0", ".FlexGrow0{flex-grow:0;}");

    // Flex Shrink
    public static MicroWind FlexShrink { get; } = new("FlexShrink", ".FlexShrink{flex-shrink:1;}");
    public static MicroWind FlexShrink0 { get; } = new("FlexShrink0", ".FlexShrink0{flex-shrink:0;}");

    // Grid Cols
    public static MicroWind GridCols1 { get; } = new("GridCols1", ".GridCols1{grid-template-columns:repeat(1, minmax(0, 1fr));}");
    public static MicroWind GridCols2 { get; } = new("GridCols2", ".GridCols2{grid-template-columns:repeat(2, minmax(0, 1fr));}");
    public static MicroWind GridCols3 { get; } = new("GridCols3", ".GridCols3{grid-template-columns:repeat(3, minmax(0, 1fr));}");
    public static MicroWind GridCols4 { get; } = new("GridCols4", ".GridCols4{grid-template-columns:repeat(4, minmax(0, 1fr));}");
    public static MicroWind GridCols5 { get; } = new("GridCols5", ".GridCols5{grid-template-columns:repeat(5, minmax(0, 1fr));}");
    public static MicroWind GridCols6 { get; } = new("GridCols6", ".GridCols6{grid-template-columns:repeat(6, minmax(0, 1fr));}");
    public static MicroWind GridCols7 { get; } = new("GridCols7", ".GridCols7{grid-template-columns:repeat(7, minmax(0, 1fr));}");
    public static MicroWind GridCols8 { get; } = new("GridCols8", ".GridCols8{grid-template-columns:repeat(8, minmax(0, 1fr));}");
    public static MicroWind GridCols9 { get; } = new("GridCols9", ".GridCols9{grid-template-columns:repeat(9, minmax(0, 1fr));}");
    public static MicroWind GridCols10 { get; } = new("GridCols10", ".GridCols10{grid-template-columns:repeat(10, minmax(0, 1fr));}");
    public static MicroWind GridCols11 { get; } = new("GridCols11", ".GridCols11{grid-template-columns:repeat(11, minmax(0, 1fr));}");
    public static MicroWind GridCols12 { get; } = new("GridCols12", ".GridCols12{grid-template-columns:repeat(12, minmax(0, 1fr));}");
    public static MicroWind GridColsNone { get; } = new("GridColsNone", ".GridColsNone{grid-template-columns:none;}");
    public static MicroWind GridColsSubgrid { get; } = new("GridColsSubgrid", ".GridColsSubgrid{grid-template-columns:subgrid;}");


    public static MicroWind ColAuto { get; } = new("ColAuto", ".ColAuto{grid-column:auto;}");
    public static MicroWind ColSpan1 { get; } = new("ColSpan1", ".ColSpan1{grid-column:span 1 / span 1;}");
    public static MicroWind ColSpan2 { get; } = new("ColSpan2", ".ColSpan2{grid-column:span 2 / span 2;}");
    public static MicroWind ColSpan3 { get; } = new("ColSpan3", ".ColSpan3{grid-column:span 3 / span 3;}");
    public static MicroWind ColSpan4 { get; } = new("ColSpan4", ".ColSpan4{grid-column:span 4 / span 4;}");
    public static MicroWind ColSpan5 { get; } = new("ColSpan5", ".ColSpan5{grid-column:span 5 / span 5;}");
    public static MicroWind ColSpan6 { get; } = new("ColSpan6", ".ColSpan6{grid-column:span 6 / span 6;}");
    public static MicroWind ColSpan7 { get; } = new("ColSpan7", ".ColSpan7{grid-column:span 7 / span 7;}");
    public static MicroWind ColSpan8 { get; } = new("ColSpan8", ".ColSpan8{grid-column:span 8 / span 8;}");
    public static MicroWind ColSpan9 { get; } = new("ColSpan9", ".ColSpan9{grid-column:span 9 / span 9;}");
    public static MicroWind ColSpan10 { get; } = new("ColSpan10", ".ColSpan10{grid-column:span 10 / span 10;}");
    public static MicroWind ColSpan11 { get; } = new("ColSpan11", ".ColSpan11{grid-column:span 11 / span 11;}");
    public static MicroWind ColSpan12 { get; } = new("ColSpan12", ".ColSpan12{grid-column:span 12 / span 12;}");
    public static MicroWind ColSpanFull { get; } = new("ColSpanFull", ".ColSpanFull{grid-column:1 / -1;}");


    public static MicroWind GridRows1 { get; } = new("GridRows1", ".GridRows1{grid-template-rows:repeat(1, minmax(0, 1fr));}");
    public static MicroWind GridRows2 { get; } = new("GridRows2", ".GridRows2{grid-template-rows:repeat(2, minmax(0, 1fr));}");
    public static MicroWind GridRows3 { get; } = new("GridRows3", ".GridRows3{grid-template-rows:repeat(3, minmax(0, 1fr));}");
    public static MicroWind GridRows4 { get; } = new("GridRows4", ".GridRows4{grid-template-rows:repeat(4, minmax(0, 1fr));}");
    public static MicroWind GridRows5 { get; } = new("GridRows5", ".GridRows5{grid-template-rows:repeat(5, minmax(0, 1fr));}");
    public static MicroWind GridRows6 { get; } = new("GridRows6", ".GridRows6{grid-template-rows:repeat(6, minmax(0, 1fr));}");
    public static MicroWind GridRows7 { get; } = new("GridRows7", ".GridRows7{grid-template-rows:repeat(7, minmax(0, 1fr));}");
    public static MicroWind GridRows8 { get; } = new("GridRows8", ".GridRows8{grid-template-rows:repeat(8, minmax(0, 1fr));}");
    public static MicroWind GridRows9 { get; } = new("GridRows9", ".GridRows9{grid-template-rows:repeat(9, minmax(0, 1fr));}");
    public static MicroWind GridRows10 { get; } = new("GridRows10", ".GridRows10{grid-template-rows:repeat(10, minmax(0, 1fr));}");
    public static MicroWind GridRows11 { get; } = new("GridRows11", ".GridRows11{grid-template-rows:repeat(11, minmax(0, 1fr));}");
    public static MicroWind GridRows12 { get; } = new("GridRows12", ".GridRows12{grid-template-rows:repeat(12, minmax(0, 1fr));}");
    public static MicroWind GridRowsNone { get; } = new("GridRowsNone", ".GridRowsNone{grid-template-rows:none;}");
    public static MicroWind GridRowsSubgrid { get; } = new("GridRowsSubgrid", ".GridRowsSubgrid{grid-template-rows:subgrid;}");


    public static MicroWind RowAuto { get; } = new("RowAuto", ".RowAuto{grid-row:auto;}");
    public static MicroWind RowSpan1 { get; } = new("RowSpan1", ".RowSpan1{grid-row:span 1 / span 1;}");
    public static MicroWind RowSpan2 { get; } = new("RowSpan2", ".RowSpan2{grid-row:span 2 / span 2;}");
    public static MicroWind RowSpan3 { get; } = new("RowSpan3", ".RowSpan3{grid-row:span 3 / span 3;}");
    public static MicroWind RowSpan4 { get; } = new("RowSpan4", ".RowSpan4{grid-row:span 4 / span 4;}");
    public static MicroWind RowSpan5 { get; } = new("RowSpan5", ".RowSpan5{grid-row:span 5 / span 5;}");
    public static MicroWind RowSpan6 { get; } = new("RowSpan6", ".RowSpan6{grid-row:span 6 / span 6;}");
    public static MicroWind RowSpan7 { get; } = new("RowSpan7", ".RowSpan7{grid-row:span 7 / span 7;}");
    public static MicroWind RowSpan8 { get; } = new("RowSpan8", ".RowSpan8{grid-row:span 8 / span 8;}");
    public static MicroWind RowSpan9 { get; } = new("RowSpan9", ".RowSpan9{grid-row:span 9 / span 9;}");
    public static MicroWind RowSpan10 { get; } = new("RowSpan10", ".RowSpan10{grid-row:span 10 / span 10;}");
    public static MicroWind RowSpan11 { get; } = new("RowSpan11", ".RowSpan11{grid-row:span 11 / span 11;}");
    public static MicroWind RowSpan12 { get; } = new("RowSpan12", ".RowSpan12{grid-row:span 12 / span 12;}");
    public static MicroWind RowSpanFull { get; } = new("RowSpanFull", ".RowSpanFull{grid-row:1 / -1;}");

    public static MicroWind GridFlowRow { get; } = new("GridFlowRow", ".GridFlowRow{grid-auto-flow:row;}");
    public static MicroWind GridFlowCol { get; } = new("GridFlowCol", ".GridFlowCol{grid-auto-flow:column;}");
    public static MicroWind GridFlowDense { get; } = new("GridFlowDense", ".GridFlowDense{grid-auto-flow:dense;}");
    public static MicroWind GridFlowRowDense { get; } = new("GridFlowRowDense", ".GridFlowRowDense{grid-auto-flow:row dense;}");
    public static MicroWind GridFlowColDense { get; } = new("GridFlowColDense", ".GridFlowColDense{grid-auto-flow:column dense;}");

    public static MicroWind AutoColsAuto { get; } = new("AutoColsAuto", ".AutoColsAuto{grid-auto-columns:auto;}");
    public static MicroWind AutoColsMin { get; } = new("AutoColsMin", ".AutoColsMin{grid-auto-columns:min-content;}");
    public static MicroWind AutoColsMax { get; } = new("AutoColsMax", ".AutoColsMax{grid-auto-columns:max-content;}");
    public static MicroWind AutoColsFr { get; } = new("AutoColsFr", ".AutoColsFr{grid-auto-columns:minmax(0, 1fr);}");

    public static MicroWind AutoRowsAuto { get; } = new("AutoRowsAuto", ".AutoRowsAuto{grid-auto-rows:auto;}");
    public static MicroWind AutoRowsMin { get; } = new("AutoRowsMin", ".AutoRowsMin{grid-auto-rows:min-content;}");
    public static MicroWind AutoRowsMax { get; } = new("AutoRowsMax", ".AutoRowsMax{grid-auto-rows:max-content;}");
    public static MicroWind AutoRowsFr { get; } = new("AutoRowsFr", ".AutoRowsFr{grid-auto-rows:minmax(0, 1fr);}");

    public static MicroWind Gap0 { get; } = new("Gap0", ".Gap0{gap:0px;}");
    public static MicroWind GapPx { get; } = new("GapPx", ".GapPx{gap:1px;}");
    public static MicroWind Gap1 { get; } = new("Gap1", ".Gap1{gap:0.25rem;}");
    public static MicroWind Gap2 { get; } = new("Gap2", ".Gap2{gap:0.5rem;}");
    public static MicroWind Gap4 { get; } = new("Gap4", ".Gap4{gap:1rem;}");
    public static MicroWind Gap8 { get; } = new("Gap8", ".Gap8{gap:2rem;}");
    public static MicroWind Gap16 { get; } = new("Gap16", ".Gap16{gap:4rem;}");
    public static MicroWind Gap32 { get; } = new("Gap32", ".Gap32{gap:8rem;}");

    public static MicroWind JustifyNormal { get; } = new("JustifyNormal", ".JustifyNormal{justify-content:normal;}");
    public static MicroWind JustifyStart { get; } = new("JustifyStart", ".JustifyStart{justify-content:flex-start;}");
    public static MicroWind JustifyEnd { get; } = new("JustifyEnd", ".JustifyEnd{justify-content:flex-end;}");
    public static MicroWind JustifyCenter { get; } = new("JustifyCenter", ".JustifyCenter{justify-content:center;}");
    public static MicroWind JustifyBetween { get; } = new("JustifyBetween", ".JustifyBetween{justify-content:space-between;}");
    public static MicroWind JustifyAround { get; } = new("JustifyAround", ".JustifyAround{justify-content:space-around;}");
    public static MicroWind JustifyEvenly { get; } = new("JustifyEvenly", ".JustifyEvenly{justify-content:space-evenly;}");
    public static MicroWind JustifyStretch { get; } = new("JustifyStretch", ".JustifyStretch{justify-content:stretch;}");

    public static MicroWind JustifyItemsStart { get; } = new("JustifyItemsStart", ".JustifyItemsStart{justify-items:start;}");
    public static MicroWind JustifyItemsEnd { get; } = new("JustifyItemsEnd", ".JustifyItemsEnd{justify-items:end;}");
    public static MicroWind JustifyItemsCenter { get; } = new("JustifyItemsCenter", ".JustifyItemsCenter{justify-items:center;}");
    public static MicroWind JustifyItemsStretch { get; } = new("JustifyItemsStretch", ".JustifyItemsStretch{justify-items:stretch;}");

    public static MicroWind JustifySelfAuto { get; } = new("JustifySelfAuto", ".JustifySelfAuto{justify-self:auto;}");
    public static MicroWind JustifySelfStart { get; } = new("JustifySelfStart", ".JustifySelfStart{justify-self:start;}");
    public static MicroWind JustifySelfEnd { get; } = new("JustifySelfEnd", ".JustifySelfEnd{justify-self:end;}");
    public static MicroWind JustifySelfCenter { get; } = new("JustifySelfCenter", ".JustifySelfCenter{justify-self:center;}");
    public static MicroWind JustifySelfStretch { get; } = new("JustifySelfStretch", ".JustifySelfStretch{justify-self:stretch;}");

    public static MicroWind ContentNormal { get; } = new("ContentNormal", ".ContentNormal{align-content:normal;}");
    public static MicroWind ContentStart { get; } = new("ContentStart", ".ContentStart{align-content:flex-start;}");
    public static MicroWind ContentEnd { get; } = new("ContentEnd", ".ContentEnd{align-content:flex-end;}");
    public static MicroWind ContentCenter { get; } = new("ContentCenter", ".ContentCenter{align-content:center;}");
    public static MicroWind ContentBetween { get; } = new("ContentBetween", ".ContentBetween{align-content:space-between;}");
    public static MicroWind ContentAround { get; } = new("ContentAround", ".ContentAround{align-content:space-around;}");
    public static MicroWind ContentEvenly { get; } = new("ContentEvenly", ".ContentEvenly{align-content:space-evenly;}");
    public static MicroWind ContentBaseline { get; } = new("ContentBaseline", ".ContentBaseline{align-content:baseline;}");
    public static MicroWind ContentStretch { get; } = new("ContentStretch", ".ContentStretch{align-content:stretch;}");

    public static MicroWind ItemsStart { get; } = new("ItemsStart", ".ItemsStart{align-items:flex-start;}");
    public static MicroWind ItemsEnd { get; } = new("ItemsEnd", ".ItemsEnd{align-items:flex-end;}");
    public static MicroWind ItemsCenter { get; } = new("ItemsCenter", ".ItemsCenter{align-items:center;}");
    public static MicroWind ItemsBaseline { get; } = new("ItemsBaseline", ".ItemsBaseline{align-items:baseline;}");
    public static MicroWind ItemsStretch { get; } = new("ItemsStretch", ".ItemsStretch{align-items:stretch;}");

    public static MicroWind SelfAuto { get; } = new("SelfAuto", ".SelfAuto{align-self:auto;}");
    public static MicroWind SelfStart { get; } = new("SelfStart", ".SelfStart{align-self:flex-start;}");
    public static MicroWind SelfEnd { get; } = new("SelfEnd", ".SelfEnd{align-self:flex-end;}");
    public static MicroWind SelfCenter { get; } = new("SelfCenter", ".SelfCenter{align-self:center;}");
    public static MicroWind SelfBaseline { get; } = new("SelfBaseline", ".SelfBaseline{align-self:baseline;}");
    public static MicroWind SelfStretch { get; } = new("SelfStretch", ".SelfStretch{align-self:stretch;}");

    public static MicroWind PlaceContentStart { get; } = new("PlaceContentStart", ".PlaceContentStart{place-content:start;}");
    public static MicroWind PlaceContentEnd { get; } = new("PlaceContentEnd", ".PlaceContentEnd{place-content:end;}");
    public static MicroWind PlaceContentCenter { get; } = new("PlaceContentCenter", ".PlaceContentCenter{place-content:center;}");
    public static MicroWind PlaceContentBetween { get; } = new("PlaceContentBetween", ".PlaceContentBetween{place-content:space-between;}");
    public static MicroWind PlaceContentAround { get; } = new("PlaceContentAround", ".PlaceContentAround{place-content:space-around;}");
    public static MicroWind PlaceContentEvenly { get; } = new("PlaceContentEvenly", ".PlaceContentEvenly{place-content:space-evenly;}");
    public static MicroWind PlaceContentStretch { get; } = new("PlaceContentStretch", ".PlaceContentStretch{place-content:stretch;}");

    public static MicroWind PlaceItemsStart { get; } = new("PlaceItemsStart", ".PlaceItemsStart{place-items:start;}");
    public static MicroWind PlaceItemsEnd { get; } = new("PlaceItemsEnd", ".PlaceItemsEnd{place-items:end;}");
    public static MicroWind PlaceItemsCenter { get; } = new("PlaceItemsCenter", ".PlaceItemsCenter{place-items:center;}");
    public static MicroWind PlaceItemsStretch { get; } = new("PlaceItemsStretch", ".PlaceItemsStretch{place-items:stretch;}");

    public static MicroWind PlaceSelfAuto { get; } = new("PlaceSelfAuto", ".PlaceSelfAuto{place-self:auto;}");
    public static MicroWind PlaceSelfStart { get; } = new("PlaceSelfStart", ".PlaceSelfStart{place-self:start;}");
    public static MicroWind PlaceSelfEnd { get; } = new("PlaceSelfEnd", ".PlaceSelfEnd{place-self:end;}");
    public static MicroWind PlaceSelfCenter { get; } = new("PlaceSelfCenter", ".PlaceSelfCenter{place-self:center;}");
    public static MicroWind PlaceSelfStretch { get; } = new("PlaceSelfStretch", ".PlaceSelfStretch{place-self:stretch;}");


    // Part 3: Spacing

 
    public static MicroWind P0 { get; } = new($"{nameof(P0)}", $".p-{nameof(MWSpace.S0)}{{{MWSpace.Padding}:{MWSpace.S0};}}");
    public static MicroWind P1 { get; } = new($"{nameof(P1)}", $".p-{nameof(MWSpace.S1)}{{{MWSpace.Padding}:{MWSpace.S1};}}");
    public static MicroWind P2 { get; } = new($"{nameof(P2)}", $".p-{nameof(MWSpace.S2)}{{{MWSpace.Padding}:{MWSpace.S2};}}");
    public static MicroWind P4 { get; } = new($"{nameof(P4)}", $".p-{nameof(MWSpace.S4)}{{{MWSpace.Padding}:{MWSpace.S4};}}");
    public static MicroWind P8 { get; } = new($"{nameof(P8)}", $".p-{nameof(MWSpace.S8)}{{{MWSpace.Padding}:{MWSpace.S8};}}");
    public static MicroWind P16 { get; } = new($"{nameof(P16)}", $".p-{nameof(MWSpace.S16)}{{{MWSpace.Padding}:{MWSpace.S16};}}");
    public static MicroWind P32 { get; } = new($"{nameof(P32)}", $".p-{nameof(MWSpace.S32)}{{{MWSpace.Padding}:{MWSpace.S32};}}");
    public static MicroWind PPx { get; } = new($"{nameof(PPx)}", $".p-{nameof(MWSpace.SPx)}{{{MWSpace.Padding}:{MWSpace.SPx};}}");

    public static MicroWind PT0 { get; } = new($"{nameof(PT0)}", $".pt-{nameof(MWSpace.S0)}{{{MWSpace.PaddingTop}:{MWSpace.S0};}}");
    public static MicroWind PT1 { get; } = new($"{nameof(PT1)}", $".pt-{nameof(MWSpace.S1)}{{{MWSpace.PaddingTop}:{MWSpace.S1};}}");
    public static MicroWind PT2 { get; } = new($"{nameof(PT2)}", $".pt-{nameof(MWSpace.S2)}{{{MWSpace.PaddingTop}:{MWSpace.S2};}}");
    public static MicroWind PT4 { get; } = new($"{nameof(PT4)}", $".pt-{nameof(MWSpace.S4)}{{{MWSpace.PaddingTop}:{MWSpace.S4};}}");
    public static MicroWind PT8 { get; } = new($"{nameof(PT8)}", $".pt-{nameof(MWSpace.S8)}{{{MWSpace.PaddingTop}:{MWSpace.S8};}}");
    public static MicroWind PT16 { get; } = new($"{nameof(PT16)}", $".pt-{nameof(MWSpace.S16)}{{{MWSpace.PaddingTop}:{MWSpace.S16};}}");
    public static MicroWind PT32 { get; } = new($"{nameof(PT32)}", $".pt-{nameof(MWSpace.S32)}{{{MWSpace.PaddingTop}:{MWSpace.S32};}}");
    public static MicroWind PTPx { get; } = new($"{nameof(PTPx)}", $".pt-{nameof(MWSpace.SPx)}{{{MWSpace.PaddingTop}:{MWSpace.SPx};}}");

    public static MicroWind PR0 { get; } = new($"{nameof(PR0)}", $".pr-{nameof(MWSpace.S0)}{{{MWSpace.PaddingRight}:{MWSpace.S0};}}");
    public static MicroWind PR1 { get; } = new($"{nameof(PR1)}", $".pr-{nameof(MWSpace.S1)}{{{MWSpace.PaddingRight}:{MWSpace.S1};}}");
    public static MicroWind PR2 { get; } = new($"{nameof(PR2)}", $".pr-{nameof(MWSpace.S2)}{{{MWSpace.PaddingRight}:{MWSpace.S2};}}");
    public static MicroWind PR4 { get; } = new($"{nameof(PR4)}", $".pr-{nameof(MWSpace.S4)}{{{MWSpace.PaddingRight}:{MWSpace.S4};}}");
    public static MicroWind PR8 { get; } = new($"{nameof(PR8)}", $".pr-{nameof(MWSpace.S8)}{{{MWSpace.PaddingRight}:{MWSpace.S8};}}");
    public static MicroWind PR16 { get; } = new($"{nameof(PR16)}", $".pr-{nameof(MWSpace.S16)}{{{MWSpace.PaddingRight}:{MWSpace.S16};}}");
    public static MicroWind PR32 { get; } = new($"{nameof(PR32)}", $".pr-{nameof(MWSpace.S32)}{{{MWSpace.PaddingRight}:{MWSpace.S32};}}");
    public static MicroWind PRPx { get; } = new($"{nameof(PRPx)}", $".pr-{nameof(MWSpace.SPx)}{{{MWSpace.PaddingRight}:{MWSpace.SPx};}}");

    public static MicroWind PB0 { get; } = new($"{nameof(PB0)}", $".Pb-{nameof(MWSpace.S0)}{{{MWSpace.PaddingBottom}:{MWSpace.S0};}}");
    public static MicroWind PB1 { get; } = new($"{nameof(PB1)}", $".Pb-{nameof(MWSpace.S1)}{{{MWSpace.PaddingBottom}:{MWSpace.S1};}}");
    public static MicroWind PB2 { get; } = new($"{nameof(PB2)}", $".Pb-{nameof(MWSpace.S2)}{{{MWSpace.PaddingBottom}:{MWSpace.S2};}}");
    public static MicroWind PB4 { get; } = new($"{nameof(PB4)}", $".Pb-{nameof(MWSpace.S4)}{{{MWSpace.PaddingBottom}:{MWSpace.S4};}}");
    public static MicroWind PB8 { get; } = new($"{nameof(PB8)}", $".Pb-{nameof(MWSpace.S8)}{{{MWSpace.PaddingBottom}:{MWSpace.S8};}}");
    public static MicroWind PB16 { get; } = new($"{nameof(PB16)}", $".Pb-{nameof(MWSpace.S16)}{{{MWSpace.PaddingBottom}:{MWSpace.S16};}}");
    public static MicroWind PB32 { get; } = new($"{nameof(PB32)}", $".Pb-{nameof(MWSpace.S32)}{{{MWSpace.PaddingBottom}:{MWSpace.S32};}}");
    public static MicroWind PBPx { get; } = new($"{nameof(PBPx)}", $".Pb-{nameof(MWSpace.SPx)}{{{MWSpace.PaddingBottom}:{MWSpace.SPx};}}");

    public static MicroWind PL0 { get; } = new($"{nameof(PL0)}", $".Pl-{nameof(MWSpace.S0)}{{{MWSpace.PaddingLeft}:{MWSpace.S0};}}");
    public static MicroWind PL1 { get; } = new($"{nameof(PL1)}", $".Pl-{nameof(MWSpace.S1)}{{{MWSpace.PaddingLeft}:{MWSpace.S1};}}");
    public static MicroWind PL2 { get; } = new($"{nameof(PL2)}", $".Pl-{nameof(MWSpace.S2)}{{{MWSpace.PaddingLeft}:{MWSpace.S2};}}");
    public static MicroWind PL4 { get; } = new($"{nameof(PL4)}", $".Pl-{nameof(MWSpace.S4)}{{{MWSpace.PaddingLeft}:{MWSpace.S4};}}");
    public static MicroWind PL8 { get; } = new($"{nameof(PL8)}", $".Pl-{nameof(MWSpace.S8)}{{{MWSpace.PaddingLeft}:{MWSpace.S8};}}");
    public static MicroWind PL16 { get; } = new($"{nameof(PL16)}", $".Pl-{nameof(MWSpace.S16)}{{{MWSpace.PaddingLeft}:{MWSpace.S16};}}");
    public static MicroWind PL32 { get; } = new($"{nameof(PL32)}", $".Pl-{nameof(MWSpace.S32)}{{{MWSpace.PaddingLeft}:{MWSpace.S32};}}");
    public static MicroWind PLPx { get; } = new($"{nameof(PLPx)}", $".Pl-{nameof(MWSpace.SPx)}{{{MWSpace.PaddingLeft}:{MWSpace.SPx};}}");

    public static MicroWind PX0 { get; } = new($"{nameof(PX0)}", $".Px-{nameof(MWSpace.S0)}{{{MWSpace.PaddingLeft}:{MWSpace.S0};{MWSpace.PaddingRight}:{MWSpace.S0};}}");
    public static MicroWind PX1 { get; } = new($"{nameof(PX1)}", $".Px-{nameof(MWSpace.S1)}{{{MWSpace.PaddingLeft}:{MWSpace.S1};{MWSpace.PaddingRight}:{MWSpace.S1};}}");
    public static MicroWind PX2 { get; } = new($"{nameof(PX2)}", $".Px-{nameof(MWSpace.S2)}{{{MWSpace.PaddingLeft}:{MWSpace.S2};{MWSpace.PaddingRight}:{MWSpace.S2};}}");
    public static MicroWind PX4 { get; } = new($"{nameof(PX4)}", $".Px-{nameof(MWSpace.S4)}{{{MWSpace.PaddingLeft}:{MWSpace.S4};{MWSpace.PaddingRight}:{MWSpace.S4};}}");
    public static MicroWind PX8 { get; } = new($"{nameof(PX8)}", $".Px-{nameof(MWSpace.S8)}{{{MWSpace.PaddingLeft}:{MWSpace.S8};{MWSpace.PaddingRight}:{MWSpace.S8};}}");
    public static MicroWind PX16 { get; } = new($"{nameof(PX16)}", $".Px-{nameof(MWSpace.S16)}{{{MWSpace.PaddingLeft}:{MWSpace.S16};{MWSpace.PaddingRight}:{MWSpace.S16};}}");
    public static MicroWind PX32 { get; } = new($"{nameof(PX32)}", $".Px-{nameof(MWSpace.S32)}{{{MWSpace.PaddingLeft}:{MWSpace.S32};{MWSpace.PaddingRight}:{MWSpace.S32};}}");
    public static MicroWind PXPx { get; } = new($"{nameof(PXPx)}", $".Px-{nameof(MWSpace.SPx)}{{{MWSpace.PaddingLeft}:{MWSpace.SPx};{MWSpace.PaddingRight}:{MWSpace.SPx};}}");

    public static MicroWind PY0 { get; } = new($"{nameof(PY0)}", $".Py-{nameof(MWSpace.S0)}{{{MWSpace.PaddingTop}:{MWSpace.S0};{MWSpace.PaddingBottom}:{MWSpace.S0};}}");
    public static MicroWind PY1 { get; } = new($"{nameof(PY1)}", $".Py-{nameof(MWSpace.S1)}{{{MWSpace.PaddingTop}:{MWSpace.S1};{MWSpace.PaddingBottom}:{MWSpace.S1};}}");
    public static MicroWind PY2 { get; } = new($"{nameof(PY2)}", $".Py-{nameof(MWSpace.S2)}{{{MWSpace.PaddingTop}:{MWSpace.S2};{MWSpace.PaddingBottom}:{MWSpace.S2};}}");
    public static MicroWind PY4 { get; } = new($"{nameof(PY4)}", $".Py-{nameof(MWSpace.S4)}{{{MWSpace.PaddingTop}:{MWSpace.S4};{MWSpace.PaddingBottom}:{MWSpace.S4};}}");
    public static MicroWind PY8 { get; } = new($"{nameof(PY8)}", $".Py-{nameof(MWSpace.S8)}{{{MWSpace.PaddingTop}:{MWSpace.S8};{MWSpace.PaddingBottom}:{MWSpace.S8};}}");
    public static MicroWind PY16 { get; } = new($"{nameof(PY16)}", $".Py-{nameof(MWSpace.S16)}{{{MWSpace.PaddingTop}:{MWSpace.S16};{MWSpace.PaddingBottom}:{MWSpace.S16};}}");
    public static MicroWind PY32 { get; } = new($"{nameof(PY32)}", $".Py-{nameof(MWSpace.S32)}{{{MWSpace.PaddingTop}:{MWSpace.S32};{MWSpace.PaddingBottom}:{MWSpace.S32};}}");
    public static MicroWind PYPx { get; } = new($"{nameof(PYPx)}", $".Py-{nameof(MWSpace.SPx)}{{{MWSpace.PaddingTop}:{MWSpace.SPx};{MWSpace.PaddingBottom}:{MWSpace.SPx};}}");


    public static MicroWind M0 { get; } = new($"{nameof(M0)}", $".M-{nameof(MWSpace.S0)}{{{MWSpace.Margin}:{MWSpace.S0};}}");
    public static MicroWind M1 { get; } = new($"{nameof(M1)}", $".M-{nameof(MWSpace.S1)}{{{MWSpace.Margin}:{MWSpace.S1};}}");
    public static MicroWind M2 { get; } = new($"{nameof(M2)}", $".M-{nameof(MWSpace.S2)}{{{MWSpace.Margin}:{MWSpace.S2};}}");
    public static MicroWind M4 { get; } = new($"{nameof(M4)}", $".M-{nameof(MWSpace.S4)}{{{MWSpace.Margin}:{MWSpace.S4};}}");
    public static MicroWind M8 { get; } = new($"{nameof(M8)}", $".M-{nameof(MWSpace.S8)}{{{MWSpace.Margin}:{MWSpace.S8};}}");
    public static MicroWind M16 { get; } = new($"{nameof(M16)}", $".M-{nameof(MWSpace.S16)}{{{MWSpace.Margin}:{MWSpace.S16};}}");
    public static MicroWind M32 { get; } = new($"{nameof(M32)}", $".M-{nameof(MWSpace.S32)}{{{MWSpace.Margin}:{MWSpace.S32};}}");
    public static MicroWind MPx { get; } = new($"{nameof(MPx)}", $".M-{nameof(MWSpace.SPx)}{{{MWSpace.Margin}:{MWSpace.SPx};}}");

    public static MicroWind MT0 { get; } = new($"{nameof(MT0)}", $".Mt-{nameof(MWSpace.S0)}{{{MWSpace.MarginTop}:{MWSpace.S0};}}");
    public static MicroWind MT1 { get; } = new($"{nameof(MT1)}", $".Mt-{nameof(MWSpace.S1)}{{{MWSpace.MarginTop}:{MWSpace.S1};}}");
    public static MicroWind MT2 { get; } = new($"{nameof(MT2)}", $".Mt-{nameof(MWSpace.S2)}{{{MWSpace.MarginTop}:{MWSpace.S2};}}");
    public static MicroWind MT4 { get; } = new($"{nameof(MT4)}", $".Mt-{nameof(MWSpace.S4)}{{{MWSpace.MarginTop}:{MWSpace.S4};}}");
    public static MicroWind MT8 { get; } = new($"{nameof(MT8)}", $".Mt-{nameof(MWSpace.S8)}{{{MWSpace.MarginTop}:{MWSpace.S8};}}");
    public static MicroWind MT16 { get; } = new($"{nameof(MT16)}", $".Mt-{nameof(MWSpace.S16)}{{{MWSpace.MarginTop}:{MWSpace.S16};}}");
    public static MicroWind MT32 { get; } = new($"{nameof(MT32)}", $".Mt-{nameof(MWSpace.S32)}{{{MWSpace.MarginTop}:{MWSpace.S32};}}");
    public static MicroWind MTPx { get; } = new($"{nameof(MTPx)}", $".Mt-{nameof(MWSpace.SPx)}{{{MWSpace.MarginTop}:{MWSpace.SPx};}}");

    public static MicroWind MR0 { get; } = new($"{nameof(MR0)}", $".Mr-{nameof(MWSpace.S0)}{{{MWSpace.MarginRight}:{MWSpace.S0};}}");
    public static MicroWind MR1 { get; } = new($"{nameof(MR1)}", $".Mr-{nameof(MWSpace.S1)}{{{MWSpace.MarginRight}:{MWSpace.S1};}}");
    public static MicroWind MR2 { get; } = new($"{nameof(MR2)}", $".Mr-{nameof(MWSpace.S2)}{{{MWSpace.MarginRight}:{MWSpace.S2};}}");
    public static MicroWind MR4 { get; } = new($"{nameof(MR4)}", $".Mr-{nameof(MWSpace.S4)}{{{MWSpace.MarginRight}:{MWSpace.S4};}}");
    public static MicroWind MR8 { get; } = new($"{nameof(MR8)}", $".Mr-{nameof(MWSpace.S8)}{{{MWSpace.MarginRight}:{MWSpace.S8};}}");
    public static MicroWind MR16 { get; } = new($"{nameof(MR16)}", $".Mr-{nameof(MWSpace.S16)}{{{MWSpace.MarginRight}:{MWSpace.S16};}}");
    public static MicroWind MR32 { get; } = new($"{nameof(MR32)}", $".Mr-{nameof(MWSpace.S32)}{{{MWSpace.MarginRight}:{MWSpace.S32};}}");
    public static MicroWind MRPx { get; } = new($"{nameof(MRPx)}", $".Mr-{nameof(MWSpace.SPx)}{{{MWSpace.MarginRight}:{MWSpace.SPx};}}");

    public static MicroWind MB0 { get; } = new($"{nameof(MB0)}", $".Mb-{nameof(MWSpace.S0)}{{{MWSpace.MarginBottom}:{MWSpace.S0};}}");
    public static MicroWind MB1 { get; } = new($"{nameof(MB1)}", $".Mb-{nameof(MWSpace.S1)}{{{MWSpace.MarginBottom}:{MWSpace.S1};}}");
    public static MicroWind MB2 { get; } = new($"{nameof(MB2)}", $".Mb-{nameof(MWSpace.S2)}{{{MWSpace.MarginBottom}:{MWSpace.S2};}}");
    public static MicroWind MB4 { get; } = new($"{nameof(MB4)}", $".Mb-{nameof(MWSpace.S4)}{{{MWSpace.MarginBottom}:{MWSpace.S4};}}");
    public static MicroWind MB8 { get; } = new($"{nameof(MB8)}", $".Mb-{nameof(MWSpace.S8)}{{{MWSpace.MarginBottom}:{MWSpace.S8};}}");
    public static MicroWind MB16 { get; } = new($"{nameof(MB16)}", $".Mb-{nameof(MWSpace.S16)}{{{MWSpace.MarginBottom}:{MWSpace.S16};}}");
    public static MicroWind MB32 { get; } = new($"{nameof(MB32)}", $".Mb-{nameof(MWSpace.S32)}{{{MWSpace.MarginBottom}:{MWSpace.S32};}}");
    public static MicroWind MBPx { get; } = new($"{nameof(MBPx)}", $".Mb-{nameof(MWSpace.SPx)}{{{MWSpace.MarginBottom}:{MWSpace.SPx};}}");

    public static MicroWind ML0 { get; } = new($"{nameof(ML0)}", $".Ml-{nameof(MWSpace.S0)}{{{MWSpace.MarginLeft}:{MWSpace.S0};}}");
    public static MicroWind ML1 { get; } = new($"{nameof(ML1)}", $".Ml-{nameof(MWSpace.S1)}{{{MWSpace.MarginLeft}:{MWSpace.S1};}}");
    public static MicroWind ML2 { get; } = new($"{nameof(ML2)}", $".Ml-{nameof(MWSpace.S2)}{{{MWSpace.MarginLeft}:{MWSpace.S2};}}");
    public static MicroWind ML4 { get; } = new($"{nameof(ML4)}", $".Ml-{nameof(MWSpace.S4)}{{{MWSpace.MarginLeft}:{MWSpace.S4};}}");
    public static MicroWind ML8 { get; } = new($"{nameof(ML8)}", $".Ml-{nameof(MWSpace.S8)}{{{MWSpace.MarginLeft}:{MWSpace.S8};}}");
    public static MicroWind ML16 { get; } = new($"{nameof(ML16)}", $".Ml-{nameof(MWSpace.S16)}{{{MWSpace.MarginLeft}:{MWSpace.S16};}}");
    public static MicroWind ML32 { get; } = new($"{nameof(ML32)}", $".Ml-{nameof(MWSpace.S32)}{{{MWSpace.MarginLeft}:{MWSpace.S32};}}");
    public static MicroWind MLPx { get; } = new($"{nameof(MLPx)}", $".Ml-{nameof(MWSpace.SPx)}{{{MWSpace.MarginLeft}:{MWSpace.SPx};}}");

    public static MicroWind MX0 { get; } = new($"{nameof(MX0)}", $".Mx-{nameof(MWSpace.S0)}{{{MWSpace.MarginLeft}:{MWSpace.S0};{MWSpace.MarginRight}:{MWSpace.S0};}}");
    public static MicroWind MX1 { get; } = new($"{nameof(MX1)}", $".Mx-{nameof(MWSpace.S1)}{{{MWSpace.MarginLeft}:{MWSpace.S1};{MWSpace.MarginRight}:{MWSpace.S1};}}");
    public static MicroWind MX2 { get; } = new($"{nameof(MX2)}", $".Mx-{nameof(MWSpace.S2)}{{{MWSpace.MarginLeft}:{MWSpace.S2};{MWSpace.MarginRight}:{MWSpace.S2};}}");
    public static MicroWind MX4 { get; } = new($"{nameof(MX4)}", $".Mx-{nameof(MWSpace.S4)}{{{MWSpace.MarginLeft}:{MWSpace.S4};{MWSpace.MarginRight}:{MWSpace.S4};}}");
    public static MicroWind MX8 { get; } = new($"{nameof(MX8)}", $".Mx-{nameof(MWSpace.S8)}{{{MWSpace.MarginLeft}:{MWSpace.S8};{MWSpace.MarginRight}:{MWSpace.S8};}}");
    public static MicroWind MX16 { get; } = new($"{nameof(MX16)}", $".Mx-{nameof(MWSpace.S16)}{{{MWSpace.MarginLeft}:{MWSpace.S16};{MWSpace.MarginRight}:{MWSpace.S16};}}");
    public static MicroWind MX32 { get; } = new($"{nameof(MX32)}", $".Mx-{nameof(MWSpace.S32)}{{{MWSpace.MarginLeft}:{MWSpace.S32};{MWSpace.MarginRight}:{MWSpace.S32};}}");
    public static MicroWind MXPx { get; } = new($"{nameof(MXPx)}", $".Mx-{nameof(MWSpace.SPx)}{{{MWSpace.MarginLeft}:{MWSpace.SPx};{MWSpace.MarginRight}:{MWSpace.SPx};}}");

    public static MicroWind MY0 { get; } = new($"{nameof(MY0)}", $".My-{nameof(MWSpace.S0)}{{{MWSpace.MarginTop}:{MWSpace.S0};{MWSpace.MarginBottom}:{MWSpace.S0};}}");
    public static MicroWind MY1 { get; } = new($"{nameof(MY1)}", $".My-{nameof(MWSpace.S1)}{{{MWSpace.MarginTop}:{MWSpace.S1};{MWSpace.MarginBottom}:{MWSpace.S1};}}");
    public static MicroWind MY2 { get; } = new($"{nameof(MY2)}", $".My-{nameof(MWSpace.S2)}{{{MWSpace.MarginTop}:{MWSpace.S2};{MWSpace.MarginBottom}:{MWSpace.S2};}}");
    public static MicroWind MY4 { get; } = new($"{nameof(MY4)}", $".My-{nameof(MWSpace.S4)}{{{MWSpace.MarginTop}:{MWSpace.S4};{MWSpace.MarginBottom}:{MWSpace.S4};}}");
    public static MicroWind MY8 { get; } = new($"{nameof(MY8)}", $".My-{nameof(MWSpace.S8)}{{{MWSpace.MarginTop}:{MWSpace.S8};{MWSpace.MarginBottom}:{MWSpace.S8};}}");
    public static MicroWind MY16 { get; } = new($"{nameof(MY16)}", $".My-{nameof(MWSpace.S16)}{{{MWSpace.MarginTop}:{MWSpace.S16};{MWSpace.MarginBottom}:{MWSpace.S16};}}");
    public static MicroWind MY32 { get; } = new($"{nameof(MY32)}", $".My-{nameof(MWSpace.S32)}{{{MWSpace.MarginTop}:{MWSpace.S32};{MWSpace.MarginBottom}:{MWSpace.S32};}}");
    public static MicroWind MYPx { get; } = new($"{nameof(MYPx)}", $".My-{nameof(MWSpace.SPx)}{{{MWSpace.MarginTop}:{MWSpace.SPx};{MWSpace.MarginBottom}:{MWSpace.SPx};}}");
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
    public const string Green900 = "#14532d";

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