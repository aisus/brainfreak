module BrainFreak.Parser

open BrainFreak.Core

let parseCharToOperator (input: char) =
    LanguagePrimitives.EnumOfValue<char, Operator> input
