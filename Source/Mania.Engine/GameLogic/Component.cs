namespace Mania.Engine.GameLogic;

public abstract class Component
{
    public Node Node { get; private set; }
    public Component(Node node) => Node = node;
    public void Depose() => Node = null;
}
