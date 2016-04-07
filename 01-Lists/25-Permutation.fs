module Lists.Permutation

open Lists.ExtractRandom

let rec randomPermute list = randomSelect (List.length list) list

let test () =
    let list = ['a'; 'b'; 'c'; 'd'; 'e'; 'f']

    printfn "Input list: %A" list
    printfn "Random permutation: %A" (randomPermute list)
