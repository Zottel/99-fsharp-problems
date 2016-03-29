module Arithmetic.Coprime

#load "./32-GCD.fsx"
open Arithmetic.GCD

let areCoprime m n = gcd m n = 1
