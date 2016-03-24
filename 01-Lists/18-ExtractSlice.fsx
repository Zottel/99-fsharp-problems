module Lists.ExtractSlice

#load "./17-Split.fsx"
open Lists.Split

let slice fromElement toElement list =
    list
    |> take toElement
    |> drop fromElement
 