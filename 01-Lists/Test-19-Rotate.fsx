#load "./19-Rotate.fsx"
open Lists.Rotate

let list = ['a'; 'b'; 'c'; 'd'; 'e'; 'f'; 'g'; 'h'; 'i'; 'j'; 'k']
let rotatePos = 3
let rotateNeg = -2

let printRotated by list = printfn "List rotated by %i: %A" by (rotate by list)

printfn "Input list: %A" list
printRotated rotatePos list
printRotated rotateNeg list
