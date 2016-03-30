#load "./40-GoldbachsConjecture.fsx"
open Arithmetic.GoldbachsConjecture

let number = 28
let result = goldbach number

printfn "%i is a sum of %i and %i" number (fst result) (snd result)
