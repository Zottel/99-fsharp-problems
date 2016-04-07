module Lists.Lotto

open Lists.IntegersInRange
open Lists.ExtractRandom

let lotto count max = range 1 max |> randomSelect count

let test () =
    let count = 6
    let max = 49

    printfn "%i random numbers from 1 to %i range: %A" count max (lotto count max)
