#load "./33-Coprime.fsx"
open Arithmetic.Coprime

let m = 35
let n = 64

printfn "%i is coprime to %i: %b" m n (areCoprime m n)
