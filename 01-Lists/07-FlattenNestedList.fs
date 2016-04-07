module Lists.FlattenNestedList

type 'a NestedList = List of 'a NestedList list | Elem of 'a

let Flatten ls = 
    let rec loop acc = function
        | Elem x -> x::acc
        | List xs -> List.foldBack(fun x acc -> loop acc x) xs acc
    loop [] ls

let test () =
    let list = List [List [Elem 1; Elem 1]; Elem 2; List [Elem 3; List [Elem 5; Elem 8]]]
    
    printfn "Input list: %A" list
    printfn "Flattened list: %A" (Flatten list)
