#load "./50-HuffmanCodes.fsx"
open LogicAndCodes.HuffmanCodes

let list = [("a", 45); ("d", 16); ("b", 13); ("c", 12); ("e", 9); ("f", 5)]

printfn "Input list:"
printfn "%A" list
printfn "Huffman encoded list:"
printfn "%A" (huffman list)
