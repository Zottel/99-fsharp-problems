#load "./50-HuffmanCodes.fsx"
#load "../01-Lists/10-LengthEncoding.fsx"
open LogicAndCodes.HuffmanCodes

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
