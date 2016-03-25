#load "./21-InsertElement.fsx"
open Lists.InsertElement

let list = ["a"; "b"; "c"; "d"]
let insert = 1
let item = "new"
    
printfn "Input list: %A" list
printfn "Inserted \"%s\" at %i: %A" item insert (insertAt item insert list)
