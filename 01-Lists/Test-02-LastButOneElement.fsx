#load "./02-LastButOneElement.fsx"
open Lists.LastButOneElement

let list = [1; 1; 2; 3; 5; 8]
printfn "Last but one element: %i" (lastButOne list)
