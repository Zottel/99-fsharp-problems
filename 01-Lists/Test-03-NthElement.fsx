#load "./03-NthElement.fsx"
open Lists.NthElement

let list = [1; 1; 2; 3; 5; 8]
let position = 4

printfn "Element at position %i is %i" position (elementAt list position)
