module Lists.Rotate

open Lists.Split

let rotate by list =
    match list, by with
    | [],_ -> []
    | ls,0 -> ls
    | ls,by ->
        let l = List.length ls
        let (head,tail) = split ((l + by) % l) ls
        tail @ head

let test () =
    let list = ['a'; 'b'; 'c'; 'd'; 'e'; 'f'; 'g'; 'h'; 'i'; 'j'; 'k']
    let rotatePos = 3
    let rotateNeg = -2

    let printRotated by list = printfn "List rotated by %i: %A" by (rotate by list)

    printfn "Input list: %A" list
    printRotated rotatePos list
    printRotated rotateNeg list
