module Arithmetic.PrimeFactorsMultiplicity

#load "./35-PrimeFactors.fsx"
open Arithmetic.PrimeFactors

let primeFactorsMultiplicity m = 
    primeFactors m 
    |> List.toSeq 
    |> Seq.groupBy (fun elem -> elem) 
    |> Seq.map (fun elem -> fst elem, Seq.length (snd elem)) 
    |> Seq.toList
