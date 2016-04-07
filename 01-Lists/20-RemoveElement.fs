module Lists.RemoveElement

open Lists.Split

let removeAt index list =
    let (start,tail) = split index list
    (start @ List.tail tail, List.head tail)

let test () =
    let list = ['a'; 'b'; 'c'; 'd']
    let remove = 1

    printfn "Input list: %A" list
    printfn "Removed element at %i: %A" remove (removeAt remove list)
