module Lists.NumberOfElements

let countElements = List.length

let test () =
    let list = [1; 1; 2; 3; 5; 8]

    printfn "Input list: %A" list
    printfn "The list has %i elements" (countElements list)
