using static SectraCalculator.CalculationCommand;

namespace Solution_Tests;


public class CalculatorTests
{
    [Fact]
    public void should_create_command_with_only_operation()
    {
      // act
      var cmd = CalculationCommandFactory.CreateCalculationCommand(Operation.Add, 0);

      // assert
      cmd.Should().NotBe(null);
      cmd.operation.Should().Be(Operation.Add);
    }
    [Fact]
    public void should_create_command_with_operation_and_single_argument()
    {
      // act
      var cmd = CalculationCommandFactory.CreateCalculationCommand(Operation.Add, 12);

      // assert
      cmd.Should().NotBe(null);
      cmd.operation.Should().Be(Operation.Add);
      cmd.value.Should().Be(12);
    }
    [Fact]
    public void calculator_should_return_0_as_initial_result()
    {
      // arrange
      var calc = new Calculator();

      // act
      var result = calc.PendingCalculations();

      // assert
      result.Should().Be(0);
    }
    [Fact]
    public void should_return_0_for_add_with_no_argument()
    {
      // arrange
      var calc = new Calculator();
      var cmd = CalculationCommandFactory.CreateCalculationCommand(Operation.Add,0);

      // act
      var result = calc.AddCalculation(cmd);

      // assert
      result.PendingCalculations().Should().Be(0);
    }
}