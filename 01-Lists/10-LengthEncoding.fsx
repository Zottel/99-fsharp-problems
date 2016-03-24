module Lists.LengthEncoding

#load "./09-PackDuplicates.fsx"
open Lists.PackDuplicates

let encode list = pack list |> List.map (fun elem -> (List.length elem, List.head elem))
