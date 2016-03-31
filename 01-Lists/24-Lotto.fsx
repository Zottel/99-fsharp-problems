module Lists.Lotto

#load "../01-Lists/22-IntegersInRange.fsx"
#load "../01-Lists/23-ExtractRandom.fsx"

open Lists.IntegersInRange
open Lists.ExtractRandom

let lotto count max = range 1 max |> randomSelect count
