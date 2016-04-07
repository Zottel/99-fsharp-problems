module Lists.DropEveryNthElement

let drop nth list =
    list
    |> List.mapi (fun index item -> (index + 1,item))
    |> List.filter (fun (index,_) -> not (index % nth = 0))
    |> List.map snd

let test () =
    let list = ['a'; 'b'; 'c'; 'd'; 'e'; 'f'; 'g'; 'h'; 'i'; 'j'; 'k']
    let nth = 3

    printfn "Input list: %A" list
    printfn "List with dopped every %i element: %A" nth (drop nth list)
