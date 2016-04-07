module Lists.LastButOneElement

let lastButOne list = list |> List.rev |> List.tail |> List.head

let test () =
    let list = [1; 1; 2; 3; 5; 8]

    printfn "Input list: %A" list
    printfn "Last but one element: %i" (lastButOne list)
