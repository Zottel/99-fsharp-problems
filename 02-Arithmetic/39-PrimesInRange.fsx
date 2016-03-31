module Arithmetic.PrimesInRange

#load "../02-Arithmetic/31-IsPrime.fsx"
open Arithmetic.IsPrime

let primesInRange lower upper = 
    [lower .. upper] |> List.filter (fun elem -> isPrime elem)
