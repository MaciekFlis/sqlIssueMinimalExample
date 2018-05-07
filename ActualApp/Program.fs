// Learn more about F# at http://fsharp.org

open System
open Program

[<EntryPoint>]
let main argv =
    let result = getIds ()
    printfn "%A" result
    0 
