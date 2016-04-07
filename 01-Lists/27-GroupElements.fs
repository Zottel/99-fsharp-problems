module Lists.GroupElements

#load "../01-Lists/26-Combinations.fsx"
open Lists.Combinations

let listDiff list1 list2 = 
    Set.toList ((Set.ofList list1) - (Set.ofList list2))
    
let group3 list = 
    [for a in combinations 2 list do
        let noA = listDiff list a
        for b in combinations 3 noA do
            yield [a] @ [b] @ [(listDiff noA b)]]
    
let rec group groups list =
    match groups, list with
    | [],_ -> [[]]
    | head::tail, list -> 
        [for a in combinations head list do
            for b in group tail (listDiff list a) do
                yield a :: b]
