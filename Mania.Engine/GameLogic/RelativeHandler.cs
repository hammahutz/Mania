#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using Mania.Engine.Extensions;
using Mania.Engine.Util;

namespace Mania.Engine.GameLogic;

public class RelativeHandler
{
    public Node CurrentNode { get; private set; }
    public Node? Parent { get; private set; }
    public List<Node> Children { get; private set; } = new List<Node>();

    public RelativeHandler(Node currentNode) => CurrentNode = currentNode;

    public RelativeHandler SetParent(Node parent)
    {
        if (Parent is not null && Parent.Relatives.Children.Contains(CurrentNode))
        {
            GameDebug.Log(
                $"Tries to set parent, but parent {parent} already contains child {this}"
            );
        }
        else if (CurrentNode.Relatives.Children.Contains(parent))
        {
            GameDebug.Warning(
                $"Tries to set parent, but can't set parent {parent} to child {this} because the parent is one of the childs children"
            );
        }
        else
        {
            Parent = parent;
            Parent.Relatives.AddChild(CurrentNode);
        }

        return this;
    }

    public RelativeHandler AddChild(Node child)
    {
        if (Children.Contains(child))
        {
            GameDebug.Log($"Tries to add child, but parent {this} already contains child {child}");
        }
        else
        {
            Children.Add(child);
            child.Relatives.SetParent(CurrentNode);
            child.Enter(CurrentNode.GlobalContent, CurrentNode.LocalContent);
        }

        return this;
    }

    public RelativeHandler AddChildren(Node[] children)
    {
        var (childrenAlreadyAdded, childrenToAdd) = children.Partition(c => Children.Contains(c));

        childrenAlreadyAdded
            ?.ToList()
            .ForEach(c =>
                {
                    GameDebug.Log($"Tries to add child, but parent {this} already contains child {c}");
                    GameDebug.Debug($"Tries to add child, but parent {this} already contains child {c}");
                    GameDebug.WriteLine($"Tries to add child, but parent {this} already contains child {c}");
                    GameDebug.Warning($"Tries to add child, but parent {this} already contains child {c}");
                    GameDebug.Error($"Tries to add child, but parent {this} already contains child {c}");
                }
            );

        childrenToAdd
            ?.ToList()
            .ForEach(c =>
            {
                Children.Add(c);
                c.Relatives.SetParent(CurrentNode);
                c.Enter(CurrentNode.GlobalContent, CurrentNode.LocalContent);
            });
        return this;
    }

    public RelativeHandler RemoveChild(Node child)
    {
        if (Children.Contains(child))
        {
            child.Depose();
            Children.Remove(child);
        }
        return this;
    }

    public RelativeHandler RemoveChildren(Node[] children)
    {
        var (childrenToRemove, childrenNotContained) = children.Partition(c =>
            Children.Contains(c)
        );

        childrenNotContained
            ?.ToList()
            .ForEach(c =>
                GameDebug.Warning(
                    $"Tries to remove child, but the parent {this} doesn't contain the child {c}."
                )
            );
        childrenToRemove
            ?.ToList()
            .ForEach(c =>
            {
                c.Depose();
                Children.Remove(c);
            });

        return this;
    }

    public void Depose()
    {
        Children.ForEach(c => c.Depose());
        Children.Clear();
        Parent = null;
    }
}
