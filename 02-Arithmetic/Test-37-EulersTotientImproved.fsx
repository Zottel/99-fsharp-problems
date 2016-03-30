#load "./37-EulersTotientImproved.fsx"
open Arithmetic.EulersTotientImproved

let m = 10

printfn "Euler's totient function phi(%i) = %i" m (totientImproved m)
