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
    /// The interface IDeviceComplianceUserStatusRequest.
    /// </summary>
    public partial interface IDeviceComplianceUserStatusRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceComplianceUserStatus using PUT.
        /// </summary>
        /// <param name="deviceComplianceUserStatusToCreate">The DeviceComplianceUserStatus to create.</param>
        /// <returns>The created DeviceComplianceUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserStatus> CreateAsync(DeviceComplianceUserStatus deviceComplianceUserStatusToCreate);        /// <summary>
        /// Creates the specified DeviceComplianceUserStatus using PUT.
        /// </summary>
        /// <param name="deviceComplianceUserStatusToCreate">The DeviceComplianceUserStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserStatus> CreateAsync(DeviceComplianceUserStatus deviceComplianceUserStatusToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceComplianceUserStatus.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceComplianceUserStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceComplianceUserStatus.
        /// </summary>
        /// <returns>The DeviceComplianceUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserStatus> GetAsync();

        /// <summary>
        /// Gets the specified DeviceComplianceUserStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceComplianceUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserStatus> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceComplianceUserStatus using PATCH.
        /// </summary>
        /// <param name="deviceComplianceUserStatusToUpdate">The DeviceComplianceUserStatus to update.</param>
        /// <returns>The updated DeviceComplianceUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserStatus> UpdateAsync(DeviceComplianceUserStatus deviceComplianceUserStatusToUpdate);

        /// <summary>
        /// Updates the specified DeviceComplianceUserStatus using PATCH.
        /// </summary>
        /// <param name="deviceComplianceUserStatusToUpdate">The DeviceComplianceUserStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceComplianceUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserStatus> UpdateAsync(DeviceComplianceUserStatus deviceComplianceUserStatusToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceUserStatusRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceUserStatusRequest Expand(Expression<Func<DeviceComplianceUserStatus, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceUserStatusRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceUserStatusRequest Select(Expression<Func<DeviceComplianceUserStatus, object>> selectExpression);

    }
}
