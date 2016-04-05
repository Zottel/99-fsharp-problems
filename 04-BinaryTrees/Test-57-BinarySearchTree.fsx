#load "./56-IsSymmetric.fsx"
#load "./57-BinarySearchTree.fsx"
open BinaryTrees.BinaryTree
open BinaryTrees.IsSymmetric
open BinaryTrees.BinarySearchTree

let list1 = [3; 2; 5; 7; 1]

printfn "Input list: %A" list1
printfn "Binary search tree: %A" (fromList list1)

let list2 = [5; 3; 18; 1; 4; 12; 21]
let list3 = [3; 2; 5; 7; 4]

let result list = printfn "List %A represents a symmetric binary tree: %b" list (list |> fromList |> isSymmetric)

result list2 
result list3 
