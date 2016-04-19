module MultiwayTrees.PostorderSequence

open MultiwayTrees.MultiwayTree

let rec postorder tree =
    match tree with
    | Node(value, []) -> [value]
    | Node(value, children) ->
        List.collect postorder children @ [value]

let test () =
    let tree = Node('a', [Node('f', [Node('g', [])]); Node('c', []); Node('b', [Node('d', []); Node('e', [])])])

    printfn "Input tree: \n%A" tree
    printfn "Tree nodes in postorder sequence: %A" (postorder tree)
