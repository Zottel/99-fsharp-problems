module Lists.Combinations

let rec combinations elements list =
    let rec tails = function
    | [] -> [[]]
    | _::tail as list -> list::tails tail 
    
    match list, elements with
    | _,0 -> [[]]
    | list, elements ->
        [for tail in tails list do
            match tail with
            | [] -> ()
            | head::tail ->
                for ls in combinations (elements - 1) tail do
                    yield head::ls]
