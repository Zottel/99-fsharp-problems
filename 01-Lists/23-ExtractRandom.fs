module Lists.ExtractRandom

open Lists.RemoveElement

let random = System.Random()

let rec randomSelect number list =
    match number,list with
    | 0,_ -> []
    | _,[] -> []
    | number,list ->
        let rest, element = removeAt (random.Next (List.length list)) list
        element :: randomSelect (number - 1) rest

let test () =
    let list = ['a'; 'b'; 'c'; 'd'; 'e'; 'f'; 'g'; 'h']
    let count = 3

    printfn "Input list: %A" list
    printfn "%i random elements: %A" count (randomSelect count list)
