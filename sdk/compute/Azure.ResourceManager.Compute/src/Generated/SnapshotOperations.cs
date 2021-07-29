// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the operations that can be performed over a specific Snapshot. </summary>
    public partial class SnapshotOperations : ResourceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private SnapshotsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="SnapshotOperations"/> class for mocking. </summary>
        protected SnapshotOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SnapshotOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal SnapshotOperations(ResourceOperations options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new SnapshotsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/snapshots";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets information about a snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<Snapshot>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Snapshot(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about a snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Snapshot> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new Snapshot(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes a snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SnapshotsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new SnapshotsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SnapshotsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new SnapshotsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public async virtual Task<Response<Snapshot>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Snapshot(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public virtual Response<Snapshot> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new Snapshot(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public async virtual Task<Response<Snapshot>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.SetTags");
            scope.Start();
            try
            {
                await TagResourceOperations.DeleteAsync(cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Snapshot(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public virtual Response<Snapshot> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.SetTags");
            scope.Start();
            try
            {
                TagResourceOperations.Delete(cancellationToken);
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new Snapshot(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public async virtual Task<Response<Snapshot>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Snapshot(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public virtual Response<Snapshot> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new Snapshot(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates (patches) a snapshot. </summary>
        /// <param name="snapshot"> Snapshot object supplied in the body of the Patch snapshot operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshot"/> is null. </exception>
        public async virtual Task<Response<Snapshot>> UpdateAsync(SnapshotUpdate snapshot, CancellationToken cancellationToken = default)
        {
            if (snapshot == null)
            {
                throw new ArgumentNullException(nameof(snapshot));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.Update");
            scope.Start();
            try
            {
                var operation = await StartUpdateAsync(snapshot, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates (patches) a snapshot. </summary>
        /// <param name="snapshot"> Snapshot object supplied in the body of the Patch snapshot operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshot"/> is null. </exception>
        public virtual Response<Snapshot> Update(SnapshotUpdate snapshot, CancellationToken cancellationToken = default)
        {
            if (snapshot == null)
            {
                throw new ArgumentNullException(nameof(snapshot));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.Update");
            scope.Start();
            try
            {
                var operation = StartUpdate(snapshot, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates (patches) a snapshot. </summary>
        /// <param name="snapshot"> Snapshot object supplied in the body of the Patch snapshot operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshot"/> is null. </exception>
        public async virtual Task<SnapshotsUpdateOperation> StartUpdateAsync(SnapshotUpdate snapshot, CancellationToken cancellationToken = default)
        {
            if (snapshot == null)
            {
                throw new ArgumentNullException(nameof(snapshot));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.StartUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateAsync(Id.ResourceGroupName, Id.Name, snapshot, cancellationToken).ConfigureAwait(false);
                return new SnapshotsUpdateOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateRequest(Id.ResourceGroupName, Id.Name, snapshot).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates (patches) a snapshot. </summary>
        /// <param name="snapshot"> Snapshot object supplied in the body of the Patch snapshot operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshot"/> is null. </exception>
        public virtual SnapshotsUpdateOperation StartUpdate(SnapshotUpdate snapshot, CancellationToken cancellationToken = default)
        {
            if (snapshot == null)
            {
                throw new ArgumentNullException(nameof(snapshot));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.StartUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Update(Id.ResourceGroupName, Id.Name, snapshot, cancellationToken);
                return new SnapshotsUpdateOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateRequest(Id.ResourceGroupName, Id.Name, snapshot).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Grants access to a snapshot. </summary>
        /// <param name="grantAccessData"> Access data object supplied in the body of the get snapshot access operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="grantAccessData"/> is null. </exception>
        public async virtual Task<Response<AccessUri>> GrantAccessAsync(GrantAccessData grantAccessData, CancellationToken cancellationToken = default)
        {
            if (grantAccessData == null)
            {
                throw new ArgumentNullException(nameof(grantAccessData));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.GrantAccess");
            scope.Start();
            try
            {
                var operation = await StartGrantAccessAsync(grantAccessData, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Grants access to a snapshot. </summary>
        /// <param name="grantAccessData"> Access data object supplied in the body of the get snapshot access operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="grantAccessData"/> is null. </exception>
        public virtual Response<AccessUri> GrantAccess(GrantAccessData grantAccessData, CancellationToken cancellationToken = default)
        {
            if (grantAccessData == null)
            {
                throw new ArgumentNullException(nameof(grantAccessData));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.GrantAccess");
            scope.Start();
            try
            {
                var operation = StartGrantAccess(grantAccessData, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Grants access to a snapshot. </summary>
        /// <param name="grantAccessData"> Access data object supplied in the body of the get snapshot access operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="grantAccessData"/> is null. </exception>
        public async virtual Task<SnapshotsGrantAccessOperation> StartGrantAccessAsync(GrantAccessData grantAccessData, CancellationToken cancellationToken = default)
        {
            if (grantAccessData == null)
            {
                throw new ArgumentNullException(nameof(grantAccessData));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.StartGrantAccess");
            scope.Start();
            try
            {
                var response = await _restClient.GrantAccessAsync(Id.ResourceGroupName, Id.Name, grantAccessData, cancellationToken).ConfigureAwait(false);
                return new SnapshotsGrantAccessOperation(_clientDiagnostics, Pipeline, _restClient.CreateGrantAccessRequest(Id.ResourceGroupName, Id.Name, grantAccessData).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Grants access to a snapshot. </summary>
        /// <param name="grantAccessData"> Access data object supplied in the body of the get snapshot access operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="grantAccessData"/> is null. </exception>
        public virtual SnapshotsGrantAccessOperation StartGrantAccess(GrantAccessData grantAccessData, CancellationToken cancellationToken = default)
        {
            if (grantAccessData == null)
            {
                throw new ArgumentNullException(nameof(grantAccessData));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.StartGrantAccess");
            scope.Start();
            try
            {
                var response = _restClient.GrantAccess(Id.ResourceGroupName, Id.Name, grantAccessData, cancellationToken);
                return new SnapshotsGrantAccessOperation(_clientDiagnostics, Pipeline, _restClient.CreateGrantAccessRequest(Id.ResourceGroupName, Id.Name, grantAccessData).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Revokes access to a snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> RevokeAccessAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.RevokeAccess");
            scope.Start();
            try
            {
                var operation = await StartRevokeAccessAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Revokes access to a snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RevokeAccess(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.RevokeAccess");
            scope.Start();
            try
            {
                var operation = StartRevokeAccess(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Revokes access to a snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SnapshotsRevokeAccessOperation> StartRevokeAccessAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.StartRevokeAccess");
            scope.Start();
            try
            {
                var response = await _restClient.RevokeAccessAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new SnapshotsRevokeAccessOperation(_clientDiagnostics, Pipeline, _restClient.CreateRevokeAccessRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Revokes access to a snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SnapshotsRevokeAccessOperation StartRevokeAccess(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotOperations.StartRevokeAccess");
            scope.Start();
            try
            {
                var response = _restClient.RevokeAccess(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new SnapshotsRevokeAccessOperation(_clientDiagnostics, Pipeline, _restClient.CreateRevokeAccessRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
