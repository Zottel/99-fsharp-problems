module BinaryTrees.LayoutTree3

let makeOption i = Some i

let zipAll alst blst aitem bitem =
    let rec loop alst blst revAcc =
        match alst, blst with
        | a::atl, b::btl -> loop atl btl ((a,b)::revAcc)
        | a::atl, [] -> loop atl [] ((a,bitem)::revAcc)
        | [], b::btl -> loop [] btl ((aitem,b)::revAcc)
        | _ -> revAcc |> List.rev
    loop alst blst []

let zipShorter alst blst =
    let rec loop alst blst revAcc =
        match alst, blst with
        | a::atl, b::btl -> loop atl btl ((a,b)::revAcc)
        | a::atl, [] -> revAcc |> List.rev
        | [], b::btl -> revAcc |> List.rev
        | _ -> revAcc |> List.rev
    loop alst blst []

type 'a BinaryTree =
    | Empty
    | Branch of 'a * 'a BinaryTree * 'a BinaryTree

    member self.left
        with get () =
            match self with
            | Empty -> Empty
            | Branch(_, left, _) -> left

    member self.right
        with get () =
            match self with
            | Empty -> Empty
            | Branch(_, _, right) -> right

    member self.bounds
        with get () =
            let lowerBounds () =
                match self.left.bounds, self.right.bounds with
                | ([], []) -> []
                | (lb, []) -> List.map (fun b -> ((fst b) - 1, (snd b) - 1)) lb
                | ([], rb) -> List.map (fun b -> ((fst b) + 1, (snd b) + 1)) rb
                | (lb, rb) ->
                    let shift = zipShorter lb rb |> List.map (fun e -> (e |> fst |> snd) - (e |> snd |> fst) / 2 + 1) |> List.reduce max
                    zipAll (lb |> List.map makeOption) (rb |> List.map makeOption) None None |> List.map (fun i ->
                        match i with
                        | (Some(a,b),Some(c,d)) -> (a - shift, d + shift)
                        | (Some(a,b),None)  -> (a - shift, b - shift)
                        | (None,Some(c,d))  -> (c + shift, d + shift)
                        | (None,None) -> failwith "not possible"
                    )

            match self with
            | Empty -> []
            | Branch(_,_,_) -> (0,0) :: lowerBounds()

let layoutTree (tree:'a BinaryTree) =
    let rec loop x level (tree:'a BinaryTree) =
        match tree with
        | Empty -> Empty
        | Branch(value, left, right) ->
            match tree.bounds with
            | _ :: (lb, rb) :: _ ->
                Branch((value, x, level), loop (x + lb) (level + 1) left, loop (x + rb) (level + 1) right)
            | _ -> Branch((value, x, level), Empty, Empty)
    loop ((tree.bounds |> List.map fst |> List.reduce min) * -1 + 1) 1 tree

let test () =
    let displayResult tree =
        printfn "\nInput tree: \n%A" tree
        printfn "Tree with coordinates: \n%A" (layoutTree tree)

    let tree = Branch("a", Branch("b", Empty, Branch("c", Empty, Empty)), Branch("d", Empty, Empty))

    displayResult tree

    let tree' = Branch('n', Branch('k', Branch('c',Branch ('a',Empty,Empty), Branch ('e',Branch ('d',Empty,Empty),Branch ('g',Empty,Empty))), Branch ('m',Empty,Empty)), Branch ('u',Branch ('p',Empty,Branch ('q',Empty,Empty)),Empty))

    displayResult tree'
