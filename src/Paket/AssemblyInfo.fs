﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Paket")>]
[<assembly: AssemblyProductAttribute("Paket")>]
[<assembly: AssemblyCompanyAttribute("Paket team")>]
[<assembly: AssemblyDescriptionAttribute("A package dependency manager for .NET with support for NuGet packages and GitHub repositories.")>]
[<assembly: AssemblyVersionAttribute("1.4.16")>]
[<assembly: AssemblyFileVersionAttribute("1.4.16")>]
[<assembly: AssemblyInformationalVersionAttribute("1.4.16")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.4.16"
