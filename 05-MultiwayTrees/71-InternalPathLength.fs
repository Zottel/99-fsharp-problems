module MultiwayTrees.InternalPathLength

open MultiwayTrees.MultiwayTree

let internalPathLength tree =
    let rec loop tree depth =
        match tree with
        | Node(_, []) -> depth
        | Node(_, children) -> depth + List.sumBy (fun child -> loop child (depth + 1)) children

    loop tree 0

let test () =
    let tree = Node('a', [Node('f', [Node('g', [])]); Node('c', []); Node('b', [Node('d', []); Node('e', [])])])

    printfn "Input tree: \n%A" tree
    printfn "Internal path length of tree: %i" (internalPathLength tree)
