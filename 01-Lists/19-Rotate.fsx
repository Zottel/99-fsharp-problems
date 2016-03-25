module Lists.Rotate

#load "./17-split.fsx"
open Lists.Split

let rotate by list = 
    match list, by with
    | [],_ -> []
    | ls,0 -> ls
    | ls,by -> 
        let l = List.length ls
        let (head,tail) = split ((l + by) % l) ls
        tail @ head
