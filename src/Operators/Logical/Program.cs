// ## Logical Operators


// Logical AND (&&) - iloczyn logiczny
// Jeśli TRUE jest po obu stronach (operandach) to jest TRUE

Console.WriteLine(true && true); // True
Console.WriteLine(false && true); // False
Console.WriteLine(true && false); // False
Console.WriteLine(false && false); // False

// 1 AND 1 = 1
// 0 AND 1 = 0
// 1 AND 0 = 0
// 0 AND 0 = 0

// Logical OR (||) - suma logiczna
// Jeśli TRUE jest chociaż po jednej stronie (operanda) to jest TRUE
Console.WriteLine(true || true); // True
Console.WriteLine(false || true); // True
Console.WriteLine(true || false); // True
Console.WriteLine(false || false); // False

// 1 OR 1 = 1
// 0 OR 1 = 1
// 1 OR 0 = 1
// 0 OR 0 = 0

// Logical XOR (^)
Console.WriteLine(true ^ true);    // output: False
Console.WriteLine(true ^ false);   // output: True
Console.WriteLine(false ^ true);   // output: True
Console.WriteLine(false ^ false);  // output: False


// !(a && b) -> a || b


// 10 + b
// lewy operand operator prawy operand

// x++
// lewy operand operator

// ++x
// operator prawy operand


bool highIncome = true;
bool goodCreditScore = false;

bool eligibleForLoan = highIncome && goodCreditScore;

Console.WriteLine(eligibleForLoan);

// Logical Negation NOT (!)
bool applicationRefused = !eligibleForLoan;

Console.WriteLine(applicationRefused);

