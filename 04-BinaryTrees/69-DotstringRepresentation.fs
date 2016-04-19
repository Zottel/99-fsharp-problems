module BinaryTrees.DotstringRepresentation

open BinaryTrees.BinaryTree

let rec toDotstring tree =
    match tree with
    | Empty -> "."
    | Branch(value, left, right) ->
        (value |> string) + (toDotstring left) + (toDotstring right)

let fromDotstring (str:string) =
    let rec loop pos =
        match str.[pos] with
        | '.' -> (Empty, pos + 1)
        | char ->
            let lTree, lPos = loop (pos + 1)
            let rTree, rPos = loop lPos
            (Branch(char, lTree, rTree), rPos)

    loop 0 |> fst

let test () =
    let tree = Branch('a', Branch('b', Branch('d', Empty, Empty), Branch('e', Empty, Empty)), Branch('c', Empty, Branch('f', Branch('g', Empty, Empty), Empty)))
    let str = "abd..e..c.fg..."

    printfn "Input tree: \n%A" tree
    printfn "Tree in dotstring representation: %s" (toDotstring tree)

    printfn "\nDotstring representation: %s" str
    printfn "Tree build from dotstring: \n%A" (fromDotstring str)
