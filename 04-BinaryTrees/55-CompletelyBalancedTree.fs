module BinaryTrees.CompletelyBalancedTree

open BinaryTrees.BinaryTree

let rec generateBalanced nodes value =
    match nodes with
    | 0 -> [Empty]
    | n when n % 2 = 1 ->
        let subtrees = generateBalanced (n / 2) value
        [for l in subtrees do
            for r in subtrees do
                yield Branch(value, l, r)]
    | n when n % 2 = 0 ->
        [for l in generateBalanced ((n - 1) / 2) value do
            for g in generateBalanced ((n - 1) / 2 + 1) value do
                yield [Branch(value, l, g); Branch(value, g, l)]]
        |> List.concat
    | _ -> [Empty]

let test () =
    let nodes = 4

    printfn "Completely balanced trees with %i nodes: \n%A" nodes (generateBalanced 4 'x')
