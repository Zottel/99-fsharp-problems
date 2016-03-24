#load "./08-EliminateDuplicates.fsx"
open Lists.EliminateDuplicates

let list = ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e']
printfn "Compressed list: %A" (compress list)