module Arithmetic.IsPrime

let isPrime n = 
    let sqrn = sqrt (float n) |> int
    not (List.exists (fun elem -> n % elem = 0) [2 .. sqrn]) 
