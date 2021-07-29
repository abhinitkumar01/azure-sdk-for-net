// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of SharedGalleryImageVersion and their operations over a SharedGalleryImage. </summary>
    public partial class SharedGalleryImageVersionContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageVersionContainer"/> class for mocking. </summary>
        protected SharedGalleryImageVersionContainer()
        {
        }

        /// <summary> Initializes a new instance of SharedGalleryImageVersionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SharedGalleryImageVersionContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private SharedGalleryImageVersionsRestOperations _restClient => new SharedGalleryImageVersionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SharedGalleryImageOperations.ResourceType;

        // Container level operations.

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<SharedGalleryImageVersion> Get(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.Get");
            scope.Start();
            try
            {
                if (galleryImageVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageVersionName));
                }

                var response = _restClient.Get(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, galleryImageVersionName, cancellationToken: cancellationToken);
                return Response.FromValue(new SharedGalleryImageVersion(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<SharedGalleryImageVersion>> GetAsync(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.Get");
            scope.Start();
            try
            {
                if (galleryImageVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageVersionName));
                }

                var response = await _restClient.GetAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, galleryImageVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SharedGalleryImageVersion(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual SharedGalleryImageVersion TryGet(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.TryGet");
            scope.Start();
            try
            {
                if (galleryImageVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageVersionName));
                }

                return Get(galleryImageVersionName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<SharedGalleryImageVersion> TryGetAsync(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.TryGet");
            scope.Start();
            try
            {
                if (galleryImageVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageVersionName));
                }

                return await GetAsync(galleryImageVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (galleryImageVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageVersionName));
                }

                return TryGet(galleryImageVersionName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (galleryImageVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageVersionName));
                }

                return await TryGetAsync(galleryImageVersionName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List shared gallery image versions by subscription id or tenant id. </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SharedGalleryImageVersion" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<SharedGalleryImageVersion> GetAll(SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            Page<SharedGalleryImageVersion> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedGalleryImageVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SharedGalleryImageVersion> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedGalleryImageVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List shared gallery image versions by subscription id or tenant id. </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SharedGalleryImageVersion" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<SharedGalleryImageVersion> GetAllAsync(SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SharedGalleryImageVersion>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedGalleryImageVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SharedGalleryImageVersion>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedGalleryImageVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SharedGalleryImageVersion" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SharedGalleryImageVersionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SharedGalleryImageVersion" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageVersionContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SharedGalleryImageVersionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, SharedGalleryImageVersion, SharedGalleryImageVersionData> Construct() { }
    }
}
