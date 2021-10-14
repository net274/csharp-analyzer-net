﻿// Copyright 2021-present MongoDB Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License")
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoDB.Analyzer.Helpers.Linq
{
    public sealed class EmptyCursor<TDocument> : IAsyncCursor<TDocument>
    {
        public IEnumerable<TDocument> Current => default;

        public void Dispose() { }
        public bool MoveNext(CancellationToken cancellationToken = default) => false;
        public async Task<bool> MoveNextAsync(CancellationToken cancellationToken = default)
        {
            await Task.FromResult(1);
            return false;
        }
    }
}
