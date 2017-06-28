﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Enc = System.Text.Encoding;

namespace CsvViewer.Utility
{
    /// <summary>
    ///     Allows Enumerating through the lines of a <see cref="File"/> in a more efficient manner.
    /// </summary>
    public class FileEnumerable : IEnumerable<string>
    {
        private readonly FileMode _fileMode;
        private readonly FileAccess _fileAccess;
        private readonly FileShare _fileShare;

        private readonly Enc _encoding;
        public int SkipAmount { get; private set; } = 0;
        public int TakeAmount { get; private set; } = 1;
        private readonly bool _useFileStream = false;
        private Expression<Func<string, bool>> _predicate;

        /// <summary>
        ///     The <see cref="Path"/> for the <see cref="FileEnumerable"/> to read.
        /// </summary>
        public string Path { get; }

        /// <summary>
        ///     Create a new <see cref="FileEnumerable"/> instance with a <paramref name="path"/>
        ///     and optional <paramref name="encoding"/> to use.
        /// </summary>
        public FileEnumerable(string path, Enc encoding = null)
        {
            _encoding = encoding;
            Path = path;
        }

        /// <summary>
        ///     Create a new <see cref="FileEnumerable"/> instance with a <paramref name="path"/>
        ///     and optional <paramref name="encoding"/> to use.
        /// </summary>
        /// <remarks>
        ///     Able to specify <see cref="File"/> options.
        /// </remarks>
        public FileEnumerable(string path, FileMode fileMode, FileAccess fileAccess, FileShare fileShare, Enc encoding = null)
            : this(path, encoding)
        {
            _useFileStream = true;
            _fileMode = fileMode;
            _fileAccess = fileAccess;
            _fileShare = fileShare;
        }

        /// <summary>
        ///     What <see cref="StreamReader"/> creation path to use.
        /// </summary>
        private StreamReader ResolveStreamReader()
        {
            StreamReader reader;
            if (_useFileStream)
            {
                var file = new FileStream(Path, _fileMode, _fileAccess, _fileShare);
                reader = new StreamReader(file, _encoding ?? Enc.UTF8);
                return reader;
            }

            reader = new StreamReader(Path, _encoding ?? Enc.UTF8);
            return reader;
        }

        /// <summary>
        ///     <see cref="Skip"/> a <paramref name="amount"/> of rows.
        /// </summary>
        public FileEnumerable Skip(int amount)
        {
            SkipAmount = amount;
            return this;
        }

        /// <summary>
        ///     <see cref="Take"/> a <paramref name="amount"/> of rows.
        /// </summary>
        public FileEnumerable Take(int amount)
        {
            TakeAmount = amount;
            return this;
        }

        /// <summary>
        ///     The returned rows must match a specific <paramref name="predicate"/>.
        /// </summary>
        public FileEnumerable Where(Expression<Func<string, bool>> predicate)
        {
            _predicate = _predicate != null ? _predicate.AndAlso(predicate) : predicate;

            return this;
        }

        /// <summary>
        ///     Count the amount of rows asynchronously.
        /// </summary>
        public async Task<long> CountAsync()
        {
            using (var file = new FileStream(Path, _fileMode, _fileAccess, _fileShare))
            {
                long lineCount = 0;
                var buffer = new byte[1024 * 1024];
                int bytesRead;

                do
                {
                    bytesRead = await file.ReadAsync(buffer, 0, buffer.Length);
                    for (var i = 0; i < bytesRead; i++)
                        if (buffer[i] == '\n')
                            lineCount++;
                }
                while (bytesRead > 0);

                file.Close();
                return lineCount;
            }
        }

        /// <summary>
        ///     <see cref="Count"/> the amount of rows.
        /// </summary>
        public long Count()
        {
            using (var file = new FileStream(Path, _fileMode, _fileAccess, _fileShare))
            {
                long lineCount = 0;
                var buffer = new byte[1024 * 1024];
                int bytesRead;

                do
                {
                    bytesRead = file.Read(buffer, 0, buffer.Length);
                    for (var i = 0; i < bytesRead; i++)
                        if (buffer[i] == '\n')
                            lineCount++;
                }
                while (bytesRead > 0);

                file.Close();
                return lineCount;
            }
        }

        /// <summary>
        ///     Check if the <see cref="File"/> contains more rows than the given <paramref name="amount"/>.
        /// </summary>
        public bool HasMoreRowsThan(int amount)
        {
            var index = 0;
            using (var reader = ResolveStreamReader())
            {
                while (!reader.EndOfStream)
                {
                    if (index > amount)
                        return true;

                    reader.ReadLine();
                    index++;
                }

                reader.Close();
            }

            return false;
        }

        /// <summary>
        ///     Check if the <see cref="File"/> contains more rows than the given <paramref name="amount"/> asynchronously.
        /// </summary>
        public async Task<bool> HasMoreRowsThanAsync(int amount)
        {
            var index = 0;
            using (var reader = ResolveStreamReader())
            {
                while (!reader.EndOfStream)
                {
                    if (index > amount)
                        return true;

                    await reader.ReadLineAsync();
                    index++;
                }

                reader.Close();
            }


            return false;
        }

        /// <summary>
        ///     Read the <see cref="First"/> row in the <see cref="File"/>.
        /// </summary>
        public string First()
        {
            using (var reader = ResolveStreamReader())
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    return line;

                reader.Close();
            }

            return string.Empty;
        }

        /// <summary>
        ///     Read the <see cref="First"/> row in the <see cref="File"/> asynchronously.
        /// </summary>
        public async Task<string> FirstAsync()
        {
            using (var reader = ResolveStreamReader())
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                    return line;

                reader.Close();
            }

            return string.Empty;
        }

        /// <summary>
        ///     Enumerate the <see cref="File"/> rows to a <see cref="List{T}"/> asynchronously.
        /// </summary>
        public async Task<List<string>> ToListAsync()
        {
            var result = new List<string>();
            using (var reader = ResolveStreamReader())
            {
                for (var i = 0; i < SkipAmount; i++)
                {
                    await reader.ReadLineAsync();
                }

                var took = 0;
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    if (took >= TakeAmount)
                        break;

                    if (!_predicate?.Compile().Invoke(line) ?? false)
                        continue;

                    took++;
                    result.Add(line);
                }

                reader.Close();
            }

            return result;
        }

        /// <summary>
        ///     Enumerate the <see cref="File"/> rows to a <see cref="IEnumerator{T}"/>.
        /// </summary>
        public IEnumerator<string> GetEnumerator()
        {
            using (var reader = ResolveStreamReader())
            {
                for (var i = 0; i < SkipAmount; i++)
                {
                    reader.ReadLine();
                }

                var took = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (took >= TakeAmount)
                        break;

                    if (!_predicate?.Compile().Invoke(line) ?? false)
                        continue;

                    took++;

                    yield return line;
                }

                reader.Close();
            }
        }

        /// <summary>
        ///     Enumerate the <see cref="File"/> rows to a <see cref="IEnumerator{T}"/>.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        ///     Create a <see cref="ReadOnly"/> instance of the <see cref="FileEnumerable"/>.
        /// </summary>
        public static FileEnumerable ReadOnly(string path, Enc encoding = null)
            => new FileEnumerable(path, FileMode.Open, FileAccess.Read, FileShare.Read, encoding);
    }
}
