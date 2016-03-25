module Lists.IntegersInRange

let rec range lower upper =
    match lower,upper with
    | lower,upper when lower > upper -> []
    | lower,upper ->
        lower::range (lower + 1) upper
    