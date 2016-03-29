#load "./26-Combinations.fsx"
open Lists.Combinations

let list = ['a' .. 'f']
let number = 3

printfn "Input list: %A" list
printfn "Combinations of %i elements:" number
printfn "%A" (combinations number list)
