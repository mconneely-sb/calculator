# IO.Swagger.Api.AccountsApi

All URIs are relative to *https://virtserver.swaggerhub.com/MConneely/Sample_PostOffice_API/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsGet**](AccountsApi.md#accountsget) | **GET** /accounts | List accounts
[**AccountsIdGet**](AccountsApi.md#accountsidget) | **GET** /accounts/{id} | Get an account

<a name="accountsget"></a>
# **AccountsGet**
> InlineResponse200 AccountsGet ()

List accounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();

            try
            {
                // List accounts
                InlineResponse200 result = apiInstance.AccountsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountsidget"></a>
# **AccountsIdGet**
> Account AccountsIdGet (string id)

Get an account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsIdGetExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var id = id_example;  // string | Account's id

            try
            {
                // Get an account
                Account result = apiInstance.AccountsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Account&#x27;s id | 

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
