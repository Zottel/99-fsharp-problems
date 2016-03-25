#load "./22-IntegersInRange.fsx"
open Lists.IntegersInRange

let lower = 4
let upper = 9

printfn "Integers from %i to %i: %A" lower upper (range lower upper)
