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
    /// The interface ICalendarRequest.
    /// </summary>
    public partial interface ICalendarRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Calendar using PUT.
        /// </summary>
        /// <param name="calendarToCreate">The Calendar to create.</param>
        /// <returns>The created Calendar.</returns>
        System.Threading.Tasks.Task<Calendar> CreateAsync(Calendar calendarToCreate);        /// <summary>
        /// Creates the specified Calendar using PUT.
        /// </summary>
        /// <param name="calendarToCreate">The Calendar to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Calendar.</returns>
        System.Threading.Tasks.Task<Calendar> CreateAsync(Calendar calendarToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Calendar.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Calendar.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Calendar.
        /// </summary>
        /// <returns>The Calendar.</returns>
        System.Threading.Tasks.Task<Calendar> GetAsync();

        /// <summary>
        /// Gets the specified Calendar.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Calendar.</returns>
        System.Threading.Tasks.Task<Calendar> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Calendar using PATCH.
        /// </summary>
        /// <param name="calendarToUpdate">The Calendar to update.</param>
        /// <returns>The updated Calendar.</returns>
        System.Threading.Tasks.Task<Calendar> UpdateAsync(Calendar calendarToUpdate);

        /// <summary>
        /// Updates the specified Calendar using PATCH.
        /// </summary>
        /// <param name="calendarToUpdate">The Calendar to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Calendar.</returns>
        System.Threading.Tasks.Task<Calendar> UpdateAsync(Calendar calendarToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICalendarRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICalendarRequest Expand(Expression<Func<Calendar, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICalendarRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICalendarRequest Select(Expression<Func<Calendar, object>> selectExpression);

    }
}
