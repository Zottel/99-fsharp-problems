module Lists.DropEveryNthElement

let drop nth list = 
    list 
    |> List.mapi (fun index item -> (index + 1,item)) 
    |> List.filter (fun (index,_) -> not (index % nth = 0)) 
    |> List.map snd
 