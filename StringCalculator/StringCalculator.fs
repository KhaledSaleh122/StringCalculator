module StringCalculator

let Add (numbers : string) = 
    let delimiters = [|",";"\n"|]
    numbers.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries)
    |> Array.map int
    |> Array.sum