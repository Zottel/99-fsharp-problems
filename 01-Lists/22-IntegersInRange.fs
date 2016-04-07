module Lists.IntegersInRange

let rec range lower upper =
    match lower,upper with
    | lower,upper when lower > upper -> []
    | lower,upper ->
        lower::range (lower + 1) upper

let test () =
    let lower = 4
    let upper = 9

    printfn "List of integers from %i to %i: %A" lower upper (range lower upper)
