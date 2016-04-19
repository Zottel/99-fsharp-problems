module MultiwayTrees.NodeString

open MultiwayTrees.MultiwayTree

let rec toString tree =
    match tree with
    | Node(value, children) -> (value |> string) + (List.fold (fun acc i -> acc + (toString i)) "" children) + "^"

let fromString (str:string) =
    let chars = List.ofSeq str
    let rec loop chars stack =
        match chars with
        | [] -> failwith "incorrect input string"
        | '^'::tail ->
            match stack with
            | [] -> failwith "incorrect input string"
            | [node] -> node
            | node::Node(value, children)::stackTail -> loop tail (Node(value, children @ [node])::stackTail)
        | char::tail -> loop tail (Node(char,[])::stack)

    loop chars []

let test () =
    let tree = Node('a', [Node('f', [Node('g', [])]); Node('c', []); Node('b', [Node('d', []); Node('e', [])])])
    let str = "afg^^c^bd^e^^^"

    printfn "Input tree: \n%A" tree
    printfn "String representation: %s" (toString tree)

    printfn "\nInput string: %s" str
    printfn "Tree generated from string: \n%A" (fromString str)
