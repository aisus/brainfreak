module BrainFreak.Program

open BrainFreak.Parser

[<EntryPoint>]
let main argv =
    let test = Seq.toList "<>.,[]"
    let parsed = test |> Seq.map (parseCharToOperator)
    parsed |> Seq.iter (printf "%A ")
    0
