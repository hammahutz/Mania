public class LDtkSettings
{
    public LDtkSettings(string path, string world, string level)
    {
        Path = path;
        World = world;
        Level = level;
    }

    public string Path { get; set; }
    public string World { get; set; }
    public string Level { get; set; }
}