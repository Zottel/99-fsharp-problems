module Arithmetic.PrimeFactors

open Arithmetic.IsPrime

let primeFactors m =
    let rec primeFactorsRec n ints =
        match n, ints with
        | _,[] -> []
        | n,_ when isPrime n -> [n]
        | n,head::_ when n % head = 0 -> head :: primeFactorsRec (n / head) ints
        | n,_::tail -> primeFactorsRec n tail

    primeFactorsRec m (2::[3 .. 2 .. sqrn m])

let test () =
    let number = 315

    printfn "Prime factors of %i are: %A" number (primeFactors number)
