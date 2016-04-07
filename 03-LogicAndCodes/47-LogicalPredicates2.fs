module LogicAndCodes.LogicalPredicates2

open LogicAndCodes.LogicalPredicates

let (!) a = not' a
let (&&.) a b = and' a b
let (||.) a b = or' a b
let (=.) a b = equ a b
let (^&&) a b = nand a b
let (^||) a b = nor a b
let (&|) a b = xor a b
let (-->) a b = impl a b

let test () =
    printfn "Table for a and (a or not(b))):"
    table (fun a b -> a &&. (a ||. (! b)))
