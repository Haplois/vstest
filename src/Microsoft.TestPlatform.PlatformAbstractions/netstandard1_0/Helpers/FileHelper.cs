// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.Utilities.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    using Microsoft.VisualStudio.TestPlatform.Utilities.Helpers.Interfaces;

    /// <inheritdoc/>
    public class FileHelper : IFileHelper
    {
        /// <inheritdoc/>
        public char PathSeparator => throw new NotImplementedException();

        /// <inheritdoc/>
        public string CreateDirectory(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void CopyFile(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void Delete(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void DeleteEmptyDirectroy(string directoryPath)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public bool DirectoryExists(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateFiles(string directory, SearchOption searchOption, params string[] endsWithSearchPatterns)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public bool Exists(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public string GetCurrentDirectory()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public FileAttributes GetFileAttributes(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Version GetFileVersion(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public string GetFullPath(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Stream GetStream(string filePath, FileMode mode, FileAccess access = FileAccess.ReadWrite)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Stream GetStream(string filePath, FileMode mode, FileAccess access, FileShare share)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void MoveFile(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void WriteAllTextToFile(string filePath, string content)
        {
            throw new NotImplementedException();
        }
    }
}
