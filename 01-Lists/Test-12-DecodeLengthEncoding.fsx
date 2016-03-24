#load "./12-DecodeLengthEncoding.fsx"
open Lists.DecodeLengthEncoding

let list = [(4, 'a'); (1, 'b'); (2, 'c'); (2, 'a'); (1, 'd'); (4, 'e')]
printfn "Length-encoded list: %A" list
printfn "Decoded list: %A" (decode list)
