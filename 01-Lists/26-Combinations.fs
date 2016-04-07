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

let test () =
    let list = ['a' .. 'f']
    let number = 3

    printfn "Input list: %A" list
    printfn "Combinations of %i elements:" number
    printfn "%A" (combinations number list)
