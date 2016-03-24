#load "./15-MultiplyElements.fsx"
open Lists.MultiplyElements

let list = ['a'; 'b'; 'c'; 'c'; 'd']

printfn "Input list: %A" list
printfn "Multiplied list: %A" (multiply 3 list)
