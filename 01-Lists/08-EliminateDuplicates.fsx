module Lists.EliminateDuplicates

let compress list =
    let accumulate acc elem =
        if elem = List.head acc
        then acc
        else elem::acc
         
    match list with
    | [] -> []
    | head::tail -> List.fold accumulate [head] tail |> List.rev
