module Program 
open FSharp.Data.Sql

[<Literal>]
let CompiletimeConnectionString = "Server=localhost;Port=5432;Database=postgres;User Id=Dev;Password=dev;"

[<Literal>]
let ResolutionPath = @".\libs"

type Db = 
    SqlDataProvider<Common.DatabaseProviderTypes.POSTGRESQL,ConnectionString = CompiletimeConnectionString,ResolutionPath = ResolutionPath>

let getIds () =
    let dataContext = Db.GetDataContext CompiletimeConnectionString

    dataContext.Public.Buildings
    |> Seq.map (fun b -> b.Id)
    

[<EntryPoint>]
let main argv =
    let result = getIds ()
    printfn "%A" result
    0 
