module Arithmetic.EulersTotientImproved

open Arithmetic.PrimeFactorsMultiplicity

let totientImproved m =
    primeFactorsMultiplicity m |> List.fold (fun acc (factor,mult) -> acc * (factor - 1) * (pown factor (mult - 1))) 1

let test () =
    let m = 10

    printfn "Euler's totient function phi(%i) = %i" m (totientImproved m)
