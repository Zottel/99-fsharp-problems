#load "./14-DuplicateElements.fsx"
open Lists.DuplicateElement

let list = ['a'; 'b'; 'c'; 'c'; 'd']

printfn "Input list: %A" list
printfn "Duplicated list: %A" (duplicate list)
