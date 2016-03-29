#load "./27-GroupElements.fsx"
open Lists.GroupElements

let list = ["Aldo"; "Beat"; "Carla"; "David"; "Evi"; "Flip"; "Gary"; "Hugo"; "Ida"]
let groups = [2; 2; 5]

let result3 = group3 list
let result = group groups list

printfn "Input list: %A" list
printfn "Grouped in 2, 3, 4 element groups: \n%A" result3
printfn "Grouped in %A element groups: \n%A" groups result
