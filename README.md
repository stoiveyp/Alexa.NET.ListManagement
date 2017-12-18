# Alexa.NET.ListManagement
A simple .NET Core library for handling lists within Alexa skills

Before you start make sure you have An Alexa Skill with appropriate permissions (if you're unsure of how to do this - [the docs are here](https://developer.amazon.com/docs/custom-skills/configure-permissions-for-customer-information-in-your-skill.html))

## Initialising your list client
This assumes you're already using [Alexa.NET](https://www.nuget.org/packages/Alexa.NET) for your Alexa skill access
```csharp
var accessToken = skillRequest.Context.System.ApiAccessToken;
var client = new Alexa.NET.ListManagementClient(accessToken);
```
&nbsp;

## Output all lists
```csharp
var lists = await client.GetListsMetadata();
foreach(var list in lists)
{
    Console.WriteLine($"{list.ListId} - {list.Name}");
}
```
&nbsp;

## Output items for a single list
```csharp
var list = await client.GetList(listId);
foreach(var item in list.Items)
{
    Console.Writeine(item.Value);
}
```
&nbsp;

## Add Skill Event support to Alexa.NET
```csharp
 RequestConverter.RequestConverters.Add(new ListSkillEventRequestTypeConverter());
```
&nbsp;
