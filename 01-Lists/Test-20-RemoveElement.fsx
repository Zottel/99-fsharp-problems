#load "./20-RemoveElement.fsx"
open Lists.RemoveElement

let list = ['a'; 'b'; 'c'; 'd']
let remove = 1

printfn "Input list: %A" list
printfn "Removed element at %i: %A" remove (removeAt remove list)
