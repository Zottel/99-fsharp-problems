#load "./10-LengthEncoding.fsx"
open Lists.LengthEncoding

let list = ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e']
printfn "Length encoded list: %A" (encode list)
