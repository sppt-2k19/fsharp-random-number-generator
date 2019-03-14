// Learn more about F# at http://fsharp.org

open System
let genRandomNumbers n m =
    let rnd = System.Random()
    Array2D.init n m (fun _ _  -> rnd.Next())

[<EntryPoint>]
let main argv =
    let l = genRandomNumbers 4 4
    printfn "%A" l
    0 // return an integer exit code
