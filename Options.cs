using CommandLine;

namespace Exporter;

public record Options
{
    [Option("path", HelpText = "The path to the sqpack directory.", Default = @"E:\Program Files (x86)\上海数龙科技有限公司\最终幻想XIV\game\sqpack")]
    public string? Path { get; set; }

    [Option('l', "languages", HelpText = "The languages to export (chs, de, en, fr, ja).", Default = new[] { "chs" }, Separator = ',')]
    public string[]? Languages { get; set; }
}