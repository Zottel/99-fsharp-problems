module Lists.EliminateDuplicates

let compress list =
    let accumulate acc elem =
        if elem = List.head acc
        then acc
        else elem::acc

    match list with
    | [] -> []
    | head::tail -> List.fold accumulate [head] tail |> List.rev

let test () =
    let list = ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e']

    printfn "Input list: %A" list
    printfn "Compressed list: %A" (compress list)
