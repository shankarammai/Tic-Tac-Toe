// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open FsXaml
type Game=XAML<"TicTacToe.xaml">
[<EntryPoint;STAThread>]
let main argv = 
    Game().Run()
    
