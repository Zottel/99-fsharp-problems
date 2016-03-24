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
