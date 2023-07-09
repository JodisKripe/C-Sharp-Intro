Unit testing is an invaluable skill when it comes to software development. It allows easy testing of your library code whenever changes are mode, to ensure functionality has not broken. We can use the Calculator project from the previous module to demonstrate this.

In C#, the actual project code and testing code are separated into different projects. In Rider, right-click the Calculator solution, go to Add > New Project and select the Unit Test Project template. Give the project a name and choose xUnit from the Type dropdown. Then Create the project.

Inside the new project, we get UnitTest1.cs, which contains a little bit of boilerplate code. The first thing we need to do is add a reference to the Calculator project. Expand the project in the Explorer view, right-click on Dependencies and select Reference. From the popup window, tick the Calculator project and click Add.

Now it's time to write our tests - I'll just cover the Add method as an example.

> public class CalculatorTests{
>
>     [Theory]
>     [InlineData(5,5,10)]
>     [InlineData(5,-5,0)]
>     [InlineData(-5,5,0)]
>     [InlineData(-5,-5,-10)]
>     public void AddTests(int i1, int i2, int expected){
>         var calc = new Calculator<int>();
>         var result = calc.Add(i1,i2);
>
>         Assert.Equal(expected,result);
>     }
>
> }

These are relatively simple - we can provide multiple sets of data so that a single test can be run multiple times. We have to know ahead of time what the result of each test should be so that we can compare an expected value with the actual value.

The tests can be run directly in Rider via the Tests menu.

These tests can also be triggered from the command line with

> dotnet test

Unit testing can be integrated into CI/CD pipelines for full automation of test, build, and deploy. You can find more information about that in our DevOps for Pentesters course.
