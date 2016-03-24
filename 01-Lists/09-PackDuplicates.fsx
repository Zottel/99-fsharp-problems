module Lists.PackDuplicates

let pack list = 
    let accumulate acc item =
        if item = List.head (List.head acc) 
        then (item::(List.head acc))::(List.tail acc) 
        else [item]::acc
        
    match list with
    | [] -> []
    | head::tail -> List.fold accumulate [[head]] tail |> List.rev
