#load "./07-FlattenNestedList.fsx"
open Lists.FlattenNestedList

let list = List [List [Elem 1; Elem 1]; Elem 2; List [Elem 3; List [Elem 5; Elem 8]]]
printfn "Flattened list: %A" (Flatten list)