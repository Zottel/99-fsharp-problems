module BinaryTrees.HeightBalanced

open BinaryTrees.BinaryTree

let rec generateHeightBalanced levels value =
    match levels with
    | n when n < 1 -> [Empty]
    | 1 -> [Branch (value, Empty, Empty)]
    | _ ->
        let fullHeight = generateHeightBalanced (levels - 1) value
        let short = generateHeightBalanced (levels - 2) value
        [for l in fullHeight do
            for r in fullHeight do
                yield [Branch (value, l, r)]] @
        [for f in fullHeight do
            for s in short do
                yield [Branch(value, f, s); Branch(value, s, f)]] |> List.concat

let test () =
    let levels = 3

    printfn "Height-balanced trees with %i levels: \n%A" levels (generateHeightBalanced 3 'x')
