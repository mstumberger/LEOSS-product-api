cmake_minimum_required(VERSION 3.8)
project(Products)

set(CMAKE_CXX_STANDARD 11)

set(SOURCE_FILES
        bin/Debug/netcoreapp3.1/Properties/launchSettings.json
        bin/Debug/netcoreapp3.1/appsettings.Development.json
        bin/Debug/netcoreapp3.1/appsettings.json
        bin/Debug/netcoreapp3.1/Microsoft.Bcl.AsyncInterfaces.dll
        bin/Debug/netcoreapp3.1/Microsoft.Bcl.HashCode.dll
        bin/Debug/netcoreapp3.1/Microsoft.EntityFrameworkCore.Abstractions.dll
        bin/Debug/netcoreapp3.1/Microsoft.EntityFrameworkCore.dll
        bin/Debug/netcoreapp3.1/Microsoft.Extensions.Caching.Abstractions.dll
        bin/Debug/netcoreapp3.1/Microsoft.Extensions.Caching.Memory.dll
        bin/Debug/netcoreapp3.1/Microsoft.Extensions.Configuration.Abstractions.dll
        bin/Debug/netcoreapp3.1/Microsoft.Extensions.Configuration.Binder.dll
        bin/Debug/netcoreapp3.1/Microsoft.Extensions.Configuration.dll
        bin/Debug/netcoreapp3.1/Microsoft.Extensions.DependencyInjection.Abstractions.dll
        bin/Debug/netcoreapp3.1/Microsoft.Extensions.DependencyInjection.dll
        bin/Debug/netcoreapp3.1/Microsoft.Extensions.Logging.Abstractions.dll
        bin/Debug/netcoreapp3.1/Microsoft.Extensions.Logging.dll
        bin/Debug/netcoreapp3.1/Microsoft.Extensions.Options.dll
        bin/Debug/netcoreapp3.1/Microsoft.Extensions.Primitives.dll
        bin/Debug/netcoreapp3.1/Products.deps.json
        bin/Debug/netcoreapp3.1/Products.dll
        bin/Debug/netcoreapp3.1/Products.exe
        bin/Debug/netcoreapp3.1/Products.pdb
        bin/Debug/netcoreapp3.1/Products.runtimeconfig.dev.json
        bin/Debug/netcoreapp3.1/Products.runtimeconfig.json
        Controllers/ProductsController.cs
        Models/Product.cs
        Models/ProductContext.cs
        obj/Debug/netcoreapp3.1/staticwebassets/Products.StaticWebAssets.Manifest.cache
        obj/Debug/netcoreapp3.1/staticwebassets/Products.StaticWebAssets.xml
        obj/Debug/netcoreapp3.1/Products.AssemblyInfo.cs
        obj/Debug/netcoreapp3.1/Products.AssemblyInfoInputs.cache
        obj/Debug/netcoreapp3.1/Products.assets.cache
        obj/Debug/netcoreapp3.1/Products.csproj.CopyComplete
        obj/Debug/netcoreapp3.1/Products.csproj.FileListAbsolute.txt
        obj/Debug/netcoreapp3.1/Products.csprojAssemblyReference.cache
        obj/Debug/netcoreapp3.1/Products.dll
        obj/Debug/netcoreapp3.1/Products.exe
        obj/Debug/netcoreapp3.1/Products.MvcApplicationPartsAssemblyInfo.cache
        obj/Debug/netcoreapp3.1/Products.pdb
        obj/Debug/netcoreapp3.1/Products.RazorTargetAssemblyInfo.cache
        obj/Products.csproj.nuget.cache
        obj/Products.csproj.nuget.dgspec.json
        obj/Products.csproj.nuget.g.props
        obj/Products.csproj.nuget.g.targets
        obj/project.assets.json
        Properties/launchSettings.json
        appsettings.Development.json
        appsettings.json
        Products.csproj
        Products.sln
        Program.cs
        Startup.cs)

add_executable(Products ${SOURCE_FILES})