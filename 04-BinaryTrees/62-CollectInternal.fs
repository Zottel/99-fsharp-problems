module BinaryTrees.CollectInternal

open BinaryTrees.BinaryTree

let rec collectInternal tree =
    match tree with
    | Empty -> []
    | Branch(_, Empty, Empty) -> []
    | Branch(node, left, right) -> node :: collectInternal left @ collectInternal right

let test () =
    let tree = Branch("a", Branch("b", Empty, Empty), Branch("c", Branch("d", Empty, Empty), Branch("e", Empty, Empty)))

    printfn "Input tree: \n%A" tree
    printfn "List of internal nodes: %A" (collectInternal tree)
