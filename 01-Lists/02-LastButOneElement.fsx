module Lists.LastButOneElement

let lastButOne list = list |> List.rev |> List.tail |> List.head
