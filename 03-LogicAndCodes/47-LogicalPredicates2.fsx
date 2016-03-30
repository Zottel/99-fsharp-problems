module LogicAndCodes.LogicalPredicates2

#load "./46-LogicalPredicates.fsx"
open LogicAndCodes.LogicalPredicates

let (!) a = not' a
let (&&.) a b = and' a b
let (||.) a b = or' a b
let (=.) a b = equ a b
let (^&&) a b = nand a b
let (^||) a b = nor a b
let (&|) a b = xor a b
let (-->) a b = impl a b
