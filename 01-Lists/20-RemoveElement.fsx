module Lists.RemoveElement

#load "./17-Split.fsx"
open Lists.Split

let removeAt index list = 
    let (start,tail) = split index list
    (start @ List.tail tail, List.head tail)
