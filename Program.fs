open System

/// List of solved problems
let problems = [
    ("1", "(*) Find the last element of a list.", Lists.LastElement.test);
    ("2", "(*) Find the last but one element of a list.", Lists.LastButOneElement.test);
    ("3", "(*) Find the Kth element of a list.", Lists.NthElement.test);
    ("4", "(*) Find the number of elements of a list.", Lists.NumberOfElements.test);
    ("5", "(*) Reverse a list.", Lists.Reverse.test);
    ("6", "(*) Find out whether a list is a palindrome.", Lists.IsPalindrome.test);
    ("7", "(**) Flatten a nested list structure.", Lists.FlattenNestedList.test);
    ("8", "(**) Eliminate consecutive duplicates of list elements.", Lists.EliminateDuplicates.test);
    ("9", "(**) Pack consecutive duplicates of list elements into sublists.", Lists.PackDuplicates.test);
    ("10", "(*) Run-length encoding of a list.", Lists.LengthEncoding.test);
    ("11", "(*) Modified run-length encoding.", Lists.ModifiedLengthEncoding.test);
    ("12", "(**) Decode a run-length encoded list.", Lists.DecodeLengthEncoding.test);
    ("13", "(**) Run-length encoding of a list (direct solution).", Lists.LengthEncodeDirect.test);
    ("14", "(*) Duplicate the elements of a list.", Lists.DuplicateElement.test);
    ("15", "(**) Duplicate the elements of a list a given number of times.", Lists.MultiplyElements.test);
    ("16", "(**) Drop every Nth element from a list.", Lists.DropEveryNthElement.test);
    ("17", "(*) Split a list into two parts.", Lists.Split.test);
    ("18", "(**) Extract a slice from a list.", Lists.ExtractSlice.test);
    ("19", "(**) Rotate a list N places to the left.", Lists.Rotate.test);
    ("20", "(*) Remove the Kth element from a list.", Lists.RemoveElement.test);
    ("21", "(*) Insert an element at a given position into a list.", Lists.InsertElement.test);
    ("22", "(*) Create a list containing all integers within a given range.", Lists.IntegersInRange.test);
    ("23", "(**) Extract a given number of randomly selected elements from a list.", Lists.ExtractRandom.test);
    ("24", "(*) Lotto: Draw N different random numbers from the set 1..M.", Lists.Lotto.test);
    ("25", "(*) Generate a random permutation of the elements of a list.", Lists.Permutation.test);
    ("26", "(**) Generate the combinations of K distinct objects chosen from the N elements of a list.", Lists.Combinations.test);
    ("27", "(**) Group the elements of a set into disjoint subsets.", Lists.GroupElements.test);
    ("28", "(**) Sorting a list of lists according to length of sublists.", Lists.SortingByLength.test);
    ("31", "(**) Determine whether a given integer number is prime.", Arithmetic.IsPrime.test);
    ("32", "(**) Determine the greatest common divisor of two positive integer numbers.", Arithmetic.GCD.test);
    ("33", "(*) Determine whether two positive integer numbers are coprime.", Arithmetic.Coprime.test);
    ("34", "(**) Calculate Euler's totient function phi(m).", Arithmetic.EulersTotient.test);
    ("35", "(**) Determine the prime factors of a given positive integer. ", Arithmetic.PrimeFactors.test);
    ("36", "(**) Determine the prime factors of a given positive integer (2).", Arithmetic.PrimeFactorsMultiplicity.test);
    ("37", "(**) Calculate Euler's totient function phi(m) (improved).", Arithmetic.EulersTotientImproved.test);
    ("38", "(*) Compare the two methods of calculating Euler's totient function.", Arithmetic.CompareTotientCalculation.test);
    ("39", "(*) A list of prime numbers.", Arithmetic.PrimesInRange.test);
    ("40", "(**) Goldbach's conjecture.", Arithmetic.GoldbachsConjecture.test);
    ("41", "(**) A list of Goldbach compositions.", Arithmetic.GoldbachList.test);
    ("46", "(**) Truth tables for logical expressions.", LogicAndCodes.LogicalPredicates.test);
    ("47", "(*) Truth tables for logical expressions (2).", LogicAndCodes.LogicalPredicates2.test);
    ("48", "(**) Truth tables for logical expressions (3).", LogicAndCodes.LogicalPredicates3.test);
    ("49", "(**) Gray code.", LogicAndCodes.GrayCode.test);
    ("50", "(***) Huffman code.", LogicAndCodes.HuffmanCodes.test);
    ("54", "Omitted. The tree representation only allows well-formed trees.", ignore);
    ("55", "(**) Construct completely balanced binary trees.", BinaryTrees.CompletelyBalancedTree.test);
    ("56", "(**) Symmetric binary trees.", BinaryTrees.IsSymmetric.test);
    ("57", "(**) Binary search trees (dictionaries).", BinaryTrees.BinarySearchTree.test);
    ("58", "(**) Generate-and-test paradigm.", BinaryTrees.GenerateAndTest.test);
    ("59", "(**) Construct height-balanced binary trees.", BinaryTrees.HeightBalanced.test);
    ("60", "(**) Construct height-balanced binary trees with a given number of nodes.", BinaryTrees.HeightBalancedWithGivenNodes.test);
    ("61", "(*) Count the leaves of a binary tree.", BinaryTrees.CountLeaves.test);
    ("61A", "(*) Collect the leaves of a binary tree in a list.", BinaryTrees.CollectLeaves.test);
    ("62", "(*) Collect the internal nodes of a binary tree in a list.", BinaryTrees.CollectInternal.test);
    ("62B", "(*) Collect the nodes at a given level in a list.", BinaryTrees.NodesAtLevel.test);
    ("63", "(**) Construct a complete binary tree.", BinaryTrees.CompleteTree.test);
    ("64", "(**) Layout a binary tree (1).", BinaryTrees.LayoutTree1.test);
    ("65", "(**) Layout a binary tree (2).", BinaryTrees.LayoutTree2.test);
    ("66", "(***) Layout a binary tree (3).", BinaryTrees.LayoutTree3.test);
    ("67", "(**) A string representation of binary trees.", BinaryTrees.StringRepresentation.test);
    ("68", "(**) Preorder and inorder sequences of binary trees.", BinaryTrees.PreorderInorder.test);
    ("69", "(**) Dotstring representation of binary trees.", BinaryTrees.DotstringRepresentation.test);
    ("70B", "Omitted. The tree representation only allows well-formed trees.", ignore);
    ("70C", "(*) Count the nodes of a multiway tree.", MultiwayTrees.CountNodes.test);
]

/// Display info on obtaining help
let helpInfo () =
    printfn "For list of available commands type 'help'"

/// Display help
let help () =
    printfn "  list            List of problems"
    printfn "  test <number>   Run problem test"
    printfn "  help            Display help"
    printfn "  quit            Quit"

/// Display program logo
let logo () =
    printfn "============================================================"
    printfn "|                      99 F# problems                      |"
    printfn "============================================================"
    helpInfo ()

/// Display unknown command error
let unknownCommand command =
    printfn "%s: Command not found." command
    helpInfo ()

let printProblem number title =
    printfn "%3s. %s" number title

/// Display problems list
let list () =
    List.iter (fun (number,title,_) -> printProblem number title) problems

/// Run problem test
let problem = function
    | i when not (List.exists (fun (number,_,_) -> number = i) problems) ->
        printfn "%s: There is no such problem number." i
    | i ->
        let number,title,func = List.find (fun (number,_,_) -> number = i) problems
        printProblem number title
        func ()

/// Main program loop
let loop () =
    let prompt () =
        printf "\n99-problems> "
        Console.ReadLine ()

    let infiniteLines = Seq.initInfinite (fun _ -> prompt ())

    let (|Prefix|_|) (p:string) (s:string) =
        if s.StartsWith(p) then
            Some(s.Substring(p.Length))
        else
            None

    let run = function
        | Prefix "test " number | Prefix "t " number ->
            problem (number.ToUpper().ToString())
            false
        | "test" | "t" ->
            printfn "You have to specify problem number."
            false
        | Prefix "source" number | Prefix "s" number ->
            // source (number.ToUpper().ToString())
            printfn "Not yet implemented."
            false
        | "quit" | "q" ->
            printfn "Bye!"
            true
        | "help" | "h" ->
            help ()
            false
        | "list" | "l" ->
            list ()
            false
        | "" -> false
        | command ->
            unknownCommand command
            false

    Seq.find run infiniteLines |> ignore

[<EntryPoint>]
let main argv =
    logo ()
    loop ()
    0
