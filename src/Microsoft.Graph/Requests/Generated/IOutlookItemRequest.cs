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
    /// The interface IOutlookItemRequest.
    /// </summary>
    public partial interface IOutlookItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OutlookItem using PUT.
        /// </summary>
        /// <param name="outlookItemToCreate">The OutlookItem to create.</param>
        /// <returns>The created OutlookItem.</returns>
        System.Threading.Tasks.Task<OutlookItem> CreateAsync(OutlookItem outlookItemToCreate);        /// <summary>
        /// Creates the specified OutlookItem using PUT.
        /// </summary>
        /// <param name="outlookItemToCreate">The OutlookItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OutlookItem.</returns>
        System.Threading.Tasks.Task<OutlookItem> CreateAsync(OutlookItem outlookItemToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OutlookItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OutlookItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OutlookItem.
        /// </summary>
        /// <returns>The OutlookItem.</returns>
        System.Threading.Tasks.Task<OutlookItem> GetAsync();

        /// <summary>
        /// Gets the specified OutlookItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OutlookItem.</returns>
        System.Threading.Tasks.Task<OutlookItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OutlookItem using PATCH.
        /// </summary>
        /// <param name="outlookItemToUpdate">The OutlookItem to update.</param>
        /// <returns>The updated OutlookItem.</returns>
        System.Threading.Tasks.Task<OutlookItem> UpdateAsync(OutlookItem outlookItemToUpdate);

        /// <summary>
        /// Updates the specified OutlookItem using PATCH.
        /// </summary>
        /// <param name="outlookItemToUpdate">The OutlookItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated OutlookItem.</returns>
        System.Threading.Tasks.Task<OutlookItem> UpdateAsync(OutlookItem outlookItemToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookItemRequest Expand(Expression<Func<OutlookItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookItemRequest Select(Expression<Func<OutlookItem, object>> selectExpression);

    }
}
