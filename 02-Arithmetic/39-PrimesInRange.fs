module Arithmetic.PrimesInRange

open Arithmetic.IsPrime

let primesInRange lower upper =
    [lower .. upper] |> List.filter (fun elem -> isPrime elem)

let test () =
    let lower = 7
    let upper = 31

    printfn "Primes in range %i to %i: \n%A" lower upper (primesInRange lower upper)
