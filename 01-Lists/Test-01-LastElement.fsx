#load "./01-LastElement.fsx"
open Lists.LastElement

let list = [1; 1; 2; 3; 5; 8]
printfn "Last element: %i" (lastElement list)
