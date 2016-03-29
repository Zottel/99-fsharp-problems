module Arithmetic.EulersTotient

#load "./33-Coprime.fsx"
open Arithmetic.Coprime

let totient m = 
    [1 .. m-1] |> List.map (fun n -> areCoprime m n) |> List.filter (fun item -> item = true) |> List.length
