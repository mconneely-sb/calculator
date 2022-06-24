# IO.Swagger.Model.TransferRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | **string** | Source account number | 
**Destination** | **string** | Destination account number | 
**Amount** | [**decimal?**](BigDecimal.md) |  | 
**Date** | **DateTime?** | Execution date for a delayed transfer or first execution date for a recurring one  | [optional] 
**Occurrences** | **int?** | Number of times a recurring transfer will be executed  | [optional] 
**Frequency** | **string** | Frequency of recurring transfer&#x27;s execution | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

