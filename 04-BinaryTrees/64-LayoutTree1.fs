module BinaryTrees.LayoutTree1

open BinaryTrees.BinaryTree
open BinaryTrees.BinarySearchTree

let layoutTree tree =
    let rec loop x y tree =
        match tree with
        | Empty -> Empty, x
        | Branch(value, left, right) ->
            let leftTree, myX = loop x (y + 1) left
            let rightTree, nextX = loop (myX + 1) (y + 1) right
            (Branch((value, myX, y), leftTree, rightTree), nextX)
    loop 1 1 tree |> fst

let test () =
    let displayResult tree =
        printfn "\nInput tree: \n%A" tree
        printfn "Tree with coordinates: \n%A" (layoutTree tree)

    let tree = Branch("a", Branch("b", Empty, Branch("c", Empty, Empty)), Branch("d", Empty, Empty))

    displayResult tree

    let tree' = fromList ['n';'k';'m';'c';'a';'h';'g';'e';'u';'p';'s';'q']

    displayResult tree'
