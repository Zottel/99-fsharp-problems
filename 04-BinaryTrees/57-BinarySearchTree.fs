module BinaryTrees.BinarySearchTree

open BinaryTrees.BinaryTree
open BinaryTrees.IsSymmetric

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

let test () =
    let list1 = [3; 2; 5; 7; 1]

    printfn "Input list: %A" list1
    printfn "Binary search tree: %A" (fromList list1)

    let list2 = [5; 3; 18; 1; 4; 12; 21]
    let list3 = [3; 2; 5; 7; 4]

    let result list = printfn "List %A represents a symmetric binary tree: %b" list (list |> fromList |> isSymmetric)

    result list2
    result list3
