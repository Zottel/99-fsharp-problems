module Arithmetic.EulersTotientImproved

#load "../02-Arithmetic/36-PrimeFactorsMultiplicity.fsx"
open Arithmetic.PrimeFactorsMultiplicity

let totientImproved m = 
    primeFactorsMultiplicity m |> List.fold (fun acc (factor,mult) -> acc * (factor - 1) * (pown factor (mult - 1))) 1 
