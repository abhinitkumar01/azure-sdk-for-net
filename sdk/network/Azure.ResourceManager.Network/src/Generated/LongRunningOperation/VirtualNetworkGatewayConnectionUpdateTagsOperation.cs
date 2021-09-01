// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Updates a virtual network gateway connection tags. </summary>
    public partial class VirtualNetworkGatewayConnectionUpdateTagsOperation : Operation<VirtualNetworkGatewayConnection>, IOperationSource<VirtualNetworkGatewayConnection>
    {
        private readonly OperationInternals<VirtualNetworkGatewayConnection> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of VirtualNetworkGatewayConnectionUpdateTagsOperation for mocking. </summary>
        protected VirtualNetworkGatewayConnectionUpdateTagsOperation()
        {
        }

        internal VirtualNetworkGatewayConnectionUpdateTagsOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualNetworkGatewayConnection>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "VirtualNetworkGatewayConnectionUpdateTagsOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualNetworkGatewayConnection Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualNetworkGatewayConnection>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualNetworkGatewayConnection>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualNetworkGatewayConnection IOperationSource<VirtualNetworkGatewayConnection>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new VirtualNetworkGatewayConnection(_operationBase, VirtualNetworkGatewayConnectionData.DeserializeVirtualNetworkGatewayConnectionData(document.RootElement));
        }

        async ValueTask<VirtualNetworkGatewayConnection> IOperationSource<VirtualNetworkGatewayConnection>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new VirtualNetworkGatewayConnection(_operationBase, VirtualNetworkGatewayConnectionData.DeserializeVirtualNetworkGatewayConnectionData(document.RootElement));
        }
    }
}
