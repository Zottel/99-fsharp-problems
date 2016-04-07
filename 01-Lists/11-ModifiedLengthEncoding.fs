module Lists.ModifiedLengthEncoding

open Lists.LengthEncoding

type 'a Encoding = Multiple of int * 'a | Single of 'a

let modifiedEncode list =
    encode list
    |> List.map (fun (count,item) -> if count = 1 then Single(item) else Multiple(count,item))

let test () =
    let list = ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e']

    printfn "Input list: %A" list
    printfn "Length encoded list: %A" (modifiedEncode list)
