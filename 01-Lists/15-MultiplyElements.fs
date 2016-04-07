module Lists.MultiplyElements

let multiply times list = List.collect (fun item -> List.replicate times item) list