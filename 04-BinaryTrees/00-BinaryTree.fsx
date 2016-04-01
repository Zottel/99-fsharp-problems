module BinaryTrees.BinaryTree

type 'a BinaryTree = Empty | Branch of 'a * 'a BinaryTree * 'a BinaryTree
