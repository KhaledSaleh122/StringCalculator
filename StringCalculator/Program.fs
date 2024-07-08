// For more information see https://aka.ms/fsharp-console-apps
try
   StringCalculator.Add "1,2,3,1001" |> printfn "Sum: %i"
   StringCalculator.Add "//;\n1;2,3,1001" |> printfn "Sum: %i"
   StringCalculator.Add "//[;]\n1;2,3,1001" |> printfn "Sum: %i"
   StringCalculator.Add "//[;][pp]\n1;2pp3,1001" |> printfn "Sum: %i"
   //StringCalculator.Add "//;\n-1;-2,5\n7" |> printfn "Sum: %i"
   //StringCalculator.Add "//;\n1;,2" |> printfn "Sum: %i"
with
| StringCalculator.NegativesNoAllowed negs ->
    printfn "Negatives not allowed: %A" negs
| StringCalculator.InvalidInput inv ->
    printf "%s" inv
