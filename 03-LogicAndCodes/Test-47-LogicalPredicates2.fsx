#load "./47-LogicalPredicates2.fsx"
open LogicAndCodes.LogicalPredicates
open LogicAndCodes.LogicalPredicates2

printfn "Table for a and (a or not(b))):"
table (fun a b -> a &&. (a ||. (! b)))
