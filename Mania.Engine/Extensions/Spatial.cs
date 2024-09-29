using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Mania.Engine.Extensions;

public static class Spatial
{
    /// <summary>
    /// Add a float to a Vector2
    /// </summary>
    /// <param name="vector2">The current Vector2 to add to</param>
    /// <param name="value">The amount to add</param>
    /// <returns>The sum of the new Vector2; {vector2.X + value, vector2.Y + value}</returns>
    public static Vector2 Add(this Vector2 vector2, float value) => new Vector2(vector2.X + value, vector2.Y + value);

    /// <summary>
    /// Subtract a float to a Vector 2
    /// </summary>
    /// <param name="vector2">The Vector2 to subtract form</param>
    /// <param name="value">The amount to subtract</param>
    /// <returns>The sum o the new Vector2; {vector2.X - value, vector2.Y - value}</returns>
    public static Vector2 Subtract(this Vector2 vector2, float value) => new Vector2(vector2.X - value, vector2.Y - value);
    public static Vector2 Decrees(this Vector2 vector2, float value)
    {
        float x, y;
        value = MathF.Abs(value);

        x = MathF.Abs(vector2.X) > value ? vector2.X < 0 ? vector2.X + value : vector2.X - value : 0;
        y = MathF.Abs(vector2.Y) > value ? vector2.Y < 0 ? vector2.Y + value : vector2.Y - value : 0;

        return new Vector2(x, y);
    }
    public static float Decrees(this float currentValue, float deltaValue) => currentValue > deltaValue ? currentValue < 0 ? currentValue + deltaValue : currentValue - deltaValue : 0f;
}