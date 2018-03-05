// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for MetricsOperations.
    /// </summary>
    public static partial class MetricsOperationsExtensions
    {
            /// <summary>
            /// **Lists the metric values for a resource**.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='timespan'>
            /// The timespan of the query. It is a string with the following format
            /// 'startDateTime_ISO/endDateTime_ISO'.
            /// </param>
            /// <param name='interval'>
            /// The interval (i.e. timegrain) of the query.
            /// </param>
            /// <param name='metric'>
            /// The name of the metric to retrieve.
            /// </param>
            /// <param name='aggregation'>
            /// The list of aggregation types (comma separated) to retrieve.
            /// </param>
            /// <param name='resultType'>
            /// Reduces the set of data collected. The syntax allowed depends on the
            /// operation. See the operation's description for details. Possible values
            /// include: 'Data', 'Metadata'
            /// </param>
            public static Response List(this IMetricsOperations operations, string resourceUri, ODataQuery<MetadataValue> odataQuery = default(ODataQuery<MetadataValue>), string timespan = default(string), System.TimeSpan? interval = default(System.TimeSpan?), string metric = default(string), string aggregation = default(string), ResultType? resultType = default(ResultType?))
            {
                return operations.ListAsync(resourceUri, odataQuery, timespan, interval, metric, aggregation, resultType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// **Lists the metric values for a resource**.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='timespan'>
            /// The timespan of the query. It is a string with the following format
            /// 'startDateTime_ISO/endDateTime_ISO'.
            /// </param>
            /// <param name='interval'>
            /// The interval (i.e. timegrain) of the query.
            /// </param>
            /// <param name='metric'>
            /// The name of the metric to retrieve.
            /// </param>
            /// <param name='aggregation'>
            /// The list of aggregation types (comma separated) to retrieve.
            /// </param>
            /// <param name='resultType'>
            /// Reduces the set of data collected. The syntax allowed depends on the
            /// operation. See the operation's description for details. Possible values
            /// include: 'Data', 'Metadata'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Response> ListAsync(this IMetricsOperations operations, string resourceUri, ODataQuery<MetadataValue> odataQuery = default(ODataQuery<MetadataValue>), string timespan = default(string), System.TimeSpan? interval = default(System.TimeSpan?), string metric = default(string), string aggregation = default(string), ResultType? resultType = default(ResultType?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceUri, odataQuery, timespan, interval, metric, aggregation, resultType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}