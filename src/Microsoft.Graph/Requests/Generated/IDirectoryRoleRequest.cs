// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDirectoryRoleRequest.
    /// </summary>
    public partial interface IDirectoryRoleRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DirectoryRole using PUT.
        /// </summary>
        /// <param name="directoryRoleToCreate">The DirectoryRole to create.</param>
        /// <returns>The created DirectoryRole.</returns>
        System.Threading.Tasks.Task<DirectoryRole> CreateAsync(DirectoryRole directoryRoleToCreate);        /// <summary>
        /// Creates the specified DirectoryRole using PUT.
        /// </summary>
        /// <param name="directoryRoleToCreate">The DirectoryRole to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryRole.</returns>
        System.Threading.Tasks.Task<DirectoryRole> CreateAsync(DirectoryRole directoryRoleToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DirectoryRole.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DirectoryRole.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DirectoryRole.
        /// </summary>
        /// <returns>The DirectoryRole.</returns>
        System.Threading.Tasks.Task<DirectoryRole> GetAsync();

        /// <summary>
        /// Gets the specified DirectoryRole.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectoryRole.</returns>
        System.Threading.Tasks.Task<DirectoryRole> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DirectoryRole using PATCH.
        /// </summary>
        /// <param name="directoryRoleToUpdate">The DirectoryRole to update.</param>
        /// <returns>The updated DirectoryRole.</returns>
        System.Threading.Tasks.Task<DirectoryRole> UpdateAsync(DirectoryRole directoryRoleToUpdate);

        /// <summary>
        /// Updates the specified DirectoryRole using PATCH.
        /// </summary>
        /// <param name="directoryRoleToUpdate">The DirectoryRole to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DirectoryRole.</returns>
        System.Threading.Tasks.Task<DirectoryRole> UpdateAsync(DirectoryRole directoryRoleToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleRequest Expand(Expression<Func<DirectoryRole, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleRequest Select(Expression<Func<DirectoryRole, object>> selectExpression);

    }
}
