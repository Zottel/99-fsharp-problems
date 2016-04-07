module Lists.Reverse

let reverse = List.rev

let test () =
    let list = [1; 1; 2; 3; 5; 8]

    printfn "Input list: %A" list
    printfn "Reversed list: %A" (reverse list)
