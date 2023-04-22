// using static SectraCalculator.CalculationCommand;

// namespace Solution_Tests;


// public class CalculatorTests
// {
//     [Fact]
//     public void should_create_command_with_only_operation()
//     {
//       // act
//       var cmd = CalculationCommandFactory.CreateCalculationCommand("", Operation.Add, 0);

//       // assert
//       cmd.Should().NotBe(null);
//       cmd.operation.Should().Be(Operation.Add);
//     }
//     [Fact]
//     public void should_create_command_with_operation_and_single_argument()
//     {
//       // act
//       var cmd = CalculationCommandFactory.CreateCalculationCommand("", Operation.Add, 12);

//       // assert
//       cmd.Should().NotBe(null);
//       cmd.operation.Should().Be(Operation.Add);
//       cmd.value.Should().Be(12);
//     }
//     [Fact]
//     public void calculator_should_return_0_as_initial_result()
//     {
//       // arrange
//       var calc = new Calculator();

//       // act
//       var result = calc.GetPendingCalculations();

//       // assert
//       result.Should().Be(0);
//     }
//     [Fact]
//     public void should_return_0_for_add_with_no_argument()
//     {
//       // arrange
//       var calc = new Calculator();
//       var cmd = CalculationCommandFactory.CreateCalculationCommand("", Operation.Add,0);

//       // act
//       var result = calc.AddCalculation(cmd);

//       // assert
//       result.GetPendingCalculations().Should().Be(0);
//     }
//     [Fact]
//     public void should_chain_add_commands()
//     {
//       // arrange
//       var calc = new Calculator();
//       var cmd1 = CalculationCommandFactory.CreateCalculationCommand("", Operation.Add, 1);
//       var cmd2 = CalculationCommandFactory.CreateCalculationCommand("", Operation.Add, 2);
//       var cmd3 = CalculationCommandFactory.CreateCalculationCommand("", Operation.Add, 3);
//       var cmd4 = CalculationCommandFactory.CreateCalculationCommand("", Operation.Add, 4);

//       // act
//       var result = calc
//         .AddCalculation(cmd1)
//         .AddCalculation(cmd2)
//         .AddCalculation(cmd3)
//         .AddCalculation(cmd4)
//         .GetPendingCalculations();

//       // assert
//       result.Should().Be(10);
//     }
//     [Fact]
//     public void should_chain_all_operation_types()
//     {
//       // arrange
//       var calc = new Calculator();
//       var cmd1 = CalculationCommandFactory.CreateCalculationCommand("" ,Operation.Subtract, 4);
//       var cmd2 = CalculationCommandFactory.CreateCalculationCommand("" ,Operation.Add, 5);
//       var cmd3 = CalculationCommandFactory.CreateCalculationCommand("" ,Operation.Subtract, 10);
//       var cmd4 = CalculationCommandFactory.CreateCalculationCommand("" ,Operation.Add, 15);
//       var cmd5 = CalculationCommandFactory.CreateCalculationCommand("" ,Operation.Multiply, 2);

//       // act
//       var result = calc
//         .AddCalculation(cmd1)
//         .AddCalculation(cmd2)
//         .AddCalculation(cmd3)
//         .AddCalculation(cmd4)
//         .AddCalculation(cmd5)
//         .GetPendingCalculations();

//       // assert
//       result.Should().Be(12);
//     }
// }