namespace Mania.Core.Data.Pipeline.Json;

public class ExampleModel
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Defense { get; set; }
    public int Attack { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}\nHealth: {Health}\nDefense: {Defense}\nAttack: {Attack}\n";
    }
}
