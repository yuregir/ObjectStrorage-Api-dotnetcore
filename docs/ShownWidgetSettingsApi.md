# Org.OpenAPITools.Api.ShownWidgetSettingsApi

All URIs are relative to *https://api.teke.li/api/v1/obs*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetshownWidgetSettings**](ShownWidgetSettingsApi.md#getshownwidgetsettings) | **GET** /shown_widget_settings | Retrieves one or more shown_widget_settings
[**GetshownWidgetSettingsItem**](ShownWidgetSettingsApi.md#getshownwidgetsettingsitem) | **GET** /shown_widget_settings/{shown-widget-settingsId} | Retrieves a shown-widget-settings document
[**PatchshownWidgetSettingsItem**](ShownWidgetSettingsApi.md#patchshownwidgetsettingsitem) | **PATCH** /shown_widget_settings/{shown-widget-settingsId} | Updates a shown-widget-settings document
[**PostshownWidgetSettings**](ShownWidgetSettingsApi.md#postshownwidgetsettings) | **POST** /shown_widget_settings | Stores one or more shown_widget_settings.
[**PutshownWidgetSettingsItem**](ShownWidgetSettingsApi.md#putshownwidgetsettingsitem) | **PUT** /shown_widget_settings/{shown-widget-settingsId} | Replaces a shown-widget-settings document


<a name="getshownwidgetsettings"></a>
# **GetshownWidgetSettings**
> InlineResponse20013 GetshownWidgetSettings (string where = null, string sort = null, int? page = null, int? maxResults = null)

Retrieves one or more shown_widget_settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetshownWidgetSettingsExample
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

            var apiInstance = new ShownWidgetSettingsApi(Configuration.Default);
            var where = where_example;  // string | the filters query parameter (ex.: {\"number\": 10}) (optional) 
            var sort = sort_example;  // string | the sort query parameter (ex.: \"city,-lastname\") (optional) 
            var page = 1;  // int? | the pages query parameter (optional) 
            var maxResults = 25;  // int? | the max results query parameter (optional) 

            try
            {
                // Retrieves one or more shown_widget_settings
                InlineResponse20013 result = apiInstance.GetshownWidgetSettings(where, sort, page, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShownWidgetSettingsApi.GetshownWidgetSettings: " + e.Message );
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

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of shown_widget_settings |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshownwidgetsettingsitem"></a>
# **GetshownWidgetSettingsItem**
> ShownWidgetSettings GetshownWidgetSettingsItem (string shownWidgetSettingsId)

Retrieves a shown-widget-settings document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetshownWidgetSettingsItemExample
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

            var apiInstance = new ShownWidgetSettingsApi(Configuration.Default);
            var shownWidgetSettingsId = shownWidgetSettingsId_example;  // string | 

            try
            {
                // Retrieves a shown-widget-settings document
                ShownWidgetSettings result = apiInstance.GetshownWidgetSettingsItem(shownWidgetSettingsId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShownWidgetSettingsApi.GetshownWidgetSettingsItem: " + e.Message );
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
 **shownWidgetSettingsId** | **string**|  | 

### Return type

[**ShownWidgetSettings**](ShownWidgetSettings.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | shown-widget-settings document fetched successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchshownwidgetsettingsitem"></a>
# **PatchshownWidgetSettingsItem**
> void PatchshownWidgetSettingsItem (string shownWidgetSettingsId, string ifMatch, ShownWidgetSettings shownWidgetSettings)

Updates a shown-widget-settings document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchshownWidgetSettingsItemExample
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

            var apiInstance = new ShownWidgetSettingsApi(Configuration.Default);
            var shownWidgetSettingsId = shownWidgetSettingsId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var shownWidgetSettings = new ShownWidgetSettings(); // ShownWidgetSettings | A shown-widget-settings or list of shown-widget-settings documents

            try
            {
                // Updates a shown-widget-settings document
                apiInstance.PatchshownWidgetSettingsItem(shownWidgetSettingsId, ifMatch, shownWidgetSettings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShownWidgetSettingsApi.PatchshownWidgetSettingsItem: " + e.Message );
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
 **shownWidgetSettingsId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **shownWidgetSettings** | [**ShownWidgetSettings**](ShownWidgetSettings.md)| A shown-widget-settings or list of shown-widget-settings documents | 

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
| **200** | shown-widget-settings document updated successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postshownwidgetsettings"></a>
# **PostshownWidgetSettings**
> void PostshownWidgetSettings (ShownWidgetSettings shownWidgetSettings)

Stores one or more shown_widget_settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostshownWidgetSettingsExample
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

            var apiInstance = new ShownWidgetSettingsApi(Configuration.Default);
            var shownWidgetSettings = new ShownWidgetSettings(); // ShownWidgetSettings | A shown-widget-settings or list of shown-widget-settings documents

            try
            {
                // Stores one or more shown_widget_settings.
                apiInstance.PostshownWidgetSettings(shownWidgetSettings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShownWidgetSettingsApi.PostshownWidgetSettings: " + e.Message );
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
 **shownWidgetSettings** | [**ShownWidgetSettings**](ShownWidgetSettings.md)| A shown-widget-settings or list of shown-widget-settings documents | 

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

<a name="putshownwidgetsettingsitem"></a>
# **PutshownWidgetSettingsItem**
> void PutshownWidgetSettingsItem (string shownWidgetSettingsId, string ifMatch, ShownWidgetSettings shownWidgetSettings)

Replaces a shown-widget-settings document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PutshownWidgetSettingsItemExample
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

            var apiInstance = new ShownWidgetSettingsApi(Configuration.Default);
            var shownWidgetSettingsId = shownWidgetSettingsId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var shownWidgetSettings = new ShownWidgetSettings(); // ShownWidgetSettings | A shown-widget-settings or list of shown-widget-settings documents

            try
            {
                // Replaces a shown-widget-settings document
                apiInstance.PutshownWidgetSettingsItem(shownWidgetSettingsId, ifMatch, shownWidgetSettings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShownWidgetSettingsApi.PutshownWidgetSettingsItem: " + e.Message );
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
 **shownWidgetSettingsId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **shownWidgetSettings** | [**ShownWidgetSettings**](ShownWidgetSettings.md)| A shown-widget-settings or list of shown-widget-settings documents | 

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
| **200** | shown-widget-settings document replaced successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

