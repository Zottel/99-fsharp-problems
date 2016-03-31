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
