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

type State =
    { buffer: int array
      mutable pointer: int }
