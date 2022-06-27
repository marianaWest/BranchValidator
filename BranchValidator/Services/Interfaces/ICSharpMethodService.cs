﻿// <copyright file="ICSharpMethodService.cs" company="KinsonDigital">
// Copyright (c) KinsonDigital. All rights reserved.
// </copyright>

namespace BranchValidator.Services.Interfaces;

/// <summary>
/// Gets a list of method names from a class that are marked as valid expression functions.
/// </summary>
public interface ICSharpMethodService
{
    /// <summary>
    /// Returns a list of method names from a class that matches the given <paramref name="className"/>
    /// in the assembly that contain the <see cref="ExpressionFunctionAttribute"/> attribute.
    /// </summary>
    /// <param name="className">The name of the class.</param>
    /// <returns>The list of method names.</returns>
    IEnumerable<string> GetMethodNames(string className);

    Dictionary<string, Type[]> GetMethodParamTypes(string className, string methodName);

    IEnumerable<string> GetMethodSignatures(string className);
}
