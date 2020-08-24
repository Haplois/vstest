// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.Utilities
{
    using System;

    /// <summary>
    /// Sends output to the console.
    /// </summary>
    public partial class ConsoleOutput : IOutput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleOutput"/> class.
        /// </summary>
        internal ConsoleOutput()
        {
            this.standardOutput = Console.Out;
            this.standardError = Console.Error;
        }
    }
}
