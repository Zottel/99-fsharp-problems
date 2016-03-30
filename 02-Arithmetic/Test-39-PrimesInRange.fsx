#load "./39-PrimesInRange.fsx"
open Arithmetic.PrimesInRange

let lower = 7
let upper = 31

printfn "Primes in range %i to %i: \n%A" lower upper (primesInRange lower upper)
