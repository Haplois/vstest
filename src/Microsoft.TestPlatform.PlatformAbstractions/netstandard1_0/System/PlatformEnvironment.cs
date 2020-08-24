// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.PlatformAbstractions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;

    public partial class PlatformEnvironment : IEnvironment
    {
        /// <inheritdoc />
        public string GetEnvironmentVariable(string variable)
        {
            throw new NotImplementedException();
        }
    }
}