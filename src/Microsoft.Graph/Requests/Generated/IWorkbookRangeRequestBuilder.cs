// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWorkbookRangeRequestBuilder.
    /// </summary>
    public partial interface IWorkbookRangeRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IWorkbookRangeRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IWorkbookRangeRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Format.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeFormatRequestBuilder"/>.</returns>
        IWorkbookRangeFormatRequestBuilder Format { get; }

        /// <summary>
        /// Gets the request builder for Sort.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeSortRequestBuilder"/>.</returns>
        IWorkbookRangeSortRequestBuilder Sort { get; }

        /// <summary>
        /// Gets the request builder for Worksheet.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetRequestBuilder"/>.</returns>
        IWorkbookWorksheetRequestBuilder Worksheet { get; }
    
        /// <summary>
        /// Gets the request builder for WorkbookRangeClear.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeClearRequestBuilder"/>.</returns>
        IWorkbookRangeClearRequestBuilder Clear(
            string applyTo);

        /// <summary>
        /// Gets the request builder for WorkbookRangeDelete.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeDeleteRequestBuilder"/>.</returns>
        IWorkbookRangeDeleteRequestBuilder Delete(
            string shift);

        /// <summary>
        /// Gets the request builder for WorkbookRangeInsert.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeInsertRequestBuilder"/>.</returns>
        IWorkbookRangeInsertRequestBuilder Insert(
            string shift);

        /// <summary>
        /// Gets the request builder for WorkbookRangeMerge.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeMergeRequestBuilder"/>.</returns>
        IWorkbookRangeMergeRequestBuilder Merge(
            bool across);

        /// <summary>
        /// Gets the request builder for WorkbookRangeUnmerge.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeUnmergeRequestBuilder"/>.</returns>
        IWorkbookRangeUnmergeRequestBuilder Unmerge();

        /// <summary>
        /// Gets the request builder for WorkbookRangeBoundingRect.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeBoundingRectRequestBuilder"/>.</returns>
        IWorkbookRangeBoundingRectRequestBuilder BoundingRect(
            string anotherRange = null);

        /// <summary>
        /// Gets the request builder for WorkbookRangeCell.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeCellRequestBuilder"/>.</returns>
        IWorkbookRangeCellRequestBuilder Cell(
            Int32 row,
            Int32 column);

        /// <summary>
        /// Gets the request builder for WorkbookRangeColumn.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeColumnRequestBuilder"/>.</returns>
        IWorkbookRangeColumnRequestBuilder Column(
            Int32 column);

        /// <summary>
        /// Gets the request builder for WorkbookRangeColumnsAfter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeColumnsAfterRequestBuilder"/>.</returns>
        IWorkbookRangeColumnsAfterRequestBuilder ColumnsAfter();

        /// <summary>
        /// Gets the request builder for WorkbookRangeColumnsAfter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeColumnsAfterRequestBuilder"/>.</returns>
        IWorkbookRangeColumnsAfterRequestBuilder ColumnsAfter(
            Int32? count = null);

        /// <summary>
        /// Gets the request builder for WorkbookRangeColumnsBefore.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeColumnsBeforeRequestBuilder"/>.</returns>
        IWorkbookRangeColumnsBeforeRequestBuilder ColumnsBefore();

        /// <summary>
        /// Gets the request builder for WorkbookRangeColumnsBefore.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeColumnsBeforeRequestBuilder"/>.</returns>
        IWorkbookRangeColumnsBeforeRequestBuilder ColumnsBefore(
            Int32? count = null);

        /// <summary>
        /// Gets the request builder for WorkbookRangeEntireColumn.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeEntireColumnRequestBuilder"/>.</returns>
        IWorkbookRangeEntireColumnRequestBuilder EntireColumn();

        /// <summary>
        /// Gets the request builder for WorkbookRangeEntireRow.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeEntireRowRequestBuilder"/>.</returns>
        IWorkbookRangeEntireRowRequestBuilder EntireRow();

        /// <summary>
        /// Gets the request builder for WorkbookRangeIntersection.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeIntersectionRequestBuilder"/>.</returns>
        IWorkbookRangeIntersectionRequestBuilder Intersection(
            string anotherRange = null);

        /// <summary>
        /// Gets the request builder for WorkbookRangeLastCell.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeLastCellRequestBuilder"/>.</returns>
        IWorkbookRangeLastCellRequestBuilder LastCell();

        /// <summary>
        /// Gets the request builder for WorkbookRangeLastColumn.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeLastColumnRequestBuilder"/>.</returns>
        IWorkbookRangeLastColumnRequestBuilder LastColumn();

        /// <summary>
        /// Gets the request builder for WorkbookRangeLastRow.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeLastRowRequestBuilder"/>.</returns>
        IWorkbookRangeLastRowRequestBuilder LastRow();

        /// <summary>
        /// Gets the request builder for WorkbookRangeOffsetRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeOffsetRangeRequestBuilder"/>.</returns>
        IWorkbookRangeOffsetRangeRequestBuilder OffsetRange(
            Int32 rowOffset,
            Int32 columnOffset);

        /// <summary>
        /// Gets the request builder for WorkbookRangeResizedRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeResizedRangeRequestBuilder"/>.</returns>
        IWorkbookRangeResizedRangeRequestBuilder ResizedRange(
            Int32 deltaRows,
            Int32 deltaColumns);

        /// <summary>
        /// Gets the request builder for WorkbookRangeRow.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeRowRequestBuilder"/>.</returns>
        IWorkbookRangeRowRequestBuilder Row(
            Int32 row);

        /// <summary>
        /// Gets the request builder for WorkbookRangeRowsAbove.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeRowsAboveRequestBuilder"/>.</returns>
        IWorkbookRangeRowsAboveRequestBuilder RowsAbove();

        /// <summary>
        /// Gets the request builder for WorkbookRangeRowsAbove.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeRowsAboveRequestBuilder"/>.</returns>
        IWorkbookRangeRowsAboveRequestBuilder RowsAbove(
            Int32? count = null);

        /// <summary>
        /// Gets the request builder for WorkbookRangeRowsBelow.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeRowsBelowRequestBuilder"/>.</returns>
        IWorkbookRangeRowsBelowRequestBuilder RowsBelow();

        /// <summary>
        /// Gets the request builder for WorkbookRangeRowsBelow.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeRowsBelowRequestBuilder"/>.</returns>
        IWorkbookRangeRowsBelowRequestBuilder RowsBelow(
            Int32? count = null);

        /// <summary>
        /// Gets the request builder for WorkbookRangeUsedRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeUsedRangeRequestBuilder"/>.</returns>
        IWorkbookRangeUsedRangeRequestBuilder UsedRange();

        /// <summary>
        /// Gets the request builder for WorkbookRangeUsedRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeUsedRangeRequestBuilder"/>.</returns>
        IWorkbookRangeUsedRangeRequestBuilder UsedRange(
            bool valuesOnly);

        /// <summary>
        /// Gets the request builder for WorkbookRangeVisibleView.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeVisibleViewRequestBuilder"/>.</returns>
        IWorkbookRangeVisibleViewRequestBuilder VisibleView();
    
    }
}
