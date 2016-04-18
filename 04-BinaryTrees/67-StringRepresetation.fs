module BinaryTrees.StringRepresentation

open BinaryTrees.BinaryTree

let rec treeToString tree =
    match tree with
    | Empty -> ""
    | Branch(value, Empty, Empty) -> value |> string
    | Branch(value, left, right) -> (value |> string) + "(" + (treeToString left) + "," + (treeToString right) + ")"

let rec stringToTree (str:string) =

    let extractSubtree (str:string) start delimiter =
        let getLevel level pos =
            match str.[pos] with
            | '(' -> level + 1
            | ')' -> level - 1
            | _ -> level

        let rec findEnd pos level =
            if str.[pos] = delimiter && level = 0 then pos
            else findEnd (pos + 1) (getLevel level pos)

        let strEnd = findEnd start 0
        (str.Substring (start, strEnd - start), strEnd)

    match str.Length with
    | 0 -> Empty
    | 1 -> Branch(str.[0], Empty, Empty)
    | _ ->
        let left,comma = extractSubtree str 2 ','
        let right,_ = extractSubtree str (comma+1) ')'
        Branch(str.[0], stringToTree left, stringToTree right)

let test () =
    let tree = Branch('a', Branch('b', Branch('d', Empty, Empty), Branch('e', Empty, Empty)), Branch('c', Empty, Branch('f', Branch('g', Empty, Empty), Empty)))
    let str = "a(b(d,e),c(,f(g,)))"

    printfn "Input tree: \n%A" tree
    printfn "Tree converted to string: %s" (treeToString tree)

    printfn "\nInput string: %s" str
    printfn "Tree made o string: \n%A" (stringToTree str)
