#load "./48-LogicalPredicates3.fsx"
open LogicAndCodes.LogicalPredicates2
open LogicAndCodes.LogicalPredicates3

#nowarn "25"    

printfn "Table for a and (b or c) equ a and b or a and c):"
tablen 3 (fun [a;b;c] -> (a &&. (b ||. c)) =. ((a &&. b) ||. (a &&. c)))
