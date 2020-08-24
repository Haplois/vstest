// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces
{
    /// <summary>
    /// Operating system environment abstractions.
    /// </summary>
    public interface IEnvironment
    {
        /// <summary>
        /// Gets the Operating System architecture.
        /// </summary>
        PlatformArchitecture Architecture { get; }

        /// <summary>
        /// Gets the Operating System name.
        /// </summary>
        PlatformOperatingSystem OperatingSystem { get; }

        /// <summary>
        /// Gets the Operating System version
        /// </summary>
        string OperatingSystemVersion { get; }

        /// <summary>
        /// Exits the current process as per Operating System
        /// </summary>
        /// <param name="exitcode">Exit code set by user</param>
        void Exit(int exitcode);

        /// <summary>
        /// Returns Operating System managed thread Id
        /// </summary>
        /// <returns>Returns the thread Id</returns>
        int GetCurrentManagedThreadId();

        /// <summary>
        /// Retrieves the value of an environment variable from the current process.
        /// </summary>
        /// <param name="variable">The name of the environment variable.</param>
        /// <returns>The value of the environment variable specified by variable, or null if the environment variable is not found.</returns>
        string GetEnvironmentVariable(string variable);
    }
}
