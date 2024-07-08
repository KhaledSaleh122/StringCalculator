module StringCalculator



let ExtractDelimiters (delimiters : string array, numbersString : string) = 
    if numbersString.StartsWith("//") then
        let inputs = numbersString.Split([|'\n'|],2)
        let customDelimiters = inputs.[0].Split([|"["; "]"; "/"|],System.StringSplitOptions.RemoveEmptyEntries)
        (Array.append delimiters customDelimiters,inputs.[1])
    else
        (delimiters,numbersString)

exception InvaildInput of string
let CheckInvaildInput (numbersString : string array) =
    let emptyItems = Array.filter(fun x -> x = " " || x = "") numbersString;
    if emptyItems.Length > 0 then
        raise(InvaildInput "Invaild input format")
    numbersString

let ExtractNumbers (delimiters : string array, numbersString : string) =
    numbersString.Split(delimiters, System.StringSplitOptions.None)
    |> CheckInvaildInput
    |> Array.map int

exception NegativesNoAllowed of int[]
let NegativeCheck (numbers : int array) =
    let negativeNumbers = Array.filter(fun n -> n < 0) numbers 
    if negativeNumbers.Length > 0 then
        raise(NegativesNoAllowed negativeNumbers)
    numbers

let FliterNumbersBiggerThan1000 (numbers : int array) =
     Array.filter(fun n -> n <= 1000) numbers

let Add (numbers : string) = 
    let  delimiters = [|",";"\n"|]
    ExtractDelimiters(delimiters,numbers)
    |> ExtractNumbers
    |> NegativeCheck
    |> FliterNumbersBiggerThan1000
    |> Array.sum
       

