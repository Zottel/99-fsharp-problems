module Misc.EightQueens

let eightQueens () =
    let rec validDiagonals queens upper lower =
        match queens with
        | [] -> true
        | q :: tail -> q <> upper && q <> lower && validDiagonals tail (upper + 1) (lower - 1)
    let valid queens =
        match queens with
        | [] -> true
        | q :: tail -> validDiagonals tail (q + 1) (q - 1)
    let rec loop curQueens remainingCols =
        if valid curQueens |> not then []
        else if remainingCols |> Set.isEmpty then [curQueens]
        else remainingCols |> Set.toList |> List.collect (fun c -> loop (c :: curQueens) (remainingCols - Set([c])))
    loop [] (Set([1 .. 8]))

let test () =
    printfn "Eight queens results: \n%A" (eightQueens ())
