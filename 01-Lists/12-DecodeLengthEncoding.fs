module Lists.DecodeLengthEncoding

let rec multiply times item =
    match times with
    | 0 -> []
    | _ -> item::multiply (times - 1) item

let decode list = List.fold (fun acc (count,item) -> (multiply count item)@acc) [] list |> List.rev

let test () =
    let list = [(4, 'a'); (1, 'b'); (2, 'c'); (2, 'a'); (1, 'd'); (4, 'e')]

    printfn "Input list: %A" list
    printfn "Decoded list: %A" (decode list)
