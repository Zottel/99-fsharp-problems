#load "./35-PrimeFactors.fsx"
open Arithmetic.PrimeFactors

let number = 315

printfn "Prime factors of %i are: %A" number (primeFactors number)
