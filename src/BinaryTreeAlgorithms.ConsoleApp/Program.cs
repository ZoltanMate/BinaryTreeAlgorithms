/*
 
Binary tree:
    - at most 2 children per node
    - exactly 1 root
    - exactly 1 path between root and any node

 */

#region Depth First Values
Console.WriteLine($"{nameof(DepthFirstValues)}:");
var depthFirstValues = new DepthFirstValues();
//var rootOfTree = depthFirstValues.CreateTestTreeNumbers();
var rootOfTree = depthFirstValues.CreateTestTreeChars();

var depthFirstValuesIterativeResult = depthFirstValues.DepthFirstValuesIterative(rootOfTree);
Console.Write($"\t{nameof(depthFirstValues.DepthFirstValuesIterative)}: ");
depthFirstValuesIterativeResult.ForEach(x => Console.Write($"{x} ")); // a b d e c f
Console.WriteLine();

var depthFirstValuesRecursiveResult = depthFirstValues.DepthFirstValuesRecursive(rootOfTree);
Console.Write($"\t{nameof(depthFirstValues.DepthFirstValuesRecursive)}: ");
depthFirstValuesRecursiveResult.ForEach(x => Console.Write($"{x} ")); // a b d e c f

Console.WriteLine();
Console.WriteLine();
#endregion

#region Breath First Values
Console.WriteLine($"{nameof(BreathFirstValues)}:");
var breathFirstValues = new BreathFirstValues();
rootOfTree = breathFirstValues.CreateTestTreeChars();

var breathFirstValuesResult = breathFirstValues.BreathFirstValuesAlgorithm(rootOfTree);
Console.Write($"\t{nameof(breathFirstValues.BreathFirstValuesAlgorithm)}: ");
breathFirstValuesResult.ForEach(x => Console.Write($"{x} ")); // a b c d e f

Console.WriteLine();
Console.WriteLine();
#endregion

#region Tree Includes
Console.WriteLine($"{nameof(TreeIncludes)}:");
var treeIncludes = new TreeIncludes();
rootOfTree = treeIncludes.CreateTestTreeChars();

Console.WriteLine($"\t{nameof(treeIncludes.TreeIncludesDepthFirstRecursive)}: {treeIncludes.TreeIncludesDepthFirstRecursive(rootOfTree, 'e')}"); // True
Console.WriteLine($"\t{nameof(treeIncludes.TreeIncludesBreadthFirst)}: {treeIncludes.TreeIncludesBreadthFirst(rootOfTree, 'e')}"); // True

Console.WriteLine();
#endregion

#region Tree Sum
Console.WriteLine($"{nameof(TreeSum)}:");
var treeSum = new TreeSum();
var treeSumRootOfTree = treeSum.CreateTestTreeNumbers();

Console.WriteLine($"\t{nameof(treeSum.TreeSumDepthFirstRecursive)}: {treeSum.TreeSumDepthFirstRecursive(treeSumRootOfTree)}"); // 21
Console.WriteLine($"\t{nameof(treeSum.TreeSumBreadthFirst)}: {treeSum.TreeSumBreadthFirst(treeSumRootOfTree)}"); // 21

Console.WriteLine();
#endregion

#region Tree Min Value
Console.WriteLine($"{nameof(TreeMinValue)}:");
var treeMinValue = new TreeMinValue();
var treeMinValueRootOfTree = treeMinValue.CreateTestTreeNumbers();

Console.WriteLine($"\t{nameof(treeMinValue.TreeMinValueDepthFirstRecursive)}: {treeMinValue.TreeMinValueDepthFirstRecursive(treeMinValueRootOfTree)}"); // -2
Console.WriteLine($"\t{nameof(treeMinValue.TreeMinValueBreathFirst)}: {treeMinValue.TreeMinValueBreathFirst(treeMinValueRootOfTree)}"); // -2

Console.WriteLine();
#endregion

#region Max Path Sum
Console.WriteLine($"{nameof(MaxPathSum)}:");
var maxPathSum = new MaxPathSum();
var maxPathSumRootOfTree = maxPathSum.CreateTestTreeNumbers();

Console.WriteLine($"\t{nameof(maxPathSum.MaxPathSumDepthFirstRecursive)}: {maxPathSum.MaxPathSumDepthFirstRecursive(maxPathSumRootOfTree)}"); // 18

#endregion