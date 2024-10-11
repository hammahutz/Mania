using Mania.Engine.Extensions;
using Microsoft.Xna.Framework;
using System;

namespace Mania.Engine.GameLogic.Components;

public class MovementComponent : Component, IUpdateComponent
{
    public MovementComponent(Node node) : base(node)
    {
    }

    public Vector2 Velocity
    {
        get => Direction * Speed;
        set
        {
            Velocity = value;
            Speed = value.Length();
            Direction = value;
        }
    }
    public Vector2 Direction
    {
        get => Direction;
        set
        {
            value.Normalize();
            Direction = value;
        }
    }
    public float Speed { get; set; } = 0.0f;

    public Vector2 Acceleration { get; set; } = Vector2.Zero;

    public float Friction { get => Friction; set => Friction = MathF.Abs(value); }
    public float Retardation { get => Retardation; set => Retardation = MathF.Abs(value); }

    public float RotationSpeed { get; set; }
    public float RotationFriction { get => RotationFriction; set => RotationFriction = MathF.Abs(value); }


    public void Update(GameTime gameTime)
    {
        Node.Transform.LocalPosition += Velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;
        Velocity.Decrees(Friction * (float)gameTime.ElapsedGameTime.TotalSeconds);

        Velocity += Acceleration * (float)gameTime.ElapsedGameTime.TotalSeconds;
        Acceleration.Decrees(Retardation * (float)gameTime.ElapsedGameTime.TotalSeconds);

        Node.Transform.LocalRotation += RotationSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
        RotationSpeed.Decrees(RotationFriction);
    }
}
