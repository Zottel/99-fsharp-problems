#load "./46-LogicalPredicates.fsx"
open LogicAndCodes.LogicalPredicates

printfn "Table for and(a, or(a, b)):"
table (fun a b -> and' a (or' a b))
