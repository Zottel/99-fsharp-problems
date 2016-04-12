module BinaryTrees.HeightBalancedWithGivenNodes

open BinaryTrees.HeightBalanced
open BinaryTrees.BinaryTree

let rec countNodes tree =
    match tree with
    | Empty -> 0
    | Branch(_, left, right) -> countNodes left + countNodes right + 1

let rec minNodes height =
    match height with
    | n when n < 1 -> 0
    | 1 -> 1
    | n -> minNodes (n - 1) + minNodes (n - 2) + 1

let rec minHeight nodes =
    match nodes with
    | 0 -> 0
    | n -> minHeight (n / 2) + 1

let maxHeight nodes =
    Seq.initInfinite (fun i -> i) |> Seq.takeWhile (fun item -> minNodes item <= nodes) |> Seq.toList |> List.rev |> List.head

let hBalWithNodes nodes value =
    [minHeight nodes .. maxHeight nodes]
    |> List.collect (fun item -> generateHeightBalanced item value)
    |> List.filter (fun item -> countNodes item = nodes)

let test () =
    let h = 3
    let n = 4
    let n' = 15

    printfn "Minimum number of nodes in height-balanced tree with H = %i: %i" h (minNodes h)
    printfn "Maximum height of height balanced tree with %i nodes: %i" n (maxHeight n)

    printfn "\nHeight-balanced trees with %i nodes: \n%A" n (hBalWithNodes n "x")

    printfn "\nNumber of height-balanced trees with %i nodes: %i" n' (hBalWithNodes n' "x" |> List.length)
