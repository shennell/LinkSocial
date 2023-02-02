# LinkSocial
Inspired by Linktree, LinkSocial lets you create your own social media landing page for free.

The user creates a page by adding links to their socials and online profiles. Their own unique page link can then be shared online. Built using Blazor WebAssembly, LinkSocial's interactive interface makes it easy to add new links and rearrange their order by dragging and dropping them.

## Technologies
- Blazor WebAssembly on .NET 5
- ASP.NET Identity
- ASP.NET Core Web API & EF Core
- Ant Design Blazor UI Component Library
- Azure Blob Storage to store profile pictures

## Notes
To work with Azure blob storage, add your blobConnectionString in appsettings.json and update the blob storage link on Line 78 in Appearance.razor.

## TODO:
1. Upgrade from .NET 5 to .NET 7
