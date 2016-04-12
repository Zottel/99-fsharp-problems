module BinaryTrees.NodesAtLevel

open BinaryTrees.BinaryTree

let nodesAtLevel level tree =
    let rec loop l tree =
        match tree with
        | Empty -> []
        | Branch (value, left, right) ->
            if l = level then
                [value]
            else
                loop (l + 1) left @ loop (l + 1) right
    loop 1 tree

let test () =
    let tree = Branch("a", Branch("b", Empty, Empty), Branch("c", Branch("d", Empty, Empty), Branch("e", Empty, Empty)))
    let level = 2

    printfn "Input tree: \n%A" tree
    printfn "Nodes at level %i: %A" level (nodesAtLevel level tree)
