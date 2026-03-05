module Tests

open System
open Xunit
open Greetings


[<Fact>]
let ``makeHello for non-VIP should return a greeting "Hello, <name>."`` () =
    let vipList = [ "Alice"; "Bob" ]
    let name = "Charlie"
    let result = Greet.makeHello vipList name
    let expected = $"Hello, {name}."
    Assert.False(String.IsNullOrWhiteSpace(result))
    Assert.Equal(expected, result)

[<Fact>]
let ``makeHello for VIP should return a greeting "Welcome, <name>!"`` () =
    let vipList = [ "Alice"; "Bob" ]
    let name = "Alice"
    let result = Greet.makeHello vipList name
    let expected = $"Welcome, {name}!"
    Assert.False(String.IsNullOrWhiteSpace(result))
    Assert.Equal(expected, result)
