module MultiwayTrees.MultiwayTree

type 'a MultiwayTree = Node of 'a * 'a MultiwayTree list
