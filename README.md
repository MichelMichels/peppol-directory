# PeppolDirectoryClient

This repository contains a C# REST API wrapper for [directory.peppol.eu](https://directory.peppol.eu)

Please read [the official documentation](https://directory.peppol.eu/public/locale-en_US/menuitem-docs-rest-api). 

> [!CAUTION]
> This library does not implement any rate limiting. The consumer of this library (you) is responsible for following the 
> guidelines of [the official documentation](https://directory.peppol.eu/public/locale-en_US/menuitem-docs-rest-api) mentioned above.

## Usage

This wrapper only supports the query parameter `q`.

Example:

```csharp
// Use PeppolDirectoryBaseUrl.Test for the Peppol testing network.
PeppolDirectoryClient client = new(PeppolDirectoryBaseUrl.Production);

// Setup query
QueryParameters parameters = new()
{
    Query = "0897067282",
};

// Get result
SearchResponse result = await client.Search(parameters);
```

