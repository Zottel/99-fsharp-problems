module Lists.NthElement

let elementAt list position = list |> Seq.skip position |> Seq.toList |> Seq.head
