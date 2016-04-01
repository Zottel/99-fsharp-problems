#load "./55-CompletelyBalancedTree.fsx"
open BinaryTrees.CompletelyBalancedTree

let nodes = 4

printfn "Completely balanced trees with %i nodes: \n%A" nodes (generateBalanced 4 'x')
