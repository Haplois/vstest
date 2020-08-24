// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.IO
{
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Enum describing whether the search operation should
    /// retrieve files/directories from the current directory alone
    /// or should include all the subdirectories also.
    /// </summary>
    [TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public enum SearchOption
    {
        /// <summary>
        /// Include only the current directory in the search operation
        /// </summary>
        TopDirectoryOnly,

        /// <summary>
        /// Include the current directory and all the sub-directories
        /// underneath it including reparse points in the search operation.
        /// This will traverse reparse points (i.e, mounted points and symbolic links)
        /// recursively. If the directory structure searched contains a loop
        /// because of hard links, the search operation will go on for ever.
        /// </summary>
        AllDirectories,
    }
}