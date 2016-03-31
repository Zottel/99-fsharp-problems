module LogicAndCodes.GrayCode

let rec grayCode n =
    match n with
    | 0 -> [""]
    | _ -> 
        let lower = grayCode (n - 1)
        (lower |> List.map (fun item -> "0" + item)) @ (lower |> List.rev |> List.map (fun item -> "1" + item))
