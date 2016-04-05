module BinaryTrees.BinarySearchTree

#load "../04-BinaryTrees/00-BinaryTree.fsx"
open BinaryTrees.BinaryTree

let rec add element tree =
    match tree with
    | Empty -> Branch(element, Empty, Empty)
    | Branch(x, left, right) ->
        if element < x then
            Branch(x, (add element left), right)
        else if element > x then
            Branch(x, left, (add element right))
        else
            tree
            
let fromList list =
    List.fold (fun tree elem -> add elem tree) Empty list
