#load "./25-Permutation.fsx"
open Lists.Permutation

let list = ['a'; 'b'; 'c'; 'd'; 'e'; 'f']

printfn "Input list: %A" list
printfn "Random permutation: %A" (randomPermute list)
