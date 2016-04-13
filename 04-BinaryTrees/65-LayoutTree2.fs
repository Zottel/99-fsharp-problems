module BinaryTrees.LayoutTree2

open BinaryTrees.BinaryTree
open BinaryTrees.BinarySearchTree

let rec height tree =
    match tree with
    | Empty -> 0
    | Branch(_,left,right) -> (max (height left) (height right)) + 1

let rec leftHeight tree =
    match tree with
    | Empty -> 0
    | Branch(_,left,_) -> (leftHeight left) + 1

let layoutTree tree =
    let h = height tree
    let rootX = [2.0 .. (leftHeight tree |> float)] |> List.map (fun elem -> (2.0 ** ((h |> float) - elem)) |> int) |> List.fold (+) 1
    let rec loop x y exp tree =
        match tree with
        | Empty -> Empty
        | Branch(value,left,right) ->
            let pow = 2.0 ** (exp |> float) |> int
            Branch(
                (value, x, y),
                loop (x - pow) (y + 1) (exp - 1) left,
                loop (x + pow) (y + 1) (exp - 1) right)

    loop rootX 1 (h - 2) tree

let test () =
    let displayResult tree =
        printfn "\nInput tree: \n%A" tree
        printfn "Tree with coordinates: \n%A" (layoutTree tree)

    let tree = Branch("a", Branch("b", Empty, Branch("c", Empty, Empty)), Branch("d", Empty, Empty))

    displayResult tree

    let tree' = fromList ['n';'k';'m';'c';'a';'e';'d';'g';'u';'p';'q']

    displayResult tree'
