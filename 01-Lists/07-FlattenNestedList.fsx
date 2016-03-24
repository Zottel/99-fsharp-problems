module Lists.FlattenNestedList

type 'a NestedList = List of 'a NestedList list | Elem of 'a

let Flatten ls = 
    let rec loop acc = function
        | Elem x -> x::acc
        | List xs -> List.foldBack(fun x acc -> loop acc x) xs acc
    loop [] ls
