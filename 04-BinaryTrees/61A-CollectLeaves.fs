module BinaryTrees.CollectLeaves

open BinaryTrees.BinaryTree

let rec collectLeaves tree =
    match tree with
    | Empty -> []
    | Branch(leaf, Empty, Empty) -> [leaf]
    | Branch(_, left, right) -> (collectLeaves left) @ (collectLeaves right)

let test () =
    let tree = Branch("a", Branch("b", Empty, Empty), Branch("c", Branch("d", Empty, Empty), Branch("e", Empty, Empty)))

    printfn "Input tree: \n%A" tree
    printfn "List of leaves: %A" (collectLeaves tree)
