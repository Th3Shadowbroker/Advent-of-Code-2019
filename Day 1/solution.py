import os
import math

# Intro \o/
print("Advent of Code 2019")
print("Solution for Day 1 by Th3Shadowbroker (github.th3shadowbroker.org)")

# Required variables
masses_source = "masses.txt"
masses = []
fuel_amounts = []
fuel_total = 0
fuel_additional = 0

# Read masses from masses_source
def readMasses():
    masses_file = open(os.path.dirname( os.path.realpath(__file__) ) + "/" + masses_source, "r")

    while True:
        l = masses_file.readline()
        if not l:
            break
        masses.append(int(l.strip()))
    
    masses_file.close()
    print("Read " + str(len(masses)) + " masses...")


# Calculate the fuel based on the given mass
def calculateFuel(mass):
    result = math.floor(mass / 3) - 2
    return result

# Calculate the additional fuel required for every module sparatly
def calculateAdditionalFuel(mass):
    global fuel_additional

    currentFuel = calculateFuel(mass)
    if currentFuel > 0:
        fuel_additional += currentFuel
        calculateAdditionalFuel(currentFuel)
    else:
        return   

# Solves the task
def solve():
    global fuel_total
    global fuel_additional

    readMasses()

    for mass in masses:
        fuel_amounts.append( calculateFuel(mass) )
        calculateAdditionalFuel( calculateFuel(mass) )

    for fuel_amount in fuel_amounts:
        fuel_total += fuel_amount

    print("Total required fuel calculates to: " + str(fuel_total))
    print("Total required fuel and the additional fuel calculates to " + str(fuel_total + fuel_additional))

# Run the script
solve()