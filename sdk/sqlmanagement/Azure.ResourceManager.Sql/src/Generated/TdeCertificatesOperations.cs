// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The TdeCertificates service client. </summary>
    public partial class TdeCertificatesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal TdeCertificatesRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of TdeCertificatesOperations for mocking. </summary>
        protected TdeCertificatesOperations()
        {
        }

        /// <summary> Initializes a new instance of TdeCertificatesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal TdeCertificatesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new TdeCertificatesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Creates a TDE certificate for a given server. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="parameters"> The requested TDE certificate to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<TdeCertificatesCreateOperation> StartCreateAsync(string resourceGroupName, string serverName, TdeCertificate parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TdeCertificatesOperations.StartCreate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateAsync(resourceGroupName, serverName, parameters, cancellationToken).ConfigureAwait(false);
                return new TdeCertificatesCreateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRequest(resourceGroupName, serverName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a TDE certificate for a given server. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="parameters"> The requested TDE certificate to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual TdeCertificatesCreateOperation StartCreate(string resourceGroupName, string serverName, TdeCertificate parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TdeCertificatesOperations.StartCreate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Create(resourceGroupName, serverName, parameters, cancellationToken);
                return new TdeCertificatesCreateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRequest(resourceGroupName, serverName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
