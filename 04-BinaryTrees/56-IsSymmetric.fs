module BinaryTrees.IsSymmetric

open BinaryTrees.BinaryTree

let rec isMirror tree1 tree2 =
    match tree1, tree2 with
    | Empty, Empty -> true
    | Branch _, Empty -> false
    | Empty, Branch _ -> false
    | Branch(_, left1, right1), Branch(_, left2, right2) ->
        isMirror left1 left2 && isMirror right1 right2

let isSymmetric tree =
    match tree with
    | Empty -> true
    | Branch(_, left, right) -> isMirror left right

let test () =
    let tree = Branch('a', Branch('b', Empty, Empty), Branch('c', Empty, Empty))

    printfn "The tree:\n%A" tree
    printfn "Is symmetric: %b" (isSymmetric tree)
