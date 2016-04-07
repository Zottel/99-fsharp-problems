module Lists.DuplicateElement

let duplicate list = List.collect (fun item -> item::[item]) list

let test () =
    let list = ['a'; 'b'; 'c'; 'c'; 'd']

    printfn "Input list: %A" list
    printfn "Duplicated list: %A" (duplicate list)
