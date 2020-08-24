// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.IO
{
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Contains constants for controlling file sharing options while
    /// opening files.  You can specify what access other processes trying
    /// to open the same file concurrently can have.
    ///
    /// Note these values currently match the values for FILE_SHARE_READ,
    /// FILE_SHARE_WRITE, and FILE_SHARE_DELETE in winnt.h
    /// </summary>
    [Flags]
    [TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public enum FileShare
    {
        /// <summary>
        /// No sharing. Any request to open the file (by this process or another
        /// process) will fail until the file is closed.
        /// </summary>
        None = 0,

        /// <summary>
        /// Allows subsequent opening of the file for reading. If this flag is not
        /// specified, any request to open the file for reading (by this process or
        /// another process) will fail until the file is closed.
        /// </summary>
        Read = 1,

        /// <summary>
        /// Allows subsequent opening of the file for writing. If this flag is not
        /// specified, any request to open the file for writing (by this process or
        /// another process) will fail until the file is closed.
        /// </summary>
        Write = 2,

        /// <summary>
        /// Allows subsequent opening of the file for writing or reading. If this flag
        /// is not specified, any request to open the file for writing or reading (by
        /// this process or another process) will fail until the file is closed.
        /// </summary>
        ReadWrite = 3,

        /// <summary>
        /// Open the file, but allow someone else to delete the file.
        /// </summary>
        Delete = 4,

        /// <summary>
        /// Whether the file handle should be inheritable by child processes.
        /// Note this is not directly supported like this by Win32.
        /// </summary>
        Inheritable = 0x10,
    }
}