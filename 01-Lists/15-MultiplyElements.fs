module Lists.MultiplyElements

let multiply times list = List.collect (fun item -> List.replicate times item) list

let test () =
    let list = ['a'; 'b'; 'c'; 'c'; 'd']
    let mult = 3

    printfn "Input list: %A" list
    printfn "Multiplied list: %A" (multiply mult list)
