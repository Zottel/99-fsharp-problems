#load "./28-SortingByLength.fsx"
open Lists.SortingByLength

let list = [['a'; 'b'; 'c']; ['d'; 'e']; ['f'; 'g'; 'h']; ['d'; 'e']; ['i'; 'j'; 'k'; 'l']; ['m'; 'n']; ['o']]

printfn "Input list: \n%A" list
printfn "List sorted by elements length: \n%A" (lsort list)
printfn "List sorted by elements length frequency: \n%A" (lsortFreq list)
