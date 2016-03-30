#load "./41-GoldbachList.fsx"
open Arithmetic.GoldbachList

let first = 9
let last = 20

printfn "Goldbach compositons from %i to %i:" first last
goldbachList first last |> printGoldbachList

let first' = 1
let last' = 2000
let limit = 50

printfn "Goldbach compositions from %i to %i limited by %i:" first' last' limit
goldbachListLimited first' last' limit |> printGoldbachList
