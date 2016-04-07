module Lists.NthElement

let elementAt list position = list |> Seq.skip position |> Seq.toList |> Seq.head

let test () =
    let list = [1; 1; 2; 3; 5; 8]
    let position = 4

    printfn "Input list: %A" list
    printfn "Element at position %i is %i" position (elementAt list position)
