#load "./31-IsPrime.fsx"
open Arithmetic.IsPrime

let number = 7

printfn "%i is prime: %b" number (isPrime number)
