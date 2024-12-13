let mutable x = ref 10
let mutable y = ref 20

let add xRef yRef = !xRef + !yRef

let z = add x y

printf "%d\n" z //Prints 30

x := 15
y := 25

printf "%d\n" (add x y) //Prints 40, reflecting the changes