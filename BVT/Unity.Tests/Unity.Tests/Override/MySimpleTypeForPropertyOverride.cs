// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
using Microsoft.Practices.Unity;

namespace Unity.Tests.Override
{
    public class MySimpleTypeForPropertyOverride
    {
        [Dependency]
        public int X { get; set; }
    }
}