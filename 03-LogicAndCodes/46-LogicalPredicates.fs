module LogicAndCodes.LogicalPredicates

let not' a =
    match a with
    | true -> false
    | false -> true

let and' a b =
    match a,b with
    | (true,true) -> true
    | _ -> false

let or' a b =
    match a,b with
    | (true,_) -> true
    | (_,true) -> true
    | _ -> false

let equ a b = or' (and' a b) (and' (not a) (not b))
let nand a b = not' (and' a b)
let nor a b = not' (or' a b)
let xor a b = not' (equ a b)
let impl a b = or' (not a) b

let table func =
    let values = [(true,true); (true,false); (false,true); (false,false)]
    printfn "%-5s %-5s %-5s" "A" "B" "result"
    List.map (fun (a,b) -> func a b) values |> List.iter2 (fun (a,b) value -> printfn "%-5b %-5b %-5b" a b value ) values

let test () =
    printfn "Table for and(a, or(a, b)):"
    table (fun a b -> and' a (or' a b))
