module LogicAndCodes.LogicalPredicates3

open LogicAndCodes.LogicalPredicates2

let tablen n func =
    // generate list of n letters
    let letters number =
        let A = int 'A'
        match number with
        | 0 -> []
        | _ when number >= 1 && number <= 26 -> [A .. (A + (number - 1))] |> List.map char
        | _ -> failwith "Number out of range"

    // print table header with n columns
    let printHeader n =
        List.iter (fun item -> printf "%-5s " (item.ToString())) (letters n)
        printfn "%-5s" "result"

    // print row with result
    let printRow row func =
        List.iter (fun item -> printf "%-5b " item) row
        printfn "%-5b" (func row)

    // generate all combinations of n-element true, false list
    let replicate n values =
        let rec repl acc n =
            match n with
            | 0 -> acc
            | _ ->
                let acc' = acc |> List.collect (fun v -> values |> List.map (fun item -> item::v))
                repl acc' (n - 1)
        repl [[]] n

    let values = replicate n [true;false]
    printHeader n
    values |> List.iter (fun item -> printRow item func)

#nowarn "25"

let test () =
    printfn "Table for a and (b or c) equ a and b or a and c):"
    tablen 3 (fun [a;b;c] -> (a &&. (b ||. c)) =. ((a &&. b) ||. (a &&. c)))
