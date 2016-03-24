#load "./18-ExtractSlice.fsx"
open Lists.ExtractSlice

let list = ['a'; 'b'; 'c'; 'd'; 'e'; 'f'; 'g'; 'h'; 'i'; 'j'; 'k']
let fromElement = 3
let toElement = 7

printfn "Input list: %A" list
printfn "List from %i to %i: %A" fromElement toElement (slice fromElement toElement list)
