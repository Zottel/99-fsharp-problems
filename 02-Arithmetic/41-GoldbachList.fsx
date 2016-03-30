module Arithmetic.GoldbachList

#load "./40-GoldbachsConjecture.fsx"
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
    List.map (fun (number, (first, second)) -> printfn "%i = %i + %i" number first second) 
