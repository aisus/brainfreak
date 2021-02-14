module BrainFreak.Interpreter

open BrainFreak.Core

let executeOperator op state =
    match op with
    | Operator.Right -> state.pointer <- state.pointer + 1
    | Operator.Left -> state.pointer <- state.pointer - 1
    | Operator.Inc -> state.buffer.[state.pointer] <- state.buffer.[state.pointer] + 1
    | Operator.Dec -> state.buffer.[state.pointer] <- state.buffer.[state.pointer] - 1
    | Operator.Write -> printf "%u" state.buffer.[state.pointer]
    | _ -> failwith "todo"

let execute input state =
    input
    |> Seq.iter (fun x -> executeOperator x state)
