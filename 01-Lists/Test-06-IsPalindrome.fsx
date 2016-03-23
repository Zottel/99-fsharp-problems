#load "./06-IsPalindrome.fsx"
open Lists.IsPalindrome
    
let list = [1; 2; 3; 2; 1]
printfn "The list %A is a palindrome: %b" list (isPalindrome list)
