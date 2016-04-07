module Lists.Split

let rec take n list =
    match list, n with
    | [], _ -> []
    | _, 0 -> []
    | head::tail, n -> head::take (n - 1) tail

let rec drop n list =
    match list, n with
    | list, 0 -> list
    | [], _ -> []
    | head::tail, n -> drop (n - 1) tail

let split division list =
    (take division list, drop division list)

let test () =
    let list = ['a'; 'b'; 'c'; 'd'; 'e'; 'f'; 'g'; 'h'; 'i'; 'j'; 'k']
    let division = 3

    printfn "Input list: %A" list
    printfn "List split at %i: %A" division (split division list)
