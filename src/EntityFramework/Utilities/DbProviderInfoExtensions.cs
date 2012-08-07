// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Utilities
{
    using System.Data.Entity.Infrastructure;
    using System.Diagnostics.Contracts;

    internal static class DbProviderInfoExtensions
    {
        public static bool IsSqlCe(this DbProviderInfo providerInfo)
        {
            Contract.Requires(providerInfo != null);

            return !string.IsNullOrWhiteSpace(providerInfo.ProviderInvariantName) &&
                   providerInfo.ProviderInvariantName.StartsWith(
                       "System.Data.SqlServerCe", StringComparison.OrdinalIgnoreCase);
        }
    }
}
