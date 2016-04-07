module Lists.LastElement

let lastElement list = list |> List.rev |> List.head

let test () =
    let list = [1; 1; 2; 3; 5; 8]

    printfn "Input list: %A" list
    printfn "Last element: %i" (lastElement list)
