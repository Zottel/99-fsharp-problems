module Lists.LengthEncoding

open Lists.PackDuplicates

let encode list = pack list |> List.map (fun elem -> (List.length elem, List.head elem))

let test () =
    let list = ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e']

    printfn "Input list: %A" list
    printfn "Length encoded list: %A" (encode list)
