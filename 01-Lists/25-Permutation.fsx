module Lists.Permutation

#load "./23-ExtractRandom.fsx"
open Lists.ExtractRandom

let random = System.Random()

let rec randomPermute list = randomSelect (List.length list) list
