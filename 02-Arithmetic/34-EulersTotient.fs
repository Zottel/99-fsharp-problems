module Arithmetic.EulersTotient

open Arithmetic.Coprime

let totient m =
    [1 .. m-1] |> List.map (fun n -> areCoprime m n) |> List.filter (fun item -> item = true) |> List.length

let test () =
    let m = 10

    printfn "Euler's totient function phi(%i) = %i" m (totient m)
