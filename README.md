# F# Mutability and Pass-by-Value Demonstration

This example demonstrates a common pitfall in F# when working with mutable variables and function calls.  Because F# uses pass-by-value semantics, changes to mutable variables after a function call will not affect the function's internal state.

The `bug.fs` file contains code that showcases the incorrect behavior, where the result of the `add` function doesn't reflect updates to the mutable variables afterwards.  The `bugSolution.fs` file offers a corrected approach using techniques such as passing mutable references or ref cells.

This repository serves as a clear illustration of this important F# concept and a practical way to handle similar scenarios.