module BrainFreak.Program

open BrainFreak.Core
open BrainFreak.Parser
open FParsec

[<EntryPoint>]
let main argv =
    let test = Seq.toList "+++.>++++.>+++++."

//    let input =
//        test
//        |> Seq.map (parseCharToOperator)
//        |> Seq.toList
//
//    let state =
//        { buffer = Array.zeroCreate 10
//          pointer = 0 }
//
//    Interpreter.execute input state
//    printfn "\n"
//    printfn "%A" state.buffer
    let result = run left '<'
    0
