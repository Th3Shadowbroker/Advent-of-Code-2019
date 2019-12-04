// Intro \o/
console.info('Advent of Code 2019');
console.info('Solution for Day 4 by Th3Shadowbroker (github.th3shadowbroker.org)');

// Required variables
let start = 347312;
let end   = 805915;

// Check if the given number contains a decrease
function hasDecrease(num) {
    let numStr = num.toString();
    for (let i = 1; i < 6; i++) {
        if (parseInt(numStr[i - 1]) > parseInt(numStr[i])) return true;
    }
    return false;
}

// True if a number contains at least two adjacent digits
function hasTwoAdjacentDigits(num) {
    let numStr = num.toString();
    for (let i = 1; i < 6; i++) {
        if (numStr[i - 1] === numStr[i]) return true;
    }
    return false;
}

// True if a number contains exactly two isolated adjacent digits
function hasTwoAdjacentDigitsOutsideBlock(num) {
    let numStr = num.toString();
    let previous;

    let inARow = 0;
    let pairLength = 0;

    for (let i = 0; i < 6; i++) {
        if (numStr[i] === previous) {
            inARow++;
            if (inARow === 1) pairLength++;
            if (inARow === 2) pairLength--;
        }
        else
        {
            previous = numStr[i];
            inARow = 0;
        }
    }

    return pairLength > 0;
}

// Get all combinations that match the rules
function getValidCombinations(min, max, allowBlocks) {
    let combinations = [];
    for (let i = min; i < max; i++) {
        if (hasDecrease(i)) continue;
        if (allowBlocks && !hasTwoAdjacentDigits(i)) continue;
        if (!allowBlocks && !hasTwoAdjacentDigitsOutsideBlock(i)) continue;
        combinations.push(i);
    }
    return combinations;
}

// Solve task 4
function solve() {
    console.log(getValidCombinations(start, end, true).length);
    console.log(getValidCombinations(start, end, false).length);
}

// Here wo go!
solve();
