#load "./49-GrayCode.fsx"
open LogicAndCodes.GrayCode

let n = 3

printfn "Gray codes for n = %i:" n
printfn "%A" (grayCode n)
