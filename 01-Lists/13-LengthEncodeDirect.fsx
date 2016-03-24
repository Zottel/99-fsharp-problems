module Lists.LengthEncodeDirect

let encodeDirect list = 
    let accumulate acc item =
        match acc with
        | [] -> [(1, item)]
        | _ -> 
            let count,item' = List.head acc
            if item = item'
            then (count + 1, item)::(List.tail acc)
            else (1, item)::acc
              
    List.fold accumulate [] list |> List.rev
