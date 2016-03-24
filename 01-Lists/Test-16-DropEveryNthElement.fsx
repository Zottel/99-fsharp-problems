#load "./16-DropEveryNthElement.fsx"
open Lists.DropEveryNthElement
    
let list = ['a'; 'b'; 'c'; 'd'; 'e'; 'f'; 'g'; 'h'; 'i'; 'j'; 'k']
let nth = 3

printfn "Input list: %A" list
printfn "List with dopped every %i element: %A" nth (drop nth list)
    