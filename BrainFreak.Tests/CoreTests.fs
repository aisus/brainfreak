module BrainFreak.Tests

open BrainFreak.Core
open NUnit.Framework
open BrainFreak.Parser

let allOperators = "<>+-.,[]"

[<Test>]
let ShouldParseOperators () =
    let expected =
        [ Operator.Left
          Operator.Right
          Operator.Inc
          Operator.Dec
          Operator.Write
          Operator.Read
          Operator.LoopStart
          Operator.LoopEnd ]

    let parsed = allOperators |> Seq.map (parseCharToOperator) |> List.ofSeq
    Assert.AreEqual(expected, parsed)