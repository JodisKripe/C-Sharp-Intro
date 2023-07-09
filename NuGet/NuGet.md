NuGet is the .NET package manager, which allows you to bring external code into your project. The most popular NuGet repository is https://www.nuget.org/, where anybody can write and publish libraries. These packages can be mind-bogglingly useful and can save you a tonne of time as a developer. Why re-invent the wheel if you don't need to?

One popular package is RestSharp which is a REST API client. You can search for and install NuGet packages directly in Rider by going to Tools > NuGet > Show NuGet Tool Window.

Packages can also be installed directly from the command line.

> dotnet add package RestSharp

It's Reflection can be seen in the NuGet.csproj file.

# dotnet pack

> dotnet build -c Release

Can be used to build binaries in the dll format for the code.

> dotnet pack

Can be used to export the code as a package and hence shared with other developers worldwide or internally in an organisation.
