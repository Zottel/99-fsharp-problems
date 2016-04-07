module Lists.InsertElement

open Lists.Split

let insertAt item index list =
    let (start,tail) = split index list
    start @ [item] @ tail

let test () =
    let list = ["a"; "b"; "c"; "d"]
    let insert = 1
    let item = "new"

    printfn "Input list: %A" list
    printfn "Inserted \"%s\" at %i: %A" item insert (insertAt item insert list)
