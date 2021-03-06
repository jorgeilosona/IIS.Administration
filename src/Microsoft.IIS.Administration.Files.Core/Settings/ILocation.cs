﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


namespace Microsoft.IIS.Administration.Files
{
    using System.Collections.Generic;

    public interface ILocation
    {
        string Alias { get; set; }
        string Path { get; set; }
        IEnumerable<string> Claims { get; }
    }
}
