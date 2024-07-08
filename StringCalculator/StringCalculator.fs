module StringCalculator

exception NegativesNoAllowed of int[]
let Add (numbers : string) = 
    let mutable delimiters = [|",";"\n"|]
    let mutable numbers = numbers
    if numbers.StartsWith("//") then
        let inputs = numbers.Split([|'\n'|],2)
        let customDelimiters = inputs.[0].Split([|"["; "]"; "/"|],System.StringSplitOptions.RemoveEmptyEntries)
        delimiters <- Array.append delimiters customDelimiters
        numbers <- inputs.[1]
    let numbers = numbers.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries)
                  |> Array.map int
    let negativeNumbers = numbers |> Array.filter(fun n -> n < 0)
    if negativeNumbers.Length > 0 then
        raise(NegativesNoAllowed negativeNumbers)
    numbers |>  Array.filter(fun n -> n <= 1000) |>  Array.sum