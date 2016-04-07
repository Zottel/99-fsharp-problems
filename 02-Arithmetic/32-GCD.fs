module Arithmetic.GCD

let rec gcd m n =
    if n = 0 then abs m
    else
        gcd n (m % n)

let test () =
    let m = 36
    let n = 63

    printfn "Greatest common divisor of %i an %i is %i" m n (gcd m n)
