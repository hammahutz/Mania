using Microsoft.Xna.Framework;

namespace Mania.Engine.GameLogic;

public class Transform
{
    private Node _nodeOwner;
    public Transform(Node node) => _nodeOwner = node;
    private Vector2 _position = Vector2.Zero;
    private float rotation = 0.0f;
    private Vector2 scale = Vector2.One;
    public Vector2 Position => _nodeOwner.Relatives.Parent == null ? _position : _position + _nodeOwner.Relatives.Parent.Transform.Position;
    public float Rotation => _nodeOwner.Relatives.Parent == null ? rotation : rotation + _nodeOwner.Relatives.Parent.Transform.Rotation;
    public Vector2 Scale => _nodeOwner.Relatives.Parent == null ? scale : scale * _nodeOwner.Relatives.Parent.Transform.Scale;

    public Vector2 LocalPosition
    {
        get => _position;
        set => _position = value;
    }
    public float LocalRotation
    {
        get => rotation;
        set => rotation = value;
    }
    public Vector2 LocalScale
    {
        get => scale;
        set => scale = value;
    }
}
