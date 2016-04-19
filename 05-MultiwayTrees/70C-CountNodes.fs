module MultiwayTrees.CountNodes

open MultiwayTrees.MultiwayTree

let rec count tree =
    match tree with
    | Node(_, []) -> 1
    | Node(_, children) ->
        (List.sumBy count children) + 1

let test () =
    let tree = Node ('a', [Node ('f', [])])

    printfn "Input tree: \n%A" tree
    printfn "Number of nodes: %i" (count tree)
