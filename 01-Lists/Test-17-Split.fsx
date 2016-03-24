#load "./17-Split.fsx"
open Lists.Split

let list = ['a'; 'b'; 'c'; 'd'; 'e'; 'f'; 'g'; 'h'; 'i'; 'j'; 'k']
let division = 3

printfn "Input list: %A" list
printfn "List split at %i: %A" division (split division list)
