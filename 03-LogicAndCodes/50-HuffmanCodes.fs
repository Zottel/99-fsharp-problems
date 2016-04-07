module LogicAndCodes.HuffmanCodes

type 'a HuffmanTree = Node of int * 'a HuffmanTree * 'a HuffmanTree | Leaf of int * 'a

let huffman list =
    // function for getting frequency from HuffmanTree node/leaf
    let freq = function
        | Node(f, _, _) -> f
        | Leaf(f, _) -> f

    // create tree from list of nodes
    let rec createTree list =
        let ls = list |> List.sortBy freq
        match ls with
        | [] -> failwith "empty"
        | [x] -> x
        | first::second::tail ->
            let node = Node(freq first + freq second, first, second)
            createTree (node::tail)

    // encode HuffmanTree
    let encode tree =
        let rec enc code tree =
            match tree with
                | Leaf (_, a) -> [(a, code)]
                | Node(_, left, right) ->
                    enc (code + "0") left @ enc (code + "1") right
        enc "" tree |> List.sortBy fst

    // make a list of HuffmanTree nodes from length encoded list
    let hufList = list |> List.map (fun (a, frequency) -> Leaf(frequency, a))
    hufList |> createTree |> encode

let test () =
    let list = [("a", 45); ("d", 16); ("b", 13); ("c", 12); ("e", 9); ("f", 5)]

    printfn "Input list:"
    printfn "%A" list
    printfn "Huffman encoded list:"
    printfn "%A" (huffman list)

    let lipsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean euismod libero sem, sit amet scelerisque diam tincidunt at. Maecenas consequat vel eros in eleifend. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Proin tristique, diam et finibus blandit, lorem nulla semper sapien, vitae sagittis felis lectus ut turpis. Nulla vestibulum scelerisque mollis. Duis sollicitudin maximus libero. Curabitur mattis diam ut leo gravida dictum. Donec sit amet imperdiet risus. Cras ullamcorper purus sit amet elit tincidunt, ut interdum ipsum tincidunt. Donec id ullamcorper massa. Vestibulum finibus porta dolor nec euismod."

    let list =
        lipsum
        |> Seq.toList
        |> List.sort
        |> Lists.LengthEncoding.encode
        |> List.map (fun (a,b) -> (b,a))

    printfn "Input string:"
    printfn "%s" lipsum
    printfn "Huffman encoded list:"
    printfn "%A" (huffman list)
