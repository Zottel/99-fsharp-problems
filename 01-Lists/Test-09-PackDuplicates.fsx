#load "./09-PackDuplicates.fsx"
open Lists.PackDuplicates

let list = ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e']
printfn "Packed list: %A" (pack list)