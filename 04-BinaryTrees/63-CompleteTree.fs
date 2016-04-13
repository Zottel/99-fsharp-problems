module BinaryTrees.CompleteTree

open BinaryTrees.BinaryTree

let generateComplete nodes value =
    let rec loop addr =
        match addr with
        | n when n > nodes -> Empty
        | n -> Branch(value, loop (addr * 2), loop (addr * 2 + 1))
    loop 1

let test () =
    let nodes = 6

    printfn "Complete binary tree with %i nodes: \n%A" nodes (generateComplete nodes "x")
