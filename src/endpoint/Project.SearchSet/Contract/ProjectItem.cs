﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace GarageGroup.Internal.Timesheet;

public sealed record class ProjectItem
{
    public ProjectItem(Guid id, [AllowNull] string name, ProjectType type)
    {
        Id = id;
        Name = name.OrEmpty();
        Type = type;
    }

    public Guid Id { get; }

    public string Name { get; }

    public ProjectType Type { get; }
}