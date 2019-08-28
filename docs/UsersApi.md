# Org.OpenAPITools.Api.UsersApi

All URIs are relative to *https://api.teke.li/api/v1/obs*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Getusers**](UsersApi.md#getusers) | **GET** /users | Retrieves one or more users
[**GetusersItem**](UsersApi.md#getusersitem) | **GET** /users/{usersId} | Retrieves a users document
[**PatchusersItem**](UsersApi.md#patchusersitem) | **PATCH** /users/{usersId} | Updates a users document
[**Postusers**](UsersApi.md#postusers) | **POST** /users | Stores one or more users.
[**PutusersItem**](UsersApi.md#putusersitem) | **PUT** /users/{usersId} | Replaces a users document


<a name="getusers"></a>
# **Getusers**
> InlineResponse20015 Getusers (string where = null, string sort = null, int? page = null, int? maxResults = null)

Retrieves one or more users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetusersExample
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

            var apiInstance = new UsersApi(Configuration.Default);
            var where = where_example;  // string | the filters query parameter (ex.: {\"number\": 10}) (optional) 
            var sort = sort_example;  // string | the sort query parameter (ex.: \"city,-lastname\") (optional) 
            var page = 1;  // int? | the pages query parameter (optional) 
            var maxResults = 25;  // int? | the max results query parameter (optional) 

            try
            {
                // Retrieves one or more users
                InlineResponse20015 result = apiInstance.Getusers(where, sort, page, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.Getusers: " + e.Message );
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

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of users |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersitem"></a>
# **GetusersItem**
> Users GetusersItem (string usersId)

Retrieves a users document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetusersItemExample
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

            var apiInstance = new UsersApi(Configuration.Default);
            var usersId = usersId_example;  // string | 

            try
            {
                // Retrieves a users document
                Users result = apiInstance.GetusersItem(usersId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetusersItem: " + e.Message );
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
 **usersId** | **string**|  | 

### Return type

[**Users**](Users.md)

### Authorization

[ApiKeyHeaderAuth](../README.md#ApiKeyHeaderAuth), [ApiKeyQueryAuth](../README.md#ApiKeyQueryAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | users document fetched successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchusersitem"></a>
# **PatchusersItem**
> void PatchusersItem (string usersId, string ifMatch, Users users)

Updates a users document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchusersItemExample
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

            var apiInstance = new UsersApi(Configuration.Default);
            var usersId = usersId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var users = new Users(); // Users | A users or list of users documents

            try
            {
                // Updates a users document
                apiInstance.PatchusersItem(usersId, ifMatch, users);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.PatchusersItem: " + e.Message );
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
 **usersId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **users** | [**Users**](Users.md)| A users or list of users documents | 

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
| **200** | users document updated successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusers"></a>
# **Postusers**
> void Postusers (Users users)

Stores one or more users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostusersExample
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

            var apiInstance = new UsersApi(Configuration.Default);
            var users = new Users(); // Users | A users or list of users documents

            try
            {
                // Stores one or more users.
                apiInstance.Postusers(users);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.Postusers: " + e.Message );
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
 **users** | [**Users**](Users.md)| A users or list of users documents | 

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

<a name="putusersitem"></a>
# **PutusersItem**
> void PutusersItem (string usersId, string ifMatch, Users users)

Replaces a users document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PutusersItemExample
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

            var apiInstance = new UsersApi(Configuration.Default);
            var usersId = usersId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | Current value of the _etag field
            var users = new Users(); // Users | A users or list of users documents

            try
            {
                // Replaces a users document
                apiInstance.PutusersItem(usersId, ifMatch, users);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.PutusersItem: " + e.Message );
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
 **usersId** | **string**|  | 
 **ifMatch** | **string**| Current value of the _etag field | 
 **users** | [**Users**](Users.md)| A users or list of users documents | 

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
| **200** | users document replaced successfully |  -  |
| **0** | An error message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

