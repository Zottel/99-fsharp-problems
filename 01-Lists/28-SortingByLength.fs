module Lists.SortingByLength

let lsort list =
    List.sortBy (fun elem -> List.length elem) list

let lsortFreq list =
    list
    |> Seq.groupBy (fun elem -> List.length elem)
    |> Seq.sortBy (fun elem -> Seq.length (snd elem))
    |> Seq.collect snd
    |> List.ofSeq

let test () =
    let list = [['a'; 'b'; 'c']; ['d'; 'e']; ['f'; 'g'; 'h']; ['d'; 'e']; ['i'; 'j'; 'k'; 'l']; ['m'; 'n']; ['o']]

    printfn "Input list: \n%A" list
    printfn "List sorted by elements length: \n%A" (lsort list)
    printfn "List sorted by elements length frequency: \n%A" (lsortFreq list)
