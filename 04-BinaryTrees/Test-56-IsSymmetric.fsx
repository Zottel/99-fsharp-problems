#load "./56-IsSymmetric.fsx"
open BinaryTrees.BinaryTree
open BinaryTrees.IsSymmetric

let tree = Branch('a', Branch('b', Empty, Empty), Branch('c', Empty, Empty))

printfn "The tree:\n%A" tree
printfn "Is symmetric: %b" (isSymmetric tree)
