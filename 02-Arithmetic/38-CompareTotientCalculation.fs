module Arithmetic.CompareTotientCalculation

open Arithmetic.EulersTotient
open Arithmetic.EulersTotientImproved

let test () =
    let testVal = 1009000

    let test name testValue (func:int->int) =
        let s = System.Diagnostics.Stopwatch()
        s.Start()
        ignore (func testValue)
        s.Stop()

        printfn "%s %i -> %i ms" name testValue s.ElapsedMilliseconds

    test "totient" testVal totient
    test "totientImproved" testVal totientImproved
