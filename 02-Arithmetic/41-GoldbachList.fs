module Arithmetic.GoldbachList

open Arithmetic.GoldbachsConjecture

let goldbachList front back =
    let start =
        match compare front 4 with
        | -1 -> 4
        | 1 when front % 2 = 1 -> front + 1
        | _ -> front
    [start .. 2 .. back] |> List.map (fun item -> (item, goldbach item))

let goldbachListLimited front back limit =
    goldbachList front back |> List.filter (fun (number, (first, second)) -> first > limit && second > limit)

let printGoldbachList =
    List.iter (fun (number, (first, second)) -> printfn "%i = %i + %i" number first second)

let test () =
    let first = 9
    let last = 20

    printfn "Goldbach compositons from %i to %i:" first last
    goldbachList first last |> printGoldbachList

    let first' = 1
    let last' = 2000
    let limit = 50

    printfn "Goldbach compositions from %i to %i limited by %i:" first' last' limit
    goldbachListLimited first' last' limit |> printGoldbachList
