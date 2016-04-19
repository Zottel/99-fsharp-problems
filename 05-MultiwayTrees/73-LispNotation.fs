module MultiwayTrees.LispNotation

open MultiwayTrees.MultiwayTree

let rec lispyString tree =
    match tree with
    | Node(value, []) -> value |> string
    | Node(value, children) ->
        "(" + (value |> string) + (List.fold (fun acc child -> acc + " " + (lispyString child)) "" children) + ")"

let lispyTree (str:string) =
    let chars = str |> List.ofSeq |> List.filter ((<>) ' ')
    let rec loop chars stack =
        match chars with
        | '('::elem::tail -> loop tail (Node(elem, [])::stack)
        | ')'::tail ->
            match stack with
            | [] -> failwith "incorrect input string"
            | [node] -> node
            | node::Node(value, children)::stackTail -> loop tail (Node(value, children @ [node])::stackTail)
        | elem::tail ->
            match stack with
            | [] -> loop tail [Node(elem, [])]
            | Node(value, children)::stackTail -> loop tail (Node(value, children @ [Node(elem,[])])::stackTail)
        | [] -> List.head stack

    loop chars []

let test () =
    let tree = Node('a', [Node('f', [Node('g', [])]); Node('c', []); Node('b', [Node('d', []); Node('e', [])])])
    let str = "(a (f g) c (b d e))"

    printfn "Input tree: \n%A" tree
    printfn "Tree in Lisp notation: %s" (lispyString tree)

    printfn "\nInput string: %s" str
    printfn "Tree made from Lisp string: \n%A" (lispyTree str)
