module BrainFreak.Tests.InterpreterTests

open BrainFreak.Core
open NUnit.Framework
open BrainFreak.Interpreter


[<Test>]
let shouldExecuteRight () =
    let state =
        { buffer = Array.zeroCreate 10
          pointer = 0 }

    executeOperator Operator.Right state
    Assert.AreEqual(state.pointer, 1)

[<Test>]
let shouldExecuteLeft () =
    let state =
        { buffer = Array.zeroCreate 10
          pointer = 1 }

    executeOperator Operator.Left state
    Assert.AreEqual(state.pointer, 0)

[<Test>]
let shouldExecuteIncrement () =
    let state =
        { buffer = Array.zeroCreate 10
          pointer = 0 }

    executeOperator Operator.Inc state
    Assert.AreEqual(state.buffer.[state.pointer], 1)

[<Test>]
let shouldExecuteDecrement () =
    let state =
        { buffer = Array.zeroCreate 10
          pointer = 0 }

    executeOperator Operator.Dec state
    Assert.AreEqual(state.buffer.[state.pointer], -1)
