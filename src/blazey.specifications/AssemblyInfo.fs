namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("blazey.specifications")>]
[<assembly: AssemblyProductAttribute("blazey.specifications")>]
[<assembly: AssemblyDescriptionAttribute("mspec compatible xunit.net runner")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
