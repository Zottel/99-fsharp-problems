#load "./11-ModifiedLengthEncoding.fsx"
open Lists.ModifiedLengthEncoding

let list = ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e']
printfn "Length encoded list: %A" (modifiedEncode list)
