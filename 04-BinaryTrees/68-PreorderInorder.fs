module BinaryTrees.PreorderInorder

open BinaryTrees.BinaryTree
open Lists.Split

let rec preorder tree =
    match tree with
    | Empty -> []
    | Branch(value, left, right) -> value :: (preorder left) @ (preorder right)

let rec inorder tree =
    match tree with
    | Empty -> []
    | Branch(value, left, right) -> (inorder left) @ [value] @ (inorder right)

let rec preInTree preorder inorder =
    let split division list =
        try
            let index = List.findIndex (fun item -> item = division) list
            (take index list, drop (index + 1) list)
        with
        | :? System.Collections.Generic.KeyNotFoundException ->
            (list, [])

    match preorder with
    | [] -> Empty
    | head::tailPre ->
        match split head inorder with
        | [], [] -> Branch(head, Empty, Empty)
        | leftIn, [] -> Branch(head, preInTree (tailPre |> take (List.length leftIn)) leftIn, Empty)
        | [], rightIn -> Branch(head, Empty, preInTree tailPre rightIn)
        | leftIn, rightIn -> Branch(head,
                                preInTree (tailPre |> take (List.length leftIn)) leftIn,
                                preInTree (tailPre |> drop (List.length leftIn)) rightIn)

let test () =
    let tree = Branch('a', Branch('b', Branch('d', Empty, Empty), Branch('e', Empty, Empty)), Branch('c', Empty, Branch('f', Branch('g', Empty, Empty), Empty)))

    printfn "Input tree: %A" tree
    printfn "Pre-order list: %A" (preorder tree)
    printfn "In-order list: %A" (inorder tree)

    printfn "Tree made from pre-order and in-order lists: \n%A" (preInTree (preorder tree) (inorder tree))
