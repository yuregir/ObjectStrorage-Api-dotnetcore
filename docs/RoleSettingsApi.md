# Org.OpenAPITools.Api.RoleSettingsApi

All URIs are relative to *https://api.teke.li/api/v1/obs*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetroleSettings**](RoleSettingsApi.md#getrolesettings) | **GET** /role_settings | Retrieves one or more role_settings
[**GetroleSettingsItem**](RoleSettingsApi.md#getrolesettingsitem) | **GET** /role_settings/{role-settingsId} | Retrieves a role-settings document
[**PatchroleSettingsItem**](RoleSettingsApi.md#patchrolesettingsitem) | **PATCH** /role_settings/{role-settingsId} | Updates a role-settings document
[**PostroleSettings**](RoleSettingsApi.md#postrolesettings) | **POST** /role_settings | Stores one or more role_settings.
[**PutroleSettingsItem**](RoleSettingsApi.md#putrolesettingsitem) | **PUT** /role_settings/{role-settingsId} | Replaces a role-settings document


<a name="getrolesettings"></a>
# **GetroleSettings**
> InlineResponse20010 GetroleSettings (string where = null, string sort = null, int? page = null, int? maxResults = null)

Retrieves one or more role_settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetroleSettingsExample
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

            var apiInstance = new RoleSettingsApi(Configuration.Default);
            var where = where_example;  // string | the filters query parameter (ex.: {\"number\": 10}) (optional) 
            var sort = sort_example;  // string | the sort query parameter (ex.: \"city,-lastname\") (optional) 
            var page = 1;  // int? | the pages query parameter (optional) 
            var maxResults = 25;  // int? | the max results query parameter (optional) 

            try
            {
                // Retrieves one or more role_settings
                InlineResponse20010 result = apiInstance.GetroleSettings(where, sort, page, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleSettingsApi.GetroleSettings: " + e.Message );
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

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of role_settings |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolesettingsitem"></a>
# **GetroleSettingsItem**
> RoleSettings GetroleSettingsItem (string roleSettingsId)

Retrieves a role-settings document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetroleSettingsItemExample
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

            var apiInstance = new RoleSettingsApi(Configuration.Default);
            var roleSettingsId = roleSettingsId_example;  // string | 

            try
            {
                // Retrieves a role-settings document
                RoleSettings result = apiInstance.GetroleSettingsItem(roleSettingsId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleSettingsApi.GetroleSettingsItem: " + e.Message );
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
 **roleSettingsId** | **string**|  | 

### Return type

[**RoleSettings**](RoleSettings.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | role-settings document fetched successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchrolesettingsitem"></a>
# **PatchroleSettingsItem**
> void PatchroleSettingsItem (string roleSettingsId, string ifMatch, RoleSettings roleSettings)

Updates a role-settings document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchroleSettingsItemExample
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

            var apiInstance = new RoleSettingsApi(Configuration.Default);
            var roleSettingsId = roleSettingsId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var roleSettings = new RoleSettings(); // RoleSettings | A role-settings or list of role-settings documents

            try
            {
                // Updates a role-settings document
                apiInstance.PatchroleSettingsItem(roleSettingsId, ifMatch, roleSettings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleSettingsApi.PatchroleSettingsItem: " + e.Message );
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
 **roleSettingsId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **roleSettings** | [**RoleSettings**](RoleSettings.md)| A role-settings or list of role-settings documents | 

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
| **200** | role-settings document updated successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrolesettings"></a>
# **PostroleSettings**
> void PostroleSettings (RoleSettings roleSettings)

Stores one or more role_settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostroleSettingsExample
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

            var apiInstance = new RoleSettingsApi(Configuration.Default);
            var roleSettings = new RoleSettings(); // RoleSettings | A role-settings or list of role-settings documents

            try
            {
                // Stores one or more role_settings.
                apiInstance.PostroleSettings(roleSettings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleSettingsApi.PostroleSettings: " + e.Message );
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
 **roleSettings** | [**RoleSettings**](RoleSettings.md)| A role-settings or list of role-settings documents | 

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

<a name="putrolesettingsitem"></a>
# **PutroleSettingsItem**
> void PutroleSettingsItem (string roleSettingsId, string ifMatch, RoleSettings roleSettings)

Replaces a role-settings document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PutroleSettingsItemExample
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

            var apiInstance = new RoleSettingsApi(Configuration.Default);
            var roleSettingsId = roleSettingsId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var roleSettings = new RoleSettings(); // RoleSettings | A role-settings or list of role-settings documents

            try
            {
                // Replaces a role-settings document
                apiInstance.PutroleSettingsItem(roleSettingsId, ifMatch, roleSettings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleSettingsApi.PutroleSettingsItem: " + e.Message );
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
 **roleSettingsId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **roleSettings** | [**RoleSettings**](RoleSettings.md)| A role-settings or list of role-settings documents | 

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
| **200** | role-settings document replaced successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

