module BrainFreak.Parser

open BrainFreak.Core
open FParsec

let right: Parser<_, Operator> = pchar '>'
let left: Parser<_, Operator> = pchar '<'
let inc: Parser<_, Operator> = pchar '+'
let dec: Parser<_, Operator> = pchar '-'
let write: Parser<_, Operator> = pchar '.'
let read: Parser<_, Operator> = pchar ','
let loopStart: Parser<_, Operator> = pchar '['
let loopEnd: Parser<_, Operator> = pchar ']'

let loop: Parser<_, Operator> =
    loopStart >>. manyCharsTill anyChar loopEnd

let parseCharToOperator (input: char) =
    LanguagePrimitives.EnumOfValue<char, Operator> input
