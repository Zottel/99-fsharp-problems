#load "./13-LengthEncodeDirect.fsx"
open Lists.LengthEncodeDirect

let list = ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e']

printfn "Input list: %A" list
printfn "Length-encoded list: %A" (encodeDirect list)
