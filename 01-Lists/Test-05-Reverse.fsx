#load "./05-Reverse.fsx"
open Lists.Reverse

let list = [1; 1; 2; 3; 5; 8]
printfn "Reversed list: %A" (reverse list)
