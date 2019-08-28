# Org.OpenAPITools.Api.DeviceShadowApi

All URIs are relative to *https://api.teke.li/api/v1/obs*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetdeviceShadow**](DeviceShadowApi.md#getdeviceshadow) | **GET** /device_shadow | Retrieves one or more device_shadow
[**GetdeviceShadowItem**](DeviceShadowApi.md#getdeviceshadowitem) | **GET** /device_shadow/{device-shadowId} | Retrieves a device-shadow document
[**PatchdeviceShadowItem**](DeviceShadowApi.md#patchdeviceshadowitem) | **PATCH** /device_shadow/{device-shadowId} | Updates a device-shadow document
[**PostdeviceShadow**](DeviceShadowApi.md#postdeviceshadow) | **POST** /device_shadow | Stores one or more device_shadow.
[**PutdeviceShadowItem**](DeviceShadowApi.md#putdeviceshadowitem) | **PUT** /device_shadow/{device-shadowId} | Replaces a device-shadow document


<a name="getdeviceshadow"></a>
# **GetdeviceShadow**
> InlineResponse2001 GetdeviceShadow (string where = null, string sort = null, int? page = null, int? maxResults = null)

Retrieves one or more device_shadow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetdeviceShadowExample
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

            var apiInstance = new DeviceShadowApi(Configuration.Default);
            var where = where_example;  // string | the filters query parameter (ex.: {\"number\": 10}) (optional) 
            var sort = sort_example;  // string | the sort query parameter (ex.: \"city,-lastname\") (optional) 
            var page = 1;  // int? | the pages query parameter (optional) 
            var maxResults = 25;  // int? | the max results query parameter (optional) 

            try
            {
                // Retrieves one or more device_shadow
                InlineResponse2001 result = apiInstance.GetdeviceShadow(where, sort, page, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceShadowApi.GetdeviceShadow: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of device_shadow |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeviceshadowitem"></a>
# **GetdeviceShadowItem**
> DeviceShadow GetdeviceShadowItem (string deviceShadowId)

Retrieves a device-shadow document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetdeviceShadowItemExample
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

            var apiInstance = new DeviceShadowApi(Configuration.Default);
            var deviceShadowId = deviceShadowId_example;  // string | 

            try
            {
                // Retrieves a device-shadow document
                DeviceShadow result = apiInstance.GetdeviceShadowItem(deviceShadowId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceShadowApi.GetdeviceShadowItem: " + e.Message );
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
 **deviceShadowId** | **string**|  | 

### Return type

[**DeviceShadow**](DeviceShadow.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | device-shadow document fetched successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchdeviceshadowitem"></a>
# **PatchdeviceShadowItem**
> void PatchdeviceShadowItem (string deviceShadowId, string ifMatch, DeviceShadow deviceShadow)

Updates a device-shadow document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchdeviceShadowItemExample
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

            var apiInstance = new DeviceShadowApi(Configuration.Default);
            var deviceShadowId = deviceShadowId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var deviceShadow = new DeviceShadow(); // DeviceShadow | A device-shadow or list of device-shadow documents

            try
            {
                // Updates a device-shadow document
                apiInstance.PatchdeviceShadowItem(deviceShadowId, ifMatch, deviceShadow);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceShadowApi.PatchdeviceShadowItem: " + e.Message );
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
 **deviceShadowId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **deviceShadow** | [**DeviceShadow**](DeviceShadow.md)| A device-shadow or list of device-shadow documents | 

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
| **200** | device-shadow document updated successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdeviceshadow"></a>
# **PostdeviceShadow**
> void PostdeviceShadow (DeviceShadow deviceShadow)

Stores one or more device_shadow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostdeviceShadowExample
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

            var apiInstance = new DeviceShadowApi(Configuration.Default);
            var deviceShadow = new DeviceShadow(); // DeviceShadow | A device-shadow or list of device-shadow documents

            try
            {
                // Stores one or more device_shadow.
                apiInstance.PostdeviceShadow(deviceShadow);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceShadowApi.PostdeviceShadow: " + e.Message );
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
 **deviceShadow** | [**DeviceShadow**](DeviceShadow.md)| A device-shadow or list of device-shadow documents | 

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

<a name="putdeviceshadowitem"></a>
# **PutdeviceShadowItem**
> void PutdeviceShadowItem (string deviceShadowId, string ifMatch, DeviceShadow deviceShadow)

Replaces a device-shadow document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PutdeviceShadowItemExample
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

            var apiInstance = new DeviceShadowApi(Configuration.Default);
            var deviceShadowId = deviceShadowId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var deviceShadow = new DeviceShadow(); // DeviceShadow | A device-shadow or list of device-shadow documents

            try
            {
                // Replaces a device-shadow document
                apiInstance.PutdeviceShadowItem(deviceShadowId, ifMatch, deviceShadow);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceShadowApi.PutdeviceShadowItem: " + e.Message );
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
 **deviceShadowId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **deviceShadow** | [**DeviceShadow**](DeviceShadow.md)| A device-shadow or list of device-shadow documents | 

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
| **200** | device-shadow document replaced successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

