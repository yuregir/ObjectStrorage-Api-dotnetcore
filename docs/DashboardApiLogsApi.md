# Org.OpenAPITools.Api.DashboardApiLogsApi

All URIs are relative to *https://api.teke.li/api/v1/obs*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetdashboardApiLogs**](DashboardApiLogsApi.md#getdashboardapilogs) | **GET** /dashboard_api_logs | Retrieves one or more dashboard_api_logs
[**GetdashboardApiLogsItem**](DashboardApiLogsApi.md#getdashboardapilogsitem) | **GET** /dashboard_api_logs/{dashboard-api-logsId} | Retrieves a dashboard-api-logs document
[**PatchdashboardApiLogsItem**](DashboardApiLogsApi.md#patchdashboardapilogsitem) | **PATCH** /dashboard_api_logs/{dashboard-api-logsId} | Updates a dashboard-api-logs document
[**PostdashboardApiLogs**](DashboardApiLogsApi.md#postdashboardapilogs) | **POST** /dashboard_api_logs | Stores one or more dashboard_api_logs.
[**PutdashboardApiLogsItem**](DashboardApiLogsApi.md#putdashboardapilogsitem) | **PUT** /dashboard_api_logs/{dashboard-api-logsId} | Replaces a dashboard-api-logs document


<a name="getdashboardapilogs"></a>
# **GetdashboardApiLogs**
> InlineResponse200 GetdashboardApiLogs (string where = null, string sort = null, int? page = null, int? maxResults = null)

Retrieves one or more dashboard_api_logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetdashboardApiLogsExample
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

            var apiInstance = new DashboardApiLogsApi(Configuration.Default);
            var where = where_example;  // string | the filters query parameter (ex.: {\"number\": 10}) (optional) 
            var sort = sort_example;  // string | the sort query parameter (ex.: \"city,-lastname\") (optional) 
            var page = 1;  // int? | the pages query parameter (optional) 
            var maxResults = 25;  // int? | the max results query parameter (optional) 

            try
            {
                // Retrieves one or more dashboard_api_logs
                InlineResponse200 result = apiInstance.GetdashboardApiLogs(where, sort, page, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardApiLogsApi.GetdashboardApiLogs: " + e.Message );
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

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of dashboard_api_logs |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdashboardapilogsitem"></a>
# **GetdashboardApiLogsItem**
> DashboardApiLogs GetdashboardApiLogsItem (string dashboardApiLogsId)

Retrieves a dashboard-api-logs document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetdashboardApiLogsItemExample
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

            var apiInstance = new DashboardApiLogsApi(Configuration.Default);
            var dashboardApiLogsId = dashboardApiLogsId_example;  // string | 

            try
            {
                // Retrieves a dashboard-api-logs document
                DashboardApiLogs result = apiInstance.GetdashboardApiLogsItem(dashboardApiLogsId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardApiLogsApi.GetdashboardApiLogsItem: " + e.Message );
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
 **dashboardApiLogsId** | **string**|  | 

### Return type

[**DashboardApiLogs**](DashboardApiLogs.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | dashboard-api-logs document fetched successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchdashboardapilogsitem"></a>
# **PatchdashboardApiLogsItem**
> void PatchdashboardApiLogsItem (string dashboardApiLogsId, string ifMatch, DashboardApiLogs dashboardApiLogs)

Updates a dashboard-api-logs document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchdashboardApiLogsItemExample
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

            var apiInstance = new DashboardApiLogsApi(Configuration.Default);
            var dashboardApiLogsId = dashboardApiLogsId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var dashboardApiLogs = new DashboardApiLogs(); // DashboardApiLogs | A dashboard-api-logs or list of dashboard-api-logs documents

            try
            {
                // Updates a dashboard-api-logs document
                apiInstance.PatchdashboardApiLogsItem(dashboardApiLogsId, ifMatch, dashboardApiLogs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardApiLogsApi.PatchdashboardApiLogsItem: " + e.Message );
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
 **dashboardApiLogsId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **dashboardApiLogs** | [**DashboardApiLogs**](DashboardApiLogs.md)| A dashboard-api-logs or list of dashboard-api-logs documents | 

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
| **200** | dashboard-api-logs document updated successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdashboardapilogs"></a>
# **PostdashboardApiLogs**
> void PostdashboardApiLogs (DashboardApiLogs dashboardApiLogs)

Stores one or more dashboard_api_logs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostdashboardApiLogsExample
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

            var apiInstance = new DashboardApiLogsApi(Configuration.Default);
            var dashboardApiLogs = new DashboardApiLogs(); // DashboardApiLogs | A dashboard-api-logs or list of dashboard-api-logs documents

            try
            {
                // Stores one or more dashboard_api_logs.
                apiInstance.PostdashboardApiLogs(dashboardApiLogs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardApiLogsApi.PostdashboardApiLogs: " + e.Message );
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
 **dashboardApiLogs** | [**DashboardApiLogs**](DashboardApiLogs.md)| A dashboard-api-logs or list of dashboard-api-logs documents | 

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

<a name="putdashboardapilogsitem"></a>
# **PutdashboardApiLogsItem**
> void PutdashboardApiLogsItem (string dashboardApiLogsId, string ifMatch, DashboardApiLogs dashboardApiLogs)

Replaces a dashboard-api-logs document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PutdashboardApiLogsItemExample
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

            var apiInstance = new DashboardApiLogsApi(Configuration.Default);
            var dashboardApiLogsId = dashboardApiLogsId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var dashboardApiLogs = new DashboardApiLogs(); // DashboardApiLogs | A dashboard-api-logs or list of dashboard-api-logs documents

            try
            {
                // Replaces a dashboard-api-logs document
                apiInstance.PutdashboardApiLogsItem(dashboardApiLogsId, ifMatch, dashboardApiLogs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardApiLogsApi.PutdashboardApiLogsItem: " + e.Message );
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
 **dashboardApiLogsId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **dashboardApiLogs** | [**DashboardApiLogs**](DashboardApiLogs.md)| A dashboard-api-logs or list of dashboard-api-logs documents | 

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
| **200** | dashboard-api-logs document replaced successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

