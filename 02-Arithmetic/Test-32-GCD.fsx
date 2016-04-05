#load "./32-GCD.fsx"
open Arithmetic.GCD

let m = 36
let n = 63

printfn "Greatest common divisor of %i an %i is %i" m n (gcd m n)
