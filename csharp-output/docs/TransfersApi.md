# IO.Swagger.Api.TransfersApi

All URIs are relative to *https://virtserver.swaggerhub.com/MConneely/Sample_PostOffice_API/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SourcesGet**](TransfersApi.md#sourcesget) | **GET** /sources | List transfer sources
[**SourcesIdDestinationsGet**](TransfersApi.md#sourcesiddestinationsget) | **GET** /sources/{id}/destinations | List transfer source&#x27;s destinations
[**TransfersGet**](TransfersApi.md#transfersget) | **GET** /transfers | List money transfers
[**TransfersIdDelete**](TransfersApi.md#transfersiddelete) | **DELETE** /transfers/{id} | Cancel a money transfer
[**TransfersIdGet**](TransfersApi.md#transfersidget) | **GET** /transfers/{id} | Get a money transfer
[**TransfersPost**](TransfersApi.md#transferspost) | **POST** /transfers | Transfer money

<a name="sourcesget"></a>
# **SourcesGet**
> void SourcesGet ()

List transfer sources

Not all bank accounts can be used as a source for a money transfers. This operation returns only the accounts elligible as a money transfer source. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SourcesGetExample
    {
        public void main()
        {
            var apiInstance = new TransfersApi();

            try
            {
                // List transfer sources
                apiInstance.SourcesGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransfersApi.SourcesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sourcesiddestinationsget"></a>
# **SourcesIdDestinationsGet**
> void SourcesIdDestinationsGet (string id)

List transfer source's destinations

Depending on the source account, only specific beneficiaries or accounts can be used as a money transfer destination. This operation returns them. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SourcesIdDestinationsGetExample
    {
        public void main()
        {
            var apiInstance = new TransfersApi();
            var id = id_example;  // string | Source's id

            try
            {
                // List transfer source's destinations
                apiInstance.SourcesIdDestinationsGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransfersApi.SourcesIdDestinationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Source&#x27;s id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="transfersget"></a>
# **TransfersGet**
> TransferList TransfersGet ()

List money transfers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TransfersGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: POAPIScopes
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransfersApi();

            try
            {
                // List money transfers
                TransferList result = apiInstance.TransfersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransfersApi.TransfersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TransferList**](TransferList.md)

### Authorization

[POAPIScopes](../README.md#POAPIScopes)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="transfersiddelete"></a>
# **TransfersIdDelete**
> void TransfersIdDelete (string id)

Cancel a money transfer

Only delayed or recurring money transfer can be canceled

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TransfersIdDeleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: POAPIScopes
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransfersApi();
            var id = id_example;  // string | Transfer's id

            try
            {
                // Cancel a money transfer
                apiInstance.TransfersIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransfersApi.TransfersIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Transfer&#x27;s id | 

### Return type

void (empty response body)

### Authorization

[POAPIScopes](../README.md#POAPIScopes)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="transfersidget"></a>
# **TransfersIdGet**
> void TransfersIdGet (string id)

Get a money transfer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TransfersIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: POAPIScopes
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransfersApi();
            var id = id_example;  // string | Transfer's id

            try
            {
                // Get a money transfer
                apiInstance.TransfersIdGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransfersApi.TransfersIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Transfer&#x27;s id | 

### Return type

void (empty response body)

### Authorization

[POAPIScopes](../README.md#POAPIScopes)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="transferspost"></a>
# **TransfersPost**
> TransferResponse TransfersPost (TransferRequest body = null)

Transfer money

This operation allows one to transfer an `amount` of money from a `source` account to a `destination` account. There are three different types of money transfer:   - Immediate - - these are executed as soon as the request is received    - Delayed - - these are executed upon a given future `date`   - Recurring - - these are executed a given `occurrences` number of times at a given `frequency` - - the first occurrence being executed immediately or at a given `date` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TransfersPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: POAPIScopes
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransfersApi();
            var body = new TransferRequest(); // TransferRequest |  (optional) 

            try
            {
                // Transfer money
                TransferResponse result = apiInstance.TransfersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransfersApi.TransfersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransferRequest**](TransferRequest.md)|  | [optional] 

### Return type

[**TransferResponse**](TransferResponse.md)

### Authorization

[POAPIScopes](../README.md#POAPIScopes)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
