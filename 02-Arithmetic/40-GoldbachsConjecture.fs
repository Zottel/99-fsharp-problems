module Arithmetic.GoldbachsConjecture

open Arithmetic.PrimesInRange

let goldbach n =
    let primes = primesInRange 2 n |> List.toArray
    let rec findSum (arr:int array) left right =
        let sum = arr.[left] + arr.[right]
        match compare sum n with
        | -1 -> findSum arr (left + 1) right
        | 1 -> findSum arr left (right - 1)
        | _ -> (arr.[left], arr.[right])
    findSum primes 0 ((Array.length primes) - 1)

let test () =
    let number = 28
    let result = goldbach number

    printfn "%i is a sum of %i and %i" number (fst result) (snd result)
