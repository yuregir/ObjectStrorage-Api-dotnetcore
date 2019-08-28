# Org.OpenAPITools.Api.TenantsApi

All URIs are relative to *https://api.teke.li/api/v1/obs*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Gettenants**](TenantsApi.md#gettenants) | **GET** /tenants | Retrieves one or more tenants
[**GettenantsItem**](TenantsApi.md#gettenantsitem) | **GET** /tenants/{tenantsId} | Retrieves a tenants document
[**PatchtenantsItem**](TenantsApi.md#patchtenantsitem) | **PATCH** /tenants/{tenantsId} | Updates a tenants document
[**Posttenants**](TenantsApi.md#posttenants) | **POST** /tenants | Stores one or more tenants.
[**PuttenantsItem**](TenantsApi.md#puttenantsitem) | **PUT** /tenants/{tenantsId} | Replaces a tenants document


<a name="gettenants"></a>
# **Gettenants**
> InlineResponse20014 Gettenants (string where = null, string sort = null, int? page = null, int? maxResults = null)

Retrieves one or more tenants

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GettenantsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.teke.li/api/v1/obs";
            // Configure API key authorization: ApiKeyHeaderAuth
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");
            // Configure API key authorization: ApiKeyQueryAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TenantsApi(Configuration.Default);
            var where = where_example;  // string | the filters query parameter (ex.: {\"number\": 10}) (optional) 
            var sort = sort_example;  // string | the sort query parameter (ex.: \"city,-lastname\") (optional) 
            var page = 1;  // int? | the pages query parameter (optional) 
            var maxResults = 25;  // int? | the max results query parameter (optional) 

            try
            {
                // Retrieves one or more tenants
                InlineResponse20014 result = apiInstance.Gettenants(where, sort, page, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.Gettenants: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| the filters query parameter (ex.: {\&quot;number\&quot;: 10}) | [optional] 
 **sort** | **string**| the sort query parameter (ex.: \&quot;city,-lastname\&quot;) | [optional] 
 **page** | **int?**| the pages query parameter | [optional] 
 **maxResults** | **int?**| the max results query parameter | [optional] 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of tenants |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettenantsitem"></a>
# **GettenantsItem**
> Tenants GettenantsItem (string tenantsId)

Retrieves a tenants document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GettenantsItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.teke.li/api/v1/obs";
            // Configure API key authorization: ApiKeyHeaderAuth
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");
            // Configure API key authorization: ApiKeyQueryAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TenantsApi(Configuration.Default);
            var tenantsId = tenantsId_example;  // string | 

            try
            {
                // Retrieves a tenants document
                Tenants result = apiInstance.GettenantsItem(tenantsId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.GettenantsItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenantsId** | **string**|  | 

### Return type

[**Tenants**](Tenants.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | tenants document fetched successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchtenantsitem"></a>
# **PatchtenantsItem**
> void PatchtenantsItem (string tenantsId, string ifMatch, Tenants tenants)

Updates a tenants document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchtenantsItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.teke.li/api/v1/obs";
            // Configure API key authorization: ApiKeyHeaderAuth
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");
            // Configure API key authorization: ApiKeyQueryAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TenantsApi(Configuration.Default);
            var tenantsId = tenantsId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var tenants = new Tenants(); // Tenants | A tenants or list of tenants documents

            try
            {
                // Updates a tenants document
                apiInstance.PatchtenantsItem(tenantsId, ifMatch, tenants);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.PatchtenantsItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenantsId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **tenants** | [**Tenants**](Tenants.md)| A tenants or list of tenants documents | 

### Return type

void (empty response body)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | tenants document updated successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttenants"></a>
# **Posttenants**
> void Posttenants (Tenants tenants)

Stores one or more tenants.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PosttenantsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.teke.li/api/v1/obs";
            // Configure API key authorization: ApiKeyHeaderAuth
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");
            // Configure API key authorization: ApiKeyQueryAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TenantsApi(Configuration.Default);
            var tenants = new Tenants(); // Tenants | A tenants or list of tenants documents

            try
            {
                // Stores one or more tenants.
                apiInstance.Posttenants(tenants);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.Posttenants: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenants** | [**Tenants**](Tenants.md)| A tenants or list of tenants documents | 

### Return type

void (empty response body)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | operation has been successful |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puttenantsitem"></a>
# **PuttenantsItem**
> void PuttenantsItem (string tenantsId, string ifMatch, Tenants tenants)

Replaces a tenants document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PuttenantsItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.teke.li/api/v1/obs";
            // Configure API key authorization: ApiKeyHeaderAuth
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");
            // Configure API key authorization: ApiKeyQueryAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TenantsApi(Configuration.Default);
            var tenantsId = tenantsId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var tenants = new Tenants(); // Tenants | A tenants or list of tenants documents

            try
            {
                // Replaces a tenants document
                apiInstance.PuttenantsItem(tenantsId, ifMatch, tenants);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.PuttenantsItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenantsId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **tenants** | [**Tenants**](Tenants.md)| A tenants or list of tenants documents | 

### Return type

void (empty response body)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | tenants document replaced successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

