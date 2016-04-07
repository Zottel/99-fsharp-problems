module Lists.IsPalindrome

let isPalindrome list = list = List.rev list

let test () =
    let list = [1; 2; 3; 2; 1]

    printfn "Input list: %A" list
    printfn "The list is a palindrome: %b" (isPalindrome list)
