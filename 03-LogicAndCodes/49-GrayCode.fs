module LogicAndCodes.GrayCode

let rec grayCode n =
    match n with
    | 0 -> [""]
    | _ ->
        let lower = grayCode (n - 1)
        (lower |> List.map (fun item -> "0" + item)) @ (lower |> List.rev |> List.map (fun item -> "1" + item))

let test () =
    let n = 3

    printfn "Gray codes for n = %i:" n
    printfn "%A" (grayCode n)
