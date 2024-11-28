namespace HtmfExample;

public class MicroWind
{
    private MicroWind(string className, string cssStyleOutput) { ClassName = className; CssStyleOutput = cssStyleOutput; }

    public string ClassName { get; }
    public string CssStyleOutput { get; }

    public override string ToString() => ClassName;

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