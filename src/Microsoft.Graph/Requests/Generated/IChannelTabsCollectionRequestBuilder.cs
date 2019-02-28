// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IChannelTabsCollectionRequestBuilder.
    /// </summary>
    public partial interface IChannelTabsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IChannelTabsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IChannelTabsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ITeamsTabRequestBuilder"/> for the specified TeamsTab.
        /// </summary>
        /// <param name="id">The ID for the TeamsTab.</param>
        /// <returns>The <see cref="ITeamsTabRequestBuilder"/>.</returns>
        ITeamsTabRequestBuilder this[string id] { get; }

        
    }
}
