module Lists.DecodeLengthEncoding

let rec multiply times item = 
    match times with
    | 0 -> []
    | _ -> item::multiply (times - 1) item

let decode list = List.fold (fun acc (count,item) -> (multiply count item)@acc) [] list |> List.rev
    