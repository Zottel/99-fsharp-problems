module Arithmetic.Coprime

open Arithmetic.GCD

let areCoprime m n = gcd m n = 1

let test () =
    let m = 35
    let n = 64

    printfn "%i is coprime to %i: %b" m n (areCoprime m n)
