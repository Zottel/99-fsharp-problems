module Lists.DuplicateElement

let duplicate list = List.collect (fun item -> item::[item]) list
