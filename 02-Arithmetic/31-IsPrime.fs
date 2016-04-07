module Arithmetic.IsPrime

let sqrn n = sqrt (float n) |> int

let isPrime n =
    not (List.exists (fun elem -> n % elem = 0) [2 .. sqrn n])

let test () =
    let number = 7

    printfn "%i is prime: %b" number (isPrime number)
