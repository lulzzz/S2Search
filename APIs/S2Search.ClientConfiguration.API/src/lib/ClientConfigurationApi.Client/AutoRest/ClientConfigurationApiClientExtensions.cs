// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.ClientConfigurationApi.Client.AutoRest
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ClientConfigurationApiClient.
    /// </summary>
    public static partial class ClientConfigurationApiClientExtensions
    {
            /// <summary>
            /// Retrieve search index query credentials by the requested customerEndpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customerEndpoint'>
            /// The host that is calling the application consuming this endpoint.
            /// </param>
            public static object GetSearchIndexQueryCredentials(this IClientConfigurationApiClient operations, string customerEndpoint)
            {
                return operations.GetSearchIndexQueryCredentialsAsync(customerEndpoint).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve search index query credentials by the requested customerEndpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customerEndpoint'>
            /// The host that is calling the application consuming this endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetSearchIndexQueryCredentialsAsync(this IClientConfigurationApiClient operations, string customerEndpoint, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSearchIndexQueryCredentialsWithHttpMessagesAsync(customerEndpoint, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve the theme for the requested customerEndpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customerEndpoint'>
            /// The host that is calling the application consuming this endpoint.
            /// </param>
            public static object GetTheme(this IClientConfigurationApiClient operations, string customerEndpoint)
            {
                return operations.GetThemeAsync(customerEndpoint).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the theme for the requested customerEndpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customerEndpoint'>
            /// The host that is calling the application consuming this endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetThemeAsync(this IClientConfigurationApiClient operations, string customerEndpoint, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetThemeWithHttpMessagesAsync(customerEndpoint, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve the configuration for a search index
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customerEndpoint'>
            /// The host that is calling the application consuming this endpoint.
            /// </param>
            public static object GetSearchConfiguration(this IClientConfigurationApiClient operations, string customerEndpoint)
            {
                return operations.GetSearchConfigurationAsync(customerEndpoint).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the configuration for a search index
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customerEndpoint'>
            /// The host that is calling the application consuming this endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetSearchConfigurationAsync(this IClientConfigurationApiClient operations, string customerEndpoint, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSearchConfigurationWithHttpMessagesAsync(customerEndpoint, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve the Generic Synonyms
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='category'>
            /// The category of the generic synonyms to retrieve.
            /// </param>
            public static object GetGenericSynonyms(this IClientConfigurationApiClient operations, string category)
            {
                return operations.GetGenericSynonymsAsync(category).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the Generic Synonyms
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='category'>
            /// The category of the generic synonyms to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetGenericSynonymsAsync(this IClientConfigurationApiClient operations, string category, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGenericSynonymsWithHttpMessagesAsync(category, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetAPIStatus(this IClientConfigurationApiClient operations)
            {
                operations.GetAPIStatusAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetAPIStatusAsync(this IClientConfigurationApiClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetAPIStatusWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}