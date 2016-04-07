module Lists.SortingByLength

let lsort list = 
    List.sortBy (fun elem -> List.length elem) list

let lsortFreq list = 
    list
    |> Seq.groupBy (fun elem -> List.length elem)
    |> Seq.sortBy (fun elem -> Seq.length (snd elem))
    |> Seq.collect snd
    |> List.ofSeq
