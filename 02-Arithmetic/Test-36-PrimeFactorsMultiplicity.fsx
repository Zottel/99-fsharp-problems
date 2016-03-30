#load "./36-PrimeFactorsMultiplicity.fsx"
open Arithmetic.PrimeFactorsMultiplicity

let number = 315

printfn "Prime factors (with multiplcity) of %i are: %A" number (primeFactorsMultiplicity number) 
