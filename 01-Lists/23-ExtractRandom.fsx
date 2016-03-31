module Lists.ExtractRandom

#load "../01-Lists/20-RemoveElement.fsx"
open Lists.RemoveElement

let random = System.Random()

let rec randomSelect number list = 
    match number,list with
    | 0,_ -> []
    | _,[] -> []
    | number,list ->
        let rest, element = removeAt (random.Next (List.length list)) list
        element :: randomSelect (number - 1) rest
