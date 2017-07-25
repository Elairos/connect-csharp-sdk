# Square.Connect.Model.CreateOrderRequestLineItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the line item. This value cannot exceed 500 characters. | [optional] 
**Quantity** | **string** | The quantity to purchase, as a string representation of a number. Currently, only integer values are supported. | 
**BasePriceMoney** | [**Money**](Money.md) | The base price for a single unit of the line item&#39;s associated variation. If a line item represents a Custom Amount instead of a particular product, this field indicates that amount. | [optional] 
**VariationName** | **string** | The variation_name of the line item. This value cannot exceed 255 characters.  If not set, the default name is &#x60;Regular&#x60;.  Do not provide a value for this field if you provide a value for the &#x60;name&#x60; and the &#x60;base_price_money&#x60;. | [optional] 
**Note** | **string** | The note of the line item. This value cannot exceed 50 characters. | [optional] 
**CatalogObjectId** | **string** | The catalog object id from existing [CatalogItemVariation](#type-catalogitemvariation).  Do not provide a value for this field if you provide a value for the &#x60;name&#x60; and the &#x60;base_price_money&#x60;. | [optional] 
**Modifiers** | [**List&lt;CreateOrderRequestModifier&gt;**](CreateOrderRequestModifier.md) | The item modifier catalog object ids from exsiting [CatalogModifier](#type-catalogmodifier)s.  Do not provide a value for this field if you provide a value for the &#x60;name&#x60; and the &#x60;base_price_money&#x60;. | [optional] 
**Taxes** | [**List&lt;CreateOrderRequestTax&gt;**](CreateOrderRequestTax.md) | The taxes to include on the line item. | [optional] 
**Discounts** | [**List&lt;CreateOrderRequestDiscount&gt;**](CreateOrderRequestDiscount.md) | The discounts to include on the line item. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

