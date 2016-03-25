#load "./24-Lotto.fsx"
open Lists.Lotto

let count = 6
let max = 49

printfn "%i random numbers from 1 to %i range: %A" count max (lotto count max)
