# IO.Swagger.Api.BeneficiariesApi

All URIs are relative to *https://virtserver.swaggerhub.com/MConneely/Sample_PostOffice_API/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BeneficiariesGet**](BeneficiariesApi.md#beneficiariesget) | **GET** /beneficiaries | List beneficiaries
[**BeneficiariesIdDelete**](BeneficiariesApi.md#beneficiariesiddelete) | **DELETE** /beneficiaries/{id} | Delete a beneficiary
[**BeneficiariesIdGet**](BeneficiariesApi.md#beneficiariesidget) | **GET** /beneficiaries/{id} | Get a beneficiary
[**BeneficiariesPost**](BeneficiariesApi.md#beneficiariespost) | **POST** /beneficiaries | Register a beneficiary

<a name="beneficiariesget"></a>
# **BeneficiariesGet**
> void BeneficiariesGet ()

List beneficiaries

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BeneficiariesGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: POAPIScopes
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeneficiariesApi();

            try
            {
                // List beneficiaries
                apiInstance.BeneficiariesGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeneficiariesApi.BeneficiariesGet: " + e.Message );
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

[POAPIScopes](../README.md#POAPIScopes)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="beneficiariesiddelete"></a>
# **BeneficiariesIdDelete**
> void BeneficiariesIdDelete (string id)

Delete a beneficiary

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BeneficiariesIdDeleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: POAPIScopes
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeneficiariesApi();
            var id = id_example;  // string | Beneficiary's id

            try
            {
                // Delete a beneficiary
                apiInstance.BeneficiariesIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeneficiariesApi.BeneficiariesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Beneficiary&#x27;s id | 

### Return type

void (empty response body)

### Authorization

[POAPIScopes](../README.md#POAPIScopes)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="beneficiariesidget"></a>
# **BeneficiariesIdGet**
> void BeneficiariesIdGet (string id)

Get a beneficiary

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BeneficiariesIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: POAPIScopes
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeneficiariesApi();
            var id = id_example;  // string | Beneficiary's id

            try
            {
                // Get a beneficiary
                apiInstance.BeneficiariesIdGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeneficiariesApi.BeneficiariesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Beneficiary&#x27;s id | 

### Return type

void (empty response body)

### Authorization

[POAPIScopes](../README.md#POAPIScopes)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="beneficiariespost"></a>
# **BeneficiariesPost**
> void BeneficiariesPost ()

Register a beneficiary

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BeneficiariesPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: POAPIScopes
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeneficiariesApi();

            try
            {
                // Register a beneficiary
                apiInstance.BeneficiariesPost();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeneficiariesApi.BeneficiariesPost: " + e.Message );
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

[POAPIScopes](../README.md#POAPIScopes)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
