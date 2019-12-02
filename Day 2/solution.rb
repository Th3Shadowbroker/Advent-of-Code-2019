# Intro \o/
puts "Advent of Code 2019"
puts "Solution for day 2 by Th3Shadowbroker (github.th3shadowbroker.org)"

# Required variables
@original_values = [1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,10,19,2,9,19,23,1,9,23,27,2,27,9,31,1,31,5,35,2,35,9,39,1,39,10,43,2,43,13,47,1,47,6,51,2,51,10,55,1,9,55,59,2,6,59,63,1,63,6,67,1,67,10,71,1,71,10,75,2,9,75,79,1,5,79,83,2,9,83,87,1,87,9,91,2,91,13,95,1,95,9,99,1,99,6,103,2,103,6,107,1,107,5,111,1,13,111,115,2,115,6,119,1,119,5,123,1,2,123,127,1,6,127,0,99,2,14,0,0]
@input_values = []
@output_values = []
@required_output = 19690720
puts "Found " + @input_values.length.to_s + " inputs..."

# Get the intcode for the given input array
def generate_intcode(input)
  
  # i is acting as "outer" counter, which is used to loop through the inputValues
  i = 0
  until i == input.length - 1
    value = input[i]

    # Stop here if the value is 99
    if value == 99
      break
    end

    # Let's start working!
    opcode = input[i]
    num1 = input[input[i + 1]]
    num2 = input[input[i + 2]]
    pos = input[i + 3]
    result = 0

    # Identify required action
    case opcode

      when 1
        result = num1 + num2

      when 2
        result = num1 * num2

      else
        puts "Invalid opcode " + opcode.to_s + "!"

    end

    input[pos] = result

    # Add 4 to i to reach next opcode
    i = i + 4
  end

  # We got it!
  return input

end

# Ensures the script is working as expected
def test

  puts "Performing test tasks:"

  puts "Test 1 " + (generate_intcode([1, 0, 0, 0, 99]) === [2, 0, 0, 0, 99] ? "succeeded": "failed") + "!"
  puts "Test 2 " + (generate_intcode([2, 3, 0, 3, 99]) === [2, 3, 0, 6, 99] ? "succeeded": "failed") + "!"
  puts "Test 3 " + (generate_intcode([2, 4, 4, 5, 99, 0]) === [2, 4, 4, 5, 99, 9801] ? "succeeded": "failed") + "!"
  puts "Test 4 " + (generate_intcode([1, 1, 1, 4, 99, 5, 6, 0, 99]) === [30, 1, 1, 4, 2, 5, 6, 0, 99] ? "succeeded": "failed") + "!"

end

# Reset the input data to its original state
def reset_memory
  i = 0
  for value in @original_values
    @input_values[i] = @original_values[i]
    i = i + 1
  end
end

# Solve the task
def solve

  reset_memory
  test

  # Modify input as stated in the task
  @input_values[1] = 12
  @input_values[2] = 2

  # Generate the result for part one
  @output_values = generate_intcode(@input_values)
  puts "Result for part one is " + @output_values[0].to_s

  # Good old brute-force way
  i = 0
  until i == 99 do

    # We can skip zero at this point
    i = i + 1

    j = 0
    until j == 99 do

      # Again. We can skip zero
      j = j + 1

      # Reset "memory"
      reset_memory

      @input_values[1] = i
      @input_values[2] = j
      result = generate_intcode(@input_values)
      if result[0] === @required_output
        puts "Found required outcome for part two:"
        puts "\tNoun: " + i.to_s
        puts "\tVerb: " + j.to_s
        puts "\tMultiplied: " + (100 * i + j).to_s
        return
      end

    end

  end

end

# Run the script
solve