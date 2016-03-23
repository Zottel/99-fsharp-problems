#load "./04-NumberOfElements.fsx"
open Lists.NumberOfElements

let list = [1; 1; 2; 3; 5; 8]
printfn "The list %A has %i elements" list (countElements list)
