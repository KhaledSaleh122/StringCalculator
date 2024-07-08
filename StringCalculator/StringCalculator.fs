module StringCalculator

exception NegativesNoAllowed of int[]
let Add (numbers : string) = 
    let delimiters = [|",";"\n"|]
    let numbers = numbers.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries)
                  |> Array.map int
    let negativeNumbers = numbers |> Array.filter(fun n -> n < 0)
    if negativeNumbers.Length > 0 then
        raise(NegativesNoAllowed negativeNumbers)
    numbers |> Array.sum