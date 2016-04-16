open System
open System.IO


type TotalRabbitPopulation = {
                               Breeders:bigint
                               Babies:bigint }
(*Creating an instance of breeders and babies 
by binding a function, 'population', to a value.
The 'p' needs to be bound to a value so 
that we can use it later. 
*)
let population p = p.Breeders + p.Babies
// Let n = generations and k = pairs of babies
let rabbits n k =
    let rec rabbitPop pop gen = 
        match pop with
        | _ when gen = n -> pop
        | {Breeders = br; Babies = nb} -> rabbitPop {Breeders = br + nb; Babies = br * k} (gen + 1)
    rabbitPop { Breeders = 0I; Babies = 1I} 1

let total = rabbits 36 2I
total
|> printfn "%A"

population total
|> printfn "%A"


[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    0 // return an integer exit code

