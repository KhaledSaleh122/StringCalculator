// For more information see https://aka.ms/fsharp-console-apps
try
    StringCalculator.Add "1,2,-3,-4,5" |> printfn "Sum: %i"
with
| StringCalculator.NegativesNoAllowed negs ->
    printfn "Negatives not allowed: %A" negs
