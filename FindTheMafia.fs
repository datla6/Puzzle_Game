open System
let getrandomnum min max=
       let rnd=System.Random()
       let value=rnd.Next(min,max)
       value
let criminals=[|"a";"b";"c";"d";"e";"f";"g"|]
let mutable players=0
let perpetuators=Array.create 3 ""
let number=Array.create 3 -1
let selected=Array.create 3 ""
let dsplydcriminals=Array.create 3 ""
let getnum () =
        let mutable i=0
        let mutable j=0
        while i<3 do
            let mutable randomnum=getrandomnum 0 6
            let mutable count=0
            for j=0 to 2 do
                if randomnum=number.[j]
                then
                 count<-count+1

            if count=0
            then number.[i]<-randomnum
                 i<-i+1
        number  
let getrandomcriminals ()=
    let num2=getnum()
    for i=0 to 2 do
        let mutable k=num2.[i]
        dsplydcriminals.[i]<-criminals.[k]
 

let getperpetratorcount () =
    let mutable count=0
    for i=0 to 2 do
         for j=0 to 2 do
            if perpetuators.[i]=dsplydcriminals.[j]
            then count<-count+1
    count
let verify () =
    let mutable cnt=0
    let mutable var=false
    for i=0 to 2 do
         for j=0 to 2 do
            if perpetuators.[i]=selected.[j]
            then cnt<-cnt+1
    if cnt=3
    then
        var<-true
    else
        var<-false
    var
let num1=getnum ()   
for i=0 to 2 do
    let mutable k=num1.[i]
    perpetuators.[i]<-criminals.[k]

let startgame () =
    let mutable ans=""
    let mutable flag=true
    //printfn "Hello player!welcome to the game"
    let mutable c=0
    while ans="n"||flag do

        flag<-false
        getrandomcriminals()
        let cnt=getperpetratorcount ()
        if cnt=3
        then flag<-true
        else
            printfn "Number of Mafia in the below listed criminals are: %d\n" cnt
            for i=0 to 2 do
                printfn "%s\n" dsplydcriminals.[i]
            printfn "Would you like to guess all the mafia"
            printfn "If yes press 1"
            printfn "else press anykey"
            ans<-System.Console.ReadLine()

            if ans="1"
            then 
               c<-1
               for i=0 to 2 do
                    let mutable k=System.Console.ReadLine()
                    selected.[i]<-k
                    ans<-"y"
    c
printfn "\n\n\t\t\t Welcome to Find The Mafia \n\n";
printfn "Rules :\n \n1. Maximum number of Hints you get to find the Mafia is 4  \n2. There are total seven different 
criminals (a,b,c,d,e,f,g,h), out of which there are 3 \"Mafia\" ";
printfn "3. The computer will show any 3 random criminal names along with the count of the \"Mafia\" in those criminals \n4. Guess the names of the three Mafia (if you have 
identified them) or Pass to next hint";
printfn "5. Correct guess - You Win..!! Incorrect guess - You Lose..!!\n";
printfn "\nLet us Begin....!!! \n \n";
let hints=4
printfn "Enter any key to start the game:";
let v=System.Console.ReadLine()
if hints<1||hints>5
then printfn "Invalid Input. hint should be between 1 and 3.";
else
    let mutable nop=1
    let mutable pflag=true
    while nop<=hints && pflag do
        printfn "Hint Number %d " nop
        let p= startgame ()
        nop<-nop+1
        let s= verify ()
        if s=true
         then  printfn "Congratulations! you won"
               pflag<-false
        else
            if(nop=5||p=1)
             then printfn "sorry! You lost the game....."            
                  pflag<-false
                  printfn "actual Mafia are"
                  for i=0 to 2 do
                    printfn "%s\n" perpetuators.[i]
printfn "End of the game"  
let k=System.Console.ReadKey (true)