#load "./34-EulersTotient.fsx"
open Arithmetic.EulersTotient

let m = 10

printfn "Euler's totient function phi(%i) = %i" m (totient m)
