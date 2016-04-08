module BinaryTrees.GenerateAndTest

open BinaryTrees.BinaryTree
open BinaryTrees.CompletelyBalancedTree
open BinaryTrees.IsSymmetric

let symmetricBalancedTrees nodes value =
    generateBalanced nodes value |> List.filter (fun tree -> isSymmetric tree)

let test () =
    let nodes = 5

    printfn "Completely balanced symmetric trees with %i nodes: \n%A" nodes (symmetricBalancedTrees nodes 'x')
