module BinaryTrees.CountLeaves

open BinaryTrees.BinaryTree

let rec countLeaves tree =
    match tree with
    | Empty -> 0
    | Branch(_, Empty, Empty) -> 1
    | Branch(_, left, right) -> countLeaves left + countLeaves right

let test () =
    let tree = Branch('x', Branch('x', Empty, Empty), Empty)

    printfn "Input tree: \n%A" tree
    printfn "Leaf count: %i" (countLeaves tree)
