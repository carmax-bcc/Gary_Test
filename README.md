# Candidate_Test
## Instructions
:wave: Hello there! Welcome to the development exercise!
The test is a fairly straightforward TDD style task. When you open the solution you will see there are two projects in it: MPG_Test and MPG_Test.Tests. 
The two files you will be concerned with are `MPGCalc.cs` and `MPGCalc_Tests.cs`

![alt text](Readme.Resources/SolutionView.jpg?raw=true, "Solution View")
### Xunit 'test'
In the Tests project there is one file `MPGCalc_Tests.cs` with one `[Fact]`, and that has some light scaffolding and several 'Assertions'.

<pre style="font-family:Cascadia Mono;font-size:13px;color:white;"><span style="color:#ff9da4;">Assert</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Equal</span>(<span style="color:#ffc58f;">25.33</span>,&nbsp;<span style="color:#ff9da4;">MPGCalc</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">GetAverageMpg</span>(<span style="color:#ff9da4;">vehicles</span>,&nbsp;<span style="color:#d1f1a9;">&quot;Honda&quot;</span>)<span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Value</span>,&nbsp;<span style="color:#ffc58f;">2</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#ff9da4;">Assert</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Equal</span>(<span style="color:#ffc58f;">25.33</span>,&nbsp;<span style="color:#ff9da4;">MPGCalc</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">GetAverageMpg</span>(<span style="color:#ff9da4;">vehicles</span>,&nbsp;<span style="color:#d1f1a9;">&quot;honda&quot;</span>)<span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Value</span>,&nbsp;<span style="color:#ffc58f;">2</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#ff9da4;">Assert</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Equal</span>(<span style="color:#ffc58f;">27</span>,&nbsp;<span style="color:#ff9da4;">MPGCalc</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">GetAverageMpg</span>(<span style="color:#ff9da4;">vehicles</span>,&nbsp;<span style="color:#d1f1a9;">&quot;Lexus&quot;</span>)<span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Value</span>,&nbsp;<span style="color:#ffc58f;">2</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#ff9da4;">Assert</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Null</span>(<span style="color:#ff9da4;">MPGCalc</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">GetAverageMpg</span>(<span style="color:#ebbbff;">null</span>,&nbsp;<span style="color:#d1f1a9;">&quot;Honda&quot;</span>));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#ff9da4;">Assert</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Null</span>(<span style="color:#ff9da4;">MPGCalc</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">GetAverageMpg</span>(<span style="color:#ff9da4;">emptyVehicles</span>,&nbsp;<span style="color:#d1f1a9;">&quot;Honda&quot;</span>));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#ff9da4;">Assert</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Null</span>(<span style="color:#ff9da4;">MPGCalc</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">GetAverageMpg</span>(<span style="color:#ff9da4;">vehicles</span>,&nbsp;<span style="color:#d1f1a9;">&quot;Ferrari&quot;</span>));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#ff9da4;">Assert</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Null</span>(<span style="color:#ff9da4;">MPGCalc</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">GetAverageMpg</span>(<span style="color:#ff9da4;">vehicles</span>,&nbsp;<span style="color:#ebbbff;">string</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Empty</span>));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#ff9da4;">Assert</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">Null</span>(<span style="color:#ff9da4;">MPGCalc</span><span style="color:#99ffff;">.</span><span style="color:#ff9da4;">GetAverageMpg</span>(<span style="color:#ff9da4;">vehicles</span>,&nbsp;<span style="color:#ebbbff;">null</span>));
&nbsp;</pre>
These Assertions define how the 'GetAverageMpg' method should behave and this is your challenge.

### `MPGCalc` - Your solution
The  `MPGCalc.cs` has a single method `GetAverageMpg` and there is a region in it marked solution which is where you should provide your code.
<pre style="font-family:Cascadia Mono;font-size:13px;color:white;"><span style="color:#ebbbff;">static</span>&nbsp;<span style="color:#ebbbff;">public</span>&nbsp;<span style="color:#ebbbff;">double</span><span style="color:#99ffff;">?</span>&nbsp;<span style="color:#bbdaff;">GetAverageMpg</span>(<span style="color:#ff9da4;">IEnumerable</span>&lt;<span style="color:#ff9da4;">Vehicle</span>&gt;<span style="color:#99ffff;">?</span>&nbsp;<span style="color:#ff9da4;">vehicles</span>,&nbsp;<span style="color:#ebbbff;">string</span>&nbsp;<span style="color:#ff9da4;">make</span>)
&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#ebbbff;">#region</span>&nbsp;<span style="color:#d1f1a9;">Solution</span>
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#ebbbff;">#endregion</span>
&nbsp;&nbsp;&nbsp;}</pre>

1. ### You should not modify any of the existing code
2. ### There should be no warnings issued by any of your code. {Yes, the test code issues warnings but that is kind by design... :dizzy_face:}
3. ### If you feel the need for code outside the `Solution` region, you may add methods or classes. {But maybe don't... :smirk_cat:}
4. #### Most of all, have fun! :thumbsup:

