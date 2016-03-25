module Lists.InsertElement

#load "./17-Split.fsx"
open Lists.Split

let insertAt item index list = 
    let (start,tail) = split index list
    start @ [item] @ tail
