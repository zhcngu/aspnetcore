// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Google.Api;
using Google.Protobuf.Reflection;

namespace Microsoft.AspNetCore.Grpc.HttpApi.Internal.Binding;

internal interface IServiceInvokerResolver<TService> where TService : class
{
    /// <summary>
    /// Creates a service invoker delegate and associated metadata using the
    /// </summary>
    (TDelegate invoker, List<object> metadata) CreateModelCore<TDelegate>(
        string methodName,
        Type[] methodParameters,
        string verb,
        HttpRule httpRule,
        MethodDescriptor methodDescriptor) where TDelegate : Delegate;
}
