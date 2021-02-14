module BrainFreak.Core

type Operator =
    | Right = '>'
    | Left = '<'
    | Inc = '+'
    | Dec = '-'
    | Write = '.'
    | Read = ','
    | LoopStart = '['
    | LoopEnd = ']'

type State = { buffer: list<int>; mutable pointer: int }
