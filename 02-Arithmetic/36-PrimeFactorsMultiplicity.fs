module Arithmetic.PrimeFactorsMultiplicity

open Arithmetic.PrimeFactors

let primeFactorsMultiplicity m =
    primeFactors m
    |> List.toSeq
    |> Seq.groupBy (fun elem -> elem)
    |> Seq.map (fun elem -> fst elem, Seq.length (snd elem))
    |> Seq.toList

let test () =
    let number = 315

    printfn "Prime factors (with multiplcity) of %i are: %A" number (primeFactorsMultiplicity number)
