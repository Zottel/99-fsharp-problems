module Arihmetic.GCD
 
let rec gcd m n =
    if n = 0 then abs m
    else
        gcd n (m % n)
