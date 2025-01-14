# Plans

```csharp
IPlansController plansController = client.PlansController;
```

## Class Name

`PlansController`

## Methods

* [Get Plan](../../doc/controllers/plans.md#get-plan)
* [Update Plan](../../doc/controllers/plans.md#update-plan)
* [Update Plan Metadata](../../doc/controllers/plans.md#update-plan-metadata)
* [Delete Plan Item](../../doc/controllers/plans.md#delete-plan-item)
* [Get Plans](../../doc/controllers/plans.md#get-plans)
* [Get Plan Item](../../doc/controllers/plans.md#get-plan-item)
* [Delete Plan](../../doc/controllers/plans.md#delete-plan)
* [Update Plan Item](../../doc/controllers/plans.md#update-plan-item)
* [Create Plan Item](../../doc/controllers/plans.md#create-plan-item)
* [Create Plan](../../doc/controllers/plans.md#create-plan)


# Get Plan

Gets a plan

```csharp
GetPlanAsync(
    string planId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |

## Response Type

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
string planId = "plan_id8";

try
{
    GetPlanResponse result = await plansController.GetPlanAsync(planId);
}
catch (ApiException e){};
```


# Update Plan

Updates a plan

```csharp
UpdatePlanAsync(
    string planId,
    Models.UpdatePlanRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `request` | [`Models.UpdatePlanRequest`](../../doc/models/update-plan-request.md) | Body, Required | Request for updating a plan |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
var request = new UpdatePlanRequest();
request.Name = "name6";
request.Description = "description6";
request.Installments = new List<int>();
request.Installments.Add(151);
request.Installments.Add(152);
request.StatementDescriptor = "statement_descriptor6";
request.Currency = "currency6";
request.Interval = "interval4";
request.IntervalCount = 114;
request.PaymentMethods = new List<string>();
request.PaymentMethods.Add("payment_methods1");
request.PaymentMethods.Add("payment_methods0");
request.PaymentMethods.Add("payment_methods9");
request.BillingType = "billing_type0";
request.Status = "status8";
request.Shippable = false;
request.BillingDays = new List<int>();
request.BillingDays.Add(115);
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");

try
{
    GetPlanResponse result = await plansController.UpdatePlanAsync(planId, request, null);
}
catch (ApiException e){};
```


# Update Plan Metadata

Updates the metadata from a plan

```csharp
UpdatePlanMetadataAsync(
    string planId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | The plan id |
| `request` | [`Models.UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the plan metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
var request = new UpdateMetadataRequest();
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");

try
{
    GetPlanResponse result = await plansController.UpdatePlanMetadataAsync(planId, request, null);
}
catch (ApiException e){};
```


# Delete Plan Item

Removes an item from a plan

```csharp
DeletePlanItemAsync(
    string planId,
    string planItemId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `planItemId` | `string` | Template, Required | Plan item id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
string planItemId = "plan_item_id0";

try
{
    GetPlanItemResponse result = await plansController.DeletePlanItemAsync(planId, planItemId, null);
}
catch (ApiException e){};
```


# Get Plans

Gets all plans

```csharp
GetPlansAsync(
    int? page = null,
    int? size = null,
    string name = null,
    string status = null,
    string billingType = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `name` | `string` | Query, Optional | Filter for Plan's name |
| `status` | `string` | Query, Optional | Filter for Plan's status |
| `billingType` | `string` | Query, Optional | Filter for plan's billing type |
| `createdSince` | `DateTime?` | Query, Optional | Filter for plan's creation date start range |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for plan's creation date end range |

## Response Type

[`Task<Models.ListPlansResponse>`](../../doc/models/list-plans-response.md)

## Example Usage

```csharp
try
{
    ListPlansResponse result = await plansController.GetPlansAsync(null, null, null, null, null, null, null);
}
catch (ApiException e){};
```


# Get Plan Item

Gets a plan item

```csharp
GetPlanItemAsync(
    string planId,
    string planItemId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `planItemId` | `string` | Template, Required | Plan item id |

## Response Type

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
string planItemId = "plan_item_id0";

try
{
    GetPlanItemResponse result = await plansController.GetPlanItemAsync(planId, planItemId);
}
catch (ApiException e){};
```


# Delete Plan

Deletes a plan

```csharp
DeletePlanAsync(
    string planId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
string planId = "plan_id8";

try
{
    GetPlanResponse result = await plansController.DeletePlanAsync(planId, null);
}
catch (ApiException e){};
```


# Update Plan Item

Updates a plan item

```csharp
UpdatePlanItemAsync(
    string planId,
    string planItemId,
    Models.UpdatePlanItemRequest body,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `planItemId` | `string` | Template, Required | Plan item id |
| `body` | [`Models.UpdatePlanItemRequest`](../../doc/models/update-plan-item-request.md) | Body, Required | Request for updating the plan item |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
string planItemId = "plan_item_id0";
var body = new UpdatePlanItemRequest();
body.Name = "name6";
body.Description = "description4";
body.Status = "status2";
body.PricingScheme = new UpdatePricingSchemeRequest();
body.PricingScheme.SchemeType = "scheme_type2";
body.PricingScheme.PriceBrackets = new List<UpdatePriceBracketRequest>();

var bodyPricingSchemePriceBrackets0 = new UpdatePriceBracketRequest();
bodyPricingSchemePriceBrackets0.StartQuantity = 31;
bodyPricingSchemePriceBrackets0.Price = 225;
body.PricingScheme.PriceBrackets.Add(bodyPricingSchemePriceBrackets0);

var bodyPricingSchemePriceBrackets1 = new UpdatePriceBracketRequest();
bodyPricingSchemePriceBrackets1.StartQuantity = 32;
bodyPricingSchemePriceBrackets1.Price = 226;
body.PricingScheme.PriceBrackets.Add(bodyPricingSchemePriceBrackets1);


try
{
    GetPlanItemResponse result = await plansController.UpdatePlanItemAsync(planId, planItemId, body, null);
}
catch (ApiException e){};
```


# Create Plan Item

Adds a new item to a plan

```csharp
CreatePlanItemAsync(
    string planId,
    Models.CreatePlanItemRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `request` | [`Models.CreatePlanItemRequest`](../../doc/models/create-plan-item-request.md) | Body, Required | Request for creating a plan item |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
var request = new CreatePlanItemRequest();
request.Name = "name6";
request.PricingScheme = new CreatePricingSchemeRequest();
request.PricingScheme.SchemeType = "scheme_type2";
request.Id = "id6";
request.Description = "description6";

try
{
    GetPlanItemResponse result = await plansController.CreatePlanItemAsync(planId, request, null);
}
catch (ApiException e){};
```


# Create Plan

Creates a new plan

```csharp
CreatePlanAsync(
    Models.CreatePlanRequest body,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CreatePlanRequest`](../../doc/models/create-plan-request.md) | Body, Required | Request for creating a plan |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
var body = new CreatePlanRequest();
body.Name = "name6";
body.Description = "description4";
body.StatementDescriptor = "statement_descriptor6";
body.Items = new List<CreatePlanItemRequest>();

var bodyItems0 = new CreatePlanItemRequest();
bodyItems0.Name = "name3";
bodyItems0.PricingScheme = new CreatePricingSchemeRequest();
bodyItems0.PricingScheme.SchemeType = "scheme_type5";
bodyItems0.Id = "id3";
bodyItems0.Description = "description3";
body.Items.Add(bodyItems0);

var bodyItems1 = new CreatePlanItemRequest();
bodyItems1.Name = "name4";
bodyItems1.PricingScheme = new CreatePricingSchemeRequest();
bodyItems1.PricingScheme.SchemeType = "scheme_type4";
bodyItems1.Id = "id4";
bodyItems1.Description = "description4";
body.Items.Add(bodyItems1);

var bodyItems2 = new CreatePlanItemRequest();
bodyItems2.Name = "name5";
bodyItems2.PricingScheme = new CreatePricingSchemeRequest();
bodyItems2.PricingScheme.SchemeType = "scheme_type3";
bodyItems2.Id = "id5";
bodyItems2.Description = "description5";
body.Items.Add(bodyItems2);

body.Shippable = false;
body.PaymentMethods = new List<string>();
body.PaymentMethods.Add("payment_methods9");
body.Installments = new List<int>();
body.Installments.Add(207);
body.Currency = "currency6";
body.Interval = "interval6";
body.IntervalCount = 170;
body.BillingDays = new List<int>();
body.BillingDays.Add(201);
body.BillingDays.Add(200);
body.BillingType = "billing_type0";
body.PricingScheme = new CreatePricingSchemeRequest();
body.PricingScheme.SchemeType = "scheme_type2";
body.Metadata = new Dictionary<string, string>();
body.Metadata.Add("key0", "metadata7");
body.Metadata.Add("key1", "metadata8");

try
{
    GetPlanResponse result = await plansController.CreatePlanAsync(body, null);
}
catch (ApiException e){};
```

