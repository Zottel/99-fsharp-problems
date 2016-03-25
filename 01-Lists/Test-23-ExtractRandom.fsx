#load "./23-ExtractRandom.fsx"
open Lists.ExtractRandom

let list = ['a'; 'b'; 'c'; 'd'; 'e'; 'f'; 'g'; 'h']
let count = 3

printfn "Input list: %A" list
printfn "%i random elements: %A" count (randomSelect count list)
