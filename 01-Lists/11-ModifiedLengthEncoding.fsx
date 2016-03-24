module Lists.ModifiedLengthEncoding

#load "./10-LengthEncoding.fsx"
open Lists.LengthEncoding

type 'a Encoding = Multiple of int * 'a | Single of 'a

let modifiedEncode list = 
    encode list 
    |> List.map (fun (count,item) -> if count = 1 then Single(item) else Multiple(count,item))
